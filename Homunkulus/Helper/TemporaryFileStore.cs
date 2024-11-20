using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homunkulus.Helper
{
    internal class TemporaryFileStore
    {
        public List<FileInfo> OldFiles { get; set; }
        public List<string> Direcorty { get; set; }
        public List<string> FileName { get; set; }
        public List<DirectoryInfo> OldBackups { get; set; }

        public TemporaryFileStore(string destination)
        {
            Direcorty = new List<string>();
            FileName = new List<string>();

            var today = DateTime.Now;
            var dirList = Directory.GetDirectories(destination, "*.*", SearchOption.TopDirectoryOnly)
                                    .Select(dir => new DirectoryInfo(dir))
                                    .Where(dirInfo => dirInfo.LastWriteTime < today)
                                    .ToList();

            var allOldFiles = new List<FileInfo>();

            foreach (var dir in dirList)
            {
                var filesInDir = Directory.GetFiles(dir.FullName, "*.*", SearchOption.AllDirectories).ToList();
                foreach (var file in filesInDir)
                {
                    var fi = new FileInfo(file);
                    allOldFiles.Add(fi);
                }
            }

            OldBackups = dirList;
            OldFiles = allOldFiles;

            foreach (var file in OldFiles)
            {
                var fiDir = file.Directory.ToString();
                FileName.Add(file.Name); // Hinzufügen des Dateinamens zur Liste

                if (!Direcorty.Contains(fiDir))
                {
                    Direcorty.Add(file.Directory.ToString()); // Hinzufügen des vollständigen Pfads zur Liste
                }
            }
        }
    }
}
