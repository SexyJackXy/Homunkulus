﻿using Newtonsoft.Json.Linq;

namespace Homunkulus.Helper
{
    public class Util
    {
        public List<string> stringToList(string str, bool removeEmptyEntries)
        {
            var returnList = new List<string>();

            if (string.IsNullOrWhiteSpace(str))
            {
                return returnList;
            }

            str.Replace("\n", "\r");
            var IReturnList = str.Replace("\r", "").Split(new[] { '\n' }, removeEmptyEntries ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None);
            return IReturnList.ToList();
        }
        public string toTextFile(string fileName)
        {
            return fileName + ".txt";
        }

        public void createBinData(string dest, string type)
        {
            var savePath = Path.Combine(dest, "HomunkulusSig.json");
            var guid = Guid.NewGuid().ToString();
            var date = DateTime.Now.ToString();

            JObject binData = new JObject(
                new JProperty("ProgramName", "Homunukulus"),
                new JProperty("Guid", guid),
                new JProperty("BackupType", type),
                new JProperty("Timestampp", date),
                new JProperty("Destination", dest));

            File.WriteAllText(savePath, binData.ToString());
        }
        public void createBackupPlan(bool compress, bool incremental, string soruce, string destination)
        {
            var util = new Util();
            var bph = new Backupplan();
            bph.Fill(compress, incremental, soruce, destination);

            if (bph.DestinationPath == null)
            {
                throw new ArgumentNullException(bph.DestinationPath);
            }
            var date = DateTime.Now.ToString("dd MM yyyy");
            date = date.Replace(" ", "");

            var saveDir = Directory.GetFiles(@"../../../backupplans");
            var saveFileName = date + "_" + saveDir.Length.ToString();
            //saveFileName = util.toTextFile(saveFileName);

            var savePath = @"../../../backupplans/" + saveFileName;

            bph.saveToJson(bph, savePath);
        }
    }
}
