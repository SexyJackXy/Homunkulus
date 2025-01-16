using System.Text.Json;

namespace Homunkulus.Helper
{
    internal class Create
    {
        /// <summary>
        /// Saves the backup plans in a text file in the folder backupplans.
        /// These can be loaded again later.
        /// </summary>
        public void Save(bool compress, bool incremental, string soruce, string destination)
        {
            var util = new Util();
            var bph = new BackupplanHelper();
            var backupplan = createBlackupplan(compress, incremental, soruce, destination);

            if (backupplan.DestinationPath == null)
            {
                throw new ArgumentNullException(backupplan.DestinationPath);
            }
            var date = DateTime.Now.ToString("dd MM yyyy");
            date = date.Replace(" ", "");

            var saveDir = Directory.GetFiles(@"../../../backupplans");
            var saveFileName = date + "_" + saveDir.Length.ToString();
            saveFileName = util.ConvertToTextFile(saveFileName);

            var savePath = @"../../../backupplans/" + saveFileName;

            bph.Save(backupplan, savePath);
        }

        public BackupplanHelper createBlackupplan(bool compress, bool incremental, string soruce, string destination)
        {
            var plan = new BackupplanHelper();
            plan.Fill(compress, incremental, soruce, destination);

            return plan;
        }

        public void createBinData(string destinationPath)
        {
            var backupPath = destinationPath;
            var guid = Guid.NewGuid();
            var timeStamp = DateTime.Now;
            var version = "1.0.0";

            List<signData> _data = new List<signData>();
            _data.Add(new signData()
            {
                guid = guid,
                timeStamp = timeStamp,
                version = version
            });

            var json = JsonSerializer.Serialize(_data);
            var fileName = "homSig.json";
            var path = backupPath + fileName;
            File.WriteAllText(path, json);
        }
    }

    public class signData
    {
        public Guid guid { get; set; }
        public DateTime timeStamp { get; set; }
        public string? version { get; set; }
    }
}
