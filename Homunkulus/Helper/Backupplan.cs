using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Homunkulus.Helper;
using System.Xml;
using System.IO;

namespace Homunkulus.Helper
{
    internal class Backupplan
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

        public void Create(bool compress, bool incremental, string soruce, string destination)
        {
            var util = new Util();
            var backupPlan = new Backupplan();
            var date = DateTime.Now.ToString("dd MM yyyy").Replace(" ", "");
            var saveDir = Directory.GetFiles(@"../../../backupplans");
            var saveFileName = date + "_" + saveDir.Length.ToString();
            var settingsPath = @"../../../config/";
            var dir = new DirectoryInfo(settingsPath);
            var newestSettingsFile = dir.GetFiles().OrderByDescending(x => x.LastWriteTime).FirstOrDefault();
            var savePath = @"../../../backupplans/" + saveFileName;

            backupPlan.Fill(compress, incremental, soruce, destination);

            if (backupPlan.DestinationPath == null)
            {
                throw new ArgumentNullException(backupPlan.DestinationPath);
            }


            backupPlan.saveToXml(backupPlan, savePath);
        }

        public void saveToTxt(Backupplan backupplan, string savePath)
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
                $"{backupplan.incrementel.ToString()}\n" +
                $"{backupplan.compress.ToString()}\n";

            File.WriteAllText(savePath, retrunString);
        }

        public void saveToXml(Backupplan backupplan, string savePath)
        {

            var destination = backupplan.DestinationPath;
            var incrementel = backupplan.incrementel.ToString();
            var compress = backupplan.compress.ToString();

            XmlTextWriter writer = new XmlTextWriter(savePath + ".xml", null);
            writer.WriteStartDocument();
            writer.WriteStartElement("Backup");

            writer.WriteStartElement("Destination");
            writer.WriteElementString("path", destination);
            writer.WriteEndElement();

            writer.WriteStartElement("SavedFiles");
            foreach (var file in Files)
            {
                writer.WriteElementString("File", file);
            }
            writer.WriteEndElement();

            writer.WriteStartElement("Status");
            writer.WriteElementString("Incrementel", incrementel);
            writer.WriteElementString("Compressed", compress);
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
