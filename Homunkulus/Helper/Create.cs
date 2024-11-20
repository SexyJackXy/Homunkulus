namespace Homunkulus.Helper
{
    internal class Create
    {
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
            saveFileName = util.toTextFile(saveFileName);

            var savePath = @"../../../backupplans/" + saveFileName;
            File.Create(savePath);

            var IBackupPlan = bph.toIEnumerable(backupplan);

            File.AppendAllLines(savePath, IBackupPlan);
        }

        public BackupplanHelper createBlackupplan(bool compress, bool incremental, string soruce, string destination)
        {
            var plan = new BackupplanHelper();
            plan.Fill(compress, incremental,soruce,destination);

            return plan;
        }
    }
}
