using Homunkulus.Helper;

namespace Homunkulus.helper
{
    internal class pagePlanManagementHandler
    {
        public string sanatizeFileXML(string xmlString)
        {
            var res = xmlString.Replace("<File>", "");
            res = res.Replace("</File>", "\n");

            return res;
        }
    }
}
