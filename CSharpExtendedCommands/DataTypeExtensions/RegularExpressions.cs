using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpExtendedCommands.DataTypeExtensions
{

    namespace RegularExpressions
    {
        public static class RegexClassExtensions
        {

            public static string[] RegexSplit(this string str, string regexPattern, RegexOptions options) => Regex.Split(str, regexPattern, options);
            public static string[] RegexSplit(this string str, string regexPattern) => Regex.Split(str, regexPattern);
            public static string RegexMatch(this string str, string regexPattern) { try { var m = Regex.Match(str, regexPattern); if (!m.Success) return null; else return m.Value; } catch { return null; } }
            public static string RegexReplace(this string str, string regexFindPattern, string replaceWith) => Regex.Replace(str, regexFindPattern, replaceWith);
            public static bool MatchRegex(this string str, string regexPattern) => Regex.IsMatch(str, regexPattern);
            public static Match GetRegexMatch(this string str, string regexPattern) => Regex.Match(str, regexPattern);
            public static Match[] GetRegexMatches(this string str, string regexPattern) { MatchCollection m = Regex.Matches(str, regexPattern); List<Match> tmp = new List<Match>(); for (int i = 0; i < m.Count; i++) tmp.Add(m[i]); return tmp.ToArray(); }
            /// <summary>
            /// Returns a search pattern for lower and uppercase letters on a literal
            /// Example: username -> [uU][sS][eE][rR][nN][aA][mM][eE]
            /// </summary>
            public static string GetRegexLowerUpperPattern(this string str)
            {
                var ret = "";
                foreach (var c in str)
                    if (c.ToString().ToLower() != c.ToString().ToUpper())
                        ret += "[" + c.ToString().ToLower() + c.ToString().ToUpper() + "]";
                    else
                        ret += c.ToString();
                return ret;
            }
            public static string[] RegexMatches(this string str, string regexPattern)
            {
                var m = Regex.Matches(str, regexPattern);
                List<string> tmp = new List<string>();
                if (!(m.Count > 0))
                    return null;
                foreach (Match match in m)
                    tmp.Add(match.Value);
                return tmp.ToArray();
            }
        }
    }
}
