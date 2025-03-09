using Homunkulus.helper;
using System.Xml;

namespace Homunkulus.Helper
{
    internal class pageBackupConfigurationHelper
    {
        private class backupPlan : pageBackupConfigurationHelper
        {
            public string DestinationPath { get; set; }
            public List<string> Files { get; set; }
            public bool incremental { get; set; }
            public bool compress { get; set; }
            public string type {  get; set; }

        }

        public Util util1 = new Util();

        private void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            Copy_All(diSource, diTarget);
        }
        public void Copy_All(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }
            try
            {
                // Copy each subdirectory using recursion.
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                    Copy_All(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch
            {
            }
        }
        public void Copy_FromList(List<string> pathList, TextBox destinationTextBox)
        {
            DateTime datetime = DateTime.Today;
            var util = new Util();
            var shrt = string.Empty;
            var sourceDirectory = string.Empty;
            var targetDirectory = string.Empty;
            var destFolder = destinationTextBox.Text;
            var date = datetime.ToString("dd/MM/yyyy");
            var newBackupFolder = destFolder + "Backup " + date;

            for (var i = 0; i < pathList.Count; i++)
            {
                sourceDirectory = pathList.ElementAt(i);
                shrt = sourceDirectory.Substring(sourceDirectory.LastIndexOf("\\") + 1);
                targetDirectory = destFolder + "/Backup " + date + "/" + shrt;

                if (Directory.Exists(newBackupFolder) && !string.IsNullOrEmpty(sourceDirectory))
                {
                    Copy(sourceDirectory, targetDirectory);
                }
                else if (!string.IsNullOrEmpty(sourceDirectory))
                {
                    Directory.CreateDirectory(newBackupFolder);
                    util1.createBinData(newBackupFolder, "Full");
                    Copy(sourceDirectory, targetDirectory);
                }
                else
                {
                    break;
                }
            }
        }
        public void Copy_FilesFromList(List<FileInfo> fileList, string destinationPath, string sourcePath)
        {
            var userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var backupFolderName = "Backup " + DateTime.Now.ToString("dd.MM.yyyy");
            var finalDestinationPath = Path.Combine(destinationPath, backupFolderName);
            var driveLetter = sourcePath.Substring(0, 3);

            util1.createBinData(finalDestinationPath, "Incremental");

            foreach (var file in fileList)
            {
                var fileName = file.Name;
                var sourceDirPath = file.FullName;
                var relativeDirPath = file.Directory.ToString();

                if (relativeDirPath.Contains(documentPath))
                {
                    relativeDirPath = relativeDirPath.Replace(documentPath, "");
                }
                else if (relativeDirPath.Contains(userProfilePath))
                {
                    relativeDirPath = relativeDirPath.Replace(userProfilePath, "");
                }
                else if (relativeDirPath.Contains(driveLetter))
                {
                    relativeDirPath = relativeDirPath.Replace(driveLetter, "");
                }


                if (relativeDirPath.StartsWith(@"\") || relativeDirPath.StartsWith("/"))
                {
                    relativeDirPath = relativeDirPath.Substring(1);
                }

                var targetDirPath = Path.Combine(finalDestinationPath, relativeDirPath);
                if (!Directory.Exists(targetDirPath))
                {
                    Directory.CreateDirectory(targetDirPath);
                }

                var targetFilePath = Path.Combine(targetDirPath, fileName);
                try
                {
                    File.Copy(sourceDirPath, targetFilePath);
                }
                catch { }
            }
        }
        public void Copy_Incremental(string destinationPath, List<string> sourceList)
        {
            var tfs = new TemporaryFileStore(destinationPath);
            var complimentaryFiles = new List<string>();
            var latestedBackupDate = tfs.OldBackups.Max(dir => dir.CreationTime);

            foreach (var source in sourceList)
            {
                var sourcePathFiles = Directory.GetFiles(source, "*.*", SearchOption.AllDirectories).Select(path => new FileInfo(path)).ToList();
                var oldFiles = tfs.Direcorty.ToList();
                var newFiles = sourcePathFiles.Where(file => file.LastWriteTime > latestedBackupDate).Select(file => file).ToList();
                var parentDirectories = newFiles.Select(file => file.Directory).Where(dir => dir != null).Distinct().ToList();

                Copy_FilesFromList(newFiles, destinationPath, source);
            }
        }
        private void InitializeBackupPlan(backupPlan backupPlan, bool compress, bool incremental, string destination, string source)
        {
            backupPlan.compress = compress;
            backupPlan.incremental = incremental;
            backupPlan.DestinationPath = destination;
            backupPlan.Files = new List<string>();

            var filesList = util1.stringToList(source, true);

            if (compress && incremental)
            {
                backupPlan.type = "incremental, compress";
            }
            else if (incremental)
            {
                backupPlan.type = "incremental";
            }
            else if (compress)
            {
                backupPlan.type = "compress";
            }
            else
            {
                backupPlan.type = "full";
            }

            backupPlan.Files.AddRange(filesList);
        }
        public void Create(bool compress, bool incremental, string source, string destination)
        {
            var configHandler = new pageSettingsHandler();
            var backupPlan = new backupPlan();
            var date = DateTime.Now.ToString("dd MM yyyy").Replace(" ", "");
            var saveDir = Directory.GetFiles(@"../../../backupplans");
            var saveFileName = date + "_" + saveDir.Length.ToString();
            var settingsPath = @"../../../config/";
            var dir = new DirectoryInfo(settingsPath);
            var backuPlanSavePath = @"../../../backupplans/" + saveFileName;

            InitializeBackupPlan(backupPlan, compress, incremental, destination, source);

            if (backupPlan.DestinationPath == null)
            {
                throw new ArgumentNullException("The Destination path is null");
            }

            var saveInFileExtension = configHandler.getConfigFile();
            switch (saveInFileExtension.FileExtension)
            {
                case "txt":
                    saveToTxt(backupPlan, backuPlanSavePath);
                    break;

                case "XML":
                    saveToXml(backupPlan, backuPlanSavePath);
                    break;
            }
        }
        private void saveToTxt(backupPlan backupplan, string savePath)
        {
            var files = string.Join("\n", backupplan.Files);

            var retrunString =
                $"Destination:\n" +
                $"{backupplan.DestinationPath}\n" +
                $"\n" +
                $"Files: \n" +
                $"{files}" +
                $"\n" +
                $"Status:\n" +
                $"{backupplan.incremental.ToString()}\n" +
                $"{backupplan.compress.ToString()}\n";

            File.WriteAllText(savePath, retrunString);
        }
        private void saveToXml(backupPlan backupplan, string savePath)
        {

            var destination = backupplan.DestinationPath;
            var incremental = backupplan.incremental.ToString();
            var compress = backupplan.compress.ToString();
            var sourceFiles = backupplan.Files;

            XmlTextWriter writer = new XmlTextWriter(savePath + ".xml", null);
            writer.WriteStartDocument();
            writer.WriteStartElement("Backup");

            writer.WriteStartElement("Destination");
            writer.WriteElementString("path", destination);
            writer.WriteEndElement();

            writer.WriteStartElement("SavedFiles");

            if (sourceFiles.Count > 0)
            {
                foreach (var file in sourceFiles)
                {
                    writer.WriteElementString("File", file);
                }
            }

            writer.WriteEndElement();

            writer.WriteStartElement("Status");
            writer.WriteElementString("incremental", incremental);
            writer.WriteElementString("Compressed", compress);
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
