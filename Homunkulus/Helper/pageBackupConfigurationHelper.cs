using Homunkulus.helper;
using System.Diagnostics;
using System.Xml.Linq;

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
            public string type { get; set; }
        }

        public Util util1 = new Util();

        private void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            Copy_All(diSource, diTarget);
        }
        static async Task Copy_All(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            try
            {
                var fileTasks = source.GetFiles().Select(async fi =>
                {
                    try
                    {
                        string targetPath = Path.Combine(target.FullName, fi.Name);
                        using var sourceStream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, true);
                        using var targetStream = new FileStream(targetPath, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true);
                        await sourceStream.CopyToAsync(targetStream);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Fehler beim Kopieren von {fi.FullName}: {ex.Message}");
                    }
                });

                var dirTasks = source.GetDirectories().Select(async diSourceSubDir =>
                {
                    try
                    {
                        var nextTargetSubDir = target.CreateSubdirectory(diSourceSubDir.Name);
                        await Copy_All(diSourceSubDir, nextTargetSubDir);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Fehler beim Erstellen des Verzeichnisses {diSourceSubDir.FullName}: {ex.Message}");
                    }
                });

                await Task.WhenAll(fileTasks.Concat(dirTasks));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Kopieren des Verzeichnisses {source.FullName}: {ex.Message}");
            }
        }
        public void Copy_FromList(List<string>? pathList, TextBox destinationTextBox)
        {
            DateTime datetime = DateTime.Today;
            var util = new Util();
            var destFolder = destinationTextBox.Text;
            var date = datetime.ToString("dd/MM/yyyy");
            var newBackupFolder = Path.Combine(destFolder, $"Backup {date}");

            if (new pageSettingsHandler().GetConfigFile().startMips.EqualsOic("yes"))
            {
                new Util().RunPowershellScript(@"../../mips.ps1");
            }

            Directory.CreateDirectory(newBackupFolder);
            util.createBinData(newBackupFolder, "Full");

            Parallel.ForEach(pathList, sourceDirectory =>
            {
                try
                {
                    if (string.IsNullOrEmpty(sourceDirectory)) return;

                    var shrt = Path.GetFileName(sourceDirectory);
                    var targetDirectory = Path.Combine(newBackupFolder, shrt);

                    Copy(sourceDirectory, targetDirectory);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Kopieren von {sourceDirectory}: {ex.Message}");
                }
            });

        }
        private void Copy_FilesFromList(List<FileInfo> fileList, string destinationPath, string sourcePath)
        {
            var userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var backupFolderName = $"Backup {DateTime.Now:dd.MM.yyyy}";
            var finalDestinationPath = Path.Combine(destinationPath, backupFolderName);
            var driveLetter = sourcePath.Substring(0, 3);

            util1.createBinData(finalDestinationPath, "Incremental");

            Parallel.ForEach(fileList, file =>
            {
                try
                {
                    var fileName = file.Name;
                    var sourceDirPath = file.FullName;
                    var relativeDirPath = file.DirectoryName!;  // Null-Sicherheit

                    if (relativeDirPath.StartsWith(documentPath))
                        relativeDirPath = relativeDirPath.Substring(documentPath.Length);
                    else if (relativeDirPath.StartsWith(userProfilePath))
                        relativeDirPath = relativeDirPath.Substring(userProfilePath.Length);
                    else if (relativeDirPath.StartsWith(driveLetter))
                        relativeDirPath = relativeDirPath.Substring(driveLetter.Length);

                    relativeDirPath = relativeDirPath.TrimStart('\\', '/'); // Entfernt führende Trennzeichen

                    var targetDirPath = Path.Combine(finalDestinationPath, relativeDirPath);
                    Directory.CreateDirectory(targetDirPath);  // Keine Notwendigkeit für Exists-Check

                    var targetFilePath = Path.Combine(targetDirPath, fileName);
                    File.Copy(sourceDirPath, targetFilePath, true);  // `true` überschreibt existierende Dateien
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler beim Kopieren von {file.FullName}: {ex.Message}");
                }
            });
        }
        public void Copy_Incremental(string destinationPath, List<string>? sourceList)
        {

            var tfs = new TemporaryFileStore(destinationPath);
            var latestBackupDate = tfs.OldBackups.Any() ? tfs.OldBackups.Max(dir => dir.CreationTime) : DateTime.MinValue;

            if (new pageSettingsHandler().GetConfigFile().startMips.EqualsOic("yes"))
            {
                new Util().RunPowershellScript(@"../../mips.ps1");
            }

            foreach (var source in sourceList)
            {
                var sourcePathFiles = Directory.GetFiles(source, "*.*", SearchOption.AllDirectories).Select(path => new FileInfo(path));
                var newFiles = sourcePathFiles.Where(file => file.LastWriteTime > latestBackupDate).ToList();

                if (newFiles.Any())
                {
                    Parallel.ForEach(newFiles, file =>
                    {
                        try
                        {
                            Copy_FilesFromList(new List<FileInfo> { file }, destinationPath, source);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Fehler beim Kopieren von {file.FullName}: {ex.Message}");
                        }
                    });
                }
            }
        }
        private void InitializeBackupPlan(backupPlan backupPlan, bool compress, bool incremental, string destination, string source)
        {
            backupPlan.compress = compress;
            backupPlan.incremental = incremental;
            backupPlan.DestinationPath = destination;
            backupPlan.Files = util1.stringToList(source, true);

            var types = new List<string>();
            if (incremental) types.Add("incremental");
            if (compress) types.Add("compress");
            backupPlan.type = types.Any() ? string.Join(", ", types) : "full";
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

            var saveInFileExtension = configHandler.GetConfigFile();
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
            var xml = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Backup",
                    new XElement("Destination",
                        new XElement("Path", backupplan.DestinationPath)
                    ),
                    new XElement("SavedFiles",
                        backupplan.Files.Select(file => new XElement("File", file))
                    ),
                    new XElement("Status",
                        new XElement("Incremental", backupplan.incremental),
                        new XElement("Compressed", backupplan.compress)
                    )
                )
            );

            xml.Save(savePath + ".xml");
        }
    }
}
