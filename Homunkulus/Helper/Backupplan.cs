using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homunkulus.Helper;

namespace Homunkulus.Helper
{
    internal class BackupplanHelper
    {
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public List<string> Files { get; set; }
        public bool incrementel {  get; set; }
        public bool compress {  get; set; }

        public void Fill(bool g_compress, bool compliemntray, string source, string destination)
        {
            var util = new Util();

            compress = g_compress;
            incrementel = compliemntray;
            DestinationPath = destination;
            Files = new List<string>();

            var filesList = util.stringToList(source,true);

            foreach (var file in filesList) 
            { 
                Files.Add(file);
            }
        }

        //TO DO Fix the return of the Enumerable
        public IEnumerable<string> toIEnumerable(BackupplanHelper backupplan)
        {
            var IBackupPlan =  Enumerable.Empty<string>();

            IBackupPlan.Append(backupplan.DestinationPath);
            IBackupPlan.Append(backupplan.incrementel.ToString());
            IBackupPlan.Append(backupplan.compress.ToString());

            foreach (var file in backupplan.Files) 
            {
                IBackupPlan.Append(file);
            }
            return IBackupPlan;
        }
    }
}
