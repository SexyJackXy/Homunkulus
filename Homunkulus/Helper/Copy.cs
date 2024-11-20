using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homunkulus.Helper
{
    public class Copy
    {
        public void CopyNormal(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            All(diSource, diTarget);
        }
        public void All(DirectoryInfo source, DirectoryInfo target)
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
                    All(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch
            {
            }
        }
        public void FromList(List<string> pathList, TextBox destinationTextBox)
        {
            DateTime datetime = DateTime.Today;

            var shrt = "";
            var sourceDirectory = "";
            var targetDirectory = "";
            var destFolder = destinationTextBox.Text;
            var date = datetime.ToString("dd/MM/yyyy");
            var newBackupFolder = destFolder + "Backup " + date;

            for (var i = 0; i < pathList.Count; i++)
            {
                sourceDirectory = pathList.ElementAt(i);
                shrt = sourceDirectory.Substring(sourceDirectory.LastIndexOf("\\") + 1);
                targetDirectory = destFolder + "/Backup " + date + "/" + shrt;

                var attributs = File.GetAttributes(sourceDirectory);

                if ((attributs & FileAttributes.Directory) != FileAttributes.Directory)
                {
                    try
                    {
                        File.Copy(sourceDirectory, targetDirectory);
                    }
                    catch
                    {
                    }
                }
                else if (Directory.Exists(newBackupFolder) && !string.IsNullOrEmpty(sourceDirectory))
                {
                    CopyNormal(sourceDirectory, targetDirectory);
                }
                else if (!string.IsNullOrEmpty(sourceDirectory))
                {
                    Directory.CreateDirectory(newBackupFolder);
                    CopyNormal(sourceDirectory, targetDirectory);
                }
                else
                {
                    break;
                }
            }
        }
        public void FilesFromList(List<FileInfo> fileList, string destinationPath, string sourcePath)
        {
            var documentPath = @"C:\Users\Tim\Documents";
            var rootUserPaht = @"C:\Users\Tim";
            var backupFolderName = "Backup " + DateTime.Now.ToString("dd.MM.yyyy");
            var finalDestinationPath = Path.Combine(destinationPath, backupFolderName);
            var driveLetter = sourcePath.Substring(0, 3);

            foreach (var file in fileList)
            {
                var fileName = file.Name;
                var sourceDirPath = file.FullName;
                var relativeDirPath = file.Directory.ToString();

                if (relativeDirPath.Contains(documentPath))
                {
                    relativeDirPath = relativeDirPath.Replace(documentPath, "");
                }
                else if (relativeDirPath.Contains(rootUserPaht))
                {
                    relativeDirPath = relativeDirPath.Replace(rootUserPaht, "");
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
        public void Incremental(string destinationPath, List<string> sourceList)
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

                FilesFromList(newFiles, destinationPath, source);
            }
        }
    }
}
