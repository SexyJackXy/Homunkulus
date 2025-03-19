using Homunkulus.Helper;
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
            public string? startMips { get; set; }
        }

        public configFile getConfigFile()
        {
            //TODO: Try to impleet Mips

            var util = new Util();
            var cf = new configFile();
            var savePath = @"../../../config";
            var directoryInfo = new DirectoryInfo(savePath);
            var firstFilePath = directoryInfo.GetFiles().OrderByDescending(x => x.LastWriteTime).FirstOrDefault().FullName;
            var content = new StreamReader(firstFilePath).ReadToEnd();
            configFile[] items = JsonConvert.DeserializeObject<configFile[]>(content);

            foreach (var item in items)
                {
                }
     

            return cf;
        }
    }
}
