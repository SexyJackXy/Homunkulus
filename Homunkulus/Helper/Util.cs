using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        public void readJsonFIle(string filePath)
        {
            //TODO:Schreib das ding Fertig oder mach es neu
            dynamic fileContent = JsonConvert.DeserializeObject(filePath);
            foreach (var content in fileContent)
            {

            }
        }
    }
}
