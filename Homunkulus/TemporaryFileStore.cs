using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homunkulus
{
    internal class TemporaryFileStore
    {
        public IEnumerable<string> Files { get; set; }
        public List<string> Direcorty { get; set; }
        public List<string> FileName { get; set; }

        public TemporaryFileStore(string destination)
        {
            Direcorty = new List<string>();
            FileName = new List<string>();

            var today = DateTime.Now;
            var dirList = Directory.GetDirectories(destination, "*.*", SearchOption.TopDirectoryOnly)
                                    .Select(dir => new DirectoryInfo(dir))
                                    .Where(dirInfo => dirInfo.LastWriteTime != today)
                                    .ToList();

            var allOldFiles = new List<string>();

            foreach (var dir in dirList)
            {
                var filesInDir = Directory.GetFiles(dir.FullName, "*.*", SearchOption.AllDirectories).ToList();
                foreach (var file in filesInDir)
                {
                    allOldFiles.Add(file);
                }
            }

            var s_allOldFiles = allOldFiles.Distinct().OrderBy(f => f).ToList();
            Files = s_allOldFiles;

            foreach (var file in s_allOldFiles)
            {
                var fi = new FileInfo(file);
                var fiDir = fi.Directory.ToString();
                FileName.Add(fi.Name); // Hinzufügen des Dateinamens zur Liste

                if (!Direcorty.Contains(fiDir))
                {
                    Direcorty.Add(fi.Directory.ToString()); // Hinzufügen des vollständigen Pfads zur Liste
                }
            }
        }
    }
}
