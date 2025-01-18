using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Homunkulus.Helper;

namespace Homunkulus.Helper
{
    internal class BackupplanHelper
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public List<string> Files { get; set; }
        public bool incrementel { get; set; }
        public bool compress { get; set; }

        public void Fill(bool g_compress, bool compliemntray, string source, string destination)
        {
            var util = new Util();

            compress = g_compress;
            incrementel = compliemntray;
            DestinationPath = destination;
            Files = new List<string>();

            var filesList = util.stringToList(source, true);

            foreach (var file in filesList)
            {
                Files.Add(file);
            }
        }

        public void Save(BackupplanHelper backupplan, string savePath)
        {
            string[] destination = { backupplan.DestinationPath };
            string[] incrementel = { backupplan.incrementel.ToString() };
            string[] compress = { backupplan.compress.ToString() };
            var tempFiles = new List<string>();

            foreach (var file in backupplan.Files)
            {
                tempFiles.Add(file);
            }

            var files = string.Join("\n", tempFiles);

            var retrunString =
                $"Destination:\n" +
                $"{backupplan.DestinationPath}\n" +
                $"\n" +
                $"Files: \n" +
                $"{files}" +
                $"\n" +
                $"Status:\n" +
                $"{backupplan.incrementel.ToString()}\n" +
                $"{backupplan.compress.ToString()}\n";

            File.WriteAllText(savePath,retrunString);
        }
    }
}
