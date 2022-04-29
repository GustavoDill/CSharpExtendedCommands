using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExtendedCommands.DataTypeExtensions
{

    namespace Converters
    {
        public static class ConvertersExtension
        {
            public static string ToHex(this int v)
            {
                return v.ToString("X2");
            }
            public static string ToBinary(this int v)
            {
                return Convert.ToString(v, 2); ;
            }
            public static int ToOctal(this int v)
            {
                return int.Parse(Convert.ToString(v, 8));
            }
            public static int ToInt(this string v)
            {
                if (v.StartsWith("0x"))
                    return Convert.ToInt32(v, 16);
                else
                {
                    try { return int.Parse(v); } catch { return -1; }
                }
            }
            public static string ToBinary(this string v)
            {
                return Converter.TextToBinary(v);
            }
            public static string ToHex(this string v)
            {
                string outp = string.Empty;
                char[] value = v.ToCharArray();
                foreach (char L in value)
                {
                    int V = Convert.ToInt32(L);
                    outp += string.Format("{0:x}", V);
                }
                return outp;
            }
        }
    }
}
