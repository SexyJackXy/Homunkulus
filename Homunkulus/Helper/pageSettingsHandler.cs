using Homunkulus.Helper;
using Newtonsoft.Json;

namespace Homunkulus.helper
{
    internal class pageSettingsHandler
    {
        private Util util = new Util();
        public class configFile
        {
            //TODO: Extend the Configfile with more User Settings
            public string FileExtension { get; set; }
            public string? startMips { get; set; }
        }

        public configFile GetConfigFile()
        {
            var savePath = @"../../../config";

            util.createDirIfNotExsits(savePath);

            var latestFile = new DirectoryInfo(savePath)
                .GetFiles()
                .OrderByDescending(file => file.LastWriteTime)
                .FirstOrDefault();

            if (latestFile == null)
            {
                MessageBox.Show(new FileNotFoundException("Es wurde keine Datei im angegebenen Verzeichnis gefunden.").Message);
            }

            var content = File.ReadAllText(latestFile.FullName);
            var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);

            var cf = new configFile
            {
                FileExtension = jsonObject.GetValueOrDefault("Extension"),
            };

            return cf;
        }
    }
}
