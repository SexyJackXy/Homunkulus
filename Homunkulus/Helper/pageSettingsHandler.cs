﻿using Homunkulus.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public configFile GetConfigFile()
        {
            var savePath = @"../../../config";
            var latestFile = new DirectoryInfo(savePath)
                .GetFiles()
                .OrderByDescending(file => file.LastWriteTime)
                .FirstOrDefault();

            if (latestFile == null)
            {
                throw new FileNotFoundException("Es wurde keine Datei im angegebenen Verzeichnis gefunden.");
            }

            var content = File.ReadAllText(latestFile.FullName);
            var jsonObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);

            var cf = new configFile
            {
                FileExtension = jsonObject.GetValueOrDefault("Extension"),
                startMips = jsonObject.GetValueOrDefault("M.I.P.S")
            };

            return cf;
        }
    }
}
