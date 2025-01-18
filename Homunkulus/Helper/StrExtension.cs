using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;

namespace Homunkulus.Helper
{
    public static class StringExtensions
    {
        public static void ThrowIfNullOrEmpty(this string source, string paramName, string paramNameDescription = null)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                var callingMethod = new StackFrame(1).GetMethod();
                throw new ArgumentOutOfRangeException(
                    paramName: paramName,
                    message: $"'{paramNameDescription ?? paramName}' can not be null or empty in method '{callingMethod.Name}' of '{callingMethod.DeclaringType.FullName}'");
            }
        }

        public static bool ContainsOic(this string s1, string s2)
        {
            if (s1 == null)
            {
                throw new ArgumentNullException(nameof(s1));
            }
            if (s2 == null)
            {
                throw new ArgumentNullException(nameof(s2));
            }
            return s1.IndexOf(s2, StringComparison.OrdinalIgnoreCase) != -1;
        }

        public static bool IsNullOrEmpty([NotNullWhen(false)] this string source)
        {
            return String.IsNullOrEmpty(source);
        }

        public static bool StartsWithOic(this string s1, string s2)
        {
            if (s1 == null)
            {
                throw new ArgumentNullException(nameof(s1));
            }
            if (s2 == null)
            {
                throw new ArgumentNullException(nameof(s2));
            }
            return s1.StartsWith(s2, StringComparison.OrdinalIgnoreCase);
        }

        public static bool EqualsOic(this string s1, string s2)
        {
            if (s1 == null)
            {
                throw new ArgumentNullException(nameof(s1));
            }
            return s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
        }

        public static string stringClean(this string str)
        {
            if (!string.IsNullOrEmpty(str) && char.IsWhiteSpace(str[0]))
            {
                str = str.TrimStart();
            }

            return str;
        }

        public static string Clean(this string str)
        {
            return str;
        }
    }
}
