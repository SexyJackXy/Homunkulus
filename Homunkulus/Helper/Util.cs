using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string stringClean(string str)
        {
            if (!string.IsNullOrEmpty(str) && char.IsWhiteSpace(str[0]))
            {
                str = str.TrimStart();
            }

            return str;
        }

        public void createBinData()
        {
            var backupPath = @"";   //TODO: HERE NEED TO ADD THE BACKUPPATH 
            var guid = Guid.NewGuid();
            var content = "";       //TODO: HERE I NEED TO THINK ABOUT POSSIBLE CONTENT WHICH I CAN PUT IN THIS .JSON FILE
        }
    }

    ///TODO: added this next
    //public bool EqualsOic(this string s1, string s2)
    //{
    //    if (s1 == null)
    //    {
    //        throw new ArgumentNullException(nameof(s1));
    //    }
    //    return s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
    //}
    //public bool ContainsOic(this string s1, string s2)
    //{
    //    if (s1 == null)
    //    {
    //        throw new ArgumentNullException(nameof(s1));
    //    }
    //    if (s2 == null)
    //    {
    //        throw new ArgumentNullException(nameof(s2));
    //    }
    //    return s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase) != -1;
    //}
    //public bool StartsWithOic(this string s1, string s2)
    //{
    //    if (s1 == null)
    //    {
    //        throw new ArgumentNullException(nameof(s1));
    //    }
    //    if (s2 == null)
    //    {
    //        throw new ArgumentNullException(nameof(s2));
    //    }
    //    return s1.StartsWith(s2, StringComparison.OrdinalIgnoreCase);
    //}
}
