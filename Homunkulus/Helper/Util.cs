using DocumentFormat.OpenXml.Bibliography;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace Homunkulus.Helper
{
    public class Util
    {
        public string mainDirectory = @"../../../";
        public virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }
        public void UnlockFile(String fileName, bool fileIsLocked)
        {
            try
            {
                if (fileIsLocked)
                {
                    return;
                }
                else
                {
                    var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    fs.Close();
                }
            }
            catch
            {
                throw new ArgumentException(fileName + "can not be unlocked");
            }
        }
        public List<string> stringToList(string str, bool removeEmptyEntries)
        {
            var returnList = new List<string>();

            if (string.IsNullOrWhiteSpace(str))
            {
                return returnList;
            }

            str.Replace("\n", "\r");
            var IReturnList = str.Replace("\r", "").Split(new[] { '\n' }, removeEmptyEntries ? StringSplitOptions.RemoveEmptyEntries : StringSplitOptions.None);
            return IReturnList.ToList();
        }
        public List<string> CleanList(List<string> list) 
        {
            var res = list.Where(x => !string.IsNullOrEmpty(x)).ToList();

            return res;
        }
        public string toTextFile(string fileName)
        {
            return fileName + ".txt";
        }
        public JObject createBinData(string dest)
        {
            var guid = Guid.NewGuid().ToString();
            var date = DateTime.Now.ToString();

            var binData = new JObject(
                new JProperty("ProgramName", "Homunukulus"),
                new JProperty("Guid", guid),
                new JProperty("Timestampp", date),
                new JProperty("Destination", dest));

            return binData;
        }
        public List<string> readJsonFIle(string filePath)
        {
            var streamReader = new StreamReader(filePath);
            var json = streamReader.ReadToEnd();
            var jsonContent = JsonConvert.DeserializeObject<List<string>>(json);

            return jsonContent;
        }
        public async Task RunPowershellScript(string path)
        {
            var arguments = $"-ExecutionPolicy Bypass -File {path}";
            var processStart = new ProcessStartInfo("powershell.exe", arguments)
            {
                RedirectStandardOutput = true,  
                RedirectStandardError = true,   
                UseShellExecute = false,        
                CreateNoWindow = true           
            };

            using var process = new Process { StartInfo = processStart };

            process.Start();
            await process.WaitForExitAsync();
        }
    }
}
