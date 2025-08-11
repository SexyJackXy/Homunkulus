using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text;
using static Homunkulus.helper.pageSettingsHandler;

namespace Homunkulus.Helper
{
    public class Util
    {
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
        public void createBinData(string dest, string type)
        {
            var savePath = Path.Combine(dest, "HomunkulusSig.json");
            var guid = Guid.NewGuid().ToString();
            var date = DateTime.Now.ToString();

            JObject binData = new JObject(
                new JProperty("ProgramName", "Homunukulus"),
                new JProperty("Guid", guid),
                new JProperty("BackupType", type),
                new JProperty("Timestampp", date),
                new JProperty("Destination", dest));

            File.WriteAllText(savePath, binData.ToString());
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
        public void createDirIfNotExsits(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
