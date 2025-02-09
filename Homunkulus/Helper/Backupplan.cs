using Homunkulus.helper;
using System.Xml;
using static Homunkulus.helper.configHander;
using static Homunkulus.pageSettings;

namespace Homunkulus.Helper
{
    internal class Backupplan
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public List<string> Files { get; set; }
        public bool incrementel { get; set; }
        public bool compress { get; set; }

        private void Fill(bool g_compress, bool compliemntray, string source, string destination)
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

            Fill(compress, incremental, soruce, destination);

            if (backupPlan.DestinationPath == null)
            {
                throw new ArgumentNullException(backupPlan.DestinationPath);
            }

            var saveInFileExtension = readSettingsFile().FileExtension;
            switch (saveInFileExtension)
            {
                case "txt":
                    saveToTxt(backupPlan, savePath);
                    break;

                case "xml":
                    saveToXml(backupPlan, savePath);
                    break;
            }
        }

        private void saveToTxt(Backupplan backupplan, string savePath)
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

        private void saveToXml(Backupplan backupplan, string savePath)
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

        private configFile readSettingsFile()
        {
            var savePath = @"../../../config";
            var directoryInfo = new DirectoryInfo(savePath);
            var firstFilePath = directoryInfo.GetFiles().OrderByDescending(x => x.LastWriteTime).FirstOrDefault();
            var jsonFileContent = System.Text.Json.JsonSerializer.Deserialize<config[]>(File.ReadAllText(firstFilePath.FullName));
            var fileExt = jsonFileContent.Select(x => x.fileExtension).FirstOrDefault();

            var configFile = new configHander.configFile
            {
                FileExtension = fileExt
            };

            return configFile;
        }
    }
}
