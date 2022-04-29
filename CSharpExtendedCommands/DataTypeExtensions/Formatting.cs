using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExtendedCommands.DataTypeExtensions
{

    namespace Formatting
    {
        public static class FormattingExtensions
        {
            public static string FormatAsXML(this string v)
            {
                return Data.Format.XML(v);
            }
            public static string FormatAsJSON(this string v)
            {
                return Data.Format.JSON(v);
            }
            public static string FormatAsJSON(this string v, string Indent)
            {
                return Data.Format.JSON(v, Indent);
            }
            public static string FormatAsJS(this string v)
            {
                return Data.Format.JS(v);
            }
            public static string FormatAsJS(this string v, char indent_char, int indent_size, int indent_level)
            {
                return Data.Format.JS(v, indent_char, indent_size, indent_level);
            }
            public static string FormatAsJS(this string v, char indent_char)
            {
                return Data.Format.JS(v, indent_char);
            }
            public static string FormatAsJS(this string v, char indent_char, int indent_size)
            {
                return Data.Format.JS(v, indent_char, indent_size);
            }
            public static string FormatAsJS(this string v, int indent_size)
            {
                return Data.Format.JS(v, indent_size);
            }
            public static string FormatAsJS(this string v, int indent_level, char indent_char = ' ')
            {
                return Data.Format.JS(v, indent_level, indent_char);
            }
        }
    }
}
