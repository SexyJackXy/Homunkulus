using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Homunkulus.pageSettings;

namespace Homunkulus.helper
{
    internal class pageSettingsHandler
    {
        public class configFile
        {
            //TODO: Extend the Configfile with more User Settings
            public string FileExtension { get; set; }
        }

        public configFile getConfigFile()
        {
            var cf = new configFile();
            var savePath = @"../../../config";
            var directoryInfo = new DirectoryInfo(savePath);
            var firstFilePath = directoryInfo.GetFiles().OrderByDescending(x => x.LastWriteTime).FirstOrDefault();

            using (StreamReader r = new StreamReader(firstFilePath.FullName))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<configFile>>(json);

                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in items)
                {
                    cf.FileExtension = item.FileExtension;
                }

            }

            return cf;
        }
    }
}
