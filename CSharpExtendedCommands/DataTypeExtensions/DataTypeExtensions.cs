using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharpExtendedCommands.DataTypeExtensions
{
    public static class GeneralClassExtensions
    {
        #region PrivateMembers
        private static List<System.IO.FileInfo> Add(List<System.IO.FileInfo> src, List<System.IO.FileInfo> @new)
        {
            foreach (var val in @new)
                src.Add(val);
            return src;
        }
        private static List<System.IO.DirectoryInfo> Add(List<System.IO.DirectoryInfo> src, List<System.IO.DirectoryInfo> @new)
        {
            foreach (var val in @new)
                src.Add(val);
            return src;
        }
        #endregion
        #region GeneralClasses
        public static bool IsOdd(this int v) => v % 2 != 0;
        public static bool ToBool(this string v) => Regex.IsMatch(v, "([tT][rR][uU][eE]|1)");
        public static object ToObject<T>(this T obj) => (object)obj;
        public static IEnumerable<Web.HtmlAgilityPack.HtmlNode> GetElementsByName(this Web.HtmlAgilityPack.HtmlNode parent, string name)
        {
            return parent.Descendants().Where(node => node.Name == name);
        }
        public static IEnumerable<Web.HtmlAgilityPack.HtmlNode> GetElementsByTagName(this Web.HtmlAgilityPack.HtmlNode parent, string name)
        {
            return parent.Descendants(name);
        }
        public static Web.HtmlAgilityPack.HtmlNode GetElementByXPath(this Web.HtmlAgilityPack.HtmlNode node, string xpath)
        {
            return node.SelectNodes(xpath)[0];
        }
        public static Web.HtmlAgilityPack.HtmlNode GetElementByXPath(this Web.HtmlAgilityPack.HtmlDocument doc, string xpath)
        {
            return doc.DocumentNode.SelectNodes(xpath)[0];
        }
        #endregion
        #region IO   
        public static void SaveXML<T>(this T obj, string path)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            System.IO.TextWriter tw = new System.IO.StreamWriter(path);
            serializer.Serialize(tw, obj);
            tw.Close();
        }
        public static T LoadXML<T>(this T obj, string path)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            System.IO.TextReader tr = new System.IO.StreamReader(path);
            var rd = serializer.Deserialize(tr);
            tr.Close();
            return (T)rd;
        }
        public static void SaveToBinary<T>(this T obj, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream file = File.OpenWrite(path);
            formatter.Serialize(file, obj);
            file.Close();
        }
        public static T LoadFromBinary<T>(this T obj, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream file = File.OpenRead(path);
            var r = formatter.Deserialize(file);
            file.Close();
            return (T)r;
        }
        public static System.IO.FileInfo[] GetAllFiles(this System.IO.DirectoryInfo dir)
        {
            List<System.IO.FileInfo> files = new List<System.IO.FileInfo>();
            foreach (var file in dir.GetFiles())
                files.Add(file);
            foreach (var directory in dir.GetDirectories())
                files = Add(files, directory.GetAllFiles().ToList());
            return files.ToArray();
        }
        public static System.IO.FileInfo[] GetAllFiles(this System.IO.DirectoryInfo dir, string searchPattern)
        {
            List<System.IO.FileInfo> files = new List<System.IO.FileInfo>();
            foreach (var file in dir.GetFiles(searchPattern))
                files.Add(file);
            foreach (var directory in dir.GetDirectories())
                files = Add(files, directory.GetAllFiles(searchPattern).ToList());
            return files.ToArray();
        }
        public static System.IO.FileInfo[] GetAllFiles(this System.IO.DirectoryInfo dir, string searchPattern, System.IO.SearchOption searchOption)
        {
            List<System.IO.FileInfo> files = new List<System.IO.FileInfo>();
            foreach (var file in dir.GetFiles(searchPattern, searchOption))
                files.Add(file);
            foreach (var directory in dir.GetDirectories())
                files = Add(files, directory.GetAllFiles(searchPattern, searchOption).ToList());
            return files.ToArray();
        }
        public static System.IO.DirectoryInfo[] GetAllDirectories(this System.IO.DirectoryInfo dir)
        {
            List<System.IO.DirectoryInfo> dirs = new List<System.IO.DirectoryInfo>();
            foreach (var directory in dir.GetDirectories())
            { dirs.Add(directory); dirs = Add(dirs, directory.GetAllDirectories().ToList()); }
            return dirs.ToArray();
        }
        public static System.IO.DirectoryInfo[] GetAllDirectories(this System.IO.DirectoryInfo dir, string searchPattern)
        {
            List<System.IO.DirectoryInfo> dirs = new List<System.IO.DirectoryInfo>();
            foreach (var directory in dir.GetDirectories(searchPattern))
                dirs.Add(directory);
            foreach (var directory in dir.GetDirectories())
                dirs = Add(dirs, directory.GetAllDirectories(searchPattern).ToList());
            return dirs.ToArray();
        }
        public static System.IO.DirectoryInfo[] GetAllDirectories(this System.IO.DirectoryInfo dir, string searchPattern, System.IO.SearchOption searchOption)
        {
            List<System.IO.DirectoryInfo> dirs = new List<System.IO.DirectoryInfo>();
            foreach (var directory in dir.GetDirectories(searchPattern, searchOption))
                dirs.Add(directory);
            foreach (var directory in dir.GetDirectories())
                dirs = Add(dirs, directory.GetAllDirectories(searchPattern, searchOption).ToList());
            return dirs.ToArray();
        }
        #endregion
    }
}
