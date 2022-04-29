using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CSharpExtendedCommands
{

    namespace Data
    {
        public class IniFile
        {
            string Path;
            string EXE = Assembly.GetExecutingAssembly().GetName().Name;
            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);
            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);
            public IniFile(string IniPath = null) => Path = new System.IO.FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
            public string Read(string Key, string Section = null)
            {
                var RetVal = new StringBuilder(255);
                GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
                return RetVal.ToString();
            }
            public void Write(string Key, string Value, string Section = null) => WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
            public void DeleteKey(string Key, string Section = null) => Write(Key, null, Section ?? EXE);
            public void DeleteSection(string Section = null) => Write(null, null, Section ?? EXE);
            public bool KeyExists(string Key, string Section = null) => Read(Key, Section).Length > 0;
        }
        public class CommandProcessor
        {
            private static string ParseQuotes(ref string thing)
            {
                var t = thing;
                t = t.Substring(1);
                t = t.Substring(0, t.IndexOf("\""));
                if (thing.Replace(t, "") == "\"\"")
                    thing = "";
                else
                    thing = thing.Substring(t.Length + 3);
                return t;
            }
            private static string ParseNoQuotes(ref string thing)
            {
                var t = thing.Split(' ')[0];
                if (thing.Contains(" "))
                    thing = thing.Substring(t.Length + 1);
                else
                    thing = "";
                return t;
            }
            public static string[] ParseArgs(string args)
            {
                List<string> cmds = new List<string>();
                string a = args;
                while (a != "")
                {
                    if (a.Substring(0, 1) == "\"")
                        cmds.Add(ParseQuotes(ref a));
                    else
                        cmds.Add(ParseNoQuotes(ref a));
                }
                return cmds.ToArray();
            }
        }
        public static class Format
        {
            public static string CSharp(string source)
            {
                return VB(source);
            }
            public static string VB(string source)
            {
                return JS(source);
            }
            public static string XML(string xml)
            {
                var document = System.Xml.Linq.XDocument.Parse(xml);
                return document.ToString();
            }
            public static string JSON(string json)
            {
                return Data.SimpleJSON.JSON.Format(json);
            }
            public static string JSON(string json, string Indent)
            {
                return Data.SimpleJSON.JSON.Format(json, Indent);
            }
            public static string JS(string source, char indent_char, int indent_size, int indent_level)
            {
                return JSFormatter.FormatJS(source, indent_char, indent_size, indent_level);
            }
            public static string JS(string source)
            {
                return Format.JS(source, ' ', 4);
            }
            public static string JS(string source, char indent_char)
            {
                return JSFormatter.FormatJS(source, indent_char, 4, 0);
            }
            public static string JS(string source, char indent_char, int indent_size)
            {
                return JSFormatter.FormatJS(source, indent_char, indent_size, 0);
            }
            public static string JS(string source, int indent_size)
            {
                return JSFormatter.FormatJS(source, ' ', indent_size, 0);
            }
            public static string JS(string source, int indent_level, char indent_char = ' ')
            {
                return JSFormatter.FormatJS(source, indent_char, 4, indent_level);
            }
            private static class JSFormatter
            {
                private static string last_word;
                private static bool var_line;
                private static bool var_line_tainted;
                private static string[] line_starters;
                private static bool in_case;
                private static string token_type;
                private static StringBuilder output;
                private static string indent_string;
                private static int indent_level;
                private static string token_text;
                private static Stack<string> modes;
                private static string current_mode;
                private static int opt_indent_size;
                private static char opt_indent_char;
                private static bool opt_preserve_newlines;
                private static bool if_line_flag;
                private static bool do_block_just_closed;
                private static string input;

                private static void Trim_output()
                {
                    while ((output.Length > 0) && ((output[output.Length - 1] == ' ') || (output[output.Length - 1].ToString() == indent_string)))
                    {
                        output.Remove(output.Length - 1, 1);
                    }
                }

                private static void Print_newline(bool? ignore_repeated)
                {
                    ignore_repeated = ignore_repeated ?? true;

                    if_line_flag = false;
                    Trim_output();

                    if (output.Length == 0)
                        return;

                    if ((output[output.Length - 1] != '\n') || !ignore_repeated.Value)
                    {
                        output.Append(Environment.NewLine);
                    }

                    for (var i = 0; i < indent_level; i++)
                    {
                        output.Append(indent_string);
                    }
                }

                private static void Print_space()
                {
                    var last_output = " ";
                    if (output.Length > 0)
                        last_output = output[output.Length - 1].ToString();
                    if ((last_output != " ") && (last_output != "\n") && (last_output != indent_string))
                    {
                        output.Append(' ');
                    }
                }


                private static void Print_token()
                {
                    output.Append(token_text);
                }

                private static void Indent()
                {
                    indent_level++;
                }

                private static void Unindent()
                {
                    if (indent_level > 0)
                        indent_level--;
                }

                private static void Remove_indent()
                {
                    if ((output.Length > 0) && (output[output.Length - 1].ToString() == indent_string))
                    {
                        output.Remove(output.Length - 1, 1);
                    }
                }

                private static void Set_mode(string mode)
                {
                    modes.Push(current_mode);
                    current_mode = mode;
                }

                private static void Restore_mode()
                {
                    do_block_just_closed = (current_mode == "DO_BLOCK");
                    current_mode = modes.Pop();
                }

                private static bool Is_ternary_op()
                {
                    int level = 0;
                    int colon_count = 0;
                    for (var i = output.Length - 1; i >= 0; i--)
                    {
                        switch (output[i])
                        {
                            case ':':
                                if (level == 0)
                                    colon_count++;
                                break;
                            case '?':
                                if (level == 0)
                                {
                                    if (colon_count == 0)
                                    {
                                        return true;
                                    }
                                    else
                                    {
                                        colon_count--;
                                    }
                                }
                                break;
                            case '{':
                                if (level == 0) return false;
                                level--;
                                break;
                            case '(':
                            case '[':
                                level--;
                                break;
                            case ')':
                            case ']':
                            case '}':
                                level++;
                                break;
                        }
                    }
                    return false;
                }

                private static string whitespace;
                private static string wordchar;
                private static int parser_pos;
                private static string last_type;
                private static string last_text;
                private static string digits;
                private static string[] punct;
                private static string prefix;

                public static int Opt_indent_level { get; set; }

                private static string[] Get_next_token(ref int parser_pos)
                {
                    var n_newlines = 0;

                    if (parser_pos >= input.Length)
                    {
                        return new string[] { "", "TK_EOF" };
                    }

                    string c = input[parser_pos].ToString();
                    parser_pos++;

                    while (whitespace.Contains(c))
                    {
                        if (parser_pos >= input.Length)
                        {
                            return new string[] { "", "TK_EOF" };
                        }

                        if (c == "\n")
                            n_newlines++;

                        c = input[parser_pos].ToString();
                        parser_pos++;
                    }

                    var wanted_newline = false;

                    if (opt_preserve_newlines)
                    {
                        if (n_newlines > 1)
                        {
                            for (var i = 0; i < 2; i++)
                            {
                                Print_newline(i == 0);
                            }
                        }
                        wanted_newline = (n_newlines == 1);

                    }

                    if (wordchar.Contains(c))
                    {
                        if (parser_pos < input.Length)
                        {
                            while (wordchar.Contains(input[parser_pos]))
                            {
                                c += input[parser_pos];
                                parser_pos++;
                                if (parser_pos == input.Length)
                                    break;
                            }
                        }


                        if ((parser_pos != input.Length) && (System.Text.RegularExpressions.Regex.IsMatch(c, "^[0-9]+[Ee]$")) && ((input[parser_pos] == '-') || (input[parser_pos] == '+')))
                        {
                            var sign = input[parser_pos];
                            parser_pos++;

                            var t = Get_next_token(ref parser_pos);
                            c += sign + t[0];
                            return new string[] { c, "TK_WORD" };
                        }

                        if (c == "in")
                        {
                            return new string[] { c, "TK_OPERATOR" };
                        }

                        if (wanted_newline && last_type != "TK_OPERATOR" && !if_line_flag)
                        {
                            Print_newline(null);
                        }
                        return new string[] { c, "TK_WORD" };

                    }

                    if ((c == "(") || (c == "["))
                        return new string[] { c, "TK_START_EXPR" };

                    if (c == ")" || c == "]")
                    {
                        return new string[] { c, "TK_END_EXPR" };
                    }

                    if (c == "{")
                    {
                        return new string[] { c, "TK_START_BLOCK" };
                    }

                    if (c == "}")
                    {
                        return new string[] { c, "TK_END_BLOCK" };
                    }

                    if (c == ";")
                    {
                        return new string[] { c, "TK_SEMICOLON" };
                    }

                    if (c == "/")
                    {
                        var comment = "";
                        if (input[parser_pos] == '*')
                        {
                            parser_pos++;
                            if (parser_pos < input.Length)
                            {
                                while (!((input[parser_pos] == '*') && (input[parser_pos + 1] > '\0') && (input[parser_pos + 1] == '/') && (parser_pos < input.Length)))
                                {
                                    comment += input[parser_pos];
                                    parser_pos++;
                                    if (parser_pos >= input.Length)
                                    {
                                        break;
                                    }
                                }
                            }

                            parser_pos += 2;
                            return new string[] { "/*" + comment + "*/", "TK_BLOCK_COMMENT" };
                        }

                        if (input[parser_pos] == '/')
                        {
                            comment = c;
                            while ((input[parser_pos] != '\x0d') && (input[parser_pos] != '\x0a'))
                            {
                                comment += input[parser_pos];
                                parser_pos++;
                                if (parser_pos >= input.Length)
                                {
                                    break;
                                }
                            }

                            parser_pos++;
                            if (wanted_newline)
                            {
                                Print_newline(null);
                            }
                            return new string[] { comment, "TK_COMMENT" };

                        }
                    }

                    if ((c == "'") || (c == "\"") || ((c == "/")
                            && ((last_type == "TK_WORD" && last_text == "return") || ((last_type == "TK_START_EXPR") || (last_type == "TK_START_BLOCK") || (last_type == "TK_END_BLOCK")
                                    || (last_type == "TK_OPERATOR") || (last_type == "TK_EOF") || (last_type == "TK_SEMICOLON"))))
                        )
                    {
                        var sep = c;
                        var esc = false;
                        var resulting_string = c;

                        if (parser_pos < input.Length)
                        {
                            if (sep == "/")
                            {
                                var in_char_class = false;
                                while ((esc) || (in_char_class) || (input[parser_pos].ToString() != sep))
                                {
                                    resulting_string += input[parser_pos];
                                    if (!esc)
                                    {
                                        esc = input[parser_pos] == '\\';
                                        if (input[parser_pos] == '[')
                                        {
                                            in_char_class = true;
                                        }
                                        else if (input[parser_pos] == ']')
                                        {
                                            in_char_class = false;
                                        }
                                    }
                                    else
                                    {
                                        esc = false;
                                    }
                                    parser_pos++;
                                    if (parser_pos >= input.Length)
                                    {
                                        return new string[] { resulting_string, "TK_STRING" };
                                    }
                                }
                            }
                            else
                            {
                                while ((esc) || (input[parser_pos].ToString() != sep))
                                {
                                    resulting_string += input[parser_pos];
                                    if (!esc)
                                    {
                                        esc = input[parser_pos] == '\\';
                                    }
                                    else
                                    {
                                        esc = false;
                                    }
                                    parser_pos++;
                                    if (parser_pos >= input.Length)
                                    {
                                        return new string[] { resulting_string, "TK_STRING" };
                                    }
                                }
                            }
                        }

                        parser_pos += 1;

                        resulting_string += sep;

                        if (sep == "/")
                        {
                            // regexps may have modifiers /regexp/MOD , so fetch those, too
                            while ((parser_pos < input.Length) && (wordchar.Contains(input[parser_pos])))
                            {
                                resulting_string += input[parser_pos];
                                parser_pos += 1;
                            }
                        }
                        return new string[] { resulting_string, "TK_STRING" };


                    }

                    if (c == "#")
                    {
                        var sharp = "#";
                        if ((parser_pos < input.Length) && (digits.Contains(input[parser_pos])))
                        {
                            do
                            {
                                c = input[parser_pos].ToString();
                                sharp += c;
                                parser_pos += 1;
                            } while ((parser_pos < input.Length) && (c != "#") && (c != "="));
                            if (c == "#")
                            {
                                return new string[] { sharp, "TK_WORD" }; ;
                            }
                            else
                            {
                                return new string[] { sharp, "TK_OPERATOR" }; ;
                            }
                        }
                    }


                    if ((c == "<") && (input.Substring(parser_pos - 1, 3) == "<!--"))
                    {
                        parser_pos += 3;
                        return new string[] { "<!--", "TK_COMMENT" }; ;
                    }

                    if ((c == "-") && (input.Substring(parser_pos - 1, 2) == "-->"))
                    {
                        parser_pos += 2;
                        if (wanted_newline)
                        {
                            Print_newline(null);
                        }
                        return new string[] { "-->", "TK_COMMENT" };
                    }

                    if (punct.Contains(c))
                    {
                        while ((parser_pos < input.Length) && (punct.Contains(c + input[parser_pos])))
                        {
                            c += input[parser_pos];
                            parser_pos += 1;
                            if (parser_pos >= input.Length)
                            {
                                break;
                            }
                        }

                        return new string[] { c, "TK_OPERATOR" };
                    }

                    return new string[] { c, "TK_UNKNOWN" };


                }
                public static string FormatJS(string js_source_text, char indent_char, int indent_size, int indent_level)
                {
                    bool add_script_tags = false;
                    opt_indent_size = indent_size;
                    opt_indent_char = indent_char;
                    Opt_indent_level = indent_level;
                    opt_preserve_newlines = true;
                    output = new StringBuilder();
                    modes = new Stack<string>();



                    indent_string = "";

                    while (opt_indent_size > 0)
                    {
                        indent_string += opt_indent_char;
                        opt_indent_size -= 1;
                    }

                    input = js_source_text.Replace("<script type=\"text/javascript\">", "").Replace("</script>", "");
                    if (input.Length != js_source_text.Length)
                    {
                        output.AppendLine("<script type=\"text/javascript\">");
                        add_script_tags = true;
                    }

                    last_word = ""; // last 'TK_WORD' passed
                    last_type = "TK_START_EXPR"; // last token type
                    last_text = ""; // last token text

                    do_block_just_closed = false;
                    var_line = false;         // currently drawing var .... ;
                    var_line_tainted = false; // false: var a = 5; true: var a = 5, b = 6

                    whitespace = "\n\r\t ";
                    wordchar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_$";
                    digits = "0123456789";

                    // <!-- is a special case (ok, it's a minor hack actually)
                    punct = "+ - * / % & ++ -- = += -= *= /= %= == === != !== > < >= <= >> << >>> >>>= >>= <<= && &= | || ! !! , : ? ^ ^= |= ::".Split(' ');

                    // words which should always start on new line.
                    line_starters = "continue,try,throw,return,var,if,switch,case,default,for,while,break,function".Split(',');

                    // states showing if we are currently in expression (i.e. "if" case) - 'EXPRESSION', or in usual block (like, procedure), 'BLOCK'.
                    // some formatting depends on that.
                    current_mode = "BLOCK";
                    modes.Push(current_mode);

                    parser_pos = 0;
                    in_case = false;

                    while (true)
                    {
                        var t = Get_next_token(ref parser_pos);
                        token_text = t[0];
                        token_type = t[1];
                        if (token_type == "TK_EOF")
                        {
                            break;
                        }

                        switch (token_type)
                        {

                            case "TK_START_EXPR":
                                var_line = false;
                                Set_mode("EXPRESSION");
                                if ((last_text == ";") || (last_type == "TK_START_BLOCK"))
                                {
                                    Print_newline(null);
                                }
                                else if ((last_type == "TK_END_EXPR") || (last_type == "TK_START_EXPR"))
                                {
                                    // do nothing on (( and )( and ][ and ]( ..
                                }
                                else if ((last_type != "TK_WORD") && (last_type != "TK_OPERATOR"))
                                {
                                    Print_space();
                                }
                                else if (line_starters.Contains(last_word))
                                {
                                    Print_space();
                                }
                                Print_token();
                                break;

                            case "TK_END_EXPR":
                                Print_token();
                                Restore_mode();
                                break;

                            case "TK_START_BLOCK":

                                if (last_word == "do")
                                {
                                    Set_mode("DO_BLOCK");
                                }
                                else
                                {
                                    Set_mode("BLOCK");
                                }
                                if ((last_type != "TK_OPERATOR") && (last_type != "TK_START_EXPR"))
                                {
                                    if (last_type == "TK_START_BLOCK")
                                    {
                                        Print_newline(null);
                                    }
                                    else
                                    {
                                        Print_space();
                                    }
                                }
                                Print_token();
                                Indent();
                                break;

                            case "TK_END_BLOCK":
                                if (last_type == "TK_START_BLOCK")
                                {
                                    // nothing
                                    Trim_output();
                                    Unindent();
                                }
                                else
                                {
                                    Unindent();
                                    Print_newline(null);
                                }
                                Print_token();
                                Restore_mode();
                                break;

                            case "TK_WORD":

                                if (do_block_just_closed)
                                {
                                    // do {} ## while ()
                                    Print_space();
                                    Print_token();
                                    Print_space();
                                    do_block_just_closed = false;
                                    break;
                                }

                                if ((token_text == "case") || (token_text == "default"))
                                {
                                    if (last_text == ":")
                                    {
                                        // switch cases following one another
                                        Remove_indent();
                                    }
                                    else
                                    {
                                        // case statement starts in the same line where switch
                                        Unindent();
                                        Print_newline(null);
                                        Indent();
                                    }
                                    Print_token();
                                    in_case = true;
                                    break;
                                }

                                prefix = "NONE";

                                if (last_type == "TK_END_BLOCK")
                                {
                                    if (!(new string[] { "else", "catch", "finally" }).Contains(token_text.ToLower()))
                                    {
                                        prefix = "NEWLINE";
                                    }
                                    else
                                    {
                                        prefix = "SPACE";
                                        Print_space();
                                    }
                                }
                                else if ((last_type == "TK_SEMICOLON") && ((current_mode == "BLOCK") || (current_mode == "DO_BLOCK")))
                                {
                                    prefix = "NEWLINE";
                                }
                                else if ((last_type == "TK_SEMICOLON") && (current_mode == "EXPRESSION"))
                                {
                                    prefix = "SPACE";
                                }
                                else if (last_type == "TK_STRING")
                                {
                                    prefix = "NEWLINE";
                                }
                                else if (last_type == "TK_WORD")
                                {
                                    prefix = "SPACE";
                                }
                                else if (last_type == "TK_START_BLOCK")
                                {
                                    prefix = "NEWLINE";
                                }
                                else if (last_type == "TK_END_EXPR")
                                {
                                    Print_space();
                                    prefix = "NEWLINE";
                                }

                                if ((last_type != "TK_END_BLOCK") && ((new string[] { "else", "catch", "finally" }).Contains(token_text.ToLower())))
                                {
                                    Print_newline(null);
                                }
                                else if ((line_starters.Contains(token_text)) || (prefix == "NEWLINE"))
                                {
                                    if (last_text == "else")
                                    {
                                        // no need to force newline on else break
                                        Print_space();
                                    }
                                    else if (((last_type == "TK_START_EXPR") || (last_text == "=") || (last_text == ",")) && (token_text == "function"))
                                    {
                                        // no need to force newline on "function": (function
                                        // DONOTHING
                                    }
                                    else if ((last_type == "TK_WORD") && ((last_text == "return") || (last_text == "throw")))
                                    {
                                        // no newline between "return nnn"
                                        Print_space();
                                    }
                                    else if (last_type != "TK_END_EXPR")
                                    {
                                        if (((last_type != "TK_START_EXPR") || (token_text != "var")) && (last_text != ":"))
                                        {
                                            // no need to force newline on "var": for (var x = 0...)
                                            if ((token_text == "if") && (last_type == "TK_WORD") && (last_word == "else"))
                                            {
                                                // no newline for } else if {
                                                Print_space();
                                            }
                                            else
                                            {
                                                Print_newline(null);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if ((line_starters.Contains(token_text)) && (last_text != ")"))
                                        {
                                            Print_newline(null);
                                        }
                                    }
                                }
                                else if (prefix == "SPACE")
                                {
                                    Print_space();
                                }
                                Print_token();
                                last_word = token_text;

                                if (token_text == "var")
                                {
                                    var_line = true;
                                    var_line_tainted = false;
                                }

                                if (token_text == "if" || token_text == "else")
                                {
                                    if_line_flag = true;
                                }

                                break;

                            case "TK_SEMICOLON":

                                Print_token();
                                var_line = false;
                                break;

                            case "TK_STRING":

                                if ((last_type == "TK_START_BLOCK") || (last_type == "TK_END_BLOCK") || (last_type == "TK_SEMICOLON"))
                                {
                                    Print_newline(null);
                                }
                                else if (last_type == "TK_WORD")
                                {
                                    Print_space();
                                }
                                Print_token();
                                break;

                            case "TK_OPERATOR":

                                var start_delim = true;
                                var end_delim = true;
                                if (var_line && (token_text != ","))
                                {
                                    var_line_tainted = true;
                                    if (token_text == ":")
                                    {
                                        var_line = false;
                                    }
                                }
                                if (var_line && (token_text == ",") && (current_mode == "EXPRESSION"))
                                {
                                    // do not break on comma, for(var a = 1, b = 2)
                                    var_line_tainted = false;
                                }

                                if (token_text == ":" && in_case)
                                {
                                    Print_token(); // colon really asks for separate treatment
                                    Print_newline(null);
                                    in_case = false;
                                    break;
                                }

                                if (token_text == "::")
                                {
                                    // no spaces around exotic namespacing syntax operator
                                    Print_token();
                                    break;
                                }

                                if (token_text == ",")
                                {
                                    if (var_line)
                                    {
                                        if (var_line_tainted)
                                        {
                                            Print_token();
                                            Print_newline(null);
                                            var_line_tainted = false;
                                        }
                                        else
                                        {
                                            Print_token();
                                            Print_space();
                                        }
                                    }
                                    else if (last_type == "TK_END_BLOCK")
                                    {
                                        Print_token();
                                        Print_newline(null);
                                    }
                                    else
                                    {
                                        if (current_mode == "BLOCK")
                                        {
                                            Print_token();
                                            Print_newline(null);
                                        }
                                        else
                                        {
                                            // EXPR od DO_BLOCK
                                            Print_token();
                                            Print_space();
                                        }
                                    }
                                    break;
                                }
                                else if ((token_text == "--") || (token_text == "++"))
                                { // unary operators special case
                                    if (last_text == ";")
                                    {
                                        if (current_mode == "BLOCK")
                                        {
                                            // { foo; --i }
                                            Print_newline(null);
                                            start_delim = true;
                                            end_delim = false;
                                        }
                                        else
                                        {
                                            // space for (;; ++i)
                                            start_delim = true;
                                            end_delim = false;
                                        }
                                    }
                                    else
                                    {
                                        if (last_text == "{")
                                        {
                                            // {--i
                                            Print_newline(null);
                                        }
                                        start_delim = false;
                                        end_delim = false;
                                    }
                                }
                                else if (((token_text == "!") || (token_text == "+") || (token_text == "-")) && ((last_text == "return") || (last_text == "case")))
                                {
                                    start_delim = true;
                                    end_delim = false;
                                }
                                else if (((token_text == "!") || (token_text == "+") || (token_text == "-")) && (last_type == "TK_START_EXPR"))
                                {
                                    // special case handling: if (!a)
                                    start_delim = false;
                                    end_delim = false;
                                }
                                else if (last_type == "TK_OPERATOR")
                                {
                                    start_delim = false;
                                    end_delim = false;
                                }
                                else if (last_type == "TK_END_EXPR")
                                {
                                    start_delim = true;
                                    end_delim = true;
                                }
                                else if (token_text == ".")
                                {
                                    // decimal digits or object.property
                                    start_delim = false;
                                    end_delim = false;

                                }
                                else if (token_text == ":")
                                {
                                    if (Is_ternary_op())
                                    {
                                        start_delim = true;
                                    }
                                    else
                                    {
                                        start_delim = false;
                                    }
                                }
                                if (start_delim)
                                {
                                    Print_space();
                                }

                                Print_token();

                                if (end_delim)
                                {
                                    Print_space();
                                }
                                break;

                            case "TK_BLOCK_COMMENT":

                                Print_newline(null);
                                Print_token();
                                Print_newline(null);
                                break;

                            case "TK_COMMENT":

                                // print_newline();
                                Print_space();
                                Print_token();
                                Print_newline(null);
                                break;

                            case "TK_UNKNOWN":
                                Print_token();
                                break;
                        }

                        last_type = token_type;
                        last_text = token_text;
                    }
                    if (add_script_tags)
                    {
                        output.AppendLine().AppendLine("</script>");
                    }
                    return output.ToString();
                }
            }
        }

        public static class ComputerRegistry
        {
            public static void DeleteKeyTree(Microsoft.Win32.RegistryKey key)
            {
                GetRootKey(key).DeleteSubKeyTree(GetKeyName(key));
            }
            public static void DeleteKey(Microsoft.Win32.RegistryKey key)
            {
                GetRootKey(key).DeleteSubKey(GetKeyName(key));
            }
            public static void DeleteKeyTree(string keyLocation)
            {
                DeleteKeyTree(OpenKey(keyLocation));
            }
            public static void DeleteKey(string keyLocation)
            {
                DeleteKey(OpenKey(keyLocation));
            }
            public static string GetKeyName(Microsoft.Win32.RegistryKey key)
            {
                return key.Name.Substring(key.Name.LastIndexOf("\\") + 1);
            }
            public static Microsoft.Win32.RegistryKey GetRootKey(Microsoft.Win32.RegistryKey key)
            {
                var keyName = key.Name;
                return OpenKey(keyName.Substring(0, keyName.LastIndexOf("\\")));
            }
            public static Microsoft.Win32.RegistryKey OpenKey(Microsoft.Win32.RegistryHive HKey, string keyLocation)
            {
                return ComputerRegistry.OpenBaseKey(HKey).OpenSubKey(keyLocation);
            }
            public static Microsoft.Win32.RegistryKey OpenKey(string KeyLocation)
            {
                var rootkey = KeyLocation.Substring(0, KeyLocation.IndexOf("\\"));
                var otherContent = KeyLocation.Substring(KeyLocation.IndexOf("\\") + 1);
                Microsoft.Win32.RegistryHive hive;
                switch (rootkey)
                {
                    case "HKEY_CLASSES_ROOT": hive = Microsoft.Win32.RegistryHive.ClassesRoot; break;
                    case "HKEY_CURRENT_CONFIG": hive = Microsoft.Win32.RegistryHive.CurrentConfig; break;
                    case "HKEY_CURRENT_USER": hive = Microsoft.Win32.RegistryHive.CurrentUser; break;
                    case "HKEY_LOCAL_MACHINE": hive = Microsoft.Win32.RegistryHive.LocalMachine; break;
                    case "HKEY_USERS": hive = Microsoft.Win32.RegistryHive.Users; break;
                    case "HKEY_DYN_DATA": hive = Microsoft.Win32.RegistryHive.DynData; break;
                    case "HKEY_PERFORMANCE_DATA": hive = Microsoft.Win32.RegistryHive.PerformanceData; break;
                    case "HKCR": hive = Microsoft.Win32.RegistryHive.ClassesRoot; break;
                    case "HKCC": hive = Microsoft.Win32.RegistryHive.CurrentConfig; break;
                    case "HKCU": hive = Microsoft.Win32.RegistryHive.CurrentUser; break;
                    case "HKLM": hive = Microsoft.Win32.RegistryHive.LocalMachine; break;
                    case "HKU": hive = Microsoft.Win32.RegistryHive.Users; break;
                    case "HKDD": hive = Microsoft.Win32.RegistryHive.DynData; break;
                    case "HKPD": hive = Microsoft.Win32.RegistryHive.PerformanceData; break;
                    default:
                        return null;
                }
                return ComputerRegistry.OpenBaseKey(hive).OpenSubKey(otherContent);
            }
            public static Microsoft.Win32.RegistryKey OpenBaseKey(Microsoft.Win32.RegistryHive HKey)
            {
                return Microsoft.Win32.RegistryKey.OpenBaseKey(HKey, Microsoft.Win32.RegistryView.Default);
            }
            public static string[] GetKeys(Microsoft.Win32.RegistryKey key)
            {
                return key.GetSubKeyNames();
            }
            public static string[] GetValueNames(Microsoft.Win32.RegistryHive HKey, string keyName)
            {
                return Microsoft.Win32.RegistryKey.OpenBaseKey(HKey, Microsoft.Win32.RegistryView.Default).OpenSubKey(keyName).GetValueNames();
            }
            public static Microsoft.Win32.RegistryKey[] GetAllKeys(Microsoft.Win32.RegistryKey key)
            {
                List<Microsoft.Win32.RegistryKey> keys = new List<Microsoft.Win32.RegistryKey>();
                foreach (string val in GetKeys(key))
                {
                    keys.Add(key.OpenSubKey(val));
                }
                return keys.ToArray() as Microsoft.Win32.RegistryKey[];
            }
            public static Microsoft.Win32.RegistryKey OpenKey(Microsoft.Win32.RegistryKey baseKey, string Path)
            {
                return baseKey.OpenSubKey(Path);
            }
        }
        public class DataManager
        {
            public DataManager()
            {

            }
            public DataManager(object data)
            {
                Data = data;
            }
            public DataManager(object data, string file)
            {
                Data = data; File = file;
            }
            public DataManager(string file)
            {
                File = file;
            }
            public object Data { get; set; }
            public string File { get; set; }
            public void SaveDataAsXML()
            {
                SaveObjectToXML(Data.GetType(), Data, File);
            }
            public object LoadDataAsXML()
            {
                Data = LoadObjectFromXML(Data.GetType(), File);
                return Data;
            }
            public void SaveDataAsBinary()
            {
                SaveObjectToBinary(Data, File);
            }
            public object LoadDataAsBinary()
            {
                Data = LoadObjectFromBinary(File);
                return Data;
            }
            public static void SaveObjectToBinary(object data, string file)
            {
                System.IO.Stream stream = System.IO.File.Open(file, System.IO.FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, data);
                stream.Close();
            }
            public static object LoadObjectFromBinary(string file)
            {
                System.IO.Stream stream = System.IO.File.Open(file, System.IO.FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data;
                try { data = bf.Deserialize(stream); } catch (Exception ex) { stream.Close(); throw ex; }
                return data;
            }
            public static void SaveObjectToXML(Type type, object data, string file)
            {
                System.IO.TextWriter tw = new System.IO.StreamWriter(file);
                XmlSerializer serializer = new XmlSerializer(type);
                try { serializer.Serialize(tw, data); }
                catch (Exception ex)
                {
                    tw.Close();
                    throw ex;
                }
                tw.Close();
            }
            public static object LoadObjectFromXML(Type type, string file)
            {
                System.IO.TextReader tr = new System.IO.StreamReader(file);
                XmlSerializer serializer = new XmlSerializer(type);
                object data;
                try { data = serializer.Deserialize(tr); }
                catch (Exception ex)
                {
                    tr.Close();
                    throw ex;
                }
                return data;
            }
        }
        public static class Media
        {
            public static class CreateSoundPlayer
            {
                public static System.Media.SoundPlayer FromEmbeddedResource(System.Reflection.Assembly assembly, string ResourcePath)
                {
                    var stream = assembly.GetManifestResourceStream(ResourcePath);
                    return CreateSoundPlayer.FromStream(stream);
                }
                public static System.Media.SoundPlayer FromEmbeddedResource(string ResourcePath)
                {
                    var stream = System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream(ResourcePath);
                    return CreateSoundPlayer.FromStream(stream);
                }
                public static System.Media.SoundPlayer FromStream(System.IO.Stream stream)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(stream);
                    return player;
                }
                public static System.Media.SoundPlayer FromFile(string soundFile)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFile);
                    return player;
                }
            }
            public static class PlaySound
            {
                public static void FromEmbeddedResource(string assemblyPath, string ResourcePath)
                {
                    var stream = Resource.LoadAssemblyFromFile(assemblyPath).GetManifestResourceStream(ResourcePath);
                    PlaySound.FromStream(stream);
                }
                public static void FromEmbeddedResource(System.Reflection.Assembly assembly, string ResourcePath)
                {
                    var stream = assembly.GetManifestResourceStream(ResourcePath);
                    PlaySound.FromStream(stream);
                }
                public static void FromEmbeddedResource(string ResourcePath)
                {
                    var stream = System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream(ResourcePath);
                    PlaySound.FromStream(stream);
                }
                public static void FromStream(System.IO.Stream stream)
                {
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer(stream);
                    sound.Play();
                }
                public static void FromFile(string soundFile)
                {
                    System.Media.SoundPlayer sound = new System.Media.SoundPlayer(soundFile);
                    sound.Play();
                }
            }
        }
        public static class Resource
        {
            public static string[] ListResources() => Assembly.GetEntryAssembly().GetManifestResourceNames();
            public static string[] ListResources(Assembly assembly) => assembly.GetManifestResourceNames();
            public static string[] ListResources(string @namespace, string directory)
            {
                List<string> s = new List<string>();
                foreach (var res in ListResources())
                    if (res.Substring(0, (@namespace + "." + directory).Length) == @namespace + "." + directory)
                        s.Add(res);
                return s.ToArray();
            }
            public static string[] ListResources(Assembly assembly, string @namespace, string directory)
            {
                List<string> s = new List<string>();
                foreach (var res in ListResources(assembly))
                    if (res.Substring(0, (@namespace + "." + directory).Length) == @namespace + "." + directory)
                        s.Add(res);
                return s.ToArray();
            }
            public static void RunFromEmbeddedResource(string ResourcePath)
            {
                Export(ResourcePath, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\" + ResourcePath);
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\" + ResourcePath);
            }
            public static void RunFromEmbeddedResource(System.Reflection.Assembly assembly, string ResourcePath)
            {
                Export(assembly, ResourcePath, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\" + ResourcePath);
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\" + ResourcePath);
            }
            public static void RunFromEmbeddedResource(string assemblyPath, string ResourcePath)
            {

                Export(assemblyPath, ResourcePath, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\" + ResourcePath);
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\" + ResourcePath);
            }
            public static System.Reflection.Assembly LoadAssemblyFromEmbeddedResource(string FilePath, string ResourcePath)
            {
                return LoadAssemblyFromEmbeddedResource(LoadAssemblyFromFile(FilePath), ResourcePath);
            }
            public static System.Reflection.Assembly LoadAssemblyFromEmbeddedResource(System.Reflection.Assembly assembly, string ResourcePath)
            {
                var str = assembly.GetManifestResourceStream(ResourcePath);
                byte[] assemblyData = new byte[str.Length];
                str.Read(assemblyData, 0, assemblyData.Length);
                str.Close();
                return System.Reflection.Assembly.Load(assemblyData);
            }
            public static System.Reflection.Assembly LoadAssemblyFromEmbeddedResource(string ResourcePath)
            {
                var str = System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream(ResourcePath);
                byte[] assemblyData = new byte[str.Length];
                str.Read(assemblyData, 0, assemblyData.Length);
                str.Close();
                return System.Reflection.Assembly.Load(assemblyData);
            }
            public static System.Reflection.Assembly LoadAssemblyFromFile(string Path)
            {
                System.IO.FileStream str = new System.IO.FileStream(Path, System.IO.FileMode.Open);
                byte[] assemblyData = new byte[str.Length];
                str.Read(assemblyData, 0, assemblyData.Length);
                var ass = System.Reflection.Assembly.Load(assemblyData);
                str.Close();
                return ass;
            }
            public static string GetEmbeddedTextFileContent(string FilePath, string ResourcePath)
            {
                return GetEmbeddedTextFileContent(LoadAssemblyFromFile(FilePath), ResourcePath);
            }
            public static string GetEmbeddedTextFileContent(System.Reflection.Assembly assembly, string ResourcePath)
            {
                System.IO.Stream ass = assembly.GetManifestResourceStream(ResourcePath);
                System.IO.BinaryReader r = new System.IO.BinaryReader(ass);
                int pos = 0;
                string FileText = null;
                r.BaseStream.Position = 0;
                byte[] bts = r.ReadBytes(3);
                string chkBts = null;
                foreach (byte bt in bts)
                {
                    chkBts += bt.ToString("X2");
                }
                if (chkBts == "EFBBBF")
                {
                    pos = 3;
                }
                while (pos < r.BaseStream.Length)
                {
                    r.BaseStream.Position = pos;
                    string posText = Converter.HexadecimalToText(r.ReadByte().ToString("X2"));
                    FileText += posText;
                    pos++;
                }
                r.Close();
                ass.Close();
                return FileText;
            }
            public static string GetEmbeddedTextFileContent(string ResourcePath)
            {
                System.IO.Stream ass = System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream(ResourcePath);
                System.IO.BinaryReader r = new System.IO.BinaryReader(ass);
                int pos = 0;
                string FileText = null;
                r.BaseStream.Position = 0;
                byte[] bts = r.ReadBytes(3);
                string chkBts = null;
                foreach (byte bt in bts)
                {
                    chkBts += bt.ToString("X2");
                }
                if (chkBts == "EFBBBF")
                {
                    pos = 3;
                }
                while (pos < r.BaseStream.Length)
                {
                    r.BaseStream.Position = pos;
                    string posText = Converter.HexadecimalToText(r.ReadByte().ToString("X2"));
                    FileText += posText;
                    pos++;
                }
                r.Close();
                ass.Close();
                return FileText;
            }
            public static Image GetEmbeddedImage(string FilePath, string ResourcePath)
            {
                return GetEmbeddedImage(LoadAssemblyFromFile(FilePath), ResourcePath);
            }
            public static Image GetEmbeddedImage(System.Reflection.Assembly assembly, string ResourcePath)
            {
                System.IO.Stream s = assembly.GetManifestResourceStream(ResourcePath);
                var st = Image.FromStream(s);
                s.Close();
                return st;
            }
            public static Image GetEmbeddedImage(string ResourcePath)
            {
                System.Reflection.Assembly assembly = System.Reflection.Assembly.GetEntryAssembly();
                using (System.IO.Stream s = assembly.GetManifestResourceStream(ResourcePath))
                    return Image.FromStream(s);
            }
            public static void Export(string FilePath, string ResourcePath, string OutFile)
            {
                Export(LoadAssemblyFromFile(FilePath), ResourcePath, OutFile);
            }
            public static void Export(System.Reflection.Assembly assembly, string ResourcePath, string OutFile)
            {
                using (System.IO.Stream s = assembly.GetManifestResourceStream(ResourcePath))
                using (System.IO.BinaryReader r = new System.IO.BinaryReader(s))
                using (System.IO.FileStream fs = new System.IO.FileStream(OutFile, System.IO.FileMode.OpenOrCreate))
                using (System.IO.BinaryWriter w = new System.IO.BinaryWriter(fs))
                    w.Write(r.ReadBytes((int)s.Length));
            }
            /// <summary>
            /// Exports a embedded resource from your application (resource must have the compile propertie set to Embedded resource)
            /// </summary>
            /// <param name="ResourcePath">The embedded resource path such as 'NamespaceName.Folder1.file.exe' or 'NamespaceName.file.pdf'</param>
            /// <param name="OutFile">The place to save the file</param>
            public static void Export(string ResourcePath, string OutFile)
            {
                Assembly assembly = Assembly.GetEntryAssembly();
                using (System.IO.Stream s = assembly.GetManifestResourceStream(ResourcePath))
                using (System.IO.BinaryReader r = new System.IO.BinaryReader(s))
                using (System.IO.FileStream fs = new System.IO.FileStream(OutFile, System.IO.FileMode.OpenOrCreate))
                using (System.IO.BinaryWriter w = new System.IO.BinaryWriter(fs))
                    w.Write(r.ReadBytes((int)s.Length));
            }
        }
        public class DataGridViewImporterExporter
        {
            private readonly char separator = 'a';
            public DataGridViewImporterExporter(char columnSeparatorChar)
            {
                separator = columnSeparatorChar;
            }
            public void ImportData(string file, DataGridView dataGridView, params string[] ColumnsTexts)
            {
                dataGridView.Rows.Clear();
                dataGridView.Columns.Clear();
                foreach (string columnText in ColumnsTexts)
                {
                    dataGridView.Columns.Add(columnText, columnText);
                }
                var str = new System.IO.StreamReader(file);
                string content = str.ReadToEnd();
                str.Close();
                foreach (string fileLine in content.Split('\n'))
                {
                    string line = fileLine.Replace("\r", "");
                    if (line != "")
                    {
                        if (line.Split(separator).Count() <= ColumnsTexts.Count())
                        {
                            dataGridView.Rows.Add(line.Split(separator));
                        }
                    }
                }
            }
            private void AppendFile(string File, string Text)
            {
                var str = new System.IO.StreamReader(File);
                var content = str.ReadToEnd() + Text;
                str.Close();
                var wrt = new System.IO.StreamWriter(File);
                wrt.Write(content);
                wrt.Close();
            }
            private void RemoveLastChar(string file)
            {
                var str = new System.IO.StreamReader(file);
                string content = str.ReadToEnd();
                str.Close();
                var wrt = new System.IO.StreamWriter(file);
                content = content.Substring(0, content.Length - 1);
                wrt.Write(content);
                wrt.Close();
            }
            public void ExportData(DataGridView dataGridView, string file)
            {
                if (System.IO.File.Exists(file)) { System.IO.File.Delete(file); }
                var fl = new System.IO.FileStream(file, System.IO.FileMode.Create);
                fl.Close();
                int curRow = 0;
                int lastRow = dataGridView.Rows.Count - 1;
                foreach (DataGridViewRow Row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell Cell in Row.Cells)
                    {
                        if (curRow == lastRow)
                        {
                            string value = null;
                            try { value = Cell.Value.ToString(); } catch (NullReferenceException) { return; }
                            if (value == null) { return; }
                            AppendFile(file, value + separator.ToString());
                        }
                        else
                        {
                            string value = "";
                            try { value = Cell.Value.ToString(); } catch (NullReferenceException) { value = ""; }
                            if (value == null) { value = ""; }
                            AppendFile(file, value + separator.ToString());
                        }
                    }
                    RemoveLastChar(file);
                    AppendFile(file, "\n");
                    curRow++;
                }
                var str = new System.IO.StreamReader(file);
                var content = str.ReadToEnd();
                str.Close();
                var newContent = "";
                foreach (string line in content.Split('\n'))
                {
                    if (line != "")
                    {
                        if (line.Substring(line.Length - 1) == separator.ToString())
                        {
                            newContent = line.Substring(0, line.Length - 1);
                        }
                        else
                        {
                            newContent = line;
                        }
                    }
                }
                var wrt = new System.IO.StreamWriter(file);
                wrt.Write(newContent);
                wrt.Close();
            }
        }
        public class ComboBoxDataImporter
        {
            public ComboBoxDataImporter(string File, int ParamsAmmount, char Separator)
            {
                this.File = File;
                //Creating = true;
                separtor = Separator;
                commands = new string[CommandCount()];
                parameters = new Array[ParamsAmmount];
                PrmsAmmount = ParamsAmmount;
                for (int i = 0; i <= parameters.Count() - 1; i++)
                {
                    parameters[i] = new string[CommandCount()];
                }
                GetCommands();
                GetAllParams();
                //Creating = false;
            }
            public void FillComboBox(string[] DisplayParameterArray, ComboBox comboBox)
            {
                foreach (string displayValue in DisplayParameterArray)
                {
                    comboBox.Items.Add(displayValue);
                }
            }

            private readonly char separtor = ',';
            public string File { get; set; }

            public int PrmsAmmount1 => PrmsAmmount;

            private readonly int PrmsAmmount = 0;
            private readonly Array[] parameters = null;
            public string[] Parameter(int ParameterIndex)
            {
                return GetParametersStringArray(ParameterIndex);
            }
            /// <summary>
            /// Reuturns all commands/lines of the file
            /// </summary>
            /// <returns></returns>
            public string[] GetAllCommands()
            {
                return commands;
            }
            /// <summary>
            /// Reuturns the count of all commands/lines
            /// </summary>
            /// <returns></returns>
            public int CommandCount()
            {
                while (true)
                {
                    int i = 0;
                    var str = new System.IO.StreamReader(File);
                    string fileContent = str.ReadToEnd();
                    str.Close();
                    foreach (string cmd in fileContent.Split('\n'))
                    {
                        if (cmd != "" && cmd != null)
                        {
                            i++;
                        }
                    }
                    return i;
                }
            }
            private void GetAllParams()
            {
                int i = 0;
                // Pra cada linha no arquivo
                while (i < commands.Count())
                {
                    int curArray = 0; //Current Array indexs
                                      //Pra cada array
                    foreach (string[] arr in parameters)
                    {
                        string value = commands[i].Split(separtor)[curArray];
                        if (value.Substring(0, 1) == " ") { value = value.Substring(1); }
                        ChangeParametersArrayValue(curArray, i, value);
                        curArray++;
                    }

                    i++;
                }
            }
            //private bool Creating = false;
            private readonly string[] commands = null;
            public void ChangeParametersArrayValue(int ParameterIndex, int ParameterCommandGroupIndex, string Value)
            {
                int i = 0;
                foreach (string[] arr in parameters)
                {
                    if (ParameterIndex == i)
                    {
                        arr[ParameterCommandGroupIndex] = Value;
                        parameters[i] = arr;
                        return;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            private string[] GetParametersStringArray(int ArrayIndex)
            {
                int i = 0;
                foreach (string[] arr in parameters)
                {
                    if (i == ArrayIndex)
                    {
                        i = -1;
                        return arr;
                    }
                    else
                    {
                        i++;
                    }
                }
                return null;
            }
            private string[] GetCommands()
            {
                int i = 0;
                var str = new System.IO.StreamReader(File);
                string fileContent = str.ReadToEnd();
                str.Close();
                foreach (string cmd in fileContent.Split('\n'))
                {
                    if (cmd != "" && cmd != null)
                    {
                        commands[i] = cmd;
                        i++;
                    }
                }
                return GetParametersStringArray(0);
            }
            public int GetComboBoxCommandGroupIndex(ComboBox comboBox, string[] displayVar)
            {
                string cmBoxText = comboBox.SelectedItem.ToString();
                int index;
                for (index = 0; index <= displayVar.Count() - 1; index++)
                {
                    if (cmBoxText == displayVar[index])
                    {
                        return index;
                    }
                }
                return -1;
            }
        }
    }
}
