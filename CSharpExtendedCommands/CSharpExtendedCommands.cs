using CSharpExtendedCommands.DataTypeExtensions;
using CSharpExtendedCommands.DataTypeExtensions.RegularExpressions;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using static CSharpExtendedCommands.Converter;
using Timer = System.Windows.Forms.Timer;

namespace CSharpExtendedCommands
{
    //namespace UI.Graphics
    //{
    //    public static partial class ManipulateObject
    //    {
    //        public static void CenterFormInScreen(Form frm)
    //        {
    //            int frmW = frm.Size.Width;
    //            int frmH = frm.Size.Height;
    //            int csW = CSharpExtendedCommands.Info.ComputerInfo.ScreenWidth() / 2;
    //            int csH = CSharpExtendedCommands.Info.ComputerInfo.ScreenHeight() / 2;
    //            frm.Location = new Point(csW - frmW / 2, csH - frmH / 2);
    //        }
    //    }
    //}
    //namespace Info
    //{
    //    public static partial class ComputerInfo
    //    {
    //        public static string OSFullName()
    //        {
    //            Microsoft.VisualBasic.Devices.Computer computerInfo = new Microsoft.VisualBasic.Devices.Computer();
    //            return computerInfo.Info.OSFullName;
    //        }
    //        public static ulong GetAvailablePhysicalMemory()
    //        {
    //            Microsoft.VisualBasic.Devices.Computer computerInfo = new Microsoft.VisualBasic.Devices.Computer();
    //            return computerInfo.Info.AvailablePhysicalMemory;
    //        }
    //        public static ulong GetAvailableVirtualMemory()
    //        {
    //            Microsoft.VisualBasic.Devices.Computer computerInfo = new Microsoft.VisualBasic.Devices.Computer();
    //            return computerInfo.Info.AvailableVirtualMemory;
    //        }
    //        public static System.Globalization.CultureInfo InstalledLanguage()
    //        {
    //            Microsoft.VisualBasic.Devices.Computer computerInfo = new Microsoft.VisualBasic.Devices.Computer();
    //            return computerInfo.Info.InstalledUICulture;
    //        }
    //        public static string OsPlatform()
    //        {
    //            Microsoft.VisualBasic.Devices.Computer computerInfo = new Microsoft.VisualBasic.Devices.Computer();
    //            return computerInfo.Info.OSPlatform;
    //        }
    //        public static string OsVersion()
    //        {
    //            Microsoft.VisualBasic.Devices.Computer computerInfo = new Microsoft.VisualBasic.Devices.Computer();
    //            return computerInfo.Info.OSVersion;
    //        }
    //        public static ulong GetTotalPhysicalMemory()
    //        {
    //            Microsoft.VisualBasic.Devices.Computer computerInfo = new Microsoft.VisualBasic.Devices.Computer();
    //            return computerInfo.Info.TotalPhysicalMemory;
    //        }
    //        public static ulong GetTotalVirtualMemory()
    //        {
    //            Microsoft.VisualBasic.Devices.Computer computerInfo = new Microsoft.VisualBasic.Devices.Computer();
    //            return computerInfo.Info.TotalVirtualMemory;
    //        }
    //        public static int ScreenWidth()
    //        {
    //            Microsoft.VisualBasic.Devices.Computer computerInfo = new Microsoft.VisualBasic.Devices.Computer();
    //            return computerInfo.Screen.Bounds.Width;
    //        }
    //        public static int ScreenHeight()
    //        {
    //            Microsoft.VisualBasic.Devices.Computer computerInfo = new Microsoft.VisualBasic.Devices.Computer();
    //            return int.Parse(computerInfo.Screen.Bounds.Height.ToString());
    //        }
    //    }
    //}
    //namespace IO
    //{
    //    public static class FileSystem
    //    {
    //        public static void CreateShortcut(string ExePath, string LnkPath, string Arguments = null, string IconPath = null, string Description = null, string WorkingDirectory = null, string Hotkeys = null)
    //        {
    //            var shell = new IWshRuntimeLibrary.WshShell();
    //            IWshRuntimeLibrary.IWshShortcut shortcut = shell.CreateShortcut(LnkPath);
    //            if (!string.IsNullOrEmpty(Arguments)) { shortcut.Arguments = Arguments; }
    //            if (!string.IsNullOrEmpty(WorkingDirectory)) { shortcut.WorkingDirectory = WorkingDirectory; }
    //            if (!string.IsNullOrEmpty(Description)) { shortcut.Description = Description; }
    //            if (!string.IsNullOrEmpty(Hotkeys)) { shortcut.Hotkey = Hotkeys; }
    //            shortcut.TargetPath = ExePath;
    //            if (!string.IsNullOrEmpty(IconPath)) { shortcut.IconLocation = ExePath; } else { shortcut.IconLocation = IconPath; }
    //            shortcut.Save();
    //        }
    //    }
    //}
    namespace Web
    {
        namespace HtmlAgilityPack
        {
            [CompilerGenerated]
            internal sealed class PrivateImplementationDetails
            {
                internal static uint ComputeStringHash(string s)
                {
                    uint num = 0u;
                    if (s != null)
                    {
                        num = 2166136261u;
                        for (int i = 0; i < s.Length; i++)
                        {
                            num = ((uint)s[i] ^ num) * 16777619u;
                        }
                    }
                    return num;
                }
                //internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024, 373B494F210C656134C5728D551D4C97B013EB33;
                //internal static readonly long _4EEB46F720594D7409B9A8E1B6275694A0C4491D;
                //[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1024)]
                //private struct __StaticArrayInitTypeSize
                //{
                //}
            }
            public enum AttributeValueQuote
            {
                SingleQuote,
                DoubleQuote
            }
            public class Crc32
            {
                internal uint CheckSum
                {
                    get
                    {
                        return this._crc32;
                    }
                    set
                    {
                        this._crc32 = value;
                    }
                }
                public static uint CRC32Bytes(byte[] bytes)
                {
                    uint num = uint.MaxValue;
                    int i = bytes.Length;
                    int num2 = 0;
                    while (i > 0)
                    {
                        i--;
                        num = Crc32.UPDC32(bytes[i], num);
                        num2++;
                    }
                    return ~num;
                }
                public static uint CRC32String(string text)
                {
                    uint num = uint.MaxValue;
                    int i = text.Length;
                    int num2 = 0;
                    while (i > 0)
                    {
                        i--;
                        char c = text[i];
                        byte octet = (byte)(c & 'ÿ');
                        num = Crc32.UPDC32((byte)(c >> 8), num);
                        num = Crc32.UPDC32(octet, num);
                        num2++;
                    }
                    return ~num;
                }
                internal uint AddToCRC32(int c)
                {
                    return this.AddToCRC32((ushort)c);
                }
                internal uint AddToCRC32(ushort c)
                {
                    byte octet = (byte)(c & 255);
                    byte octet2 = (byte)(c >> 8);
                    this._crc32 = Crc32.UPDC32(octet2, this._crc32);
                    this._crc32 = Crc32.UPDC32(octet, this._crc32);
                    return ~this._crc32;
                }
                private static uint UPDC32(byte octet, uint crc)
                {
                    return Crc32.crc_32_tab[(int)((crc ^ (uint)octet) & 255u)] ^ crc >> 8;
                }
                private uint _crc32;
                private static uint[] crc_32_tab = new uint[]
                {
            0u,
            1996959894u,
            3993919788u,
            2567524794u,
            124634137u,
            1886057615u,
            3915621685u,
            2657392035u,
            249268274u,
            2044508324u,
            3772115230u,
            2547177864u,
            162941995u,
            2125561021u,
            3887607047u,
            2428444049u,
            498536548u,
            1789927666u,
            4089016648u,
            2227061214u,
            450548861u,
            1843258603u,
            4107580753u,
            2211677639u,
            325883990u,
            1684777152u,
            4251122042u,
            2321926636u,
            335633487u,
            1661365465u,
            4195302755u,
            2366115317u,
            997073096u,
            1281953886u,
            3579855332u,
            2724688242u,
            1006888145u,
            1258607687u,
            3524101629u,
            2768942443u,
            901097722u,
            1119000684u,
            3686517206u,
            2898065728u,
            853044451u,
            1172266101u,
            3705015759u,
            2882616665u,
            651767980u,
            1373503546u,
            3369554304u,
            3218104598u,
            565507253u,
            1454621731u,
            3485111705u,
            3099436303u,
            671266974u,
            1594198024u,
            3322730930u,
            2970347812u,
            795835527u,
            1483230225u,
            3244367275u,
            3060149565u,
            1994146192u,
            31158534u,
            2563907772u,
            4023717930u,
            1907459465u,
            112637215u,
            2680153253u,
            3904427059u,
            2013776290u,
            251722036u,
            2517215374u,
            3775830040u,
            2137656763u,
            141376813u,
            2439277719u,
            3865271297u,
            1802195444u,
            476864866u,
            2238001368u,
            4066508878u,
            1812370925u,
            453092731u,
            2181625025u,
            4111451223u,
            1706088902u,
            314042704u,
            2344532202u,
            4240017532u,
            1658658271u,
            366619977u,
            2362670323u,
            4224994405u,
            1303535960u,
            984961486u,
            2747007092u,
            3569037538u,
            1256170817u,
            1037604311u,
            2765210733u,
            3554079995u,
            1131014506u,
            879679996u,
            2909243462u,
            3663771856u,
            1141124467u,
            855842277u,
            2852801631u,
            3708648649u,
            1342533948u,
            654459306u,
            3188396048u,
            3373015174u,
            1466479909u,
            544179635u,
            3110523913u,
            3462522015u,
            1591671054u,
            702138776u,
            2966460450u,
            3352799412u,
            1504918807u,
            783551873u,
            3082640443u,
            3233442989u,
            3988292384u,
            2596254646u,
            62317068u,
            1957810842u,
            3939845945u,
            2647816111u,
            81470997u,
            1943803523u,
            3814918930u,
            2489596804u,
            225274430u,
            2053790376u,
            3826175755u,
            2466906013u,
            167816743u,
            2097651377u,
            4027552580u,
            2265490386u,
            503444072u,
            1762050814u,
            4150417245u,
            2154129355u,
            426522225u,
            1852507879u,
            4275313526u,
            2312317920u,
            282753626u,
            1742555852u,
            4189708143u,
            2394877945u,
            397917763u,
            1622183637u,
            3604390888u,
            2714866558u,
            953729732u,
            1340076626u,
            3518719985u,
            2797360999u,
            1068828381u,
            1219638859u,
            3624741850u,
            2936675148u,
            906185462u,
            1090812512u,
            3747672003u,
            2825379669u,
            829329135u,
            1181335161u,
            3412177804u,
            3160834842u,
            628085408u,
            1382605366u,
            3423369109u,
            3138078467u,
            570562233u,
            1426400815u,
            3317316542u,
            2998733608u,
            733239954u,
            1555261956u,
            3268935591u,
            3050360625u,
            752459403u,
            1541320221u,
            2607071920u,
            3965973030u,
            1969922972u,
            40735498u,
            2617837225u,
            3943577151u,
            1913087877u,
            83908371u,
            2512341634u,
            3803740692u,
            2075208622u,
            213261112u,
            2463272603u,
            3855990285u,
            2094854071u,
            198958881u,
            2262029012u,
            4057260610u,
            1759359992u,
            534414190u,
            2176718541u,
            4139329115u,
            1873836001u,
            414664567u,
            2282248934u,
            4279200368u,
            1711684554u,
            285281116u,
            2405801727u,
            4167216745u,
            1634467795u,
            376229701u,
            2685067896u,
            3608007406u,
            1308918612u,
            956543938u,
            2808555105u,
            3495958263u,
            1231636301u,
            1047427035u,
            2932959818u,
            3654703836u,
            1088359270u,
            936918000u,
            2847714899u,
            3736837829u,
            1202900863u,
            817233897u,
            3183342108u,
            3401237130u,
            1404277552u,
            615818150u,
            3134207493u,
            3453421203u,
            1423857449u,
            601450431u,
            3009837614u,
            3294710456u,
            1567103746u,
            711928724u,
            3020668471u,
            3272380065u,
            1510334235u,
            755167117u
                };
            }
            internal class EncodingFoundException : Exception
            {
                internal EncodingFoundException(Encoding encoding)
                {
                    this._encoding = encoding;
                }
                internal Encoding Encoding
                {
                    get
                    {
                        return this._encoding;
                    }
                }
                private Encoding _encoding;
            }
            [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
            public sealed class HasXPathAttribute : Attribute
            {
            }
            [DebuggerDisplay("Name: {OriginalName}, Value: {Value}")]
            public class HtmlAttribute : IComparable
            {
                internal HtmlAttribute(HtmlDocument ownerdocument)
                {
                    this._ownerdocument = ownerdocument;
                }
                public int Line
                {
                    get
                    {
                        return this._line;
                    }
                    internal set
                    {
                        this._line = value;
                    }
                }
                public int LinePosition
                {
                    get
                    {
                        return this._lineposition;
                    }
                }
                public int ValueStartIndex
                {
                    get
                    {
                        return this._valuestartindex;
                    }
                }
                public int ValueLength
                {
                    get
                    {
                        return this._valuelength;
                    }
                }
                public bool UseOriginalName { get; set; }
                public string Name
                {
                    get
                    {
                        if (this._name == null)
                        {
                            this._name = this._ownerdocument.Text.Substring(this._namestartindex, this._namelength);
                        }
                        if (!this.UseOriginalName)
                        {
                            return this._name.ToLowerInvariant();
                        }
                        return this._name;
                    }
                    set
                    {
                        if (value == null)
                        {
                            throw new ArgumentNullException("value");
                        }
                        this._name = value;
                        if (this._ownernode != null)
                        {
                            this._ownernode.SetChanged();
                        }
                    }
                }
                public string OriginalName
                {
                    get
                    {
                        return this._name;
                    }
                }
                public HtmlDocument OwnerDocument
                {
                    get
                    {
                        return this._ownerdocument;
                    }
                }
                public HtmlNode OwnerNode
                {
                    get
                    {
                        return this._ownernode;
                    }
                }
                public AttributeValueQuote QuoteType
                {
                    get
                    {
                        return this._quoteType;
                    }
                    set
                    {
                        this._quoteType = value;
                    }
                }
                public int StreamPosition
                {
                    get
                    {
                        return this._streamposition;
                    }
                }
                public string Value
                {
                    get
                    {
                        if (this._value == null && this._ownerdocument.Text == null && this._valuestartindex == 0 && this._valuelength == 0)
                        {
                            return null;
                        }
                        if (this._value == null)
                        {
                            this._value = this._ownerdocument.Text.Substring(this._valuestartindex, this._valuelength);
                            if (!this._ownerdocument.BackwardCompatibility)
                            {
                                this._value = HtmlEntity.DeEntitize(this._value);
                            }
                        }
                        return this._value;
                    }
                    set
                    {
                        this._value = value;
                        if (this._ownernode != null)
                        {
                            this._ownernode.SetChanged();
                        }
                    }
                }
                public string DeEntitizeValue
                {
                    get
                    {
                        return HtmlEntity.DeEntitize(this.Value);
                    }
                }
                internal string XmlName
                {
                    get
                    {
                        return HtmlDocument.GetXmlName(this.Name, true, this.OwnerDocument.OptionPreserveXmlNamespaces);
                    }
                }
                internal string XmlValue
                {
                    get
                    {
                        return this.Value;
                    }
                }
                public string XPath
                {
                    get
                    {
                        return ((this.OwnerNode == null) ? "/" : (this.OwnerNode.XPath + "/")) + this.GetRelativeXpath();
                    }
                }
                public int CompareTo(object obj)
                {
                    HtmlAttribute htmlAttribute = obj as HtmlAttribute;
                    if (htmlAttribute == null)
                    {
                        throw new ArgumentException("obj");
                    }
                    return this.Name.CompareTo(htmlAttribute.Name);
                }
                public HtmlAttribute Clone()
                {
                    return new HtmlAttribute(this._ownerdocument)
                    {
                        Name = this.Name,
                        Value = this.Value,
                        QuoteType = this.QuoteType
                    };
                }
                public void Remove()
                {
                    this._ownernode.Attributes.Remove(this);
                }
                private string GetRelativeXpath()
                {
                    if (this.OwnerNode == null)
                    {
                        return this.Name;
                    }
                    int num = 1;
                    foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)this.OwnerNode.Attributes))
                    {
                        if (!(htmlAttribute.Name != this.Name))
                        {
                            if (htmlAttribute == this)
                            {
                                break;
                            }
                            num++;
                        }
                    }
                    return string.Concat(new object[]
                    {
                "@",
                this.Name,
                "[",
                num,
                "]"
                    });
                }
                private int _line;
                internal int _lineposition;
                internal string _name;
                internal int _namelength;
                internal int _namestartindex;
                internal HtmlDocument _ownerdocument;
                internal HtmlNode _ownernode;
                private AttributeValueQuote _quoteType = AttributeValueQuote.DoubleQuote;
                internal int _streamposition;
                internal string _value;
                internal int _valuelength;
                internal int _valuestartindex;
            }
            public class HtmlAttributeCollection : IList<HtmlAttribute>, ICollection<HtmlAttribute>, IEnumerable<HtmlAttribute>, IEnumerable
            {
                internal HtmlAttributeCollection(HtmlNode ownernode)
                {
                    this._ownernode = ownernode;
                }
                public int Count
                {
                    get
                    {
                        return this.items.Count;
                    }
                }
                public bool IsReadOnly
                {
                    get
                    {
                        return false;
                    }
                }
                public HtmlAttribute this[int index]
                {
                    get
                    {
                        return this.items[index];
                    }
                    set
                    {
                        HtmlAttribute htmlAttribute = this.items[index];
                        this.items[index] = value;
                        if (htmlAttribute.Name != value.Name)
                        {
                            this.Hashitems.Remove(htmlAttribute.Name);
                        }
                        this.Hashitems[value.Name] = value;
                        value._ownernode = this._ownernode;
                        this._ownernode.SetChanged();
                    }
                }
                public HtmlAttribute this[string name]
                {
                    get
                    {
                        if (name == null)
                        {
                            throw new ArgumentNullException("name");
                        }
                        HtmlAttribute result;
                        if (!this.Hashitems.TryGetValue(name, out result))
                        {
                            return null;
                        }
                        return result;
                    }
                    set
                    {
                        HtmlAttribute item;
                        if (!this.Hashitems.TryGetValue(name, out item))
                        {
                            this.Append(value);
                        }
                        this[this.items.IndexOf(item)] = value;
                    }
                }
                public void Add(string name, string value)
                {
                    this.Append(name, value);
                }
                public void Add(HtmlAttribute item)
                {
                    this.Append(item);
                }
                public void AddRange(IEnumerable<HtmlAttribute> items)
                {
                    foreach (HtmlAttribute newAttribute in items)
                    {
                        this.Append(newAttribute);
                    }
                }
                public void AddRange(Dictionary<string, string> items)
                {
                    foreach (KeyValuePair<string, string> keyValuePair in items)
                    {
                        this.Add(keyValuePair.Key, keyValuePair.Value);
                    }
                }
                void ICollection<HtmlAttribute>.Clear()
                {
                    this.items.Clear();
                }
                public bool Contains(HtmlAttribute item)
                {
                    return this.items.Contains(item);
                }
                public void CopyTo(HtmlAttribute[] array, int arrayIndex)
                {
                    this.items.CopyTo(array, arrayIndex);
                }
                IEnumerator<HtmlAttribute> IEnumerable<HtmlAttribute>.GetEnumerator()
                {
                    return this.items.GetEnumerator();
                }
                IEnumerator IEnumerable.GetEnumerator()
                {
                    return this.items.GetEnumerator();
                }
                public int IndexOf(HtmlAttribute item)
                {
                    return this.items.IndexOf(item);
                }
                public void Insert(int index, HtmlAttribute item)
                {
                    if (item == null)
                    {
                        throw new ArgumentNullException("item");
                    }
                    this.Hashitems[item.Name] = item;
                    item._ownernode = this._ownernode;
                    this.items.Insert(index, item);
                    this._ownernode.SetChanged();
                }
                bool ICollection<HtmlAttribute>.Remove(HtmlAttribute item)
                {
                    return this.items.Remove(item);
                }
                public void RemoveAt(int index)
                {
                    HtmlAttribute htmlAttribute = this.items[index];
                    this.Hashitems.Remove(htmlAttribute.Name);
                    this.items.RemoveAt(index);
                    this._ownernode.SetChanged();
                }
                public HtmlAttribute Append(HtmlAttribute newAttribute)
                {
                    if (this._ownernode.NodeType == HtmlNodeType.Text || this._ownernode.NodeType == HtmlNodeType.Comment)
                    {
                        throw new Exception("A Text or Comment node cannot have attributes.");
                    }
                    if (newAttribute == null)
                    {
                        throw new ArgumentNullException("newAttribute");
                    }
                    this.Hashitems[newAttribute.Name] = newAttribute;
                    newAttribute._ownernode = this._ownernode;
                    this.items.Add(newAttribute);
                    this._ownernode.SetChanged();
                    return newAttribute;
                }
                public HtmlAttribute Append(string name)
                {
                    HtmlAttribute newAttribute = this._ownernode._ownerdocument.CreateAttribute(name);
                    return this.Append(newAttribute);
                }
                public HtmlAttribute Append(string name, string value)
                {
                    HtmlAttribute newAttribute = this._ownernode._ownerdocument.CreateAttribute(name, value);
                    return this.Append(newAttribute);
                }
                public bool Contains(string name)
                {
                    for (int i = 0; i < this.items.Count; i++)
                    {
                        if (string.Equals(this.items[i].Name, name, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                public HtmlAttribute Prepend(HtmlAttribute newAttribute)
                {
                    this.Insert(0, newAttribute);
                    return newAttribute;
                }
                public void Remove(HtmlAttribute attribute)
                {
                    if (attribute == null)
                    {
                        throw new ArgumentNullException("attribute");
                    }
                    int attributeIndex = this.GetAttributeIndex(attribute);
                    if (attributeIndex == -1)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    this.RemoveAt(attributeIndex);
                }
                public void Remove(string name)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    for (int i = 0; i < this.items.Count; i++)
                    {
                        if (string.Equals(this.items[i].Name, name, StringComparison.OrdinalIgnoreCase))
                        {
                            this.RemoveAt(i);
                        }
                    }
                }
                public void RemoveAll()
                {
                    this.Hashitems.Clear();
                    this.items.Clear();
                    this._ownernode.SetChanged();
                }
                public IEnumerable<HtmlAttribute> AttributesWithName(string attributeName)
                {
                    int num;
                    for (int i = 0; i < this.items.Count; i = num + 1)
                    {
                        if (string.Equals(this.items[i].Name, attributeName, StringComparison.OrdinalIgnoreCase))
                        {
                            yield return this.items[i];
                        }
                        num = i;
                    }
                    yield break;
                }
                public void Remove()
                {
                    this.items.Clear();
                }
                internal void Clear()
                {
                    this.Hashitems.Clear();
                    this.items.Clear();
                }
                internal int GetAttributeIndex(HtmlAttribute attribute)
                {
                    if (attribute == null)
                    {
                        throw new ArgumentNullException("attribute");
                    }
                    for (int i = 0; i < this.items.Count; i++)
                    {
                        if (this.items[i] == attribute)
                        {
                            return i;
                        }
                    }
                    return -1;
                }
                internal int GetAttributeIndex(string name)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    for (int i = 0; i < this.items.Count; i++)
                    {
                        if (string.Equals(this.items[i].Name, name, StringComparison.OrdinalIgnoreCase))
                        {
                            return i;
                        }
                    }
                    return -1;
                }
                internal Dictionary<string, HtmlAttribute> Hashitems = new Dictionary<string, HtmlAttribute>(StringComparer.OrdinalIgnoreCase);
                private HtmlNode _ownernode;
                private List<HtmlAttribute> items = new List<HtmlAttribute>();
            }
            internal class HtmlCmdLine
            {
                static HtmlCmdLine()
                {
                    HtmlCmdLine.ParseArgs();
                }
                internal static string GetOption(string name, string def)
                {
                    string result = def;
                    string[] commandLineArgs = Environment.GetCommandLineArgs();
                    for (int i = 1; i < commandLineArgs.Length; i++)
                    {
                        HtmlCmdLine.GetStringArg(commandLineArgs[i], name, ref result);
                    }
                    return result;
                }
                internal static string GetOption(int index, string def)
                {
                    string result = def;
                    string[] commandLineArgs = Environment.GetCommandLineArgs();
                    int num = 0;
                    for (int i = 1; i < commandLineArgs.Length; i++)
                    {
                        if (HtmlCmdLine.GetStringArg(commandLineArgs[i], ref result))
                        {
                            if (index == num)
                            {
                                return result;
                            }
                            result = def;
                            num++;
                        }
                    }
                    return result;
                }
                internal static bool GetOption(string name, bool def)
                {
                    bool result = def;
                    string[] commandLineArgs = Environment.GetCommandLineArgs();
                    for (int i = 1; i < commandLineArgs.Length; i++)
                    {
                        HtmlCmdLine.GetBoolArg(commandLineArgs[i], name, ref result);
                    }
                    return result;
                }
                internal static int GetOption(string name, int def)
                {
                    int result = def;
                    string[] commandLineArgs = Environment.GetCommandLineArgs();
                    for (int i = 1; i < commandLineArgs.Length; i++)
                    {
                        HtmlCmdLine.GetIntArg(commandLineArgs[i], name, ref result);
                    }
                    return result;
                }
                private static void GetBoolArg(string Arg, string Name, ref bool ArgValue)
                {
                    if (Arg.Length < Name.Length + 1)
                    {
                        return;
                    }
                    if ('/' != Arg[0] && '-' != Arg[0])
                    {
                        return;
                    }
                    if (Arg.Substring(1, Name.Length).ToLowerInvariant() == Name.ToLowerInvariant())
                    {
                        ArgValue = true;
                    }
                }
                private static void GetIntArg(string Arg, string Name, ref int ArgValue)
                {
                    if (Arg.Length < Name.Length + 3)
                    {
                        return;
                    }
                    if ('/' != Arg[0] && '-' != Arg[0])
                    {
                        return;
                    }
                    if (Arg.Substring(1, Name.Length).ToLowerInvariant() == Name.ToLowerInvariant())
                    {
                        try
                        {
                            ArgValue = Convert.ToInt32(Arg.Substring(Name.Length + 2, Arg.Length - Name.Length - 2));
                        }
                        catch
                        {
                        }
                    }
                }
                private static bool GetStringArg(string Arg, ref string ArgValue)
                {
                    if ('/' == Arg[0] || '-' == Arg[0])
                    {
                        return false;
                    }
                    ArgValue = Arg;
                    return true;
                }
                private static void GetStringArg(string Arg, string Name, ref string ArgValue)
                {
                    if (Arg.Length < Name.Length + 3)
                    {
                        return;
                    }
                    if ('/' != Arg[0] && '-' != Arg[0])
                    {
                        return;
                    }
                    if (Arg.Substring(1, Name.Length).ToLowerInvariant() == Name.ToLowerInvariant())
                    {
                        ArgValue = Arg.Substring(Name.Length + 2, Arg.Length - Name.Length - 2);
                    }
                }
                private static void ParseArgs()
                {
                    string[] commandLineArgs = Environment.GetCommandLineArgs();
                    for (int i = 1; i < commandLineArgs.Length; i++)
                    {
                        HtmlCmdLine.GetBoolArg(commandLineArgs[i], "?", ref HtmlCmdLine.Help);
                        HtmlCmdLine.GetBoolArg(commandLineArgs[i], "h", ref HtmlCmdLine.Help);
                        HtmlCmdLine.GetBoolArg(commandLineArgs[i], "help", ref HtmlCmdLine.Help);
                    }
                }
                internal static bool Help = false;
            }
            public class HtmlCommentNode : HtmlNode
            {
                internal HtmlCommentNode(HtmlDocument ownerdocument, int index) : base(HtmlNodeType.Comment, ownerdocument, index)
                {
                }
                public string Comment
                {
                    get
                    {
                        if (this._comment == null)
                        {
                            return base.InnerHtml;
                        }
                        return this._comment;
                    }
                    set
                    {
                        this._comment = value;
                    }
                }
                public override string InnerHtml
                {
                    get
                    {
                        if (this._comment == null)
                        {
                            return base.InnerHtml;
                        }
                        return this._comment;
                    }
                    set
                    {
                        this._comment = value;
                    }
                }
                public override string OuterHtml
                {
                    get
                    {
                        if (this._comment == null)
                        {
                            return base.OuterHtml;
                        }
                        return "<!--" + this._comment + "-->";
                    }
                }
                private string _comment;
            }
            internal class HtmlConsoleListener : TraceListener
            {
                public override void Write(string Message)
                {
                    this.Write(Message, "");
                }
                public override void Write(string Message, string Category)
                {
                    Console.Write("T:" + Category + ": " + Message);
                }
                public override void WriteLine(string Message)
                {
                    this.Write(Message + "\n");
                }
                public override void WriteLine(string Message, string Category)
                {
                    this.Write(Message + "\n", Category);
                }
            }
            public class HtmlDocument : IXPathNavigable
            {
                public void LoadHtml(Uri url) => LoadHtml(new WebClient().DownloadString(url.AbsoluteUri));
                public static bool DisableBehaviorTagP
                {
                    get
                    {
                        return HtmlDocument._disableBehaviorTagP;
                    }
                    set
                    {
                        if (value)
                        {
                            if (HtmlNode.ElementsFlags.ContainsKey("p"))
                            {
                                HtmlNode.ElementsFlags.Remove("p");
                            }
                        }
                        else if (!HtmlNode.ElementsFlags.ContainsKey("p"))
                        {
                            HtmlNode.ElementsFlags.Add("p", HtmlElementFlag.Empty | HtmlElementFlag.Closed);
                        }
                        HtmlDocument._disableBehaviorTagP = value;
                    }
                }
                public static Action<HtmlDocument> DefaultBuilder { get; set; }
                public Action<HtmlDocument> ParseExecuting { get; set; }
                public HtmlDocument()
                {
                    if (HtmlDocument.DefaultBuilder != null)
                    {
                        HtmlDocument.DefaultBuilder(this);
                    }
                    this._documentnode = this.CreateNode(HtmlNodeType.Document, 0);
                    this.OptionDefaultStreamEncoding = Encoding.Default;
                }
                public string ParsedText
                {
                    get
                    {
                        return this.Text;
                    }
                }
                public static int MaxDepthLevel
                {
                    get
                    {
                        return HtmlDocument._maxDepthLevel;
                    }
                    set
                    {
                        HtmlDocument._maxDepthLevel = value;
                    }
                }
                public int CheckSum
                {
                    get
                    {
                        if (this._crc32 != null)
                        {
                            return (int)this._crc32.CheckSum;
                        }
                        return 0;
                    }
                }
                public Encoding DeclaredEncoding
                {
                    get
                    {
                        return this._declaredencoding;
                    }
                }
                public HtmlNode DocumentNode
                {
                    get
                    {
                        return this._documentnode;
                    }
                }
                public Encoding Encoding
                {
                    get
                    {
                        return this.GetOutEncoding();
                    }
                }
                public IEnumerable<HtmlParseError> ParseErrors
                {
                    get
                    {
                        return this._parseerrors;
                    }
                }
                public string Remainder
                {
                    get
                    {
                        return this._remainder;
                    }
                }
                public int RemainderOffset
                {
                    get
                    {
                        return this._remainderOffset;
                    }
                }
                public Encoding StreamEncoding
                {
                    get
                    {
                        return this._streamencoding;
                    }
                }
                public static string GetXmlName(string name)
                {
                    return HtmlDocument.GetXmlName(name, false, false);
                }
                public void UseAttributeOriginalName(string tagName)
                {
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.DocumentNode.SelectNodes("//" + tagName)))
                    {
                        foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)htmlNode.Attributes))
                        {
                            htmlAttribute.UseOriginalName = true;
                        }
                    }
                }
                public static string GetXmlName(string name, bool isAttribute, bool preserveXmlNamespaces)
                {
                    string text = string.Empty;
                    bool flag = true;
                    for (int i = 0; i < name.Length; i++)
                    {
                        if ((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= '0' && name[i] <= '9') || ((isAttribute || preserveXmlNamespaces) && name[i] == ':') || name[i] == '_' || name[i] == '-' || name[i] == '.')
                        {
                            text += name[i].ToString();
                        }
                        else
                        {
                            flag = false;
                            byte[] bytes = Encoding.UTF8.GetBytes(new char[]
                            {
                        name[i]
                            });
                            for (int j = 0; j < bytes.Length; j++)
                            {
                                text += bytes[j].ToString("x2");
                            }
                            text += "_";
                        }
                    }
                    if (flag)
                    {
                        return text;
                    }
                    return "_" + text;
                }
                public static string HtmlEncode(string html)
                {
                    return HtmlDocument.HtmlEncodeWithCompatibility(html, true);
                }
                internal static string HtmlEncodeWithCompatibility(string html, bool backwardCompatibility = true)
                {
                    if (html == null)
                    {
                        throw new ArgumentNullException("html");
                    }
                    return (backwardCompatibility ? new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;))", RegexOptions.IgnoreCase) : new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;)|(nbsp;)|(reg;))", RegexOptions.IgnoreCase)).Replace(html, "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");
                }
                public static bool IsWhiteSpace(int c)
                {
                    return c == 10 || c == 13 || c == 32 || c == 9;
                }
                public HtmlAttribute CreateAttribute(string name)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    HtmlAttribute htmlAttribute = this.CreateAttribute();
                    htmlAttribute.Name = name;
                    return htmlAttribute;
                }
                public HtmlAttribute CreateAttribute(string name, string value)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    HtmlAttribute htmlAttribute = this.CreateAttribute(name);
                    htmlAttribute.Value = value;
                    return htmlAttribute;
                }
                public HtmlCommentNode CreateComment()
                {
                    return (HtmlCommentNode)this.CreateNode(HtmlNodeType.Comment);
                }
                public HtmlCommentNode CreateComment(string comment)
                {
                    if (comment == null)
                    {
                        throw new ArgumentNullException("comment");
                    }
                    HtmlCommentNode htmlCommentNode = this.CreateComment();
                    htmlCommentNode.Comment = comment;
                    return htmlCommentNode;
                }
                public HtmlNode CreateElement(string name)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    HtmlNode htmlNode = this.CreateNode(HtmlNodeType.Element);
                    htmlNode.Name = name;
                    return htmlNode;
                }
                public HtmlTextNode CreateTextNode()
                {
                    return (HtmlTextNode)this.CreateNode(HtmlNodeType.Text);
                }
                public HtmlTextNode CreateTextNode(string text)
                {
                    if (text == null)
                    {
                        throw new ArgumentNullException("text");
                    }
                    HtmlTextNode htmlTextNode = this.CreateTextNode();
                    htmlTextNode.Text = text;
                    return htmlTextNode;
                }
                public Encoding DetectEncoding(System.IO.Stream stream)
                {
                    return this.DetectEncoding(stream, false);
                }
                public Encoding DetectEncoding(System.IO.Stream stream, bool checkHtml)
                {
                    this._useHtmlEncodingForStream = checkHtml;
                    if (stream == null)
                    {
                        throw new ArgumentNullException("stream");
                    }
                    return this.DetectEncoding(new System.IO.StreamReader(stream));
                }
                public Encoding DetectEncoding(System.IO.TextReader reader)
                {
                    if (reader == null)
                    {
                        throw new ArgumentNullException("reader");
                    }
                    this._onlyDetectEncoding = true;
                    if (this.OptionCheckSyntax)
                    {
                        this.Openednodes = new Dictionary<int, HtmlNode>();
                    }
                    else
                    {
                        this.Openednodes = null;
                    }
                    if (this.OptionUseIdAttribute)
                    {
                        this.Nodesid = new Dictionary<string, HtmlNode>(StringComparer.OrdinalIgnoreCase);
                    }
                    else
                    {
                        this.Nodesid = null;
                    }
                    System.IO.StreamReader streamReader = reader as System.IO.StreamReader;
                    if (streamReader != null && !this._useHtmlEncodingForStream)
                    {
                        this.Text = streamReader.ReadToEnd();
                        this._streamencoding = streamReader.CurrentEncoding;
                        return this._streamencoding;
                    }
                    this._streamencoding = null;
                    this._declaredencoding = null;
                    this.Text = reader.ReadToEnd();
                    this._documentnode = this.CreateNode(HtmlNodeType.Document, 0);
                    try
                    {
                        this.Parse();
                    }
                    catch (EncodingFoundException ex)
                    {
                        return ex.Encoding;
                    }
                    return this._streamencoding;
                }
                public Encoding DetectEncodingHtml(string html)
                {
                    if (html == null)
                    {
                        throw new ArgumentNullException("html");
                    }
                    Encoding result;
                    using (System.IO.StringReader stringReader = new System.IO.StringReader(html))
                    {
                        result = this.DetectEncoding(stringReader);
                    }
                    return result;
                }
                public HtmlNode GetElementbyId(string id)
                {
                    if (id == null)
                    {
                        throw new ArgumentNullException("id");
                    }
                    if (this.Nodesid == null)
                    {
                        throw new Exception(HtmlDocument.HtmlExceptionUseIdAttributeFalse);
                    }
                    if (!this.Nodesid.ContainsKey(id))
                    {
                        return null;
                    }
                    return this.Nodesid[id];
                }
                public void Load(System.IO.Stream stream)
                {
                    this.Load(new System.IO.StreamReader(stream, this.OptionDefaultStreamEncoding));
                }
                public void Load(System.IO.Stream stream, bool detectEncodingFromByteOrderMarks)
                {
                    this.Load(new System.IO.StreamReader(stream, detectEncodingFromByteOrderMarks));
                }
                public void Load(System.IO.Stream stream, Encoding encoding)
                {
                    this.Load(new System.IO.StreamReader(stream, encoding));
                }
                public void Load(System.IO.Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
                {
                    this.Load(new System.IO.StreamReader(stream, encoding, detectEncodingFromByteOrderMarks));
                }
                public void Load(System.IO.Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
                {
                    this.Load(new System.IO.StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, buffersize));
                }
                public void Load(System.IO.TextReader reader)
                {
                    if (reader == null)
                    {
                        throw new ArgumentNullException("reader");
                    }
                    this._onlyDetectEncoding = false;
                    if (this.OptionCheckSyntax)
                    {
                        this.Openednodes = new Dictionary<int, HtmlNode>();
                    }
                    else
                    {
                        this.Openednodes = null;
                    }
                    if (this.OptionUseIdAttribute)
                    {
                        this.Nodesid = new Dictionary<string, HtmlNode>(StringComparer.OrdinalIgnoreCase);
                    }
                    else
                    {
                        this.Nodesid = null;
                    }
                    System.IO.StreamReader streamReader = reader as System.IO.StreamReader;
                    if (streamReader != null)
                    {
                        try
                        {
                            streamReader.Peek();
                        }
                        catch (Exception)
                        {
                        }
                        this._streamencoding = streamReader.CurrentEncoding;
                    }
                    else
                    {
                        this._streamencoding = null;
                    }
                    this._declaredencoding = null;
                    this.Text = reader.ReadToEnd();
                    this._documentnode = this.CreateNode(HtmlNodeType.Document, 0);
                    this.Parse();
                    if (!this.OptionCheckSyntax || this.Openednodes == null)
                    {
                        return;
                    }
                    foreach (HtmlNode htmlNode in this.Openednodes.Values)
                    {
                        if (htmlNode._starttag)
                        {
                            string text;
                            if (this.OptionExtractErrorSourceText)
                            {
                                text = htmlNode.OuterHtml;
                                if (text.Length > this.OptionExtractErrorSourceTextMaxLength)
                                {
                                    text = text.Substring(0, this.OptionExtractErrorSourceTextMaxLength);
                                }
                            }
                            else
                            {
                                text = string.Empty;
                            }
                            this.AddError(HtmlParseErrorCode.TagNotClosed, htmlNode._line, htmlNode._lineposition, htmlNode._streamposition, text, "End tag </" + htmlNode.Name + "> was not found");
                        }
                    }
                    this.Openednodes.Clear();
                }
                public void LoadHtml(string html)
                {
                    if (html == null)
                    {
                        throw new ArgumentNullException("html");
                    }
                    using (System.IO.StringReader stringReader = new System.IO.StringReader(html))
                    {
                        this.Load(stringReader);
                    }
                }
                public void Save(System.IO.Stream outStream)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(outStream, this.GetOutEncoding());
                    this.Save(writer);
                }
                public void Save(System.IO.Stream outStream, Encoding encoding)
                {
                    if (outStream == null)
                    {
                        throw new ArgumentNullException("outStream");
                    }
                    if (encoding == null)
                    {
                        throw new ArgumentNullException("encoding");
                    }
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(outStream, encoding);
                    this.Save(writer);
                }
                public void Save(System.IO.StreamWriter writer)
                {
                    this.Save(writer);
                }
                public void Save(System.IO.TextWriter writer)
                {
                    if (writer == null)
                    {
                        throw new ArgumentNullException("writer");
                    }
                    this.DocumentNode.WriteTo(writer, 0);
                    writer.Flush();
                }
                public void Save(XmlWriter writer)
                {
                    this.DocumentNode.WriteTo(writer);
                    writer.Flush();
                }
                internal HtmlAttribute CreateAttribute()
                {
                    return new HtmlAttribute(this);
                }
                internal HtmlNode CreateNode(HtmlNodeType type)
                {
                    return this.CreateNode(type, -1);
                }
                internal HtmlNode CreateNode(HtmlNodeType type, int index)
                {
                    if (type == HtmlNodeType.Comment)
                    {
                        return new HtmlCommentNode(this, index);
                    }
                    if (type != HtmlNodeType.Text)
                    {
                        return new HtmlNode(type, this, index);
                    }
                    return new HtmlTextNode(this, index);
                }
                internal Encoding GetOutEncoding()
                {
                    Encoding result;
                    if ((result = this._declaredencoding) == null)
                    {
                        result = (this._streamencoding ?? this.OptionDefaultStreamEncoding);
                    }
                    return result;
                }
                internal HtmlNode GetXmlDeclaration()
                {
                    if (!this._documentnode.HasChildNodes)
                    {
                        return null;
                    }
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this._documentnode._childnodes))
                    {
                        if (htmlNode.Name == "?xml")
                        {
                            return htmlNode;
                        }
                    }
                    return null;
                }
                internal void SetIdForNode(HtmlNode node, string id)
                {
                    if (!this.OptionUseIdAttribute)
                    {
                        return;
                    }
                    if (this.Nodesid == null || id == null)
                    {
                        return;
                    }
                    if (node == null)
                    {
                        this.Nodesid.Remove(id);
                        return;
                    }
                    this.Nodesid[id] = node;
                }
                internal void UpdateLastParentNode()
                {
                    do
                    {
                        if (this._lastparentnode.Closed)
                        {
                            this._lastparentnode = this._lastparentnode.ParentNode;
                        }
                    }
                    while (this._lastparentnode != null && this._lastparentnode.Closed);
                    if (this._lastparentnode == null)
                    {
                        this._lastparentnode = this._documentnode;
                    }
                }
                private void AddError(HtmlParseErrorCode code, int line, int linePosition, int streamPosition, string sourceText, string reason)
                {
                    HtmlParseError item = new HtmlParseError(code, line, linePosition, streamPosition, sourceText, reason);
                    this._parseerrors.Add(item);
                }
                private void CloseCurrentNode()
                {
                    if (this._currentnode.Closed)
                    {
                        return;
                    }
                    bool flag = false;
                    HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault<string, HtmlNode>(this.Lastnodes, this._currentnode.Name, null);
                    if (dictionaryValueOrDefault == null)
                    {
                        if (HtmlNode.IsClosedElement(this._currentnode.Name))
                        {
                            this._currentnode.CloseNode(this._currentnode, 0);
                            if (this._lastparentnode != null)
                            {
                                HtmlNode htmlNode = null;
                                Stack<HtmlNode> stack = new Stack<HtmlNode>();
                                for (HtmlNode htmlNode2 = this._lastparentnode.LastChild; htmlNode2 != null; htmlNode2 = htmlNode2.PreviousSibling)
                                {
                                    if (htmlNode2.Name == this._currentnode.Name && !htmlNode2.HasChildNodes)
                                    {
                                        htmlNode = htmlNode2;
                                        break;
                                    }
                                    stack.Push(htmlNode2);
                                }
                                if (htmlNode != null)
                                {
                                    while (stack.Count != 0)
                                    {
                                        HtmlNode htmlNode3 = stack.Pop();
                                        this._lastparentnode.RemoveChild(htmlNode3);
                                        htmlNode.AppendChild(htmlNode3);
                                    }
                                }
                                else
                                {
                                    this._lastparentnode.AppendChild(this._currentnode);
                                }
                            }
                        }
                        else if (HtmlNode.CanOverlapElement(this._currentnode.Name))
                        {
                            HtmlNode htmlNode4 = this.CreateNode(HtmlNodeType.Text, this._currentnode._outerstartindex);
                            htmlNode4._outerlength = this._currentnode._outerlength;
                            ((HtmlTextNode)htmlNode4).Text = ((HtmlTextNode)htmlNode4).Text.ToLowerInvariant();
                            if (this._lastparentnode != null)
                            {
                                this._lastparentnode.AppendChild(htmlNode4);
                            }
                        }
                        else if (HtmlNode.IsEmptyElement(this._currentnode.Name))
                        {
                            this.AddError(HtmlParseErrorCode.EndTagNotRequired, this._currentnode._line, this._currentnode._lineposition, this._currentnode._streamposition, this._currentnode.OuterHtml, "End tag </" + this._currentnode.Name + "> is not required");
                        }
                        else
                        {
                            this.AddError(HtmlParseErrorCode.TagNotOpened, this._currentnode._line, this._currentnode._lineposition, this._currentnode._streamposition, this._currentnode.OuterHtml, "Start tag <" + this._currentnode.Name + "> was not found");
                            flag = true;
                        }
                    }
                    else
                    {
                        if (this.OptionFixNestedTags && this.FindResetterNodes(dictionaryValueOrDefault, this.GetResetters(this._currentnode.Name)))
                        {
                            this.AddError(HtmlParseErrorCode.EndTagInvalidHere, this._currentnode._line, this._currentnode._lineposition, this._currentnode._streamposition, this._currentnode.OuterHtml, "End tag </" + this._currentnode.Name + "> invalid here");
                            flag = true;
                        }
                        if (!flag)
                        {
                            this.Lastnodes[this._currentnode.Name] = dictionaryValueOrDefault._prevwithsamename;
                            dictionaryValueOrDefault.CloseNode(this._currentnode, 0);
                        }
                    }
                    if (!flag && this._lastparentnode != null && (!HtmlNode.IsClosedElement(this._currentnode.Name) || this._currentnode._starttag))
                    {
                        this.UpdateLastParentNode();
                    }
                }
                private string CurrentNodeName()
                {
                    return this.Text.Substring(this._currentnode._namestartindex, this._currentnode._namelength);
                }
                private void DecrementPosition()
                {
                    this._index--;
                    if (this._lineposition == 0)
                    {
                        this._lineposition = this._maxlineposition;
                        this._line--;
                        return;
                    }
                    this._lineposition--;
                }
                private HtmlNode FindResetterNode(HtmlNode node, string name)
                {
                    HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault<string, HtmlNode>(this.Lastnodes, name, null);
                    if (dictionaryValueOrDefault == null)
                    {
                        return null;
                    }
                    if (dictionaryValueOrDefault.Closed)
                    {
                        return null;
                    }
                    if (dictionaryValueOrDefault._streamposition < node._streamposition)
                    {
                        return null;
                    }
                    return dictionaryValueOrDefault;
                }
                private bool FindResetterNodes(HtmlNode node, string[] names)
                {
                    if (names == null)
                    {
                        return false;
                    }
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (this.FindResetterNode(node, names[i]) != null)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                private void FixNestedTag(string name, string[] resetters)
                {
                    if (resetters == null)
                    {
                        return;
                    }
                    HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault<string, HtmlNode>(this.Lastnodes, this._currentnode.Name, null);
                    if (dictionaryValueOrDefault == null || this.Lastnodes[name].Closed)
                    {
                        return;
                    }
                    if (this.FindResetterNodes(dictionaryValueOrDefault, resetters))
                    {
                        return;
                    }
                    HtmlNode htmlNode = new HtmlNode(dictionaryValueOrDefault.NodeType, this, -1);
                    htmlNode._endnode = htmlNode;
                    dictionaryValueOrDefault.CloseNode(htmlNode, 0);
                }
                private void FixNestedTags()
                {
                    if (!this._currentnode._starttag)
                    {
                        return;
                    }
                    string name = this.CurrentNodeName();
                    this.FixNestedTag(name, this.GetResetters(name));
                }
                private string[] GetResetters(string name)
                {
                    string[] result;
                    if (!HtmlDocument.HtmlResetters.TryGetValue(name, out result))
                    {
                        return null;
                    }
                    return result;
                }
                private void IncrementPosition()
                {
                    if (this._crc32 != null)
                    {
                        this._crc32.AddToCRC32(this._c);
                    }
                    this._index++;
                    this._maxlineposition = this._lineposition;
                    if (this._c == 10)
                    {
                        this._lineposition = 0;
                        this._line++;
                        return;
                    }
                    this._lineposition++;
                }
                private bool IsValidTag()
                {
                    return this._c == 60 && this._index < this.Text.Length && (char.IsLetter(this.Text[this._index]) || this.Text[this._index] == '/' || this.Text[this._index] == '!' || this.Text[this._index] == '%');
                }
                private bool NewCheck()
                {
                    if (this._c != 60 || !this.IsValidTag())
                    {
                        return false;
                    }
                    if (this._index < this.Text.Length && this.Text[this._index] == '%')
                    {
                        if (this.DisableServerSideCode)
                        {
                            return false;
                        }
                        HtmlDocument.ParseState state = this._state;
                        if (state != HtmlDocument.ParseState.WhichTag)
                        {
                            if (state != HtmlDocument.ParseState.BetweenAttributes)
                            {
                                if (state == HtmlDocument.ParseState.AttributeAfterEquals)
                                {
                                    this.PushAttributeValueStart(this._index - 1);
                                }
                            }
                            else
                            {
                                this.PushAttributeNameStart(this._index - 1, this._lineposition - 1);
                            }
                        }
                        else
                        {
                            this.PushNodeNameStart(true, this._index - 1);
                            this._state = HtmlDocument.ParseState.Tag;
                        }
                        this._oldstate = this._state;
                        this._state = HtmlDocument.ParseState.ServerSideCode;
                        return true;
                    }
                    else
                    {
                        if (!this.PushNodeEnd(this._index - 1, true))
                        {
                            this._index = this.Text.Length;
                            return true;
                        }
                        this._state = HtmlDocument.ParseState.WhichTag;
                        if (this._index - 1 <= this.Text.Length - 2 && this.Text[this._index] == '!')
                        {
                            this.PushNodeStart(HtmlNodeType.Comment, this._index - 1, this._lineposition - 1);
                            this.PushNodeNameStart(true, this._index);
                            this.PushNodeNameEnd(this._index + 1);
                            this._state = HtmlDocument.ParseState.Comment;
                            if (this._index < this.Text.Length - 2)
                            {
                                if (this.Text[this._index + 1] == '-' && this.Text[this._index + 2] == '-')
                                {
                                    this._fullcomment = true;
                                }
                                else
                                {
                                    this._fullcomment = false;
                                }
                            }
                            return true;
                        }
                        this.PushNodeStart(HtmlNodeType.Element, this._index - 1, this._lineposition - 1);
                        return true;
                    }
                }
                private void Parse()
                {
                    if (this.ParseExecuting != null)
                    {
                        this.ParseExecuting(this);
                    }
                    int num = 0;
                    if (this.OptionComputeChecksum)
                    {
                        this._crc32 = new Crc32();
                    }
                    this.Lastnodes = new Dictionary<string, HtmlNode>();
                    this._c = 0;
                    this._fullcomment = false;
                    this._parseerrors = new List<HtmlParseError>();
                    this._line = 1;
                    this._lineposition = 0;
                    this._maxlineposition = 0;
                    this._state = HtmlDocument.ParseState.Text;
                    this._oldstate = this._state;
                    this._documentnode._innerlength = this.Text.Length;
                    this._documentnode._outerlength = this.Text.Length;
                    this._remainderOffset = this.Text.Length;
                    this._lastparentnode = this._documentnode;
                    this._currentnode = this.CreateNode(HtmlNodeType.Text, 0);
                    this._currentattribute = null;
                    this._index = 0;
                    this.PushNodeStart(HtmlNodeType.Text, 0, this._lineposition);
                    while (this._index < this.Text.Length)
                    {
                        this._c = (int)this.Text[this._index];
                        this.IncrementPosition();
                        switch (this._state)
                        {
                            case HtmlDocument.ParseState.Text:
                                if (this.NewCheck())
                                {
                                }
                                break;
                            case HtmlDocument.ParseState.WhichTag:
                                if (!this.NewCheck())
                                {
                                    if (this._c == 47)
                                    {
                                        this.PushNodeNameStart(false, this._index);
                                    }
                                    else
                                    {
                                        this.PushNodeNameStart(true, this._index - 1);
                                        this.DecrementPosition();
                                    }
                                    this._state = HtmlDocument.ParseState.Tag;
                                }
                                break;
                            case HtmlDocument.ParseState.Tag:
                                if (!this.NewCheck())
                                {
                                    if (HtmlDocument.IsWhiteSpace(this._c))
                                    {
                                        this.CloseParentImplicitExplicitNode();
                                        this.PushNodeNameEnd(this._index - 1);
                                        if (this._state == HtmlDocument.ParseState.Tag)
                                        {
                                            this._state = HtmlDocument.ParseState.BetweenAttributes;
                                        }
                                    }
                                    else if (this._c == 47)
                                    {
                                        this.CloseParentImplicitExplicitNode();
                                        this.PushNodeNameEnd(this._index - 1);
                                        if (this._state == HtmlDocument.ParseState.Tag)
                                        {
                                            this._state = HtmlDocument.ParseState.EmptyTag;
                                        }
                                    }
                                    else if (this._c == 62)
                                    {
                                        this.CloseParentImplicitExplicitNode();
                                        this.PushNodeNameEnd(this._index - 1);
                                        if (this._state == HtmlDocument.ParseState.Tag)
                                        {
                                            if (!this.PushNodeEnd(this._index, false))
                                            {
                                                this._index = this.Text.Length;
                                            }
                                            else if (this._state == HtmlDocument.ParseState.Tag)
                                            {
                                                this._state = HtmlDocument.ParseState.Text;
                                                this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                            }
                                        }
                                    }
                                }
                                break;
                            case HtmlDocument.ParseState.BetweenAttributes:
                                if (!this.NewCheck() && !HtmlDocument.IsWhiteSpace(this._c))
                                {
                                    if (this._c == 47 || this._c == 63)
                                    {
                                        this._state = HtmlDocument.ParseState.EmptyTag;
                                    }
                                    else if (this._c == 62)
                                    {
                                        if (!this.PushNodeEnd(this._index, false))
                                        {
                                            this._index = this.Text.Length;
                                        }
                                        else if (this._state == HtmlDocument.ParseState.BetweenAttributes)
                                        {
                                            this._state = HtmlDocument.ParseState.Text;
                                            this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                        }
                                    }
                                    else
                                    {
                                        this.PushAttributeNameStart(this._index - 1, this._lineposition - 1);
                                        this._state = HtmlDocument.ParseState.AttributeName;
                                    }
                                }
                                break;
                            case HtmlDocument.ParseState.EmptyTag:
                                if (!this.NewCheck())
                                {
                                    if (this._c == 62)
                                    {
                                        if (!this.PushNodeEnd(this._index, true))
                                        {
                                            this._index = this.Text.Length;
                                        }
                                        else if (this._state == HtmlDocument.ParseState.EmptyTag)
                                        {
                                            this._state = HtmlDocument.ParseState.Text;
                                            this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                        }
                                    }
                                    else if (!HtmlDocument.IsWhiteSpace(this._c))
                                    {
                                        this.DecrementPosition();
                                        this._state = HtmlDocument.ParseState.BetweenAttributes;
                                    }
                                    else
                                    {
                                        this._state = HtmlDocument.ParseState.BetweenAttributes;
                                    }
                                }
                                break;
                            case HtmlDocument.ParseState.AttributeName:
                                if (!this.NewCheck())
                                {
                                    if (HtmlDocument.IsWhiteSpace(this._c))
                                    {
                                        this.PushAttributeNameEnd(this._index - 1);
                                        this._state = HtmlDocument.ParseState.AttributeBeforeEquals;
                                    }
                                    else if (this._c == 61)
                                    {
                                        this.PushAttributeNameEnd(this._index - 1);
                                        this._state = HtmlDocument.ParseState.AttributeAfterEquals;
                                    }
                                    else if (this._c == 62)
                                    {
                                        this.PushAttributeNameEnd(this._index - 1);
                                        if (!this.PushNodeEnd(this._index, false))
                                        {
                                            this._index = this.Text.Length;
                                        }
                                        else if (this._state == HtmlDocument.ParseState.AttributeName)
                                        {
                                            this._state = HtmlDocument.ParseState.Text;
                                            this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                        }
                                    }
                                }
                                break;
                            case HtmlDocument.ParseState.AttributeBeforeEquals:
                                if (!this.NewCheck() && !HtmlDocument.IsWhiteSpace(this._c))
                                {
                                    if (this._c == 62)
                                    {
                                        if (!this.PushNodeEnd(this._index, false))
                                        {
                                            this._index = this.Text.Length;
                                        }
                                        else if (this._state == HtmlDocument.ParseState.AttributeBeforeEquals)
                                        {
                                            this._state = HtmlDocument.ParseState.Text;
                                            this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                        }
                                    }
                                    else if (this._c == 61)
                                    {
                                        this._state = HtmlDocument.ParseState.AttributeAfterEquals;
                                    }
                                    else
                                    {
                                        this._state = HtmlDocument.ParseState.BetweenAttributes;
                                        this.DecrementPosition();
                                    }
                                }
                                break;
                            case HtmlDocument.ParseState.AttributeAfterEquals:
                                if (!this.NewCheck() && !HtmlDocument.IsWhiteSpace(this._c))
                                {
                                    if (this._c == 39 || this._c == 34)
                                    {
                                        this._state = HtmlDocument.ParseState.QuotedAttributeValue;
                                        this.PushAttributeValueStart(this._index, this._c);
                                        num = this._c;
                                    }
                                    else if (this._c == 62)
                                    {
                                        if (!this.PushNodeEnd(this._index, false))
                                        {
                                            this._index = this.Text.Length;
                                        }
                                        else if (this._state == HtmlDocument.ParseState.AttributeAfterEquals)
                                        {
                                            this._state = HtmlDocument.ParseState.Text;
                                            this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                        }
                                    }
                                    else
                                    {
                                        this.PushAttributeValueStart(this._index - 1);
                                        this._state = HtmlDocument.ParseState.AttributeValue;
                                    }
                                }
                                break;
                            case HtmlDocument.ParseState.AttributeValue:
                                if (!this.NewCheck())
                                {
                                    if (HtmlDocument.IsWhiteSpace(this._c))
                                    {
                                        this.PushAttributeValueEnd(this._index - 1);
                                        this._state = HtmlDocument.ParseState.BetweenAttributes;
                                    }
                                    else if (this._c == 62)
                                    {
                                        this.PushAttributeValueEnd(this._index - 1);
                                        if (!this.PushNodeEnd(this._index, false))
                                        {
                                            this._index = this.Text.Length;
                                        }
                                        else if (this._state == HtmlDocument.ParseState.AttributeValue)
                                        {
                                            this._state = HtmlDocument.ParseState.Text;
                                            this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                        }
                                    }
                                }
                                break;
                            case HtmlDocument.ParseState.Comment:
                                if (this._c == 62 && (!this._fullcomment || (this.Text[this._index - 2] == '-' && this.Text[this._index - 3] == '-') || (this.Text[this._index - 2] == '!' && this.Text[this._index - 3] == '-' && this.Text[this._index - 4] == '-')))
                                {
                                    if (!this.PushNodeEnd(this._index, false))
                                    {
                                        this._index = this.Text.Length;
                                    }
                                    else
                                    {
                                        this._state = HtmlDocument.ParseState.Text;
                                        this.PushNodeStart(HtmlNodeType.Text, this._index, this._lineposition);
                                    }
                                }
                                break;
                            case HtmlDocument.ParseState.QuotedAttributeValue:
                                if (this._c == num)
                                {
                                    this.PushAttributeValueEnd(this._index - 1);
                                    this._state = HtmlDocument.ParseState.BetweenAttributes;
                                }
                                else if (this._c == 60 && this._index < this.Text.Length && this.Text[this._index] == '%')
                                {
                                    this._oldstate = this._state;
                                    this._state = HtmlDocument.ParseState.ServerSideCode;
                                }
                                break;
                            case HtmlDocument.ParseState.ServerSideCode:
                                if (this._c == 37)
                                {
                                    if (this._index < this.Text.Length && this.Text[this._index] == '>')
                                    {
                                        HtmlDocument.ParseState oldstate = this._oldstate;
                                        if (oldstate != HtmlDocument.ParseState.BetweenAttributes)
                                        {
                                            if (oldstate == HtmlDocument.ParseState.AttributeAfterEquals)
                                            {
                                                this._state = HtmlDocument.ParseState.AttributeValue;
                                            }
                                            else
                                            {
                                                this._state = this._oldstate;
                                            }
                                        }
                                        else
                                        {
                                            this.PushAttributeNameEnd(this._index + 1);
                                            this._state = HtmlDocument.ParseState.BetweenAttributes;
                                        }
                                        this.IncrementPosition();
                                    }
                                }
                                else if (this._oldstate == HtmlDocument.ParseState.QuotedAttributeValue && this._c == num)
                                {
                                    this._state = this._oldstate;
                                    this.DecrementPosition();
                                }
                                break;
                            case HtmlDocument.ParseState.PcData:
                                if (this._currentnode._namelength + 3 <= this.Text.Length - (this._index - 1) && string.Compare(this.Text.Substring(this._index - 1, this._currentnode._namelength + 2), "</" + this._currentnode.Name, StringComparison.OrdinalIgnoreCase) == 0)
                                {
                                    int num2 = (int)this.Text[this._index - 1 + 2 + this._currentnode.Name.Length];
                                    if (num2 == 62 || HtmlDocument.IsWhiteSpace(num2))
                                    {
                                        HtmlNode htmlNode = this.CreateNode(HtmlNodeType.Text, this._currentnode._outerstartindex + this._currentnode._outerlength);
                                        htmlNode._outerlength = this._index - 1 - htmlNode._outerstartindex;
                                        htmlNode._streamposition = htmlNode._outerstartindex;
                                        htmlNode._line = this._currentnode.Line;
                                        htmlNode._lineposition = this._currentnode.LinePosition + this._currentnode._namelength + 2;
                                        this._currentnode.AppendChild(htmlNode);
                                        this.PushNodeStart(HtmlNodeType.Element, this._index - 1, this._lineposition - 1);
                                        this.PushNodeNameStart(false, this._index - 1 + 2);
                                        this._state = HtmlDocument.ParseState.Tag;
                                        this.IncrementPosition();
                                    }
                                }
                                break;
                        }
                    }
                    if (this._currentnode._namestartindex > 0)
                    {
                        this.PushNodeNameEnd(this._index);
                    }
                    this.PushNodeEnd(this._index, false);
                    this.Lastnodes.Clear();
                }
                private void PushAttributeNameEnd(int index)
                {
                    this._currentattribute._namelength = index - this._currentattribute._namestartindex;
                    if (this._currentattribute.Name != null && !HtmlDocument.BlockAttributes.Contains(this._currentattribute.Name))
                    {
                        this._currentnode.Attributes.Append(this._currentattribute);
                    }
                }
                private void PushAttributeNameStart(int index, int lineposition)
                {
                    this._currentattribute = this.CreateAttribute();
                    this._currentattribute._namestartindex = index;
                    this._currentattribute.Line = this._line;
                    this._currentattribute._lineposition = lineposition;
                    this._currentattribute._streamposition = index;
                }
                private void PushAttributeValueEnd(int index)
                {
                    this._currentattribute._valuelength = index - this._currentattribute._valuestartindex;
                }
                private void PushAttributeValueStart(int index)
                {
                    this.PushAttributeValueStart(index, 0);
                }
                private void CloseParentImplicitExplicitNode()
                {
                    bool flag = true;
                    while (flag && !this._lastparentnode.Closed)
                    {
                        flag = false;
                        bool flag2 = false;
                        if (this.IsParentImplicitEnd())
                        {
                            if (this.OptionOutputAsXml)
                            {
                                flag2 = true;
                            }
                            else
                            {
                                this.CloseParentImplicitEnd();
                                flag = true;
                            }
                        }
                        if (flag2 || this.IsParentExplicitEnd())
                        {
                            this.CloseParentExplicitEnd();
                            flag = true;
                        }
                    }
                }
                private bool IsParentImplicitEnd()
                {
                    if (!this._currentnode._starttag)
                    {
                        return false;
                    }
                    bool result = false;
                    string name = this._lastparentnode.Name;
                    string a = this.Text.Substring(this._currentnode._namestartindex, this._index - this._currentnode._namestartindex - 1).ToLowerInvariant();
                    if (!(name == "a"))
                    {
                        if (!(name == "dd"))
                        {
                            if (!(name == "dt"))
                            {
                                if (!(name == "li"))
                                {
                                    if (!(name == "p"))
                                    {
                                        if (name == "option")
                                        {
                                            result = (a == "option");
                                        }
                                    }
                                    else if (HtmlDocument.DisableBehaviorTagP)
                                    {
                                        result = (a == "address" || a == "article" || a == "aside" || a == "blockquote" || a == "dir" || a == "div" || a == "dl" || a == "fieldset" || a == "footer" || a == "form" || a == "h1" || a == "h2" || a == "h3" || a == "h4" || a == "h5" || a == "h6" || a == "header" || a == "hr" || a == "menu" || a == "nav" || a == "ol" || a == "p" || a == "pre" || a == "section" || a == "table" || a == "ul");
                                    }
                                    else
                                    {
                                        result = (a == "p");
                                    }
                                }
                                else
                                {
                                    result = (a == "li");
                                }
                            }
                            else
                            {
                                result = (a == "dt" || a == "dd");
                            }
                        }
                        else
                        {
                            result = (a == "dt" || a == "dd");
                        }
                    }
                    else
                    {
                        result = (a == "a");
                    }
                    return result;
                }
                private bool IsParentExplicitEnd()
                {
                    if (!this._currentnode._starttag)
                    {
                        return false;
                    }
                    bool result = false;
                    string name = this._lastparentnode.Name;
                    string a = this.Text.Substring(this._currentnode._namestartindex, this._index - this._currentnode._namestartindex - 1).ToLowerInvariant();
                    uint num = PrivateImplementationDetails.ComputeStringHash(name);
                    if (num <= 2352688966u)
                    {
                        if (num <= 1095059089u)
                        {
                            if (num != 1027948613u)
                            {
                                if (num == 1095059089u)
                                {
                                    if (name == "th")
                                    {
                                        result = (a == "td" || a == "th" || a == "tr");
                                    }
                                }
                            }
                            else if (name == "td")
                            {
                                result = (a == "td" || a == "th" || a == "tr");
                            }
                        }
                        else if (num != 1195724803u)
                        {
                            if (num != 1251777503u)
                            {
                                if (num == 2352688966u)
                                {
                                    if (name == "h5")
                                    {
                                        result = (a == "h1" || a == "h2" || a == "h3" || a == "h4");
                                    }
                                }
                            }
                            else if (name == "table")
                            {
                                result = (a == "table");
                            }
                        }
                        else if (name == "tr")
                        {
                            result = (a == "tr");
                        }
                    }
                    else if (num <= 2403021823u)
                    {
                        if (num != 2369466585u)
                        {
                            if (num != 2386244204u)
                            {
                                if (num == 2403021823u)
                                {
                                    if (name == "h2")
                                    {
                                        result = (a == "h1" || a == "h3" || a == "h4" || a == "h5");
                                    }
                                }
                            }
                            else if (name == "h3")
                            {
                                result = (a == "h1" || a == "h2" || a == "h4" || a == "h5");
                            }
                        }
                        else if (name == "h4")
                        {
                            result = (a == "h1" || a == "h2" || a == "h3" || a == "h5");
                        }
                    }
                    else if (num != 2419799442u)
                    {
                        if (num != 2556802313u)
                        {
                            if (num == 4111221743u)
                            {
                                if (name == "p")
                                {
                                    result = (a == "div");
                                }
                            }
                        }
                        else if (name == "title")
                        {
                            result = (a == "title");
                        }
                    }
                    else if (name == "h1")
                    {
                        result = (a == "h2" || a == "h3" || a == "h4" || a == "h5");
                    }
                    return result;
                }
                private void CloseParentImplicitEnd()
                {
                    HtmlNode htmlNode = new HtmlNode(this._lastparentnode.NodeType, this, -1);
                    htmlNode._endnode = htmlNode;
                    htmlNode._isImplicitEnd = true;
                    this._lastparentnode._isImplicitEnd = true;
                    this._lastparentnode.CloseNode(htmlNode, 0);
                }
                private void CloseParentExplicitEnd()
                {
                    HtmlNode htmlNode = new HtmlNode(this._lastparentnode.NodeType, this, -1);
                    htmlNode._endnode = htmlNode;
                    this._lastparentnode.CloseNode(htmlNode, 0);
                }
                private void PushAttributeValueStart(int index, int quote)
                {
                    this._currentattribute._valuestartindex = index;
                    if (quote == 39)
                    {
                        this._currentattribute.QuoteType = AttributeValueQuote.SingleQuote;
                    }
                }
                private bool PushNodeEnd(int index, bool close)
                {
                    this._currentnode._outerlength = index - this._currentnode._outerstartindex;
                    if (this._currentnode._nodetype == HtmlNodeType.Text || this._currentnode._nodetype == HtmlNodeType.Comment)
                    {
                        if (this._currentnode._outerlength > 0)
                        {
                            this._currentnode._innerlength = this._currentnode._outerlength;
                            this._currentnode._innerstartindex = this._currentnode._outerstartindex;
                            if (this._lastparentnode != null)
                            {
                                this._lastparentnode.AppendChild(this._currentnode);
                            }
                        }
                    }
                    else if (this._currentnode._starttag && this._lastparentnode != this._currentnode)
                    {
                        if (this._lastparentnode != null)
                        {
                            this._lastparentnode.AppendChild(this._currentnode);
                        }
                        this.ReadDocumentEncoding(this._currentnode);
                        HtmlNode dictionaryValueOrDefault = Utilities.GetDictionaryValueOrDefault<string, HtmlNode>(this.Lastnodes, this._currentnode.Name, null);
                        this._currentnode._prevwithsamename = dictionaryValueOrDefault;
                        this.Lastnodes[this._currentnode.Name] = this._currentnode;
                        if (this._currentnode.NodeType == HtmlNodeType.Document || this._currentnode.NodeType == HtmlNodeType.Element)
                        {
                            this._lastparentnode = this._currentnode;
                        }
                        if (HtmlNode.IsCDataElement(this.CurrentNodeName()))
                        {
                            this._state = HtmlDocument.ParseState.PcData;
                            return true;
                        }
                        if (HtmlNode.IsClosedElement(this._currentnode.Name) || HtmlNode.IsEmptyElement(this._currentnode.Name))
                        {
                            close = true;
                        }
                    }
                    if (close || !this._currentnode._starttag)
                    {
                        if (this.OptionStopperNodeName != null && this._remainder == null && string.Compare(this._currentnode.Name, this.OptionStopperNodeName, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            this._remainderOffset = index;
                            this._remainder = this.Text.Substring(this._remainderOffset);
                            this.CloseCurrentNode();
                            return false;
                        }
                        this.CloseCurrentNode();
                    }
                    return true;
                }
                private void PushNodeNameEnd(int index)
                {
                    this._currentnode._namelength = index - this._currentnode._namestartindex;
                    if (this.OptionFixNestedTags)
                    {
                        this.FixNestedTags();
                    }
                }
                private void PushNodeNameStart(bool starttag, int index)
                {
                    this._currentnode._starttag = starttag;
                    this._currentnode._namestartindex = index;
                }
                private void PushNodeStart(HtmlNodeType type, int index, int lineposition)
                {
                    this._currentnode = this.CreateNode(type, index);
                    this._currentnode._line = this._line;
                    this._currentnode._lineposition = lineposition;
                    this._currentnode._streamposition = index;
                }
                private void ReadDocumentEncoding(HtmlNode node)
                {
                    if (!this.OptionReadEncoding)
                    {
                        return;
                    }
                    if (node._namelength != 4)
                    {
                        return;
                    }
                    if (node.Name != "meta")
                    {
                        return;
                    }
                    string text = null;
                    HtmlAttribute htmlAttribute = node.Attributes["http-equiv"];
                    if (htmlAttribute != null)
                    {
                        if (string.Compare(htmlAttribute.Value, "content-type", StringComparison.OrdinalIgnoreCase) != 0)
                        {
                            return;
                        }
                        HtmlAttribute htmlAttribute2 = node.Attributes["content"];
                        if (htmlAttribute2 != null)
                        {
                            text = NameValuePairList.GetNameValuePairsValue(htmlAttribute2.Value, "charset");
                        }
                    }
                    else
                    {
                        htmlAttribute = node.Attributes["charset"];
                        if (htmlAttribute != null)
                        {
                            text = htmlAttribute.Value;
                        }
                    }
                    if (!string.IsNullOrEmpty(text))
                    {
                        if (string.Equals(text, "utf8", StringComparison.OrdinalIgnoreCase))
                        {
                            text = "utf-8";
                        }
                        try
                        {
                            this._declaredencoding = Encoding.GetEncoding(text);
                        }
                        catch (ArgumentException)
                        {
                            this._declaredencoding = null;
                        }
                        if (this._onlyDetectEncoding)
                        {
                            throw new EncodingFoundException(this._declaredencoding);
                        }
                        if (this._streamencoding != null && this._declaredencoding != null && this._declaredencoding.CodePage != this._streamencoding.CodePage)
                        {
                            this.AddError(HtmlParseErrorCode.CharsetMismatch, this._line, this._lineposition, this._index, node.OuterHtml, "Encoding mismatch between StreamEncoding: " + this._streamencoding.WebName + " and DeclaredEncoding: " + this._declaredencoding.WebName);
                        }
                    }
                }
                public void DetectEncodingAndLoad(string path)
                {
                    this.DetectEncodingAndLoad(path, true);
                }
                public void DetectEncodingAndLoad(string path, bool detectEncoding)
                {
                    if (path == null)
                    {
                        throw new ArgumentNullException("path");
                    }
                    Encoding encoding;
                    if (detectEncoding)
                    {
                        encoding = this.DetectEncoding(path);
                    }
                    else
                    {
                        encoding = null;
                    }
                    if (encoding == null)
                    {
                        this.Load(path);
                        return;
                    }
                    this.Load(path, encoding);
                }
                public Encoding DetectEncoding(string path)
                {
                    if (path == null)
                    {
                        throw new ArgumentNullException("path");
                    }
                    Encoding result;
                    using (System.IO.StreamReader streamReader = new System.IO.StreamReader(path, this.OptionDefaultStreamEncoding))
                    {
                        result = this.DetectEncoding(streamReader);
                    }
                    return result;
                }
                public void Load(string path)
                {
                    if (path == null)
                    {
                        throw new ArgumentNullException("path");
                    }
                    using (System.IO.StreamReader streamReader = new System.IO.StreamReader(path, this.OptionDefaultStreamEncoding))
                    {
                        this.Load(streamReader);
                    }
                }
                public void Load(string path, bool detectEncodingFromByteOrderMarks)
                {
                    if (path == null)
                    {
                        throw new ArgumentNullException("path");
                    }
                    using (System.IO.StreamReader streamReader = new System.IO.StreamReader(path, detectEncodingFromByteOrderMarks))
                    {
                        this.Load(streamReader);
                    }
                }
                public void Load(string path, Encoding encoding)
                {
                    if (path == null)
                    {
                        throw new ArgumentNullException("path");
                    }
                    if (encoding == null)
                    {
                        throw new ArgumentNullException("encoding");
                    }
                    using (System.IO.StreamReader streamReader = new System.IO.StreamReader(path, encoding))
                    {
                        this.Load(streamReader);
                    }
                }
                public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
                {
                    if (path == null)
                    {
                        throw new ArgumentNullException("path");
                    }
                    if (encoding == null)
                    {
                        throw new ArgumentNullException("encoding");
                    }
                    using (System.IO.StreamReader streamReader = new System.IO.StreamReader(path, encoding, detectEncodingFromByteOrderMarks))
                    {
                        this.Load(streamReader);
                    }
                }
                public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
                {
                    if (path == null)
                    {
                        throw new ArgumentNullException("path");
                    }
                    if (encoding == null)
                    {
                        throw new ArgumentNullException("encoding");
                    }
                    using (System.IO.StreamReader streamReader = new System.IO.StreamReader(path, encoding, detectEncodingFromByteOrderMarks, buffersize))
                    {
                        this.Load(streamReader);
                    }
                }
                public void Save(string filename)
                {
                    using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filename, false, this.GetOutEncoding()))
                    {
                        this.Save(streamWriter);
                    }
                }
                public void Save(string filename, Encoding encoding)
                {
                    if (filename == null)
                    {
                        throw new ArgumentNullException("filename");
                    }
                    if (encoding == null)
                    {
                        throw new ArgumentNullException("encoding");
                    }
                    using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filename, false, encoding))
                    {
                        this.Save(streamWriter);
                    }
                }
                public XPathNavigator CreateNavigator()
                {
                    return new HtmlNodeNavigator(this, this._documentnode);
                }
                internal static bool _disableBehaviorTagP = true;
                private static int _maxDepthLevel = int.MaxValue;
                private int _c;
                private Crc32 _crc32;
                private HtmlAttribute _currentattribute;
                private HtmlNode _currentnode;
                private Encoding _declaredencoding;
                private HtmlNode _documentnode;
                private bool _fullcomment;
                private int _index;
                internal Dictionary<string, HtmlNode> Lastnodes = new Dictionary<string, HtmlNode>();
                private HtmlNode _lastparentnode;
                private int _line;
                private int _lineposition;
                private int _maxlineposition;
                internal Dictionary<string, HtmlNode> Nodesid;
                private HtmlDocument.ParseState _oldstate;
                private bool _onlyDetectEncoding;
                internal Dictionary<int, HtmlNode> Openednodes;
                private List<HtmlParseError> _parseerrors = new List<HtmlParseError>();
                private string _remainder;
                private int _remainderOffset;
                private HtmlDocument.ParseState _state;
                private Encoding _streamencoding;
                private bool _useHtmlEncodingForStream;
                public string Text;
                public bool BackwardCompatibility = true;
                public bool OptionAddDebuggingAttributes;
                public bool OptionAutoCloseOnEnd;
                public bool OptionCheckSyntax = true;
                public bool OptionComputeChecksum;
                public bool OptionEmptyCollection;
                public bool DisableServerSideCode;
                public Encoding OptionDefaultStreamEncoding;
                public bool OptionExtractErrorSourceText;
                public int OptionExtractErrorSourceTextMaxLength = 100;
                public bool OptionFixNestedTags;
                public bool OptionOutputAsXml;
                public bool OptionPreserveXmlNamespaces;
                public bool OptionOutputOptimizeAttributeValues;
                public bool OptionOutputOriginalCase;
                public bool OptionOutputUpperCase;
                public bool OptionReadEncoding = true;
                public string OptionStopperNodeName;
                public bool OptionUseIdAttribute = true;
                public bool OptionWriteEmptyNodes;
                public int OptionMaxNestedChildNodes;
                internal static readonly string HtmlExceptionRefNotChild = "Reference node must be a child of this node";
                internal static readonly string HtmlExceptionUseIdAttributeFalse = "You need to set UseIdAttribute property to true to enable this feature";
                internal static readonly string HtmlExceptionClassDoesNotExist = "Class name doesn't exist";
                internal static readonly string HtmlExceptionClassExists = "Class name already exists";
                internal static readonly Dictionary<string, string[]> HtmlResetters = new Dictionary<string, string[]>
        {
            {
                "li",
                new string[]
                {
                    "ul",
                    "ol"
                }
            },
            {
                "tr",
                new string[]
                {
                    "table"
                }
            },
            {
                "th",
                new string[]
                {
                    "tr",
                    "table"
                }
            },
            {
                "td",
                new string[]
                {
                    "tr",
                    "table"
                }
            }
        };
                private static List<string> BlockAttributes = new List<string>
        {
            "\"",
            "'"
        };
                private enum ParseState
                {
                    Text,
                    WhichTag,
                    Tag,
                    BetweenAttributes,
                    EmptyTag,
                    AttributeName,
                    AttributeBeforeEquals,
                    AttributeAfterEquals,
                    AttributeValue,
                    Comment,
                    QuotedAttributeValue,
                    ServerSideCode,
                    PcData
                }
            }
            [Flags]
            public enum HtmlElementFlag
            {
                CData = 1,
                Empty = 2,
                Closed = 4,
                CanOverlap = 8
            }
            public class HtmlEntity
            {
                public static Dictionary<int, string> EntityName
                {
                    get
                    {
                        return HtmlEntity._entityName;
                    }
                }
                public static Dictionary<string, int> EntityValue
                {
                    get
                    {
                        return HtmlEntity._entityValue;
                    }
                }
                static HtmlEntity()
                {
                    HtmlEntity._entityValue.Add("quot", 34);
                    HtmlEntity._entityName.Add(34, "quot");
                    HtmlEntity._entityValue.Add("amp", 38);
                    HtmlEntity._entityName.Add(38, "amp");
                    HtmlEntity._entityValue.Add("apos", 39);
                    HtmlEntity._entityName.Add(39, "apos");
                    HtmlEntity._entityValue.Add("lt", 60);
                    HtmlEntity._entityName.Add(60, "lt");
                    HtmlEntity._entityValue.Add("gt", 62);
                    HtmlEntity._entityName.Add(62, "gt");
                    HtmlEntity._entityValue.Add("nbsp", 160);
                    HtmlEntity._entityName.Add(160, "nbsp");
                    HtmlEntity._entityValue.Add("iexcl", 161);
                    HtmlEntity._entityName.Add(161, "iexcl");
                    HtmlEntity._entityValue.Add("cent", 162);
                    HtmlEntity._entityName.Add(162, "cent");
                    HtmlEntity._entityValue.Add("pound", 163);
                    HtmlEntity._entityName.Add(163, "pound");
                    HtmlEntity._entityValue.Add("curren", 164);
                    HtmlEntity._entityName.Add(164, "curren");
                    HtmlEntity._entityValue.Add("yen", 165);
                    HtmlEntity._entityName.Add(165, "yen");
                    HtmlEntity._entityValue.Add("brvbar", 166);
                    HtmlEntity._entityName.Add(166, "brvbar");
                    HtmlEntity._entityValue.Add("sect", 167);
                    HtmlEntity._entityName.Add(167, "sect");
                    HtmlEntity._entityValue.Add("uml", 168);
                    HtmlEntity._entityName.Add(168, "uml");
                    HtmlEntity._entityValue.Add("copy", 169);
                    HtmlEntity._entityName.Add(169, "copy");
                    HtmlEntity._entityValue.Add("ordf", 170);
                    HtmlEntity._entityName.Add(170, "ordf");
                    HtmlEntity._entityValue.Add("laquo", 171);
                    HtmlEntity._entityName.Add(171, "laquo");
                    HtmlEntity._entityValue.Add("not", 172);
                    HtmlEntity._entityName.Add(172, "not");
                    HtmlEntity._entityValue.Add("shy", 173);
                    HtmlEntity._entityName.Add(173, "shy");
                    HtmlEntity._entityValue.Add("reg", 174);
                    HtmlEntity._entityName.Add(174, "reg");
                    HtmlEntity._entityValue.Add("macr", 175);
                    HtmlEntity._entityName.Add(175, "macr");
                    HtmlEntity._entityValue.Add("deg", 176);
                    HtmlEntity._entityName.Add(176, "deg");
                    HtmlEntity._entityValue.Add("plusmn", 177);
                    HtmlEntity._entityName.Add(177, "plusmn");
                    HtmlEntity._entityValue.Add("sup2", 178);
                    HtmlEntity._entityName.Add(178, "sup2");
                    HtmlEntity._entityValue.Add("sup3", 179);
                    HtmlEntity._entityName.Add(179, "sup3");
                    HtmlEntity._entityValue.Add("acute", 180);
                    HtmlEntity._entityName.Add(180, "acute");
                    HtmlEntity._entityValue.Add("micro", 181);
                    HtmlEntity._entityName.Add(181, "micro");
                    HtmlEntity._entityValue.Add("para", 182);
                    HtmlEntity._entityName.Add(182, "para");
                    HtmlEntity._entityValue.Add("middot", 183);
                    HtmlEntity._entityName.Add(183, "middot");
                    HtmlEntity._entityValue.Add("cedil", 184);
                    HtmlEntity._entityName.Add(184, "cedil");
                    HtmlEntity._entityValue.Add("sup1", 185);
                    HtmlEntity._entityName.Add(185, "sup1");
                    HtmlEntity._entityValue.Add("ordm", 186);
                    HtmlEntity._entityName.Add(186, "ordm");
                    HtmlEntity._entityValue.Add("raquo", 187);
                    HtmlEntity._entityName.Add(187, "raquo");
                    HtmlEntity._entityValue.Add("frac14", 188);
                    HtmlEntity._entityName.Add(188, "frac14");
                    HtmlEntity._entityValue.Add("frac12", 189);
                    HtmlEntity._entityName.Add(189, "frac12");
                    HtmlEntity._entityValue.Add("frac34", 190);
                    HtmlEntity._entityName.Add(190, "frac34");
                    HtmlEntity._entityValue.Add("iquest", 191);
                    HtmlEntity._entityName.Add(191, "iquest");
                    HtmlEntity._entityValue.Add("Agrave", 192);
                    HtmlEntity._entityName.Add(192, "Agrave");
                    HtmlEntity._entityValue.Add("Aacute", 193);
                    HtmlEntity._entityName.Add(193, "Aacute");
                    HtmlEntity._entityValue.Add("Acirc", 194);
                    HtmlEntity._entityName.Add(194, "Acirc");
                    HtmlEntity._entityValue.Add("Atilde", 195);
                    HtmlEntity._entityName.Add(195, "Atilde");
                    HtmlEntity._entityValue.Add("Auml", 196);
                    HtmlEntity._entityName.Add(196, "Auml");
                    HtmlEntity._entityValue.Add("Aring", 197);
                    HtmlEntity._entityName.Add(197, "Aring");
                    HtmlEntity._entityValue.Add("AElig", 198);
                    HtmlEntity._entityName.Add(198, "AElig");
                    HtmlEntity._entityValue.Add("Ccedil", 199);
                    HtmlEntity._entityName.Add(199, "Ccedil");
                    HtmlEntity._entityValue.Add("Egrave", 200);
                    HtmlEntity._entityName.Add(200, "Egrave");
                    HtmlEntity._entityValue.Add("Eacute", 201);
                    HtmlEntity._entityName.Add(201, "Eacute");
                    HtmlEntity._entityValue.Add("Ecirc", 202);
                    HtmlEntity._entityName.Add(202, "Ecirc");
                    HtmlEntity._entityValue.Add("Euml", 203);
                    HtmlEntity._entityName.Add(203, "Euml");
                    HtmlEntity._entityValue.Add("Igrave", 204);
                    HtmlEntity._entityName.Add(204, "Igrave");
                    HtmlEntity._entityValue.Add("Iacute", 205);
                    HtmlEntity._entityName.Add(205, "Iacute");
                    HtmlEntity._entityValue.Add("Icirc", 206);
                    HtmlEntity._entityName.Add(206, "Icirc");
                    HtmlEntity._entityValue.Add("Iuml", 207);
                    HtmlEntity._entityName.Add(207, "Iuml");
                    HtmlEntity._entityValue.Add("ETH", 208);
                    HtmlEntity._entityName.Add(208, "ETH");
                    HtmlEntity._entityValue.Add("Ntilde", 209);
                    HtmlEntity._entityName.Add(209, "Ntilde");
                    HtmlEntity._entityValue.Add("Ograve", 210);
                    HtmlEntity._entityName.Add(210, "Ograve");
                    HtmlEntity._entityValue.Add("Oacute", 211);
                    HtmlEntity._entityName.Add(211, "Oacute");
                    HtmlEntity._entityValue.Add("Ocirc", 212);
                    HtmlEntity._entityName.Add(212, "Ocirc");
                    HtmlEntity._entityValue.Add("Otilde", 213);
                    HtmlEntity._entityName.Add(213, "Otilde");
                    HtmlEntity._entityValue.Add("Ouml", 214);
                    HtmlEntity._entityName.Add(214, "Ouml");
                    HtmlEntity._entityValue.Add("times", 215);
                    HtmlEntity._entityName.Add(215, "times");
                    HtmlEntity._entityValue.Add("Oslash", 216);
                    HtmlEntity._entityName.Add(216, "Oslash");
                    HtmlEntity._entityValue.Add("Ugrave", 217);
                    HtmlEntity._entityName.Add(217, "Ugrave");
                    HtmlEntity._entityValue.Add("Uacute", 218);
                    HtmlEntity._entityName.Add(218, "Uacute");
                    HtmlEntity._entityValue.Add("Ucirc", 219);
                    HtmlEntity._entityName.Add(219, "Ucirc");
                    HtmlEntity._entityValue.Add("Uuml", 220);
                    HtmlEntity._entityName.Add(220, "Uuml");
                    HtmlEntity._entityValue.Add("Yacute", 221);
                    HtmlEntity._entityName.Add(221, "Yacute");
                    HtmlEntity._entityValue.Add("THORN", 222);
                    HtmlEntity._entityName.Add(222, "THORN");
                    HtmlEntity._entityValue.Add("szlig", 223);
                    HtmlEntity._entityName.Add(223, "szlig");
                    HtmlEntity._entityValue.Add("agrave", 224);
                    HtmlEntity._entityName.Add(224, "agrave");
                    HtmlEntity._entityValue.Add("aacute", 225);
                    HtmlEntity._entityName.Add(225, "aacute");
                    HtmlEntity._entityValue.Add("acirc", 226);
                    HtmlEntity._entityName.Add(226, "acirc");
                    HtmlEntity._entityValue.Add("atilde", 227);
                    HtmlEntity._entityName.Add(227, "atilde");
                    HtmlEntity._entityValue.Add("auml", 228);
                    HtmlEntity._entityName.Add(228, "auml");
                    HtmlEntity._entityValue.Add("aring", 229);
                    HtmlEntity._entityName.Add(229, "aring");
                    HtmlEntity._entityValue.Add("aelig", 230);
                    HtmlEntity._entityName.Add(230, "aelig");
                    HtmlEntity._entityValue.Add("ccedil", 231);
                    HtmlEntity._entityName.Add(231, "ccedil");
                    HtmlEntity._entityValue.Add("egrave", 232);
                    HtmlEntity._entityName.Add(232, "egrave");
                    HtmlEntity._entityValue.Add("eacute", 233);
                    HtmlEntity._entityName.Add(233, "eacute");
                    HtmlEntity._entityValue.Add("ecirc", 234);
                    HtmlEntity._entityName.Add(234, "ecirc");
                    HtmlEntity._entityValue.Add("euml", 235);
                    HtmlEntity._entityName.Add(235, "euml");
                    HtmlEntity._entityValue.Add("igrave", 236);
                    HtmlEntity._entityName.Add(236, "igrave");
                    HtmlEntity._entityValue.Add("iacute", 237);
                    HtmlEntity._entityName.Add(237, "iacute");
                    HtmlEntity._entityValue.Add("icirc", 238);
                    HtmlEntity._entityName.Add(238, "icirc");
                    HtmlEntity._entityValue.Add("iuml", 239);
                    HtmlEntity._entityName.Add(239, "iuml");
                    HtmlEntity._entityValue.Add("eth", 240);
                    HtmlEntity._entityName.Add(240, "eth");
                    HtmlEntity._entityValue.Add("ntilde", 241);
                    HtmlEntity._entityName.Add(241, "ntilde");
                    HtmlEntity._entityValue.Add("ograve", 242);
                    HtmlEntity._entityName.Add(242, "ograve");
                    HtmlEntity._entityValue.Add("oacute", 243);
                    HtmlEntity._entityName.Add(243, "oacute");
                    HtmlEntity._entityValue.Add("ocirc", 244);
                    HtmlEntity._entityName.Add(244, "ocirc");
                    HtmlEntity._entityValue.Add("otilde", 245);
                    HtmlEntity._entityName.Add(245, "otilde");
                    HtmlEntity._entityValue.Add("ouml", 246);
                    HtmlEntity._entityName.Add(246, "ouml");
                    HtmlEntity._entityValue.Add("divide", 247);
                    HtmlEntity._entityName.Add(247, "divide");
                    HtmlEntity._entityValue.Add("oslash", 248);
                    HtmlEntity._entityName.Add(248, "oslash");
                    HtmlEntity._entityValue.Add("ugrave", 249);
                    HtmlEntity._entityName.Add(249, "ugrave");
                    HtmlEntity._entityValue.Add("uacute", 250);
                    HtmlEntity._entityName.Add(250, "uacute");
                    HtmlEntity._entityValue.Add("ucirc", 251);
                    HtmlEntity._entityName.Add(251, "ucirc");
                    HtmlEntity._entityValue.Add("uuml", 252);
                    HtmlEntity._entityName.Add(252, "uuml");
                    HtmlEntity._entityValue.Add("yacute", 253);
                    HtmlEntity._entityName.Add(253, "yacute");
                    HtmlEntity._entityValue.Add("thorn", 254);
                    HtmlEntity._entityName.Add(254, "thorn");
                    HtmlEntity._entityValue.Add("yuml", 255);
                    HtmlEntity._entityName.Add(255, "yuml");
                    HtmlEntity._entityValue.Add("fnof", 402);
                    HtmlEntity._entityName.Add(402, "fnof");
                    HtmlEntity._entityValue.Add("Alpha", 913);
                    HtmlEntity._entityName.Add(913, "Alpha");
                    HtmlEntity._entityValue.Add("Beta", 914);
                    HtmlEntity._entityName.Add(914, "Beta");
                    HtmlEntity._entityValue.Add("Gamma", 915);
                    HtmlEntity._entityName.Add(915, "Gamma");
                    HtmlEntity._entityValue.Add("Delta", 916);
                    HtmlEntity._entityName.Add(916, "Delta");
                    HtmlEntity._entityValue.Add("Epsilon", 917);
                    HtmlEntity._entityName.Add(917, "Epsilon");
                    HtmlEntity._entityValue.Add("Zeta", 918);
                    HtmlEntity._entityName.Add(918, "Zeta");
                    HtmlEntity._entityValue.Add("Eta", 919);
                    HtmlEntity._entityName.Add(919, "Eta");
                    HtmlEntity._entityValue.Add("Theta", 920);
                    HtmlEntity._entityName.Add(920, "Theta");
                    HtmlEntity._entityValue.Add("Iota", 921);
                    HtmlEntity._entityName.Add(921, "Iota");
                    HtmlEntity._entityValue.Add("Kappa", 922);
                    HtmlEntity._entityName.Add(922, "Kappa");
                    HtmlEntity._entityValue.Add("Lambda", 923);
                    HtmlEntity._entityName.Add(923, "Lambda");
                    HtmlEntity._entityValue.Add("Mu", 924);
                    HtmlEntity._entityName.Add(924, "Mu");
                    HtmlEntity._entityValue.Add("Nu", 925);
                    HtmlEntity._entityName.Add(925, "Nu");
                    HtmlEntity._entityValue.Add("Xi", 926);
                    HtmlEntity._entityName.Add(926, "Xi");
                    HtmlEntity._entityValue.Add("Omicron", 927);
                    HtmlEntity._entityName.Add(927, "Omicron");
                    HtmlEntity._entityValue.Add("Pi", 928);
                    HtmlEntity._entityName.Add(928, "Pi");
                    HtmlEntity._entityValue.Add("Rho", 929);
                    HtmlEntity._entityName.Add(929, "Rho");
                    HtmlEntity._entityValue.Add("Sigma", 931);
                    HtmlEntity._entityName.Add(931, "Sigma");
                    HtmlEntity._entityValue.Add("Tau", 932);
                    HtmlEntity._entityName.Add(932, "Tau");
                    HtmlEntity._entityValue.Add("Upsilon", 933);
                    HtmlEntity._entityName.Add(933, "Upsilon");
                    HtmlEntity._entityValue.Add("Phi", 934);
                    HtmlEntity._entityName.Add(934, "Phi");
                    HtmlEntity._entityValue.Add("Chi", 935);
                    HtmlEntity._entityName.Add(935, "Chi");
                    HtmlEntity._entityValue.Add("Psi", 936);
                    HtmlEntity._entityName.Add(936, "Psi");
                    HtmlEntity._entityValue.Add("Omega", 937);
                    HtmlEntity._entityName.Add(937, "Omega");
                    HtmlEntity._entityValue.Add("alpha", 945);
                    HtmlEntity._entityName.Add(945, "alpha");
                    HtmlEntity._entityValue.Add("beta", 946);
                    HtmlEntity._entityName.Add(946, "beta");
                    HtmlEntity._entityValue.Add("gamma", 947);
                    HtmlEntity._entityName.Add(947, "gamma");
                    HtmlEntity._entityValue.Add("delta", 948);
                    HtmlEntity._entityName.Add(948, "delta");
                    HtmlEntity._entityValue.Add("epsilon", 949);
                    HtmlEntity._entityName.Add(949, "epsilon");
                    HtmlEntity._entityValue.Add("zeta", 950);
                    HtmlEntity._entityName.Add(950, "zeta");
                    HtmlEntity._entityValue.Add("eta", 951);
                    HtmlEntity._entityName.Add(951, "eta");
                    HtmlEntity._entityValue.Add("theta", 952);
                    HtmlEntity._entityName.Add(952, "theta");
                    HtmlEntity._entityValue.Add("iota", 953);
                    HtmlEntity._entityName.Add(953, "iota");
                    HtmlEntity._entityValue.Add("kappa", 954);
                    HtmlEntity._entityName.Add(954, "kappa");
                    HtmlEntity._entityValue.Add("lambda", 955);
                    HtmlEntity._entityName.Add(955, "lambda");
                    HtmlEntity._entityValue.Add("mu", 956);
                    HtmlEntity._entityName.Add(956, "mu");
                    HtmlEntity._entityValue.Add("nu", 957);
                    HtmlEntity._entityName.Add(957, "nu");
                    HtmlEntity._entityValue.Add("xi", 958);
                    HtmlEntity._entityName.Add(958, "xi");
                    HtmlEntity._entityValue.Add("omicron", 959);
                    HtmlEntity._entityName.Add(959, "omicron");
                    HtmlEntity._entityValue.Add("pi", 960);
                    HtmlEntity._entityName.Add(960, "pi");
                    HtmlEntity._entityValue.Add("rho", 961);
                    HtmlEntity._entityName.Add(961, "rho");
                    HtmlEntity._entityValue.Add("sigmaf", 962);
                    HtmlEntity._entityName.Add(962, "sigmaf");
                    HtmlEntity._entityValue.Add("sigma", 963);
                    HtmlEntity._entityName.Add(963, "sigma");
                    HtmlEntity._entityValue.Add("tau", 964);
                    HtmlEntity._entityName.Add(964, "tau");
                    HtmlEntity._entityValue.Add("upsilon", 965);
                    HtmlEntity._entityName.Add(965, "upsilon");
                    HtmlEntity._entityValue.Add("phi", 966);
                    HtmlEntity._entityName.Add(966, "phi");
                    HtmlEntity._entityValue.Add("chi", 967);
                    HtmlEntity._entityName.Add(967, "chi");
                    HtmlEntity._entityValue.Add("psi", 968);
                    HtmlEntity._entityName.Add(968, "psi");
                    HtmlEntity._entityValue.Add("omega", 969);
                    HtmlEntity._entityName.Add(969, "omega");
                    HtmlEntity._entityValue.Add("thetasym", 977);
                    HtmlEntity._entityName.Add(977, "thetasym");
                    HtmlEntity._entityValue.Add("upsih", 978);
                    HtmlEntity._entityName.Add(978, "upsih");
                    HtmlEntity._entityValue.Add("piv", 982);
                    HtmlEntity._entityName.Add(982, "piv");
                    HtmlEntity._entityValue.Add("bull", 8226);
                    HtmlEntity._entityName.Add(8226, "bull");
                    HtmlEntity._entityValue.Add("hellip", 8230);
                    HtmlEntity._entityName.Add(8230, "hellip");
                    HtmlEntity._entityValue.Add("prime", 8242);
                    HtmlEntity._entityName.Add(8242, "prime");
                    HtmlEntity._entityValue.Add("Prime", 8243);
                    HtmlEntity._entityName.Add(8243, "Prime");
                    HtmlEntity._entityValue.Add("oline", 8254);
                    HtmlEntity._entityName.Add(8254, "oline");
                    HtmlEntity._entityValue.Add("frasl", 8260);
                    HtmlEntity._entityName.Add(8260, "frasl");
                    HtmlEntity._entityValue.Add("weierp", 8472);
                    HtmlEntity._entityName.Add(8472, "weierp");
                    HtmlEntity._entityValue.Add("image", 8465);
                    HtmlEntity._entityName.Add(8465, "image");
                    HtmlEntity._entityValue.Add("real", 8476);
                    HtmlEntity._entityName.Add(8476, "real");
                    HtmlEntity._entityValue.Add("trade", 8482);
                    HtmlEntity._entityName.Add(8482, "trade");
                    HtmlEntity._entityValue.Add("alefsym", 8501);
                    HtmlEntity._entityName.Add(8501, "alefsym");
                    HtmlEntity._entityValue.Add("larr", 8592);
                    HtmlEntity._entityName.Add(8592, "larr");
                    HtmlEntity._entityValue.Add("uarr", 8593);
                    HtmlEntity._entityName.Add(8593, "uarr");
                    HtmlEntity._entityValue.Add("rarr", 8594);
                    HtmlEntity._entityName.Add(8594, "rarr");
                    HtmlEntity._entityValue.Add("darr", 8595);
                    HtmlEntity._entityName.Add(8595, "darr");
                    HtmlEntity._entityValue.Add("harr", 8596);
                    HtmlEntity._entityName.Add(8596, "harr");
                    HtmlEntity._entityValue.Add("crarr", 8629);
                    HtmlEntity._entityName.Add(8629, "crarr");
                    HtmlEntity._entityValue.Add("lArr", 8656);
                    HtmlEntity._entityName.Add(8656, "lArr");
                    HtmlEntity._entityValue.Add("uArr", 8657);
                    HtmlEntity._entityName.Add(8657, "uArr");
                    HtmlEntity._entityValue.Add("rArr", 8658);
                    HtmlEntity._entityName.Add(8658, "rArr");
                    HtmlEntity._entityValue.Add("dArr", 8659);
                    HtmlEntity._entityName.Add(8659, "dArr");
                    HtmlEntity._entityValue.Add("hArr", 8660);
                    HtmlEntity._entityName.Add(8660, "hArr");
                    HtmlEntity._entityValue.Add("forall", 8704);
                    HtmlEntity._entityName.Add(8704, "forall");
                    HtmlEntity._entityValue.Add("part", 8706);
                    HtmlEntity._entityName.Add(8706, "part");
                    HtmlEntity._entityValue.Add("exist", 8707);
                    HtmlEntity._entityName.Add(8707, "exist");
                    HtmlEntity._entityValue.Add("empty", 8709);
                    HtmlEntity._entityName.Add(8709, "empty");
                    HtmlEntity._entityValue.Add("nabla", 8711);
                    HtmlEntity._entityName.Add(8711, "nabla");
                    HtmlEntity._entityValue.Add("isin", 8712);
                    HtmlEntity._entityName.Add(8712, "isin");
                    HtmlEntity._entityValue.Add("notin", 8713);
                    HtmlEntity._entityName.Add(8713, "notin");
                    HtmlEntity._entityValue.Add("ni", 8715);
                    HtmlEntity._entityName.Add(8715, "ni");
                    HtmlEntity._entityValue.Add("prod", 8719);
                    HtmlEntity._entityName.Add(8719, "prod");
                    HtmlEntity._entityValue.Add("sum", 8721);
                    HtmlEntity._entityName.Add(8721, "sum");
                    HtmlEntity._entityValue.Add("minus", 8722);
                    HtmlEntity._entityName.Add(8722, "minus");
                    HtmlEntity._entityValue.Add("lowast", 8727);
                    HtmlEntity._entityName.Add(8727, "lowast");
                    HtmlEntity._entityValue.Add("radic", 8730);
                    HtmlEntity._entityName.Add(8730, "radic");
                    HtmlEntity._entityValue.Add("prop", 8733);
                    HtmlEntity._entityName.Add(8733, "prop");
                    HtmlEntity._entityValue.Add("infin", 8734);
                    HtmlEntity._entityName.Add(8734, "infin");
                    HtmlEntity._entityValue.Add("ang", 8736);
                    HtmlEntity._entityName.Add(8736, "ang");
                    HtmlEntity._entityValue.Add("and", 8743);
                    HtmlEntity._entityName.Add(8743, "and");
                    HtmlEntity._entityValue.Add("or", 8744);
                    HtmlEntity._entityName.Add(8744, "or");
                    HtmlEntity._entityValue.Add("cap", 8745);
                    HtmlEntity._entityName.Add(8745, "cap");
                    HtmlEntity._entityValue.Add("cup", 8746);
                    HtmlEntity._entityName.Add(8746, "cup");
                    HtmlEntity._entityValue.Add("int", 8747);
                    HtmlEntity._entityName.Add(8747, "int");
                    HtmlEntity._entityValue.Add("there4", 8756);
                    HtmlEntity._entityName.Add(8756, "there4");
                    HtmlEntity._entityValue.Add("sim", 8764);
                    HtmlEntity._entityName.Add(8764, "sim");
                    HtmlEntity._entityValue.Add("cong", 8773);
                    HtmlEntity._entityName.Add(8773, "cong");
                    HtmlEntity._entityValue.Add("asymp", 8776);
                    HtmlEntity._entityName.Add(8776, "asymp");
                    HtmlEntity._entityValue.Add("ne", 8800);
                    HtmlEntity._entityName.Add(8800, "ne");
                    HtmlEntity._entityValue.Add("equiv", 8801);
                    HtmlEntity._entityName.Add(8801, "equiv");
                    HtmlEntity._entityValue.Add("le", 8804);
                    HtmlEntity._entityName.Add(8804, "le");
                    HtmlEntity._entityValue.Add("ge", 8805);
                    HtmlEntity._entityName.Add(8805, "ge");
                    HtmlEntity._entityValue.Add("sub", 8834);
                    HtmlEntity._entityName.Add(8834, "sub");
                    HtmlEntity._entityValue.Add("sup", 8835);
                    HtmlEntity._entityName.Add(8835, "sup");
                    HtmlEntity._entityValue.Add("nsub", 8836);
                    HtmlEntity._entityName.Add(8836, "nsub");
                    HtmlEntity._entityValue.Add("sube", 8838);
                    HtmlEntity._entityName.Add(8838, "sube");
                    HtmlEntity._entityValue.Add("supe", 8839);
                    HtmlEntity._entityName.Add(8839, "supe");
                    HtmlEntity._entityValue.Add("oplus", 8853);
                    HtmlEntity._entityName.Add(8853, "oplus");
                    HtmlEntity._entityValue.Add("otimes", 8855);
                    HtmlEntity._entityName.Add(8855, "otimes");
                    HtmlEntity._entityValue.Add("perp", 8869);
                    HtmlEntity._entityName.Add(8869, "perp");
                    HtmlEntity._entityValue.Add("sdot", 8901);
                    HtmlEntity._entityName.Add(8901, "sdot");
                    HtmlEntity._entityValue.Add("lceil", 8968);
                    HtmlEntity._entityName.Add(8968, "lceil");
                    HtmlEntity._entityValue.Add("rceil", 8969);
                    HtmlEntity._entityName.Add(8969, "rceil");
                    HtmlEntity._entityValue.Add("lfloor", 8970);
                    HtmlEntity._entityName.Add(8970, "lfloor");
                    HtmlEntity._entityValue.Add("rfloor", 8971);
                    HtmlEntity._entityName.Add(8971, "rfloor");
                    HtmlEntity._entityValue.Add("lang", 9001);
                    HtmlEntity._entityName.Add(9001, "lang");
                    HtmlEntity._entityValue.Add("rang", 9002);
                    HtmlEntity._entityName.Add(9002, "rang");
                    HtmlEntity._entityValue.Add("loz", 9674);
                    HtmlEntity._entityName.Add(9674, "loz");
                    HtmlEntity._entityValue.Add("spades", 9824);
                    HtmlEntity._entityName.Add(9824, "spades");
                    HtmlEntity._entityValue.Add("clubs", 9827);
                    HtmlEntity._entityName.Add(9827, "clubs");
                    HtmlEntity._entityValue.Add("hearts", 9829);
                    HtmlEntity._entityName.Add(9829, "hearts");
                    HtmlEntity._entityValue.Add("diams", 9830);
                    HtmlEntity._entityName.Add(9830, "diams");
                    HtmlEntity._entityValue.Add("OElig", 338);
                    HtmlEntity._entityName.Add(338, "OElig");
                    HtmlEntity._entityValue.Add("oelig", 339);
                    HtmlEntity._entityName.Add(339, "oelig");
                    HtmlEntity._entityValue.Add("Scaron", 352);
                    HtmlEntity._entityName.Add(352, "Scaron");
                    HtmlEntity._entityValue.Add("scaron", 353);
                    HtmlEntity._entityName.Add(353, "scaron");
                    HtmlEntity._entityValue.Add("Yuml", 376);
                    HtmlEntity._entityName.Add(376, "Yuml");
                    HtmlEntity._entityValue.Add("circ", 710);
                    HtmlEntity._entityName.Add(710, "circ");
                    HtmlEntity._entityValue.Add("tilde", 732);
                    HtmlEntity._entityName.Add(732, "tilde");
                    HtmlEntity._entityValue.Add("ensp", 8194);
                    HtmlEntity._entityName.Add(8194, "ensp");
                    HtmlEntity._entityValue.Add("emsp", 8195);
                    HtmlEntity._entityName.Add(8195, "emsp");
                    HtmlEntity._entityValue.Add("thinsp", 8201);
                    HtmlEntity._entityName.Add(8201, "thinsp");
                    HtmlEntity._entityValue.Add("zwnj", 8204);
                    HtmlEntity._entityName.Add(8204, "zwnj");
                    HtmlEntity._entityValue.Add("zwj", 8205);
                    HtmlEntity._entityName.Add(8205, "zwj");
                    HtmlEntity._entityValue.Add("lrm", 8206);
                    HtmlEntity._entityName.Add(8206, "lrm");
                    HtmlEntity._entityValue.Add("rlm", 8207);
                    HtmlEntity._entityName.Add(8207, "rlm");
                    HtmlEntity._entityValue.Add("ndash", 8211);
                    HtmlEntity._entityName.Add(8211, "ndash");
                    HtmlEntity._entityValue.Add("mdash", 8212);
                    HtmlEntity._entityName.Add(8212, "mdash");
                    HtmlEntity._entityValue.Add("lsquo", 8216);
                    HtmlEntity._entityName.Add(8216, "lsquo");
                    HtmlEntity._entityValue.Add("rsquo", 8217);
                    HtmlEntity._entityName.Add(8217, "rsquo");
                    HtmlEntity._entityValue.Add("sbquo", 8218);
                    HtmlEntity._entityName.Add(8218, "sbquo");
                    HtmlEntity._entityValue.Add("ldquo", 8220);
                    HtmlEntity._entityName.Add(8220, "ldquo");
                    HtmlEntity._entityValue.Add("rdquo", 8221);
                    HtmlEntity._entityName.Add(8221, "rdquo");
                    HtmlEntity._entityValue.Add("bdquo", 8222);
                    HtmlEntity._entityName.Add(8222, "bdquo");
                    HtmlEntity._entityValue.Add("dagger", 8224);
                    HtmlEntity._entityName.Add(8224, "dagger");
                    HtmlEntity._entityValue.Add("Dagger", 8225);
                    HtmlEntity._entityName.Add(8225, "Dagger");
                    HtmlEntity._entityValue.Add("permil", 8240);
                    HtmlEntity._entityName.Add(8240, "permil");
                    HtmlEntity._entityValue.Add("lsaquo", 8249);
                    HtmlEntity._entityName.Add(8249, "lsaquo");
                    HtmlEntity._entityValue.Add("rsaquo", 8250);
                    HtmlEntity._entityName.Add(8250, "rsaquo");
                    HtmlEntity._entityValue.Add("euro", 8364);
                    HtmlEntity._entityName.Add(8364, "euro");
                    HtmlEntity._maxEntitySize = 9;
                }
                private HtmlEntity()
                {
                }
                public static string DeEntitize(string text)
                {
                    if (text == null)
                    {
                        return null;
                    }
                    if (text.Length == 0)
                    {
                        return text;
                    }
                    StringBuilder stringBuilder = new StringBuilder(text.Length);
                    HtmlEntity.ParseState parseState = HtmlEntity.ParseState.Text;
                    StringBuilder stringBuilder2 = new StringBuilder(10);
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (parseState != HtmlEntity.ParseState.Text)
                        {
                            if (parseState == HtmlEntity.ParseState.EntityStart)
                            {
                                char c = text[i];
                                if (c != '&')
                                {
                                    if (c == ';')
                                    {
                                        if (stringBuilder2.Length == 0)
                                        {
                                            stringBuilder.Append("&;");
                                        }
                                        else
                                        {
                                            if (stringBuilder2[0] == '#')
                                            {
                                                string text2 = stringBuilder2.ToString();
                                                try
                                                {
                                                    string text3 = text2.Substring(1).Trim();
                                                    int fromBase;
                                                    if (text3.StartsWith("x", StringComparison.OrdinalIgnoreCase))
                                                    {
                                                        fromBase = 16;
                                                        text3 = text3.Substring(1);
                                                    }
                                                    else
                                                    {
                                                        fromBase = 10;
                                                    }
                                                    int value = Convert.ToInt32(text3, fromBase);
                                                    stringBuilder.Append(Convert.ToChar(value));
                                                    goto IL_14B;
                                                }
                                                catch
                                                {
                                                    stringBuilder.Append("&#" + text2 + ";");
                                                    goto IL_14B;
                                                }
                                            }
                                            goto IL_110;
                                        IL_14B:
                                            stringBuilder2.Remove(0, stringBuilder2.Length);
                                            goto IL_159;
                                        IL_110:
                                            int value2;
                                            if (!HtmlEntity._entityValue.TryGetValue(stringBuilder2.ToString(), out value2))
                                            {
                                                stringBuilder.Append("&" + stringBuilder2 + ";");
                                                goto IL_14B;
                                            }
                                            stringBuilder.Append(Convert.ToChar(value2));
                                            goto IL_14B;
                                        }
                                    IL_159:
                                        parseState = HtmlEntity.ParseState.Text;
                                    }
                                    else
                                    {
                                        stringBuilder2.Append(text[i]);
                                        if (stringBuilder2.Length > HtmlEntity._maxEntitySize)
                                        {
                                            parseState = HtmlEntity.ParseState.Text;
                                            stringBuilder.Append("&" + stringBuilder2);
                                            stringBuilder2.Remove(0, stringBuilder2.Length);
                                        }
                                    }
                                }
                                else
                                {
                                    stringBuilder.Append("&" + stringBuilder2);
                                    stringBuilder2.Remove(0, stringBuilder2.Length);
                                }
                            }
                        }
                        else
                        {
                            char c = text[i];
                            if (c == '&')
                            {
                                parseState = HtmlEntity.ParseState.EntityStart;
                            }
                            else
                            {
                                stringBuilder.Append(text[i]);
                            }
                        }
                    }
                    if (parseState == HtmlEntity.ParseState.EntityStart)
                    {
                        stringBuilder.Append("&" + stringBuilder2);
                    }
                    return stringBuilder.ToString();
                }
                public static HtmlNode Entitize(HtmlNode node)
                {
                    if (node == null)
                    {
                        throw new ArgumentNullException("node");
                    }
                    HtmlNode htmlNode = node.CloneNode(true);
                    if (htmlNode.HasAttributes)
                    {
                        HtmlEntity.Entitize(htmlNode.Attributes);
                    }
                    if (htmlNode.HasChildNodes)
                    {
                        HtmlEntity.Entitize(htmlNode.ChildNodes);
                    }
                    else if (htmlNode.NodeType == HtmlNodeType.Text)
                    {
                        ((HtmlTextNode)htmlNode).Text = HtmlEntity.Entitize(((HtmlTextNode)htmlNode).Text, true, true);
                    }
                    return htmlNode;
                }
                public static string Entitize(string text)
                {
                    return HtmlEntity.Entitize(text, true);
                }
                public static string Entitize(string text, bool useNames)
                {
                    return HtmlEntity.Entitize(text, useNames, false);
                }
                public static string Entitize(string text, bool useNames, bool entitizeQuotAmpAndLtGt)
                {
                    if (text == null)
                    {
                        return null;
                    }
                    if (text.Length == 0)
                    {
                        return text;
                    }
                    StringBuilder stringBuilder = new StringBuilder(text.Length);
                    for (int i = 0; i < text.Length; i++)
                    {
                        int num = (int)text[i];
                        if (num > 127 || (entitizeQuotAmpAndLtGt && (num == 34 || num == 38 || num == 60 || num == 62)))
                        {
                            string text2;
                            HtmlEntity.EntityName.TryGetValue(num, out text2);
                            if (text2 == null || !useNames)
                            {
                                stringBuilder.Append("&#" + num + ";");
                            }
                            else
                            {
                                stringBuilder.Append("&" + text2 + ";");
                            }
                        }
                        else
                        {
                            stringBuilder.Append(text[i]);
                        }
                    }
                    return stringBuilder.ToString();
                }
                private static void Entitize(HtmlAttributeCollection collection)
                {
                    foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)collection))
                    {
                        if (htmlAttribute.Value != null)
                        {
                            htmlAttribute.Value = HtmlEntity.Entitize(htmlAttribute.Value);
                        }
                    }
                }
                private static void Entitize(HtmlNodeCollection collection)
                {
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)collection))
                    {
                        if (htmlNode.HasAttributes)
                        {
                            HtmlEntity.Entitize(htmlNode.Attributes);
                        }
                        if (htmlNode.HasChildNodes)
                        {
                            HtmlEntity.Entitize(htmlNode.ChildNodes);
                        }
                        else if (htmlNode.NodeType == HtmlNodeType.Text)
                        {
                            ((HtmlTextNode)htmlNode).Text = HtmlEntity.Entitize(((HtmlTextNode)htmlNode).Text, true, true);
                        }
                    }
                }
                private static readonly int _maxEntitySize;
                private static Dictionary<int, string> _entityName = new Dictionary<int, string>();
                private static Dictionary<string, int> _entityValue = new Dictionary<string, int>();
                private enum ParseState
                {
                    Text,
                    EntityStart
                }
            }
            internal class HtmlNameTable : XmlNameTable
            {
                public override string Add(string array)
                {
                    return this._nametable.Add(array);
                }
                public override string Add(char[] array, int offset, int length)
                {
                    return this._nametable.Add(array, offset, length);
                }
                public override string Get(string array)
                {
                    return this._nametable.Get(array);
                }
                public override string Get(char[] array, int offset, int length)
                {
                    return this._nametable.Get(array, offset, length);
                }
                internal string GetOrAdd(string array)
                {
                    string text = this.Get(array);
                    if (text == null)
                    {
                        return this.Add(array);
                    }
                    return text;
                }
                private NameTable _nametable = new NameTable();
            }
            [DebuggerDisplay("Name: {OriginalName}")]
            public class HtmlNode : IXPathNavigable
            {
                static HtmlNode()
                {
                    HtmlNode.ElementsFlags.Add("script", HtmlElementFlag.CData);
                    HtmlNode.ElementsFlags.Add("style", HtmlElementFlag.CData);
                    HtmlNode.ElementsFlags.Add("noxhtml", HtmlElementFlag.CData);
                    HtmlNode.ElementsFlags.Add("textarea", HtmlElementFlag.CData);
                    HtmlNode.ElementsFlags.Add("title", HtmlElementFlag.CData);
                    HtmlNode.ElementsFlags.Add("base", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("link", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("meta", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("isindex", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("hr", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("col", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("img", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("param", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("embed", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("frame", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("wbr", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("bgsound", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("spacer", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("keygen", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("area", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("input", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("basefont", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("source", HtmlElementFlag.Empty);
                    HtmlNode.ElementsFlags.Add("form", HtmlElementFlag.CanOverlap);
                    HtmlNode.ElementsFlags.Add("br", HtmlElementFlag.Empty | HtmlElementFlag.Closed);
                    if (!HtmlDocument.DisableBehaviorTagP)
                    {
                        HtmlNode.ElementsFlags.Add("p", HtmlElementFlag.Empty | HtmlElementFlag.Closed);
                    }
                }
                public HtmlNode(HtmlNodeType type, HtmlDocument ownerdocument, int index)
                {
                    this._nodetype = type;
                    this._ownerdocument = ownerdocument;
                    this._outerstartindex = index;
                    switch (type)
                    {
                        case HtmlNodeType.Document:
                            this.Name = HtmlNode.HtmlNodeTypeNameDocument;
                            this._endnode = this;
                            break;
                        case HtmlNodeType.Comment:
                            this.Name = HtmlNode.HtmlNodeTypeNameComment;
                            this._endnode = this;
                            break;
                        case HtmlNodeType.Text:
                            this.Name = HtmlNode.HtmlNodeTypeNameText;
                            this._endnode = this;
                            break;
                    }
                    if (this._ownerdocument.Openednodes != null && !this.Closed && -1 != index)
                    {
                        this._ownerdocument.Openednodes.Add(index, this);
                    }
                    if (-1 != index || type == HtmlNodeType.Comment || type == HtmlNodeType.Text)
                    {
                        return;
                    }
                    this.SetChanged();
                }
                public HtmlAttributeCollection Attributes
                {
                    get
                    {
                        if (!this.HasAttributes)
                        {
                            this._attributes = new HtmlAttributeCollection(this);
                        }
                        return this._attributes;
                    }
                    internal set
                    {
                        this._attributes = value;
                    }
                }
                public HtmlNodeCollection ChildNodes
                {
                    get
                    {
                        HtmlNodeCollection result;
                        if ((result = this._childnodes) == null)
                        {
                            result = (this._childnodes = new HtmlNodeCollection(this));
                        }
                        return result;
                    }
                    internal set
                    {
                        this._childnodes = value;
                    }
                }
                public bool Closed
                {
                    get
                    {
                        return this._endnode != null;
                    }
                }
                public HtmlAttributeCollection ClosingAttributes
                {
                    get
                    {
                        if (this.HasClosingAttributes)
                        {
                            return this._endnode.Attributes;
                        }
                        return new HtmlAttributeCollection(this);
                    }
                }
                public HtmlNode EndNode
                {
                    get
                    {
                        return this._endnode;
                    }
                }
                public HtmlNode FirstChild
                {
                    get
                    {
                        if (this.HasChildNodes)
                        {
                            return this._childnodes[0];
                        }
                        return null;
                    }
                }
                public bool HasAttributes
                {
                    get
                    {
                        return this._attributes != null && this._attributes.Count > 0;
                    }
                }
                public bool HasChildNodes
                {
                    get
                    {
                        return this._childnodes != null && this._childnodes.Count > 0;
                    }
                }
                public bool HasClosingAttributes
                {
                    get
                    {
                        return this._endnode != null && this._endnode != this && this._endnode._attributes != null && this._endnode._attributes.Count > 0;
                    }
                }
                public string Id
                {
                    get
                    {
                        if (this._ownerdocument.Nodesid == null)
                        {
                            throw new Exception(HtmlDocument.HtmlExceptionUseIdAttributeFalse);
                        }
                        return this.GetId();
                    }
                    set
                    {
                        if (this._ownerdocument.Nodesid == null)
                        {
                            throw new Exception(HtmlDocument.HtmlExceptionUseIdAttributeFalse);
                        }
                        if (value == null)
                        {
                            throw new ArgumentNullException("value");
                        }
                        this.SetId(value);
                    }
                }
                public virtual string InnerHtml
                {
                    get
                    {
                        if (this._changed)
                        {
                            this.UpdateHtml();
                            return this._innerhtml;
                        }
                        if (this._innerhtml != null)
                        {
                            return this._innerhtml;
                        }
                        if (this._innerstartindex < 0 || this._innerlength < 0)
                        {
                            return string.Empty;
                        }
                        return this._ownerdocument.Text.Substring(this._innerstartindex, this._innerlength);
                    }
                    set
                    {
                        HtmlDocument htmlDocument = new HtmlDocument();
                        htmlDocument.LoadHtml(value);
                        this.RemoveAllChildren();
                        this.AppendChildren(htmlDocument.DocumentNode.ChildNodes);
                    }
                }
                public virtual string InnerText
                {
                    get
                    {
                        if (!this._ownerdocument.BackwardCompatibility)
                        {
                            if (this.HasChildNodes)
                            {
                                StringBuilder stringBuilder = new StringBuilder();
                                this.AppendInnerText(stringBuilder);
                                return stringBuilder.ToString();
                            }
                            return this.GetCurrentNodeText();
                        }
                        else
                        {
                            if (this._nodetype == HtmlNodeType.Text)
                            {
                                return ((HtmlTextNode)this).Text;
                            }
                            if (this._nodetype == HtmlNodeType.Comment)
                            {
                                return "";
                            }
                            if (!this.HasChildNodes)
                            {
                                return string.Empty;
                            }
                            string text = null;
                            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
                            {
                                text += htmlNode.InnerText;
                            }
                            return text;
                        }
                    }
                }
                public virtual string GetDirectInnerText()
                {
                    if (!this._ownerdocument.BackwardCompatibility)
                    {
                        if (this.HasChildNodes)
                        {
                            StringBuilder stringBuilder = new StringBuilder();
                            this.AppendDirectInnerText(stringBuilder);
                            return stringBuilder.ToString();
                        }
                        return this.GetCurrentNodeText();
                    }
                    else
                    {
                        if (this._nodetype == HtmlNodeType.Text)
                        {
                            return ((HtmlTextNode)this).Text;
                        }
                        if (this._nodetype == HtmlNodeType.Comment)
                        {
                            return "";
                        }
                        if (!this.HasChildNodes)
                        {
                            return string.Empty;
                        }
                        string text = null;
                        foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
                        {
                            if (htmlNode._nodetype == HtmlNodeType.Text)
                            {
                                text += ((HtmlTextNode)htmlNode).Text;
                            }
                        }
                        return text;
                    }
                }
                internal string GetCurrentNodeText()
                {
                    if (this._nodetype == HtmlNodeType.Text)
                    {
                        string text = ((HtmlTextNode)this).Text;
                        if (this.ParentNode.Name != "pre")
                        {
                            text = text.Replace("\n", "").Replace("\r", "").Replace("\t", "");
                        }
                        return text;
                    }
                    return "";
                }
                internal void AppendDirectInnerText(StringBuilder sb)
                {
                    if (this._nodetype == HtmlNodeType.Text)
                    {
                        sb.Append(this.GetCurrentNodeText());
                    }
                    if (!this.HasChildNodes)
                    {
                        return;
                    }
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
                    {
                        sb.Append(htmlNode.GetCurrentNodeText());
                    }
                }
                internal void AppendInnerText(StringBuilder sb)
                {
                    if (this._nodetype == HtmlNodeType.Text)
                    {
                        sb.Append(this.GetCurrentNodeText());
                    }
                    if (!this.HasChildNodes)
                    {
                        return;
                    }
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
                    {
                        htmlNode.AppendInnerText(sb);
                    }
                }
                public HtmlNode LastChild
                {
                    get
                    {
                        if (this.HasChildNodes)
                        {
                            return this._childnodes[this._childnodes.Count - 1];
                        }
                        return null;
                    }
                }
                public int Line
                {
                    get
                    {
                        return this._line;
                    }
                    internal set
                    {
                        this._line = value;
                    }
                }
                public int LinePosition
                {
                    get
                    {
                        return this._lineposition;
                    }
                    internal set
                    {
                        this._lineposition = value;
                    }
                }
                public int InnerStartIndex
                {
                    get
                    {
                        return this._innerstartindex;
                    }
                }
                public int InnerLength
                {
                    get
                    {
                        return this.InnerHtml.Length;
                    }
                }
                public int OuterLength
                {
                    get
                    {
                        return this.OuterHtml.Length;
                    }
                }
                public string Name
                {
                    get
                    {
                        if (this._optimizedName == null)
                        {
                            if (this._name == null)
                            {
                                this.Name = this._ownerdocument.Text.Substring(this._namestartindex, this._namelength);
                            }
                            if (this._name == null)
                            {
                                this._optimizedName = string.Empty;
                            }
                            else
                            {
                                this._optimizedName = this._name.ToLowerInvariant();
                            }
                        }
                        return this._optimizedName;
                    }
                    set
                    {
                        this._name = value;
                        this._optimizedName = null;
                    }
                }
                public HtmlNode NextSibling
                {
                    get
                    {
                        return this._nextnode;
                    }
                    internal set
                    {
                        this._nextnode = value;
                    }
                }
                public HtmlNodeType NodeType
                {
                    get
                    {
                        return this._nodetype;
                    }
                    internal set
                    {
                        this._nodetype = value;
                    }
                }
                public string OriginalName
                {
                    get
                    {
                        return this._name;
                    }
                }
                public virtual string OuterHtml
                {
                    get
                    {
                        if (this._changed)
                        {
                            this.UpdateHtml();
                            return this._outerhtml;
                        }
                        if (this._outerhtml != null)
                        {
                            return this._outerhtml;
                        }
                        if (this._outerstartindex < 0 || this._outerlength < 0)
                        {
                            return string.Empty;
                        }
                        return this._ownerdocument.Text.Substring(this._outerstartindex, this._outerlength);
                    }
                }
                public HtmlDocument OwnerDocument
                {
                    get
                    {
                        return this._ownerdocument;
                    }
                    internal set
                    {
                        this._ownerdocument = value;
                    }
                }
                public HtmlNode ParentNode
                {
                    get
                    {
                        return this._parentnode;
                    }
                    internal set
                    {
                        this._parentnode = value;
                    }
                }
                public HtmlNode PreviousSibling
                {
                    get
                    {
                        return this._prevnode;
                    }
                    internal set
                    {
                        this._prevnode = value;
                    }
                }
                public int StreamPosition
                {
                    get
                    {
                        return this._streamposition;
                    }
                }
                public string XPath
                {
                    get
                    {
                        return ((this.ParentNode == null || this.ParentNode.NodeType == HtmlNodeType.Document) ? "/" : (this.ParentNode.XPath + "/")) + this.GetRelativeXpath();
                    }
                }
                public int Depth { get; set; }
                public static bool CanOverlapElement(string name)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    HtmlElementFlag htmlElementFlag;
                    return HtmlNode.ElementsFlags.TryGetValue(name, out htmlElementFlag) && (htmlElementFlag & HtmlElementFlag.CanOverlap) > (HtmlElementFlag)0;
                }
                public static HtmlNode CreateNode(string html)
                {
                    HtmlDocument htmlDocument = new HtmlDocument();
                    htmlDocument.LoadHtml(html);
                    if (!htmlDocument.DocumentNode.IsSingleElementNode())
                    {
                        throw new Exception("Multiple node elments can't be created.");
                    }
                    for (HtmlNode htmlNode = htmlDocument.DocumentNode.FirstChild; htmlNode != null; htmlNode = htmlNode.NextSibling)
                    {
                        if (htmlNode.NodeType == HtmlNodeType.Element && htmlNode.OuterHtml != "\r\n")
                        {
                            return htmlNode;
                        }
                    }
                    return htmlDocument.DocumentNode.FirstChild;
                }
                public static bool IsCDataElement(string name)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    HtmlElementFlag htmlElementFlag;
                    return HtmlNode.ElementsFlags.TryGetValue(name, out htmlElementFlag) && (htmlElementFlag & HtmlElementFlag.CData) > (HtmlElementFlag)0;
                }
                public static bool IsClosedElement(string name)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    HtmlElementFlag htmlElementFlag;
                    return HtmlNode.ElementsFlags.TryGetValue(name, out htmlElementFlag) && (htmlElementFlag & HtmlElementFlag.Closed) > (HtmlElementFlag)0;
                }
                public static bool IsEmptyElement(string name)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    HtmlElementFlag htmlElementFlag;
                    return name.Length == 0 || '!' == name[0] || '?' == name[0] || (HtmlNode.ElementsFlags.TryGetValue(name, out htmlElementFlag) && (htmlElementFlag & HtmlElementFlag.Empty) > (HtmlElementFlag)0);
                }
                public static bool IsOverlappedClosingElement(string text)
                {
                    if (text == null)
                    {
                        throw new ArgumentNullException("text");
                    }
                    return text.Length > 4 && text[0] == '<' && text[text.Length - 1] == '>' && text[1] == '/' && HtmlNode.CanOverlapElement(text.Substring(2, text.Length - 3));
                }
                public IEnumerable<HtmlNode> Ancestors()
                {
                    HtmlNode node = this.ParentNode;
                    if (node != null)
                    {
                        yield return node;
                        while (node.ParentNode != null)
                        {
                            yield return node.ParentNode;
                            node = node.ParentNode;
                        }
                    }
                    yield break;
                }
                public IEnumerable<HtmlNode> Ancestors(string name)
                {
                    HtmlNode i;
                    for (i = this.ParentNode; i != null; i = i.ParentNode)
                    {
                        if (i.Name == name)
                        {
                            yield return i;
                        }
                    }
                    i = null;
                    yield break;
                }
                public IEnumerable<HtmlNode> AncestorsAndSelf()
                {
                    HtmlNode i;
                    for (i = this; i != null; i = i.ParentNode)
                    {
                        yield return i;
                    }
                    i = null;
                    yield break;
                }
                public IEnumerable<HtmlNode> AncestorsAndSelf(string name)
                {
                    HtmlNode i;
                    for (i = this; i != null; i = i.ParentNode)
                    {
                        if (i.Name == name)
                        {
                            yield return i;
                        }
                    }
                    i = null;
                    yield break;
                }
                public HtmlNode AppendChild(HtmlNode newChild)
                {
                    if (newChild == null)
                    {
                        throw new ArgumentNullException("newChild");
                    }
                    this.ChildNodes.Append(newChild);
                    this._ownerdocument.SetIdForNode(newChild, newChild.GetId());
                    this.SetChildNodesId(newChild);
                    this.SetChanged();
                    return newChild;
                }
                public void SetChildNodesId(HtmlNode chilNode)
                {
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)chilNode.ChildNodes))
                    {
                        this._ownerdocument.SetIdForNode(htmlNode, htmlNode.GetId());
                        this.SetChildNodesId(htmlNode);
                    }
                }
                public void AppendChildren(HtmlNodeCollection newChildren)
                {
                    if (newChildren == null)
                    {
                        throw new ArgumentNullException("newChildren");
                    }
                    foreach (HtmlNode newChild in ((IEnumerable<HtmlNode>)newChildren))
                    {
                        this.AppendChild(newChild);
                    }
                }
                public IEnumerable<HtmlAttribute> ChildAttributes(string name)
                {
                    return this.Attributes.AttributesWithName(name);
                }
                public HtmlNode Clone()
                {
                    return this.CloneNode(true);
                }
                public HtmlNode CloneNode(string newName)
                {
                    return this.CloneNode(newName, true);
                }
                public HtmlNode CloneNode(string newName, bool deep)
                {
                    if (newName == null)
                    {
                        throw new ArgumentNullException("newName");
                    }
                    HtmlNode htmlNode = this.CloneNode(deep);
                    htmlNode.Name = newName;
                    return htmlNode;
                }
                public HtmlNode CloneNode(bool deep)
                {
                    HtmlNode htmlNode = this._ownerdocument.CreateNode(this._nodetype);
                    htmlNode.Name = this.OriginalName;
                    HtmlNodeType nodetype = this._nodetype;
                    if (nodetype == HtmlNodeType.Comment)
                    {
                        ((HtmlCommentNode)htmlNode).Comment = ((HtmlCommentNode)this).Comment;
                        return htmlNode;
                    }
                    if (nodetype == HtmlNodeType.Text)
                    {
                        ((HtmlTextNode)htmlNode).Text = ((HtmlTextNode)this).Text;
                        return htmlNode;
                    }
                    if (this.HasAttributes)
                    {
                        foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)this._attributes))
                        {
                            HtmlAttribute newAttribute = htmlAttribute.Clone();
                            htmlNode.Attributes.Append(newAttribute);
                        }
                    }
                    if (this.HasClosingAttributes)
                    {
                        htmlNode._endnode = this._endnode.CloneNode(false);
                        foreach (HtmlAttribute htmlAttribute2 in ((IEnumerable<HtmlAttribute>)this._endnode._attributes))
                        {
                            HtmlAttribute newAttribute2 = htmlAttribute2.Clone();
                            htmlNode._endnode._attributes.Append(newAttribute2);
                        }
                    }
                    if (!deep)
                    {
                        return htmlNode;
                    }
                    if (!this.HasChildNodes)
                    {
                        return htmlNode;
                    }
                    foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)this._childnodes))
                    {
                        HtmlNode newChild = htmlNode2.CloneNode(deep);
                        htmlNode.AppendChild(newChild);
                    }
                    return htmlNode;
                }
                public void CopyFrom(HtmlNode node)
                {
                    this.CopyFrom(node, true);
                }
                public void CopyFrom(HtmlNode node, bool deep)
                {
                    if (node == null)
                    {
                        throw new ArgumentNullException("node");
                    }
                    this.Attributes.RemoveAll();
                    if (node.HasAttributes)
                    {
                        foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)node.Attributes))
                        {
                            HtmlAttribute newAttribute = htmlAttribute.Clone();
                            this.Attributes.Append(newAttribute);
                        }
                    }
                    if (deep)
                    {
                        this.RemoveAllChildren();
                        if (node.HasChildNodes)
                        {
                            foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)node.ChildNodes))
                            {
                                this.AppendChild(htmlNode.CloneNode(true));
                            }
                        }
                    }
                }
                [Obsolete("Use Descendants() instead, the results of this function will change in a future version")]
                public IEnumerable<HtmlNode> DescendantNodes(int level = 0)
                {
                    if (level > HtmlDocument.MaxDepthLevel)
                    {
                        throw new ArgumentException("The document is too complex to parse");
                    }
                    foreach (HtmlNode node in ((IEnumerable<HtmlNode>)this.ChildNodes))
                    {
                        yield return node;
                        foreach (HtmlNode htmlNode in node.DescendantNodes(level + 1))
                        {
                            yield return htmlNode;
                        }
                        //node = null;
                    }
                    yield break;
                }
                [Obsolete("Use DescendantsAndSelf() instead, the results of this function will change in a future version")]
                public IEnumerable<HtmlNode> DescendantNodesAndSelf()
                {
                    return this.DescendantsAndSelf();
                }
                public IEnumerable<HtmlNode> Descendants()
                {
                    return this.Descendants(0);
                }
                public IEnumerable<HtmlNode> Descendants(int level)
                {
                    if (level > HtmlDocument.MaxDepthLevel)
                    {
                        throw new ArgumentException("The document is too complex to parse");
                    }
                    foreach (HtmlNode node in ((IEnumerable<HtmlNode>)this.ChildNodes))
                    {
                        yield return node;
                        foreach (HtmlNode htmlNode in node.Descendants(level + 1))
                        {
                            yield return htmlNode;
                        }
                        //node = null;
                    }
                    yield break;
                }
                public IEnumerable<HtmlNode> Descendants(string name)
                {
                    foreach (HtmlNode htmlNode in this.Descendants())
                    {
                        if (string.Equals(htmlNode.Name, name, StringComparison.OrdinalIgnoreCase))
                        {
                            yield return htmlNode;
                        }
                    }
                    yield break;
                }
                public IEnumerable<HtmlNode> DescendantsAndSelf()
                {
                    yield return this;
                    foreach (HtmlNode htmlNode in this.Descendants())
                    {
                        if (htmlNode != null)
                        {
                            yield return htmlNode;
                        }
                    }
                    yield break;
                }
                public IEnumerable<HtmlNode> DescendantsAndSelf(string name)
                {
                    yield return this;
                    foreach (HtmlNode htmlNode in this.Descendants())
                    {
                        if (htmlNode.Name == name)
                        {
                            yield return htmlNode;
                        }
                    }
                    yield break;
                }
                public HtmlNode Element(string name)
                {
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
                    {
                        if (htmlNode.Name == name)
                        {
                            return htmlNode;
                        }
                    }
                    return null;
                }
                public IEnumerable<HtmlNode> Elements(string name)
                {
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ChildNodes))
                    {
                        if (htmlNode.Name == name)
                        {
                            yield return htmlNode;
                        }
                    }
                    yield break;
                }
                public string GetAttributeValue(string name, string def)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    if (!this.HasAttributes)
                    {
                        return def;
                    }
                    HtmlAttribute htmlAttribute = this.Attributes[name];
                    if (htmlAttribute == null)
                    {
                        return def;
                    }
                    return htmlAttribute.Value;
                }
                public int GetAttributeValue(string name, int def)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    if (!this.HasAttributes)
                    {
                        return def;
                    }
                    HtmlAttribute htmlAttribute = this.Attributes[name];
                    if (htmlAttribute == null)
                    {
                        return def;
                    }
                    int result;
                    try
                    {
                        result = Convert.ToInt32(htmlAttribute.Value);
                    }
                    catch
                    {
                        result = def;
                    }
                    return result;
                }
                public bool GetAttributeValue(string name, bool def)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    if (!this.HasAttributes)
                    {
                        return def;
                    }
                    HtmlAttribute htmlAttribute = this.Attributes[name];
                    if (htmlAttribute == null)
                    {
                        return def;
                    }
                    bool result;
                    try
                    {
                        result = Convert.ToBoolean(htmlAttribute.Value);
                    }
                    catch
                    {
                        result = def;
                    }
                    return result;
                }
                public HtmlNode InsertAfter(HtmlNode newChild, HtmlNode refChild)
                {
                    if (newChild == null)
                    {
                        throw new ArgumentNullException("newChild");
                    }
                    if (refChild == null)
                    {
                        return this.PrependChild(newChild);
                    }
                    if (newChild == refChild)
                    {
                        return newChild;
                    }
                    int num = -1;
                    if (this._childnodes != null)
                    {
                        num = this._childnodes[refChild];
                    }
                    if (num == -1)
                    {
                        throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
                    }
                    if (this._childnodes != null)
                    {
                        this._childnodes.Insert(num + 1, newChild);
                    }
                    this._ownerdocument.SetIdForNode(newChild, newChild.GetId());
                    this.SetChildNodesId(newChild);
                    this.SetChanged();
                    return newChild;
                }
                public HtmlNode InsertBefore(HtmlNode newChild, HtmlNode refChild)
                {
                    if (newChild == null)
                    {
                        throw new ArgumentNullException("newChild");
                    }
                    if (refChild == null)
                    {
                        return this.AppendChild(newChild);
                    }
                    if (newChild == refChild)
                    {
                        return newChild;
                    }
                    int num = -1;
                    if (this._childnodes != null)
                    {
                        num = this._childnodes[refChild];
                    }
                    if (num == -1)
                    {
                        throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
                    }
                    if (this._childnodes != null)
                    {
                        this._childnodes.Insert(num, newChild);
                    }
                    this._ownerdocument.SetIdForNode(newChild, newChild.GetId());
                    this.SetChildNodesId(newChild);
                    this.SetChanged();
                    return newChild;
                }
                public HtmlNode PrependChild(HtmlNode newChild)
                {
                    if (newChild == null)
                    {
                        throw new ArgumentNullException("newChild");
                    }
                    this.ChildNodes.Prepend(newChild);
                    this._ownerdocument.SetIdForNode(newChild, newChild.GetId());
                    this.SetChildNodesId(newChild);
                    this.SetChanged();
                    return newChild;
                }
                public void PrependChildren(HtmlNodeCollection newChildren)
                {
                    if (newChildren == null)
                    {
                        throw new ArgumentNullException("newChildren");
                    }
                    for (int i = newChildren.Count - 1; i >= 0; i--)
                    {
                        this.PrependChild(newChildren[i]);
                    }
                }
                public void Remove()
                {
                    if (this.ParentNode != null)
                    {
                        this.ParentNode.ChildNodes.Remove(this);
                    }
                }
                public void RemoveAll()
                {
                    this.RemoveAllChildren();
                    if (this.HasAttributes)
                    {
                        this._attributes.Clear();
                    }
                    if (this._endnode != null && this._endnode != this && this._endnode._attributes != null)
                    {
                        this._endnode._attributes.Clear();
                    }
                    this.SetChanged();
                }
                public void RemoveAllChildren()
                {
                    if (!this.HasChildNodes)
                    {
                        return;
                    }
                    if (this._ownerdocument.OptionUseIdAttribute)
                    {
                        foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this._childnodes))
                        {
                            this._ownerdocument.SetIdForNode(null, htmlNode.GetId());
                            this.RemoveAllIDforNode(htmlNode);
                        }
                    }
                    this._childnodes.Clear();
                    this.SetChanged();
                }
                public void RemoveAllIDforNode(HtmlNode node)
                {
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)node.ChildNodes))
                    {
                        this._ownerdocument.SetIdForNode(null, htmlNode.GetId());
                        this.RemoveAllIDforNode(htmlNode);
                    }
                }
                public HtmlNode RemoveChild(HtmlNode oldChild)
                {
                    if (oldChild == null)
                    {
                        throw new ArgumentNullException("oldChild");
                    }
                    int num = -1;
                    if (this._childnodes != null)
                    {
                        num = this._childnodes[oldChild];
                    }
                    if (num == -1)
                    {
                        throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
                    }
                    if (this._childnodes != null)
                    {
                        this._childnodes.Remove(num);
                    }
                    this._ownerdocument.SetIdForNode(null, oldChild.GetId());
                    this.RemoveAllIDforNode(oldChild);
                    this.SetChanged();
                    return oldChild;
                }
                public HtmlNode RemoveChild(HtmlNode oldChild, bool keepGrandChildren)
                {
                    if (oldChild == null)
                    {
                        throw new ArgumentNullException("oldChild");
                    }
                    if (oldChild._childnodes != null && keepGrandChildren)
                    {
                        HtmlNode refChild = oldChild.PreviousSibling;
                        foreach (HtmlNode newChild in ((IEnumerable<HtmlNode>)oldChild._childnodes))
                        {
                            refChild = this.InsertAfter(newChild, refChild);
                        }
                    }
                    this.RemoveChild(oldChild);
                    this.SetChanged();
                    return oldChild;
                }
                public HtmlNode ReplaceChild(HtmlNode newChild, HtmlNode oldChild)
                {
                    if (newChild == null)
                    {
                        return this.RemoveChild(oldChild);
                    }
                    if (oldChild == null)
                    {
                        return this.AppendChild(newChild);
                    }
                    int num = -1;
                    if (this._childnodes != null)
                    {
                        num = this._childnodes[oldChild];
                    }
                    if (num == -1)
                    {
                        throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
                    }
                    if (this._childnodes != null)
                    {
                        this._childnodes.Replace(num, newChild);
                    }
                    this._ownerdocument.SetIdForNode(null, oldChild.GetId());
                    this.RemoveAllIDforNode(oldChild);
                    this._ownerdocument.SetIdForNode(newChild, newChild.GetId());
                    this.SetChildNodesId(newChild);
                    this.SetChanged();
                    return newChild;
                }
                public HtmlAttribute SetAttributeValue(string name, string value)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException("name");
                    }
                    HtmlAttribute htmlAttribute = this.Attributes[name];
                    if (htmlAttribute == null)
                    {
                        return this.Attributes.Append(this._ownerdocument.CreateAttribute(name, value));
                    }
                    htmlAttribute.Value = value;
                    return htmlAttribute;
                }
                public void WriteContentTo(System.IO.TextWriter outText, int level = 0)
                {
                    if (level > HtmlDocument.MaxDepthLevel)
                    {
                        throw new ArgumentException("The document is too complex to parse");
                    }
                    if (this._childnodes == null)
                    {
                        return;
                    }
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this._childnodes))
                    {
                        htmlNode.WriteTo(outText, level + 1);
                    }
                }
                public string WriteContentTo()
                {
                    System.IO.StringWriter stringWriter = new System.IO.StringWriter();
                    this.WriteContentTo(stringWriter, 0);
                    stringWriter.Flush();
                    return stringWriter.ToString();
                }
                public virtual void WriteTo(System.IO.TextWriter outText, int level = 0)
                {
                    switch (this._nodetype)
                    {
                        case HtmlNodeType.Document:
                            if (this._ownerdocument.OptionOutputAsXml)
                            {
                                outText.Write("<?xml version=\"1.0\" encoding=\"" + this._ownerdocument.GetOutEncoding().BodyName + "\"?>");
                                if (this._ownerdocument.DocumentNode.HasChildNodes)
                                {
                                    int num = this._ownerdocument.DocumentNode._childnodes.Count;
                                    if (num > 0)
                                    {
                                        if (this._ownerdocument.GetXmlDeclaration() != null)
                                        {
                                            num--;
                                        }
                                        if (num > 1)
                                        {
                                            if (!this._ownerdocument.BackwardCompatibility)
                                            {
                                                this.WriteContentTo(outText, level);
                                                return;
                                            }
                                            if (this._ownerdocument.OptionOutputUpperCase)
                                            {
                                                outText.Write("<SPAN>");
                                                this.WriteContentTo(outText, level);
                                                outText.Write("</SPAN>");
                                                return;
                                            }
                                            outText.Write("<span>");
                                            this.WriteContentTo(outText, level);
                                            outText.Write("</span>");
                                            return;
                                        }
                                    }
                                }
                            }
                            this.WriteContentTo(outText, level);
                            return;
                        case HtmlNodeType.Element:
                            {
                                string text = this._ownerdocument.OptionOutputUpperCase ? this.Name.ToUpperInvariant() : this.Name;
                                if (this._ownerdocument.OptionOutputOriginalCase)
                                {
                                    text = this.OriginalName;
                                }
                                if (this._ownerdocument.OptionOutputAsXml)
                                {
                                    if (text.Length <= 0 || text[0] == '?' || text.Trim().Length == 0)
                                    {
                                        return;
                                    }
                                    text = HtmlDocument.GetXmlName(text, false, this._ownerdocument.OptionPreserveXmlNamespaces);
                                }
                                outText.Write("<" + text);
                                this.WriteAttributes(outText, false);
                                if (this.HasChildNodes)
                                {
                                    outText.Write(">");
                                    bool flag = false;
                                    if (this._ownerdocument.OptionOutputAsXml && HtmlNode.IsCDataElement(this.Name))
                                    {
                                        flag = true;
                                        outText.Write("\r\n//<![CDATA[\r\n");
                                    }
                                    if (flag)
                                    {
                                        if (this.HasChildNodes)
                                        {
                                            this.ChildNodes[0].WriteTo(outText, level);
                                        }
                                        outText.Write("\r\n//]]>//\r\n");
                                    }
                                    else
                                    {
                                        this.WriteContentTo(outText, level);
                                    }
                                    if (this._ownerdocument.OptionOutputAsXml || !this._isImplicitEnd)
                                    {
                                        outText.Write("</" + text);
                                        if (!this._ownerdocument.OptionOutputAsXml)
                                        {
                                            this.WriteAttributes(outText, true);
                                        }
                                        outText.Write(">");
                                        return;
                                    }
                                }
                                else if (HtmlNode.IsEmptyElement(this.Name))
                                {
                                    if (this._ownerdocument.OptionWriteEmptyNodes || this._ownerdocument.OptionOutputAsXml)
                                    {
                                        outText.Write(" />");
                                        return;
                                    }
                                    if (this.Name.Length > 0 && this.Name[0] == '?')
                                    {
                                        outText.Write("?");
                                    }
                                    outText.Write(">");
                                    return;
                                }
                                else
                                {
                                    if (!this._isImplicitEnd)
                                    {
                                        outText.Write("></" + text + ">");
                                        return;
                                    }
                                    outText.Write(">");
                                }
                                return;
                            }
                        case HtmlNodeType.Comment:
                            {
                                string text2 = ((HtmlCommentNode)this).Comment;
                                if (!this._ownerdocument.OptionOutputAsXml)
                                {
                                    outText.Write(text2);
                                    return;
                                }
                                HtmlCommentNode htmlCommentNode = (HtmlCommentNode)this;
                                if (!this._ownerdocument.BackwardCompatibility && htmlCommentNode.Comment.ToLowerInvariant().StartsWith("<!doctype"))
                                {
                                    outText.Write(htmlCommentNode.Comment);
                                    return;
                                }
                                outText.Write("<!--" + HtmlNode.GetXmlComment(htmlCommentNode) + " -->");
                                return;
                            }
                        case HtmlNodeType.Text:
                            {
                                string text2 = ((HtmlTextNode)this).Text;
                                outText.Write(this._ownerdocument.OptionOutputAsXml ? HtmlDocument.HtmlEncodeWithCompatibility(text2, this._ownerdocument.BackwardCompatibility) : text2);
                                return;
                            }
                        default:
                            return;
                    }
                }
                public void WriteTo(XmlWriter writer)
                {
                    switch (this._nodetype)
                    {
                        case HtmlNodeType.Document:
                            writer.WriteProcessingInstruction("xml", "version=\"1.0\" encoding=\"" + this._ownerdocument.GetOutEncoding().BodyName + "\"");
                            if (!this.HasChildNodes)
                            {
                                return;
                            }
                            using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>)this.ChildNodes).GetEnumerator())
                            {
                                while (enumerator.MoveNext())
                                {
                                    HtmlNode htmlNode = enumerator.Current;
                                    htmlNode.WriteTo(writer);
                                }
                                return;
                            }
                        case HtmlNodeType.Element:
                            {
                                string localName = this._ownerdocument.OptionOutputUpperCase ? this.Name.ToUpperInvariant() : this.Name;
                                if (this._ownerdocument.OptionOutputOriginalCase)
                                {
                                    localName = this.OriginalName;
                                }
                                writer.WriteStartElement(localName);
                                HtmlNode.WriteAttributes(writer, this);
                                if (this.HasChildNodes)
                                {
                                    foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)this.ChildNodes))
                                    {
                                        htmlNode2.WriteTo(writer);
                                    }
                                }
                                writer.WriteEndElement();
                                return;
                            }
                        case HtmlNodeType.Comment:
                            writer.WriteComment(HtmlNode.GetXmlComment((HtmlCommentNode)this));
                            return;
                        case HtmlNodeType.Text:
                            break;
                        default:
                            return;
                    }
                    string text = ((HtmlTextNode)this).Text;
                    writer.WriteString(text);
                }
                public string WriteTo()
                {
                    string result;
                    using (System.IO.StringWriter stringWriter = new System.IO.StringWriter())
                    {
                        this.WriteTo(stringWriter, 0);
                        stringWriter.Flush();
                        result = stringWriter.ToString();
                    }
                    return result;
                }
                public void SetParent(HtmlNode parent)
                {
                    if (parent == null)
                    {
                        return;
                    }
                    this.ParentNode = parent;
                    if (this.OwnerDocument.OptionMaxNestedChildNodes > 0)
                    {
                        this.Depth = parent.Depth + 1;
                        if (this.Depth > this.OwnerDocument.OptionMaxNestedChildNodes)
                        {
                            throw new Exception(string.Format("Document has more than {0} nested tags. This is likely due to the page not closing tags properly.", this.OwnerDocument.OptionMaxNestedChildNodes));
                        }
                    }
                }
                internal void SetChanged()
                {
                    this._changed = true;
                    if (this.ParentNode != null)
                    {
                        this.ParentNode.SetChanged();
                    }
                }
                private void UpdateHtml()
                {
                    this._innerhtml = this.WriteContentTo();
                    this._outerhtml = this.WriteTo();
                    this._changed = false;
                }
                internal static string GetXmlComment(HtmlCommentNode comment)
                {
                    string comment2 = comment.Comment;
                    return comment2.Substring(4, comment2.Length - 7).Replace("--", " - -");
                }
                internal static void WriteAttributes(XmlWriter writer, HtmlNode node)
                {
                    if (!node.HasAttributes)
                    {
                        return;
                    }
                    foreach (HtmlAttribute htmlAttribute in node.Attributes.Hashitems.Values)
                    {
                        writer.WriteAttributeString(htmlAttribute.XmlName, htmlAttribute.Value);
                    }
                }
                internal void UpdateLastNode()
                {
                    HtmlNode htmlNode = null;
                    if (this._prevwithsamename == null || !this._prevwithsamename._starttag)
                    {
                        using (Dictionary<int, HtmlNode>.Enumerator enumerator = this._ownerdocument.Openednodes.GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                            {
                                KeyValuePair<int, HtmlNode> keyValuePair = enumerator.Current;
                                if ((keyValuePair.Key < this._outerstartindex || keyValuePair.Key > this._outerstartindex + this._outerlength) && keyValuePair.Value._name == this._name)
                                {
                                    if (htmlNode == null && keyValuePair.Value._starttag)
                                    {
                                        htmlNode = keyValuePair.Value;
                                    }
                                    else if (htmlNode != null && htmlNode.InnerStartIndex < keyValuePair.Key && keyValuePair.Value._starttag)
                                    {
                                        htmlNode = keyValuePair.Value;
                                    }
                                }
                            }
                            goto IL_DC;
                        }
                    }
                    htmlNode = this._prevwithsamename;
                IL_DC:
                    if (htmlNode != null)
                    {
                        this._ownerdocument.Lastnodes[htmlNode.Name] = htmlNode;
                    }
                }
                internal void CloseNode(HtmlNode endnode, int level = 0)
                {
                    if (level > HtmlDocument.MaxDepthLevel)
                    {
                        throw new ArgumentException("The document is too complex to parse");
                    }
                    if (!this._ownerdocument.OptionAutoCloseOnEnd && this._childnodes != null)
                    {
                        foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this._childnodes))
                        {
                            if (!htmlNode.Closed)
                            {
                                HtmlNode htmlNode2 = new HtmlNode(this.NodeType, this._ownerdocument, -1);
                                htmlNode2._endnode = htmlNode2;
                                htmlNode.CloseNode(htmlNode2, level + 1);
                            }
                        }
                    }
                    if (!this.Closed)
                    {
                        this._endnode = endnode;
                        if (this._ownerdocument.Openednodes != null)
                        {
                            this._ownerdocument.Openednodes.Remove(this._outerstartindex);
                        }
                        if (Utilities.GetDictionaryValueOrDefault<string, HtmlNode>(this._ownerdocument.Lastnodes, this.Name, null) == this)
                        {
                            this._ownerdocument.Lastnodes.Remove(this.Name);
                            this._ownerdocument.UpdateLastParentNode();
                            if (this._starttag && !string.IsNullOrEmpty(this.Name))
                            {
                                this.UpdateLastNode();
                            }
                        }
                        if (endnode == this)
                        {
                            return;
                        }
                        this._innerstartindex = this._outerstartindex + this._outerlength;
                        this._innerlength = endnode._outerstartindex - this._innerstartindex;
                        this._outerlength = endnode._outerstartindex + endnode._outerlength - this._outerstartindex;
                    }
                }
                internal string GetId()
                {
                    HtmlAttribute htmlAttribute = this.Attributes["id"];
                    if (htmlAttribute != null)
                    {
                        return htmlAttribute.Value;
                    }
                    return string.Empty;
                }
                internal void SetId(string id)
                {
                    HtmlAttribute htmlAttribute = this.Attributes["id"] ?? this._ownerdocument.CreateAttribute("id");
                    htmlAttribute.Value = id;
                    this._ownerdocument.SetIdForNode(this, htmlAttribute.Value);
                    this.Attributes.Add(htmlAttribute);
                    this.SetChanged();
                }
                internal void WriteAttribute(System.IO.TextWriter outText, HtmlAttribute att)
                {
                    if (att.Value == null)
                    {
                        return;
                    }
                    string text = (att.QuoteType == AttributeValueQuote.DoubleQuote) ? "\"" : "'";
                    string text2;
                    if (this._ownerdocument.OptionOutputAsXml)
                    {
                        text2 = (this._ownerdocument.OptionOutputUpperCase ? att.XmlName.ToUpperInvariant() : att.XmlName);
                        if (this._ownerdocument.OptionOutputOriginalCase)
                        {
                            text2 = att.OriginalName;
                        }
                        outText.Write(string.Concat(new string[]
                        {
                    " ",
                    text2,
                    "=",
                    text,
                    HtmlDocument.HtmlEncodeWithCompatibility(att.XmlValue, this._ownerdocument.BackwardCompatibility),
                    text
                        }));
                        return;
                    }
                    text2 = (this._ownerdocument.OptionOutputUpperCase ? att.Name.ToUpperInvariant() : att.Name);
                    if (this._ownerdocument.OptionOutputOriginalCase)
                    {
                        text2 = att.OriginalName;
                    }
                    if (att.Name.Length >= 4 && att.Name[0] == '<' && att.Name[1] == '%' && att.Name[att.Name.Length - 1] == '>' && att.Name[att.Name.Length - 2] == '%')
                    {
                        outText.Write(" " + text2);
                        return;
                    }
                    if (!this._ownerdocument.OptionOutputOptimizeAttributeValues)
                    {
                        outText.Write(string.Concat(new string[]
                        {
                    " ",
                    text2,
                    "=",
                    text,
                    att.Value,
                    text
                        }));
                        return;
                    }
                    if (att.Value.IndexOfAny(new char[]
                    {
                '\n',
                '\r',
                '\t',
                ' '
                    }) < 0)
                    {
                        outText.Write(" " + text2 + "=" + att.Value);
                        return;
                    }
                    outText.Write(string.Concat(new string[]
                    {
                " ",
                text2,
                "=",
                text,
                att.Value,
                text
                    }));
                }
                internal void WriteAttributes(System.IO.TextWriter outText, bool closing)
                {
                    if (!this._ownerdocument.OptionOutputAsXml)
                    {
                        if (!closing)
                        {
                            if (this._attributes != null)
                            {
                                foreach (HtmlAttribute att in ((IEnumerable<HtmlAttribute>)this._attributes))
                                {
                                    this.WriteAttribute(outText, att);
                                }
                            }
                            if (!this._ownerdocument.OptionAddDebuggingAttributes)
                            {
                                return;
                            }
                            this.WriteAttribute(outText, this._ownerdocument.CreateAttribute("_closed", this.Closed.ToString()));
                            this.WriteAttribute(outText, this._ownerdocument.CreateAttribute("_children", this.ChildNodes.Count.ToString()));
                            int num = 0;
                            using (IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>)this.ChildNodes).GetEnumerator())
                            {
                                while (enumerator2.MoveNext())
                                {
                                    HtmlNode htmlNode = enumerator2.Current;
                                    this.WriteAttribute(outText, this._ownerdocument.CreateAttribute("_child_" + num, htmlNode.Name));
                                    num++;
                                }
                                return;
                            }
                        }
                        if (this._endnode == null || this._endnode._attributes == null || this._endnode == this)
                        {
                            return;
                        }
                        foreach (HtmlAttribute att2 in ((IEnumerable<HtmlAttribute>)this._endnode._attributes))
                        {
                            this.WriteAttribute(outText, att2);
                        }
                        if (!this._ownerdocument.OptionAddDebuggingAttributes)
                        {
                            return;
                        }
                        this.WriteAttribute(outText, this._ownerdocument.CreateAttribute("_closed", this.Closed.ToString()));
                        this.WriteAttribute(outText, this._ownerdocument.CreateAttribute("_children", this.ChildNodes.Count.ToString()));
                        return;
                    }
                    if (this._attributes == null)
                    {
                        return;
                    }
                    foreach (HtmlAttribute att3 in this._attributes.Hashitems.Values)
                    {
                        this.WriteAttribute(outText, att3);
                    }
                }
                private string GetRelativeXpath()
                {
                    if (this.ParentNode == null)
                    {
                        return this.Name;
                    }
                    if (this.NodeType == HtmlNodeType.Document)
                    {
                        return string.Empty;
                    }
                    int num = 1;
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)this.ParentNode.ChildNodes))
                    {
                        if (!(htmlNode.Name != this.Name))
                        {
                            if (htmlNode == this)
                            {
                                break;
                            }
                            num++;
                        }
                    }
                    return string.Concat(new object[]
                    {
                this.Name,
                "[",
                num,
                "]"
                    });
                }
                private bool IsSingleElementNode()
                {
                    int num = 0;
                    for (HtmlNode htmlNode = this.FirstChild; htmlNode != null; htmlNode = htmlNode.NextSibling)
                    {
                        if (htmlNode.NodeType == HtmlNodeType.Element && htmlNode.OuterHtml != "\r\n")
                        {
                            num++;
                        }
                    }
                    return num <= 1;
                }
                public void AddClass(string name)
                {
                    this.AddClass(name, false);
                }
                public void AddClass(string name, bool throwError)
                {
                    IEnumerable<HtmlAttribute> enumerable = this.Attributes.AttributesWithName("class");
                    if (!this.IsEmpty(enumerable))
                    {
                        using (IEnumerator<HtmlAttribute> enumerator = enumerable.GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                            {
                                HtmlAttribute htmlAttribute = enumerator.Current;
                                if (htmlAttribute.Value.Equals(name) || htmlAttribute.Value.Contains(name))
                                {
                                    if (throwError)
                                    {
                                        throw new Exception(HtmlDocument.HtmlExceptionClassExists);
                                    }
                                }
                                else
                                {
                                    this.SetAttributeValue(htmlAttribute.Name, htmlAttribute.Value + " " + name);
                                }
                            }
                            return;
                        }
                    }
                    HtmlAttribute newAttribute = this._ownerdocument.CreateAttribute("class", name);
                    this.Attributes.Append(newAttribute);
                }
                public void RemoveClass()
                {
                    this.RemoveClass(false);
                }
                public void RemoveClass(bool throwError)
                {
                    IEnumerable<HtmlAttribute> enumerable = this.Attributes.AttributesWithName("class");
                    if (this.IsEmpty(enumerable) && throwError)
                    {
                        throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
                    }
                    foreach (HtmlAttribute attribute in enumerable)
                    {
                        this.Attributes.Remove(attribute);
                    }
                }
                public void RemoveClass(string name)
                {
                    this.RemoveClass(name, false);
                }
                public void RemoveClass(string name, bool throwError)
                {
                    IEnumerable<HtmlAttribute> enumerable = this.Attributes.AttributesWithName("class");
                    if (this.IsEmpty(enumerable) && throwError)
                    {
                        throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
                    }
                    foreach (HtmlAttribute htmlAttribute in enumerable)
                    {
                        if (htmlAttribute.Value != null)
                        {
                            if (htmlAttribute.Value.Equals(name))
                            {
                                this.Attributes.Remove(htmlAttribute);
                            }
                            else if (htmlAttribute.Value.Contains(name))
                            {
                                string[] array = htmlAttribute.Value.Split(new char[]
                                {
                            ' '
                                });
                                string text = "";
                                foreach (string text2 in array)
                                {
                                    if (!text2.Equals(name))
                                    {
                                        text = text + text2 + " ";
                                    }
                                }
                                text = text.Trim();
                                this.SetAttributeValue(htmlAttribute.Name, text);
                            }
                            else if (throwError)
                            {
                                throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
                            }
                            if (string.IsNullOrEmpty(htmlAttribute.Value))
                            {
                                this.Attributes.Remove(htmlAttribute);
                            }
                        }
                    }
                }
                public void ReplaceClass(string newClass, string oldClass)
                {
                    this.ReplaceClass(newClass, oldClass, false);
                }
                public void ReplaceClass(string newClass, string oldClass, bool throwError)
                {
                    if (string.IsNullOrEmpty(newClass))
                    {
                        this.RemoveClass(oldClass);
                    }
                    if (string.IsNullOrEmpty(oldClass))
                    {
                        this.AddClass(newClass);
                    }
                    IEnumerable<HtmlAttribute> enumerable = this.Attributes.AttributesWithName("class");
                    if (this.IsEmpty(enumerable) && throwError)
                    {
                        throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
                    }
                    foreach (HtmlAttribute htmlAttribute in enumerable)
                    {
                        if (htmlAttribute.Value != null)
                        {
                            if (htmlAttribute.Value.Equals(oldClass) || htmlAttribute.Value.Contains(oldClass))
                            {
                                string value = htmlAttribute.Value.Replace(oldClass, newClass);
                                this.SetAttributeValue(htmlAttribute.Name, value);
                            }
                            else if (throwError)
                            {
                                throw new Exception(HtmlDocument.HtmlExceptionClassDoesNotExist);
                            }
                        }
                    }
                }
                public IEnumerable<string> GetClasses()
                {
                    IEnumerable<HtmlAttribute> enumerable = this.Attributes.AttributesWithName("class");
                    foreach (HtmlAttribute htmlAttribute in enumerable)
                    {
                        string[] tmp = null;
                        string[] array = htmlAttribute.Value.Split(tmp, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string text in array)
                        {
                            yield return text;
                        }
                    }
                    yield break;
                }
                public bool HasClass(string className)
                {
                    foreach (string text in this.GetClasses())
                    {
                        string[] tmp = null;
                        string[] array = text.Split(tmp, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] == className)
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                private bool IsEmpty(IEnumerable en)
                {
                    IEnumerator enumerator = en.GetEnumerator();
                    if (enumerator.MoveNext())
                    {
                        object obj = enumerator.Current;
                        return false;
                    }
                    return true;
                }
                public T GetEncapsulatedData<T>(HtmlDocument htmlDocument = null)
                {
                    return (T)((object)this.GetEncapsulatedData(typeof(T), htmlDocument));
                }
                public object GetEncapsulatedData(Type targetType, HtmlDocument htmlDocument = null)
                {
                    if (targetType == null)
                    {
                        throw new ArgumentNullException("Parameter targetType is null");
                    }
                    HtmlDocument htmlDocument2 = null;
                    if (htmlDocument == null)
                    {
                        htmlDocument2 = this.OwnerDocument;
                    }
                    else
                    {
                        htmlDocument2 = htmlDocument;
                    }
                    if (!targetType.IsInstantiable())
                    {
                        throw new MissingMethodException("Parameterless Constructor excpected for " + targetType.FullName);
                    }
                    object obj = Activator.CreateInstance(targetType);
                    if (!targetType.IsDefinedAttribute(typeof(HasXPathAttribute)))
                    {
                        throw new MissingXPathException("Type T must define HasXPath attribute and include properties with XPath attribute.");
                    }
                    IEnumerable<PropertyInfo> propertiesDefinedXPath = targetType.GetPropertiesDefinedXPath();
                    if (propertiesDefinedXPath.CountOfIEnumerable<PropertyInfo>() == 0)
                    {
                        throw new MissingXPathException("Type " + targetType.FullName + " defined HasXPath Attribute but it does not have any property with XPath Attribte.");
                    }
                    foreach (PropertyInfo propertyInfo in propertiesDefinedXPath)
                    {
                        XPathAttribute xpathAttribute = ((IList)propertyInfo.GetCustomAttributes(typeof(XPathAttribute), false))[0] as XPathAttribute;
                        if (!propertyInfo.IsIEnumerable())
                        {
                            HtmlNode htmlNode = null;
                            try
                            {
                                htmlNode = htmlDocument2.DocumentNode.SelectSingleNode(xpathAttribute.XPath);
                            }
                            catch
                            {
                                throw new NodeNotFoundException("Cannot find node with giving XPath to bind to " + propertyInfo.PropertyType.FullName + " " + propertyInfo.Name);
                            }
                            if (htmlNode == null)
                            {
                                throw new NodeNotFoundException("Cannot find node with givig XPath to bind to " + propertyInfo.PropertyType.FullName + " " + propertyInfo.Name);
                            }
                            if (propertyInfo.PropertyType.IsDefinedAttribute(typeof(HasXPathAttribute)))
                            {
                                HtmlDocument htmlDocument3 = new HtmlDocument();
                                htmlDocument3.LoadHtml(htmlNode.InnerHtml);
                                object encapsulatedData = this.GetEncapsulatedData(propertyInfo.PropertyType, htmlDocument3);
                                propertyInfo.SetValue(obj, encapsulatedData, null);
                            }
                            else
                            {
                                string text = string.Empty;
                                if (xpathAttribute.AttributeName == null)
                                {
                                    text = Tools.GetNodeValueBasedOnXPathReturnType<string>(htmlNode, xpathAttribute);
                                }
                                else
                                {
                                    text = htmlNode.GetAttributeValue(xpathAttribute.AttributeName, null);
                                }
                                if (text == null)
                                {
                                    throw new NodeAttributeNotFoundException(string.Concat(new string[]
                                    {
                                "Can not find ",
                                xpathAttribute.AttributeName,
                                " Attribute in ",
                                htmlNode.Name,
                                " related to ",
                                propertyInfo.PropertyType.FullName,
                                " ",
                                propertyInfo.Name
                                    }));
                                }
                                object value;
                                try
                                {
                                    value = Convert.ChangeType(text, propertyInfo.PropertyType);
                                }
                                catch (FormatException)
                                {
                                    throw new FormatException("Can not convert Invalid string to " + propertyInfo.PropertyType.FullName + " " + propertyInfo.Name);
                                }
                                catch (Exception ex)
                                {
                                    throw new Exception("Unhandled Exception : " + ex.Message);
                                }
                                propertyInfo.SetValue(obj, value, null);
                            }
                        }
                        else
                        {
                            IList<Type> list = propertyInfo.GetGenericTypes() as IList<Type>;
                            if (list == null || list.Count == 0)
                            {
                                throw new ArgumentException(propertyInfo.Name + " should have one generic argument.");
                            }
                            if (list.Count > 1)
                            {
                                throw new ArgumentException(propertyInfo.Name + " should have one generic argument.");
                            }
                            if (list.Count == 1)
                            {
                                HtmlNodeCollection htmlNodeCollection;
                                try
                                {
                                    htmlNodeCollection = htmlDocument2.DocumentNode.SelectNodes(xpathAttribute.XPath);
                                }
                                catch
                                {
                                    throw new NodeNotFoundException("Cannot find node with givig XPath to bind to " + propertyInfo.PropertyType.FullName + " " + propertyInfo.Name);
                                }
                                if (htmlNodeCollection == null || htmlNodeCollection.Count == 0)
                                {
                                    throw new NodeNotFoundException("Cannot find node with givig XPath to bind to " + propertyInfo.PropertyType.FullName + " " + propertyInfo.Name);
                                }
                                IList list2 = list[0].CreateIListOfType();
                                if (list[0].IsDefinedAttribute(typeof(HasXPathAttribute)))
                                {
                                    using (IEnumerator<HtmlNode> enumerator2 = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator())
                                    {
                                        while (enumerator2.MoveNext())
                                        {
                                            HtmlNode htmlNode2 = enumerator2.Current;
                                            HtmlDocument htmlDocument4 = new HtmlDocument();
                                            htmlDocument4.LoadHtml(htmlNode2.InnerHtml);
                                            object encapsulatedData2 = this.GetEncapsulatedData(list[0], htmlDocument4);
                                            list2.Add(encapsulatedData2);
                                        }
                                        goto IL_53C;
                                    }
                                }
                                goto IL_3D3;
                            IL_53C:
                                if (list2 == null || list2.Count == 0)
                                {
                                    throw new Exception(string.Concat(new string[]
                                    {
                                "Cannot fill ",
                                propertyInfo.PropertyType.FullName,
                                " ",
                                propertyInfo.Name,
                                " because it is null."
                                    }));
                                }
                                propertyInfo.SetValue(obj, list2, null);
                                continue;
                            IL_3D3:
                                if (xpathAttribute.AttributeName == null)
                                {
                                    try
                                    {
                                        list2 = Tools.GetNodesValuesBasedOnXPathReturnType(htmlNodeCollection, xpathAttribute, list[0]);
                                        goto IL_53C;
                                    }
                                    catch (FormatException)
                                    {
                                        throw new FormatException("Can not convert Invalid string in node collection to " + list[0].FullName + " " + propertyInfo.Name);
                                    }
                                    catch (Exception ex2)
                                    {
                                        throw new Exception("Unhandled Exception : " + ex2.Message);
                                    }
                                }
                                foreach (HtmlNode htmlNode3 in ((IEnumerable<HtmlNode>)htmlNodeCollection))
                                {
                                    string attributeValue = htmlNode3.GetAttributeValue(xpathAttribute.AttributeName, null);
                                    if (attributeValue == null)
                                    {
                                        throw new NodeAttributeNotFoundException(string.Concat(new string[]
                                        {
                                    "Can not find ",
                                    xpathAttribute.AttributeName,
                                    " Attribute in ",
                                    htmlNode3.Name,
                                    " related to ",
                                    propertyInfo.PropertyType.FullName,
                                    " ",
                                    propertyInfo.Name
                                        }));
                                    }
                                    object value2;
                                    try
                                    {
                                        value2 = Convert.ChangeType(attributeValue, list[0]);
                                    }
                                    catch (FormatException)
                                    {
                                        throw new FormatException("Can not convert Invalid string to " + list[0].FullName + " " + propertyInfo.Name);
                                    }
                                    catch (Exception ex3)
                                    {
                                        throw new Exception("Unhandled Exception : " + ex3.Message);
                                    }
                                    list2.Add(value2);
                                }
                                goto IL_53C;
                            }
                        }
                    }
                    return obj;
                }
                public XPathNavigator CreateNavigator()
                {
                    return new HtmlNodeNavigator(this.OwnerDocument, this);
                }
                public XPathNavigator CreateRootNavigator()
                {
                    return new HtmlNodeNavigator(this.OwnerDocument, this.OwnerDocument.DocumentNode);
                }
                public HtmlNodeCollection SelectNodes(string xpath)
                {
                    HtmlNodeCollection htmlNodeCollection = new HtmlNodeCollection(null);
                    XPathNodeIterator xpathNodeIterator = new HtmlNodeNavigator(this.OwnerDocument, this).Select(xpath);
                    while (xpathNodeIterator.MoveNext())
                    {
                        XPathNavigator xpathNavigator = xpathNodeIterator.Current;
                        HtmlNodeNavigator htmlNodeNavigator = (HtmlNodeNavigator)xpathNavigator;
                        htmlNodeCollection.Add(htmlNodeNavigator.CurrentNode, false);
                    }
                    if (htmlNodeCollection.Count == 0 && !this.OwnerDocument.OptionEmptyCollection)
                    {
                        return null;
                    }
                    return htmlNodeCollection;
                }
                public HtmlNodeCollection SelectNodes(XPathExpression xpath)
                {
                    HtmlNodeCollection htmlNodeCollection = new HtmlNodeCollection(null);
                    XPathNodeIterator xpathNodeIterator = new HtmlNodeNavigator(this.OwnerDocument, this).Select(xpath);
                    while (xpathNodeIterator.MoveNext())
                    {
                        XPathNavigator xpathNavigator = xpathNodeIterator.Current;
                        HtmlNodeNavigator htmlNodeNavigator = (HtmlNodeNavigator)xpathNavigator;
                        htmlNodeCollection.Add(htmlNodeNavigator.CurrentNode, false);
                    }
                    if (htmlNodeCollection.Count == 0 && !this.OwnerDocument.OptionEmptyCollection)
                    {
                        return null;
                    }
                    return htmlNodeCollection;
                }
                public HtmlNode SelectSingleNode(string xpath)
                {
                    if (xpath == null)
                    {
                        throw new ArgumentNullException("xpath");
                    }
                    XPathNodeIterator xpathNodeIterator = new HtmlNodeNavigator(this.OwnerDocument, this).Select(xpath);
                    if (!xpathNodeIterator.MoveNext())
                    {
                        return null;
                    }
                    return ((HtmlNodeNavigator)xpathNodeIterator.Current).CurrentNode;
                }
                public HtmlNode SelectSingleNode(XPathExpression xpath)
                {
                    if (xpath == null)
                    {
                        throw new ArgumentNullException("xpath");
                    }
                    XPathNodeIterator xpathNodeIterator = new HtmlNodeNavigator(this.OwnerDocument, this).Select(xpath);
                    if (!xpathNodeIterator.MoveNext())
                    {
                        return null;
                    }
                    return ((HtmlNodeNavigator)xpathNodeIterator.Current).CurrentNode;
                }
                internal const string DepthLevelExceptionMessage = "The document is too complex to parse";
                internal HtmlAttributeCollection _attributes;
                internal HtmlNodeCollection _childnodes;
                internal HtmlNode _endnode;
                private bool _changed;
                internal string _innerhtml;
                internal int _innerlength;
                internal int _innerstartindex;
                internal int _line;
                internal int _lineposition;
                private string _name;
                internal int _namelength;
                internal int _namestartindex;
                internal HtmlNode _nextnode;
                internal HtmlNodeType _nodetype;
                internal string _outerhtml;
                internal int _outerlength;
                internal int _outerstartindex;
                private string _optimizedName;
                internal HtmlDocument _ownerdocument;
                internal HtmlNode _parentnode;
                internal HtmlNode _prevnode;
                internal HtmlNode _prevwithsamename;
                internal bool _starttag;
                internal int _streamposition;
                internal bool _isImplicitEnd;
                public static readonly string HtmlNodeTypeNameComment = "#comment";
                public static readonly string HtmlNodeTypeNameDocument = "#document";
                public static readonly string HtmlNodeTypeNameText = "#text";
                public static Dictionary<string, HtmlElementFlag> ElementsFlags = new Dictionary<string, HtmlElementFlag>(StringComparer.OrdinalIgnoreCase);
            }
            public class HtmlNodeCollection : IList<HtmlNode>, ICollection<HtmlNode>, IEnumerable<HtmlNode>, IEnumerable
            {
                public HtmlNodeCollection(HtmlNode parentnode)
                {
                    this._parentnode = parentnode;
                }
                public int this[HtmlNode node]
                {
                    get
                    {
                        int nodeIndex = this.GetNodeIndex(node);
                        if (nodeIndex == -1)
                        {
                            throw new ArgumentOutOfRangeException("node", "Node \"" + node.CloneNode(false).OuterHtml + "\" was not found in the collection");
                        }
                        return nodeIndex;
                    }
                }
                public HtmlNode this[string nodeName]
                {
                    get
                    {
                        for (int i = 0; i < this._items.Count; i++)
                        {
                            if (string.Equals(this._items[i].Name, nodeName, StringComparison.OrdinalIgnoreCase))
                            {
                                return this._items[i];
                            }
                        }
                        return null;
                    }
                }
                public int Count
                {
                    get
                    {
                        return this._items.Count;
                    }
                }
                public bool IsReadOnly
                {
                    get
                    {
                        return false;
                    }
                }
                public HtmlNode this[int index]
                {
                    get
                    {
                        return this._items[index];
                    }
                    set
                    {
                        this._items[index] = value;
                    }
                }
                public void Add(HtmlNode node)
                {
                    this.Add(node, true);
                }
                public void Add(HtmlNode node, bool setParent)
                {
                    this._items.Add(node);
                    if (setParent)
                    {
                        node.ParentNode = this._parentnode;
                    }
                }
                public void Clear()
                {
                    foreach (HtmlNode htmlNode in this._items)
                    {
                        htmlNode.ParentNode = null;
                        htmlNode.NextSibling = null;
                        htmlNode.PreviousSibling = null;
                    }
                    this._items.Clear();
                }
                public bool Contains(HtmlNode item)
                {
                    return this._items.Contains(item);
                }
                public void CopyTo(HtmlNode[] array, int arrayIndex)
                {
                    this._items.CopyTo(array, arrayIndex);
                }
                IEnumerator<HtmlNode> IEnumerable<HtmlNode>.GetEnumerator()
                {
                    return this._items.GetEnumerator();
                }
                IEnumerator IEnumerable.GetEnumerator()
                {
                    return this._items.GetEnumerator();
                }
                public int IndexOf(HtmlNode item)
                {
                    return this._items.IndexOf(item);
                }
                public void Insert(int index, HtmlNode node)
                {
                    HtmlNode htmlNode = null;
                    HtmlNode htmlNode2 = null;
                    if (index > 0)
                    {
                        htmlNode2 = this._items[index - 1];
                    }
                    if (index < this._items.Count)
                    {
                        htmlNode = this._items[index];
                    }
                    this._items.Insert(index, node);
                    if (htmlNode2 != null)
                    {
                        if (node == htmlNode2)
                        {
                            throw new InvalidProgramException("Unexpected error.");
                        }
                        htmlNode2._nextnode = node;
                    }
                    if (htmlNode != null)
                    {
                        htmlNode._prevnode = node;
                    }
                    node._prevnode = htmlNode2;
                    if (htmlNode == node)
                    {
                        throw new InvalidProgramException("Unexpected error.");
                    }
                    node._nextnode = htmlNode;
                    node.SetParent(this._parentnode);
                }
                public bool Remove(HtmlNode item)
                {
                    int index = this._items.IndexOf(item);
                    this.RemoveAt(index);
                    return true;
                }
                public void RemoveAt(int index)
                {
                    HtmlNode htmlNode = null;
                    HtmlNode htmlNode2 = null;
                    HtmlNode htmlNode3 = this._items[index];
                    HtmlNode htmlNode4 = this._parentnode ?? htmlNode3._parentnode;
                    if (index > 0)
                    {
                        htmlNode2 = this._items[index - 1];
                    }
                    if (index < this._items.Count - 1)
                    {
                        htmlNode = this._items[index + 1];
                    }
                    this._items.RemoveAt(index);
                    if (htmlNode2 != null)
                    {
                        if (htmlNode == htmlNode2)
                        {
                            throw new InvalidProgramException("Unexpected error.");
                        }
                        htmlNode2._nextnode = htmlNode;
                    }
                    if (htmlNode != null)
                    {
                        htmlNode._prevnode = htmlNode2;
                    }
                    htmlNode3._prevnode = null;
                    htmlNode3._nextnode = null;
                    htmlNode3._parentnode = null;
                    if (htmlNode4 != null)
                    {
                        htmlNode4.SetChanged();
                    }
                }
                public static HtmlNode FindFirst(HtmlNodeCollection items, string name)
                {
                    foreach (HtmlNode htmlNode in ((IEnumerable<HtmlNode>)items))
                    {
                        if (htmlNode.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                        {
                            return htmlNode;
                        }
                        if (htmlNode.HasChildNodes)
                        {
                            HtmlNode htmlNode2 = HtmlNodeCollection.FindFirst(htmlNode.ChildNodes, name);
                            if (htmlNode2 != null)
                            {
                                return htmlNode2;
                            }
                        }
                    }
                    return null;
                }
                public void Append(HtmlNode node)
                {
                    HtmlNode htmlNode = null;
                    if (this._items.Count > 0)
                    {
                        htmlNode = this._items[this._items.Count - 1];
                    }
                    this._items.Add(node);
                    node._prevnode = htmlNode;
                    node._nextnode = null;
                    node.SetParent(this._parentnode);
                    if (htmlNode == null)
                    {
                        return;
                    }
                    if (htmlNode == node)
                    {
                        throw new InvalidProgramException("Unexpected error.");
                    }
                    htmlNode._nextnode = node;
                }
                public HtmlNode FindFirst(string name)
                {
                    return HtmlNodeCollection.FindFirst(this, name);
                }
                public int GetNodeIndex(HtmlNode node)
                {
                    for (int i = 0; i < this._items.Count; i++)
                    {
                        if (node == this._items[i])
                        {
                            return i;
                        }
                    }
                    return -1;
                }
                public void Prepend(HtmlNode node)
                {
                    HtmlNode htmlNode = null;
                    if (this._items.Count > 0)
                    {
                        htmlNode = this._items[0];
                    }
                    this._items.Insert(0, node);
                    if (node == htmlNode)
                    {
                        throw new InvalidProgramException("Unexpected error.");
                    }
                    node._nextnode = htmlNode;
                    node._prevnode = null;
                    node.SetParent(this._parentnode);
                    if (htmlNode != null)
                    {
                        htmlNode._prevnode = node;
                    }
                }
                public bool Remove(int index)
                {
                    this.RemoveAt(index);
                    return true;
                }
                public void Replace(int index, HtmlNode node)
                {
                    HtmlNode htmlNode = null;
                    HtmlNode htmlNode2 = null;
                    HtmlNode htmlNode3 = this._items[index];
                    if (index > 0)
                    {
                        htmlNode2 = this._items[index - 1];
                    }
                    if (index < this._items.Count - 1)
                    {
                        htmlNode = this._items[index + 1];
                    }
                    this._items[index] = node;
                    if (htmlNode2 != null)
                    {
                        if (node == htmlNode2)
                        {
                            throw new InvalidProgramException("Unexpected error.");
                        }
                        htmlNode2._nextnode = node;
                    }
                    if (htmlNode != null)
                    {
                        htmlNode._prevnode = node;
                    }
                    node._prevnode = htmlNode2;
                    if (htmlNode == node)
                    {
                        throw new InvalidProgramException("Unexpected error.");
                    }
                    node._nextnode = htmlNode;
                    node.SetParent(this._parentnode);
                    htmlNode3._prevnode = null;
                    htmlNode3._nextnode = null;
                    htmlNode3._parentnode = null;
                }
                public IEnumerable<HtmlNode> Descendants()
                {
                    foreach (HtmlNode htmlNode in this._items)
                    {
                        foreach (HtmlNode htmlNode2 in htmlNode.Descendants())
                        {
                            yield return htmlNode2;
                        }
                    }
                    yield break;
                }
                public IEnumerable<HtmlNode> Descendants(string name)
                {
                    foreach (HtmlNode htmlNode in this._items)
                    {
                        foreach (HtmlNode htmlNode2 in htmlNode.Descendants(name))
                        {
                            yield return htmlNode2;
                        }
                    }
                    yield break;
                }
                public IEnumerable<HtmlNode> Elements()
                {
                    foreach (HtmlNode htmlNode in this._items)
                    {
                        foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)htmlNode.ChildNodes))
                        {
                            yield return htmlNode2;
                        }
                    }
                    yield break;
                }
                public IEnumerable<HtmlNode> Elements(string name)
                {
                    foreach (HtmlNode htmlNode in this._items)
                    {
                        foreach (HtmlNode htmlNode2 in htmlNode.Elements(name))
                        {
                            yield return htmlNode2;
                        }
                    }
                    yield break;
                }
                public IEnumerable<HtmlNode> Nodes()
                {
                    foreach (HtmlNode htmlNode in this._items)
                    {
                        foreach (HtmlNode htmlNode2 in ((IEnumerable<HtmlNode>)htmlNode.ChildNodes))
                        {
                            yield return htmlNode2;
                        }
                    }
                    yield break;
                }
                private readonly HtmlNode _parentnode;
                private readonly List<HtmlNode> _items = new List<HtmlNode>();
            }
            public class HtmlNodeNavigator : XPathNavigator
            {
                internal HtmlNodeNavigator()
                {
                    this.Reset();
                }
                internal HtmlNodeNavigator(HtmlDocument doc, HtmlNode currentNode)
                {
                    if (currentNode == null)
                    {
                        throw new ArgumentNullException("currentNode");
                    }
                    if (currentNode.OwnerDocument != doc)
                    {
                        throw new ArgumentException(HtmlDocument.HtmlExceptionRefNotChild);
                    }
                    this._doc = doc;
                    this.Reset();
                    this._currentnode = currentNode;
                }
                private HtmlNodeNavigator(HtmlNodeNavigator nav)
                {
                    if (nav == null)
                    {
                        throw new ArgumentNullException("nav");
                    }
                    this._doc = nav._doc;
                    this._currentnode = nav._currentnode;
                    this._attindex = nav._attindex;
                    this._nametable = nav._nametable;
                }
                public HtmlNodeNavigator(System.IO.Stream stream)
                {
                    this._doc.Load(stream);
                    this.Reset();
                }
                public HtmlNodeNavigator(System.IO.Stream stream, bool detectEncodingFromByteOrderMarks)
                {
                    this._doc.Load(stream, detectEncodingFromByteOrderMarks);
                    this.Reset();
                }
                public HtmlNodeNavigator(System.IO.Stream stream, Encoding encoding)
                {
                    this._doc.Load(stream, encoding);
                    this.Reset();
                }
                public HtmlNodeNavigator(System.IO.Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
                {
                    this._doc.Load(stream, encoding, detectEncodingFromByteOrderMarks);
                    this.Reset();
                }
                public HtmlNodeNavigator(System.IO.Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
                {
                    this._doc.Load(stream, encoding, detectEncodingFromByteOrderMarks, buffersize);
                    this.Reset();
                }
                public HtmlNodeNavigator(System.IO.TextReader reader)
                {
                    this._doc.Load(reader);
                    this.Reset();
                }
                public HtmlNodeNavigator(string path)
                {
                    this._doc.Load(path);
                    this.Reset();
                }
                public HtmlNodeNavigator(string path, bool detectEncodingFromByteOrderMarks)
                {
                    this._doc.Load(path, detectEncodingFromByteOrderMarks);
                    this.Reset();
                }
                public HtmlNodeNavigator(string path, Encoding encoding)
                {
                    this._doc.Load(path, encoding);
                    this.Reset();
                }
                public HtmlNodeNavigator(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
                {
                    this._doc.Load(path, encoding, detectEncodingFromByteOrderMarks);
                    this.Reset();
                }
                public HtmlNodeNavigator(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
                {
                    this._doc.Load(path, encoding, detectEncodingFromByteOrderMarks, buffersize);
                    this.Reset();
                }
                public override string BaseURI
                {
                    get
                    {
                        return this._nametable.GetOrAdd(string.Empty);
                    }
                }
                public HtmlDocument CurrentDocument
                {
                    get
                    {
                        return this._doc;
                    }
                }
                public HtmlNode CurrentNode
                {
                    get
                    {
                        return this._currentnode;
                    }
                }
                public override bool HasAttributes
                {
                    get
                    {
                        return this._currentnode.Attributes.Count > 0;
                    }
                }
                public override bool HasChildren
                {
                    get
                    {
                        return this._currentnode.ChildNodes.Count > 0;
                    }
                }
                public override bool IsEmptyElement
                {
                    get
                    {
                        return !this.HasChildren;
                    }
                }
                public override string LocalName
                {
                    get
                    {
                        if (this._attindex != -1)
                        {
                            return this._nametable.GetOrAdd(this._currentnode.Attributes[this._attindex].Name);
                        }
                        return this._nametable.GetOrAdd(this._currentnode.Name);
                    }
                }
                public override string Name
                {
                    get
                    {
                        return this._nametable.GetOrAdd(this._currentnode.Name);
                    }
                }
                public override string NamespaceURI
                {
                    get
                    {
                        return this._nametable.GetOrAdd(string.Empty);
                    }
                }
                public override XmlNameTable NameTable
                {
                    get
                    {
                        return this._nametable;
                    }
                }
                public override XPathNodeType NodeType
                {
                    get
                    {
                        switch (this._currentnode.NodeType)
                        {
                            case HtmlNodeType.Document:
                                return XPathNodeType.Root;
                            case HtmlNodeType.Element:
                                if (this._attindex != -1)
                                {
                                    return XPathNodeType.Attribute;
                                }
                                return XPathNodeType.Element;
                            case HtmlNodeType.Comment:
                                return XPathNodeType.Comment;
                            case HtmlNodeType.Text:
                                return XPathNodeType.Text;
                            default:
                                throw new NotImplementedException("Internal error: Unhandled HtmlNodeType: " + this._currentnode.NodeType);
                        }
                    }
                }
                public override string Prefix
                {
                    get
                    {
                        return this._nametable.GetOrAdd(string.Empty);
                    }
                }
                public override string Value
                {
                    get
                    {
                        switch (this._currentnode.NodeType)
                        {
                            case HtmlNodeType.Document:
                                return "";
                            case HtmlNodeType.Element:
                                if (this._attindex != -1)
                                {
                                    return this._currentnode.Attributes[this._attindex].Value;
                                }
                                return this._currentnode.InnerText;
                            case HtmlNodeType.Comment:
                                return ((HtmlCommentNode)this._currentnode).Comment;
                            case HtmlNodeType.Text:
                                return ((HtmlTextNode)this._currentnode).Text;
                            default:
                                throw new NotImplementedException("Internal error: Unhandled HtmlNodeType: " + this._currentnode.NodeType);
                        }
                    }
                }
                public override string XmlLang
                {
                    get
                    {
                        return this._nametable.GetOrAdd(string.Empty);
                    }
                }
                public override XPathNavigator Clone()
                {
                    return new HtmlNodeNavigator(this);
                }
                public override string GetAttribute(string localName, string namespaceURI)
                {
                    HtmlAttribute htmlAttribute = this._currentnode.Attributes[localName];
                    if (htmlAttribute == null)
                    {
                        return null;
                    }
                    return htmlAttribute.Value;
                }
                public override string GetNamespace(string name)
                {
                    return string.Empty;
                }
                public override bool IsSamePosition(XPathNavigator other)
                {
                    HtmlNodeNavigator htmlNodeNavigator = other as HtmlNodeNavigator;
                    return htmlNodeNavigator != null && htmlNodeNavigator._currentnode == this._currentnode;
                }
                public override bool MoveTo(XPathNavigator other)
                {
                    HtmlNodeNavigator htmlNodeNavigator = other as HtmlNodeNavigator;
                    if (htmlNodeNavigator == null)
                    {
                        return false;
                    }
                    if (htmlNodeNavigator._doc == this._doc)
                    {
                        this._currentnode = htmlNodeNavigator._currentnode;
                        this._attindex = htmlNodeNavigator._attindex;
                        return true;
                    }
                    return false;
                }
                public override bool MoveToAttribute(string localName, string namespaceURI)
                {
                    int attributeIndex = this._currentnode.Attributes.GetAttributeIndex(localName);
                    if (attributeIndex == -1)
                    {
                        return false;
                    }
                    this._attindex = attributeIndex;
                    return true;
                }
                public override bool MoveToFirst()
                {
                    if (this._currentnode.ParentNode == null)
                    {
                        return false;
                    }
                    if (this._currentnode.ParentNode.FirstChild == null)
                    {
                        return false;
                    }
                    this._currentnode = this._currentnode.ParentNode.FirstChild;
                    return true;
                }
                public override bool MoveToFirstAttribute()
                {
                    if (!this.HasAttributes)
                    {
                        return false;
                    }
                    this._attindex = 0;
                    return true;
                }
                public override bool MoveToFirstChild()
                {
                    if (!this._currentnode.HasChildNodes)
                    {
                        return false;
                    }
                    this._currentnode = this._currentnode.ChildNodes[0];
                    return true;
                }
                public override bool MoveToFirstNamespace(XPathNamespaceScope scope)
                {
                    return false;
                }
                public override bool MoveToId(string id)
                {
                    HtmlNode elementbyId = this._doc.GetElementbyId(id);
                    if (elementbyId == null)
                    {
                        return false;
                    }
                    this._currentnode = elementbyId;
                    return true;
                }
                public override bool MoveToNamespace(string name)
                {
                    return false;
                }
                public override bool MoveToNext()
                {
                    if (this._currentnode.NextSibling == null)
                    {
                        return false;
                    }
                    this._currentnode = this._currentnode.NextSibling;
                    return true;
                }
                public override bool MoveToNextAttribute()
                {
                    if (this._attindex >= this._currentnode.Attributes.Count - 1)
                    {
                        return false;
                    }
                    this._attindex++;
                    return true;
                }
                public override bool MoveToNextNamespace(XPathNamespaceScope scope)
                {
                    return false;
                }
                public override bool MoveToParent()
                {
                    if (this._currentnode.ParentNode == null)
                    {
                        return false;
                    }
                    this._currentnode = this._currentnode.ParentNode;
                    return true;
                }
                public override bool MoveToPrevious()
                {
                    if (this._currentnode.PreviousSibling == null)
                    {
                        return false;
                    }
                    this._currentnode = this._currentnode.PreviousSibling;
                    return true;
                }
                public override void MoveToRoot()
                {
                    this._currentnode = this._doc.DocumentNode;
                }
                private void Reset()
                {
                    this._currentnode = this._doc.DocumentNode;
                    this._attindex = -1;
                }
                private int _attindex;
                private HtmlNode _currentnode;
                private readonly HtmlDocument _doc = new HtmlDocument();
                private readonly HtmlNameTable _nametable = new HtmlNameTable();
            }
            public enum HtmlNodeType
            {
                Document,
                Element,
                Comment,
                Text
            }
            public class HtmlParseError
            {
                internal HtmlParseError(HtmlParseErrorCode code, int line, int linePosition, int streamPosition, string sourceText, string reason)
                {
                    this._code = code;
                    this._line = line;
                    this._linePosition = linePosition;
                    this._streamPosition = streamPosition;
                    this._sourceText = sourceText;
                    this._reason = reason;
                }
                public HtmlParseErrorCode Code
                {
                    get
                    {
                        return this._code;
                    }
                }
                public int Line
                {
                    get
                    {
                        return this._line;
                    }
                }
                public int LinePosition
                {
                    get
                    {
                        return this._linePosition;
                    }
                }
                public string Reason
                {
                    get
                    {
                        return this._reason;
                    }
                }
                public string SourceText
                {
                    get
                    {
                        return this._sourceText;
                    }
                }
                public int StreamPosition
                {
                    get
                    {
                        return this._streamPosition;
                    }
                }
                private HtmlParseErrorCode _code;
                private int _line;
                private int _linePosition;
                private string _reason;
                private string _sourceText;
                private int _streamPosition;
            }
            public enum HtmlParseErrorCode
            {
                TagNotClosed,
                TagNotOpened,
                CharsetMismatch,
                EndTagNotRequired,
                EndTagInvalidHere
            }
            public class HtmlTextNode : HtmlNode
            {
                internal HtmlTextNode(HtmlDocument ownerdocument, int index) : base(HtmlNodeType.Text, ownerdocument, index)
                {
                }
                public override string InnerHtml
                {
                    get
                    {
                        return this.OuterHtml;
                    }
                    set
                    {
                        this._text = value;
                    }
                }
                public override string OuterHtml
                {
                    get
                    {
                        if (this._text == null)
                        {
                            return base.OuterHtml;
                        }
                        return this._text;
                    }
                }
                public string Text
                {
                    get
                    {
                        if (this._text == null)
                        {
                            return base.OuterHtml;
                        }
                        return this._text;
                    }
                    set
                    {
                        this._text = value;
                        base.SetChanged();
                    }
                }
                private string _text;
            }
            public class HtmlWeb
            {
                public bool AutoDetectEncoding
                {
                    get
                    {
                        return this._autoDetectEncoding;
                    }
                    set
                    {
                        this._autoDetectEncoding = value;
                    }
                }
                public Encoding OverrideEncoding
                {
                    get
                    {
                        return this._encoding;
                    }
                    set
                    {
                        this._encoding = value;
                    }
                }
                public bool CacheOnly
                {
                    get
                    {
                        return this._cacheOnly;
                    }
                    set
                    {
                        if (value && !this.UsingCache)
                        {
                            throw new HtmlWebException("Cache is not enabled. Set UsingCache to true first.");
                        }
                        this._cacheOnly = value;
                    }
                }
                public bool UsingCacheIfExists
                {
                    get
                    {
                        return this._usingCacheIfExists;
                    }
                    set
                    {
                        this._usingCacheIfExists = value;
                    }
                }
                public string CachePath
                {
                    get
                    {
                        return this._cachePath;
                    }
                    set
                    {
                        this._cachePath = value;
                    }
                }
                public bool FromCache
                {
                    get
                    {
                        return this._fromCache;
                    }
                }
                public int RequestDuration
                {
                    get
                    {
                        return this._requestDuration;
                    }
                }
                public Uri ResponseUri
                {
                    get
                    {
                        return this._responseUri;
                    }
                }
                public HttpStatusCode StatusCode
                {
                    get
                    {
                        return this._statusCode;
                    }
                }
                public int StreamBufferSize
                {
                    get
                    {
                        return this._streamBufferSize;
                    }
                    set
                    {
                        if (this._streamBufferSize <= 0)
                        {
                            throw new ArgumentException("Size must be greater than zero.");
                        }
                        this._streamBufferSize = value;
                    }
                }
                public bool UseCookies
                {
                    get
                    {
                        return this._useCookies;
                    }
                    set
                    {
                        this._useCookies = value;
                    }
                }
                public bool CaptureRedirect { get; set; }
                public string UserAgent
                {
                    get
                    {
                        return this._userAgent;
                    }
                    set
                    {
                        this._userAgent = value;
                    }
                }
                public bool UsingCache
                {
                    get
                    {
                        return this._cachePath != null && this._usingCache;
                    }
                    set
                    {
                        if (value && this._cachePath == null)
                        {
                            throw new HtmlWebException("You need to define a CachePath first.");
                        }
                        this._usingCache = value;
                    }
                }
                public static string GetContentTypeForExtension(string extension, string def)
                {
                    if (string.IsNullOrEmpty(extension))
                    {
                        return def;
                    }
                    string result = "";
                    if (!extension.StartsWith("."))
                    {
                        extension = "." + extension;
                    }
                    if (!MimeTypeMap.Mappings.TryGetValue(extension, out result))
                    {
                        result = def;
                    }
                    return result;
                }
                public static string GetExtensionForContentType(string contentType, string def)
                {
                    if (string.IsNullOrEmpty(contentType))
                    {
                        return def;
                    }
                    if (contentType.StartsWith("."))
                    {
                        throw new ArgumentException("Requested mime type is not valid: " + contentType);
                    }
                    string result = "";
                    if (!MimeTypeMap.Mappings.TryGetValue(contentType, out result))
                    {
                        result = def;
                    }
                    return result;
                }
                public object CreateInstance(string url, Type type)
                {
                    return this.CreateInstance(url, null, null, type);
                }
                public void Get(string url, string path)
                {
                    this.Get(url, path, "GET");
                }
                public void Get(string url, string path, WebProxy proxy, NetworkCredential credentials)
                {
                    this.Get(url, path, proxy, credentials, "GET");
                }
                public void Get(string url, string path, string method)
                {
                    Uri uri = new Uri(url);
                    if (uri.Scheme == Uri.UriSchemeHttps || uri.Scheme == Uri.UriSchemeHttp)
                    {
                        this.Get(uri, method, path, null, null, null);
                        return;
                    }
                    throw new HtmlWebException("Unsupported uri scheme: '" + uri.Scheme + "'.");
                }
                public void Get(string url, string path, WebProxy proxy, NetworkCredential credentials, string method)
                {
                    Uri uri = new Uri(url);
                    if (uri.Scheme == Uri.UriSchemeHttps || uri.Scheme == Uri.UriSchemeHttp)
                    {
                        this.Get(uri, method, path, null, proxy, credentials);
                        return;
                    }
                    throw new HtmlWebException("Unsupported uri scheme: '" + uri.Scheme + "'.");
                }
                public string GetCachePath(Uri uri)
                {
                    if (uri == null)
                    {
                        throw new ArgumentNullException("uri");
                    }
                    if (!this.UsingCache)
                    {
                        throw new HtmlWebException("Cache is not enabled. Set UsingCache to true first.");
                    }
                    string result;
                    if (uri.AbsolutePath == "/")
                    {
                        result = System.IO.Path.Combine(this._cachePath, ".htm");
                    }
                    else
                    {
                        string text = uri.AbsolutePath;
                        string text2 = new string(System.IO.Path.GetInvalidFileNameChars()) + new string(System.IO.Path.GetInvalidPathChars());
                        for (int i = 0; i < text2.Length; i++)
                        {
                            text = text.Replace(text2[i].ToString(), "");
                        }
                        if (uri.AbsolutePath[uri.AbsolutePath.Length - 1] == System.IO.Path.AltDirectorySeparatorChar)
                        {
                            result = System.IO.Path.Combine(this._cachePath, (uri.Host + text.TrimEnd(new char[]
                            {
                        System.IO.Path.AltDirectorySeparatorChar
                            })).Replace('/', '\\') + ".htm");
                        }
                        else
                        {
                            result = System.IO.Path.Combine(this._cachePath, uri.Host + text.Replace('/', '\\'));
                        }
                    }
                    return result;
                }
                public HtmlDocument Load(string url)
                {
                    return this.Load(url, "GET");
                }
                public HtmlDocument Load(Uri uri)
                {
                    return this.Load(uri, "GET");
                }
                public HtmlDocument Load(string url, string proxyHost, int proxyPort, string userId, string password)
                {
                    WebProxy webProxy = new WebProxy(proxyHost, proxyPort);
                    webProxy.BypassProxyOnLocal = true;
                    NetworkCredential networkCredential = null;
                    if (userId != null && password != null)
                    {
                        networkCredential = new NetworkCredential(userId, password);
                        CredentialCache credentialCache = new CredentialCache();
                        credentialCache.Add(webProxy.Address, "Basic", networkCredential);
                        credentialCache.Add(webProxy.Address, "Digest", networkCredential);
                    }
                    return this.Load(url, "GET", webProxy, networkCredential);
                }
                public HtmlDocument Load(Uri uri, string proxyHost, int proxyPort, string userId, string password)
                {
                    WebProxy webProxy = new WebProxy(proxyHost, proxyPort);
                    webProxy.BypassProxyOnLocal = true;
                    NetworkCredential networkCredential = null;
                    if (userId != null && password != null)
                    {
                        networkCredential = new NetworkCredential(userId, password);
                        CredentialCache credentialCache = new CredentialCache();
                        credentialCache.Add(webProxy.Address, "Basic", networkCredential);
                        credentialCache.Add(webProxy.Address, "Digest", networkCredential);
                    }
                    return this.Load(uri, "GET", webProxy, networkCredential);
                }
                public HtmlDocument Load(string url, string method)
                {
                    Uri uri = new Uri(url);
                    return this.Load(uri, method);
                }
                public HtmlDocument Load(Uri uri, string method)
                {
                    if (this.UsingCache)
                    {
                        this._usingCacheAndLoad = true;
                    }
                    HtmlDocument htmlDocument;
                    if (uri.Scheme == Uri.UriSchemeHttps || uri.Scheme == Uri.UriSchemeHttp)
                    {
                        htmlDocument = this.LoadUrl(uri, method, null, null);
                    }
                    else
                    {
                        if (!(uri.Scheme == Uri.UriSchemeFile))
                        {
                            throw new HtmlWebException("Unsupported uri scheme: '" + uri.Scheme + "'.");
                        }
                        htmlDocument = new HtmlDocument();
                        htmlDocument.OptionAutoCloseOnEnd = false;
                        htmlDocument.OptionAutoCloseOnEnd = true;
                        if (this.OverrideEncoding != null)
                        {
                            htmlDocument.Load(uri.OriginalString, this.OverrideEncoding);
                        }
                        else
                        {
                            htmlDocument.DetectEncodingAndLoad(uri.OriginalString, this._autoDetectEncoding);
                        }
                    }
                    if (this.PreHandleDocument != null)
                    {
                        this.PreHandleDocument(htmlDocument);
                    }
                    return htmlDocument;
                }
                public HtmlDocument Load(string url, string method, WebProxy proxy, NetworkCredential credentials)
                {
                    Uri uri = new Uri(url);
                    return this.Load(uri, method, proxy, credentials);
                }
                public HtmlDocument Load(Uri uri, string method, WebProxy proxy, NetworkCredential credentials)
                {
                    if (this.UsingCache)
                    {
                        this._usingCacheAndLoad = true;
                    }
                    HtmlDocument htmlDocument;
                    if (uri.Scheme == Uri.UriSchemeHttps || uri.Scheme == Uri.UriSchemeHttp)
                    {
                        htmlDocument = this.LoadUrl(uri, method, proxy, credentials);
                    }
                    else
                    {
                        if (!(uri.Scheme == Uri.UriSchemeFile))
                        {
                            throw new HtmlWebException("Unsupported uri scheme: '" + uri.Scheme + "'.");
                        }
                        htmlDocument = new HtmlDocument();
                        htmlDocument.OptionAutoCloseOnEnd = false;
                        htmlDocument.OptionAutoCloseOnEnd = true;
                        htmlDocument.DetectEncodingAndLoad(uri.OriginalString, this._autoDetectEncoding);
                    }
                    if (this.PreHandleDocument != null)
                    {
                        this.PreHandleDocument(htmlDocument);
                    }
                    return htmlDocument;
                }
                public void LoadHtmlAsXml(string htmlUrl, XmlTextWriter writer)
                {
                    this.Load(htmlUrl).Save(writer);
                }
                private static void FilePreparePath(string target)
                {
                    if (System.IO.File.Exists(target))
                    {
                        System.IO.FileAttributes attributes = System.IO.File.GetAttributes(target);
                        System.IO.File.SetAttributes(target, attributes & ~System.IO.FileAttributes.ReadOnly);
                        return;
                    }
                    string directoryName = System.IO.Path.GetDirectoryName(target);
                    if (!System.IO.Directory.Exists(directoryName))
                    {
                        System.IO.Directory.CreateDirectory(directoryName);
                    }
                }
                private static DateTime RemoveMilliseconds(DateTime t)
                {
                    return new DateTime(t.Year, t.Month, t.Day, t.Hour, t.Minute, t.Second, 0);
                }
                private static DateTime RemoveMilliseconds(DateTimeOffset? offset)
                {
                    DateTimeOffset dateTimeOffset = offset ?? DateTimeOffset.Now;
                    return new DateTime(dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day, dateTimeOffset.Hour, dateTimeOffset.Minute, dateTimeOffset.Second, 0);
                }
                private static long SaveStream(System.IO.Stream stream, string path, DateTime touchDate, int streamBufferSize)
                {
                    HtmlWeb.FilePreparePath(path);
                    long num = 0L;
                    using (System.IO.FileStream fileStream = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                    {
                        using (System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(stream))
                        {
                            using (System.IO.BinaryWriter binaryWriter = new System.IO.BinaryWriter(fileStream))
                            {
                                byte[] array;
                                do
                                {
                                    array = binaryReader.ReadBytes(streamBufferSize);
                                    num += (long)array.Length;
                                    if (array.Length != 0)
                                    {
                                        binaryWriter.Write(array);
                                    }
                                }
                                while (array.Length != 0);
                                binaryWriter.Flush();
                            }
                        }
                    }
                    System.IO.File.SetLastWriteTime(path, touchDate);
                    return num;
                }
                private HttpStatusCode Get(Uri uri, string method, string path, HtmlDocument doc, IWebProxy proxy, ICredentials creds)
                {
                    string text = null;
                    bool flag = false;
                    HttpWebRequest httpWebRequest = WebRequest.Create(uri) as HttpWebRequest;
                    httpWebRequest.Method = method;
                    httpWebRequest.UserAgent = this.UserAgent;
                    if (this.CaptureRedirect)
                    {
                        httpWebRequest.AllowAutoRedirect = false;
                    }
                    if (proxy != null)
                    {
                        if (creds != null)
                        {
                            proxy.Credentials = creds;
                            httpWebRequest.Credentials = creds;
                        }
                        else
                        {
                            proxy.Credentials = CredentialCache.DefaultCredentials;
                            httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
                        }
                        httpWebRequest.Proxy = proxy;
                    }
                    this._fromCache = false;
                    this._requestDuration = 0;
                    int tickCount = Environment.TickCount;
                    if (this.UsingCache)
                    {
                        text = this.GetCachePath(httpWebRequest.RequestUri);
                        if (System.IO.File.Exists(text))
                        {
                            httpWebRequest.IfModifiedSince = System.IO.File.GetLastAccessTime(text);
                            flag = true;
                        }
                    }
                    if (this._cacheOnly || this._usingCacheIfExists)
                    {
                        if (System.IO.File.Exists(text))
                        {
                            if (path != null)
                            {
                                IOLibrary.CopyAlways(text, path);
                                if (text != null)
                                {
                                    System.IO.File.SetLastWriteTime(path, System.IO.File.GetLastWriteTime(text));
                                }
                            }
                            this._fromCache = true;
                            return HttpStatusCode.NotModified;
                        }
                        if (this._cacheOnly)
                        {
                            throw new HtmlWebException("File was not found at cache path: '" + text + "'");
                        }
                    }
                    if (this._useCookies)
                    {
                        httpWebRequest.CookieContainer = new CookieContainer();
                    }
                    if (this.PreRequest != null && !this.PreRequest(httpWebRequest))
                    {
                        return HttpStatusCode.ResetContent;
                    }
                    HttpWebResponse httpWebResponse;
                    try
                    {
                        httpWebResponse = (httpWebRequest.GetResponse() as HttpWebResponse);
                    }
                    catch (WebException ex)
                    {
                        this._requestDuration = Environment.TickCount - tickCount;
                        httpWebResponse = (HttpWebResponse)ex.Response;
                        if (httpWebResponse == null)
                        {
                            if (flag)
                            {
                                if (path != null)
                                {
                                    IOLibrary.CopyAlways(text, path);
                                    System.IO.File.SetLastWriteTime(path, System.IO.File.GetLastWriteTime(text));
                                }
                                return HttpStatusCode.NotModified;
                            }
                            throw;
                        }
                    }
                    catch (Exception)
                    {
                        this._requestDuration = Environment.TickCount - tickCount;
                        throw;
                    }
                    if (this.PostResponse != null)
                    {
                        this.PostResponse(httpWebRequest, httpWebResponse);
                    }
                    this._requestDuration = Environment.TickCount - tickCount;
                    this._responseUri = httpWebResponse.ResponseUri;
                    HttpStatusCode statusCode = httpWebResponse.StatusCode;
                    bool flag2 = this.IsHtmlContent(httpWebResponse.ContentType);
                    bool flag3 = string.IsNullOrEmpty(httpWebResponse.ContentType);
                    Encoding encoding = (!string.IsNullOrEmpty(httpWebResponse.ContentEncoding)) ? Encoding.GetEncoding(httpWebResponse.ContentEncoding) : null;
                    if (this.OverrideEncoding != null)
                    {
                        encoding = this.OverrideEncoding;
                    }
                    if (this.CaptureRedirect && httpWebResponse.StatusCode == HttpStatusCode.Found)
                    {
                        string text2 = httpWebResponse.Headers["Location"];
                        Uri uri2;
                        if (!Uri.TryCreate(text2, UriKind.Absolute, out uri2))
                        {
                            uri2 = new Uri(uri, text2);
                        }
                        return this.Get(uri2, "GET", path, doc, proxy, creds);
                    }
                    if (httpWebResponse.StatusCode != HttpStatusCode.NotModified)
                    {
                        System.IO.Stream responseStream = httpWebResponse.GetResponseStream();
                        if (responseStream != null)
                        {
                            if (this.UsingCache)
                            {
                                HtmlWeb.SaveStream(responseStream, text, HtmlWeb.RemoveMilliseconds(httpWebResponse.LastModified), this._streamBufferSize);
                                this.SaveCacheHeaders(httpWebRequest.RequestUri, httpWebResponse);
                                if (path != null)
                                {
                                    IOLibrary.CopyAlways(text, path);
                                    System.IO.File.SetLastWriteTime(path, System.IO.File.GetLastWriteTime(text));
                                }
                                if (this._usingCacheAndLoad)
                                {
                                    doc.Load(text);
                                }
                            }
                            else
                            {
                                if (doc != null && flag2)
                                {
                                    if (encoding == null)
                                    {
                                        doc.Load(responseStream, true);
                                    }
                                    else
                                    {
                                        doc.Load(responseStream, encoding);
                                    }
                                }
                                if (doc != null && flag3)
                                {
                                    try
                                    {
                                        if (encoding == null)
                                        {
                                            doc.Load(responseStream, true);
                                        }
                                        else
                                        {
                                            doc.Load(responseStream, encoding);
                                        }
                                    }
                                    catch
                                    {
                                    }
                                }
                            }
                            httpWebResponse.Close();
                        }
                        return statusCode;
                    }
                    if (this.UsingCache)
                    {
                        this._fromCache = true;
                        if (path != null)
                        {
                            IOLibrary.CopyAlways(text, path);
                            System.IO.File.SetLastWriteTime(path, System.IO.File.GetLastWriteTime(text));
                        }
                        return httpWebResponse.StatusCode;
                    }
                    throw new HtmlWebException("Server has send a NotModifed code, without cache enabled.");
                }
                private string GetCacheHeader(Uri requestUri, string name, string def)
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(this.GetCacheHeadersPath(requestUri));
                    XmlNode xmlNode = xmlDocument.SelectSingleNode("//h[translate(@n, 'abcdefghijklmnopqrstuvwxyz','ABCDEFGHIJKLMNOPQRSTUVWXYZ')='" + name.ToUpperInvariant() + "']");
                    if (xmlNode == null)
                    {
                        return def;
                    }
                    return xmlNode.Attributes[name].Value;
                }
                private string GetCacheHeadersPath(Uri uri)
                {
                    return this.GetCachePath(uri) + ".h.xml";
                }
                private bool IsCacheHtmlContent(string path)
                {
                    string contentTypeForExtension = HtmlWeb.GetContentTypeForExtension(System.IO.Path.GetExtension(path), null);
                    return this.IsHtmlContent(contentTypeForExtension);
                }
                private bool IsHtmlContent(string contentType)
                {
                    return contentType.ToLowerInvariant().StartsWith("text/html");
                }
                private bool IsGZipEncoding(string contentEncoding)
                {
                    return contentEncoding.ToLowerInvariant().StartsWith("gzip");
                }
                private HtmlDocument LoadUrl(Uri uri, string method, WebProxy proxy, NetworkCredential creds)
                {
                    HtmlDocument htmlDocument = new HtmlDocument();
                    htmlDocument.OptionAutoCloseOnEnd = false;
                    htmlDocument.OptionFixNestedTags = true;
                    this._statusCode = this.Get(uri, method, null, htmlDocument, proxy, creds);
                    if (this._statusCode == HttpStatusCode.NotModified)
                    {
                        htmlDocument.DetectEncodingAndLoad(this.GetCachePath(uri));
                    }
                    return htmlDocument;
                }
                private void SaveCacheHeaders(Uri requestUri, HttpWebResponse resp)
                {
                    string cacheHeadersPath = this.GetCacheHeadersPath(requestUri);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml("<c></c>");
                    XmlNode firstChild = xmlDocument.FirstChild;
                    foreach (object obj in resp.Headers)
                    {
                        string text = (string)obj;
                        XmlNode xmlNode = xmlDocument.CreateElement("h");
                        XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("n");
                        xmlAttribute.Value = text;
                        xmlNode.Attributes.Append(xmlAttribute);
                        xmlAttribute = xmlDocument.CreateAttribute("v");
                        xmlAttribute.Value = resp.Headers[text];
                        xmlNode.Attributes.Append(xmlAttribute);
                        firstChild.AppendChild(xmlNode);
                    }
                    xmlDocument.Save(cacheHeadersPath);
                }
                public TimeSpan BrowserTimeout
                {
                    get
                    {
                        return this._browserTimeout;
                    }
                    set
                    {
                        this._browserTimeout = value;
                    }
                }
                public TimeSpan BrowserDelay
                {
                    get
                    {
                        return this._browserDelay;
                    }
                    set
                    {
                        this._browserDelay = value;
                    }
                }
                public HtmlDocument LoadFromBrowser(string url)
                {
                    return this.LoadFromBrowser(url, (object browser) => true);
                }
                internal string WebBrowserOuterHtml(object webBrowser)
                {
                    try
                    {
                        PropertyInfo property = webBrowser.GetType().GetProperty("Url");
                        this._responseUri = (Uri)property.GetValue(webBrowser, null);
                    }
                    catch
                    {
                    }
                    object value = webBrowser.GetType().GetProperty("Document").GetValue(webBrowser, null);
                    MethodBase method = value.GetType().GetMethod("GetElementsByTagName", new Type[]
                    {
                typeof(string)
                    });
                    object obj = value;
                    object[] parameters = new string[]
                    {
                "HTML"
                    };
                    object obj2 = method.Invoke(obj, parameters);
                    object value2 = obj2.GetType().GetProperty("Item", new Type[]
                    {
                typeof(int)
                    }).GetValue(obj2, new object[]
                    {
                0
                    });
                    return (string)value2.GetType().GetProperty("OuterHtml").GetValue(value2, null);
                }
                public HtmlDocument LoadFromBrowser(string url, Func<string, bool> isBrowserScriptCompleted = null)
                {
                    return this.LoadFromBrowser(url, (object browser) => isBrowserScriptCompleted == null || isBrowserScriptCompleted(this.WebBrowserOuterHtml(browser)));
                }
                public HtmlDocument LoadFromBrowser(string url, Func<object, bool> isBrowserScriptCompleted = null)
                {
                    Assembly assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault((Assembly x) => x.GetName().Name == "System.Windows.Forms");
                    if (assembly == null)
                    {
                        try
                        {
                            Assembly assembly2 = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault((Assembly x) => x.GetName().Name == "System");
                            if (assembly2 != null)
                            {
                                Assembly.LoadFile(assembly2.CodeBase.Replace("System", "System.Windows.Forms").Replace("file:///", ""));
                            }
                        }
                        catch (Exception)
                        {
                        }
                        assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault((Assembly x) => x.GetName().Name == "System.Windows.Forms");
                        if (assembly == null)
                        {
                            throw new Exception("Oops! No reference to System.Windows.Forms have been loaded. Make sure your project load any type from this assembly to make sure the reference is added to the domain assemblies list. Example: `var webBrowserType = typeof(WebBrowser);`");
                        }
                    }
                    Type type = assembly.GetType("System.Windows.Forms.WebBrowser");
                    ConstructorInfo constructor = type.GetConstructor(new Type[0]);
                    MethodInfo method = assembly.GetType("System.Windows.Forms.Application").GetMethod("DoEvents");
                    Uri uri = new Uri(url);
                    HtmlDocument htmlDocument = new HtmlDocument();
                    string message = "WebBrowser Execution Timeout Expired. The timeout period elapsed prior to completion of the operation. To avoid this error, increase the WebBrowserTimeout value or set it to 0 (unlimited).";
                    using (IDisposable disposable = (IDisposable)constructor.Invoke(new object[0]))
                    {
                        type.GetProperty("ScriptErrorsSuppressed").SetValue(disposable, true, null);
                        type.GetMethod("Navigate", new Type[]
                        {
                    typeof(Uri)
                        }).Invoke(disposable, new object[]
                        {
                    uri
                        });
                        PropertyInfo property = type.GetProperty("ReadyState");
                        PropertyInfo property2 = type.GetProperty("IsBusy");
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        while ((int)property.GetValue(disposable, null) != 4 || (bool)property2.GetValue(disposable, null))
                        {
                            if (this.BrowserTimeout.TotalMilliseconds != 0.0 && (double)stopwatch.ElapsedMilliseconds > this.BrowserTimeout.TotalMilliseconds)
                            {
                                throw new Exception(message);
                            }
                            method.Invoke(null, new object[0]);
                            Thread.Sleep(this._browserDelay);
                        }
                        if (isBrowserScriptCompleted != null)
                        {
                            while (!isBrowserScriptCompleted(disposable))
                            {
                                if (this.BrowserTimeout.TotalMilliseconds != 0.0 && (double)stopwatch.ElapsedMilliseconds > this.BrowserTimeout.TotalMilliseconds)
                                {
                                    this.WebBrowserOuterHtml(disposable);
                                    throw new Exception(message);
                                }
                                method.Invoke(null, new object[0]);
                                Thread.Sleep(this._browserDelay);
                            }
                        }
                        string html = this.WebBrowserOuterHtml(disposable);
                        htmlDocument.LoadHtml(html);
                    }
                    return htmlDocument;
                }
                public object CreateInstance(string htmlUrl, string xsltUrl, XsltArgumentList xsltArgs, Type type)
                {
                    return this.CreateInstance(htmlUrl, xsltUrl, xsltArgs, type, null);
                }
                public object CreateInstance(string htmlUrl, string xsltUrl, XsltArgumentList xsltArgs, Type type, string xmlPath)
                {
                    System.IO.StringWriter stringWriter = new System.IO.StringWriter();
                    XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
                    if (xsltUrl == null)
                    {
                        this.LoadHtmlAsXml(htmlUrl, xmlTextWriter);
                    }
                    else if (xmlPath == null)
                    {
                        this.LoadHtmlAsXml(htmlUrl, xsltUrl, xsltArgs, xmlTextWriter);
                    }
                    else
                    {
                        this.LoadHtmlAsXml(htmlUrl, xsltUrl, xsltArgs, xmlTextWriter, xmlPath);
                    }
                    xmlTextWriter.Flush();
                    XmlTextReader xmlReader = new XmlTextReader(new System.IO.StringReader(stringWriter.ToString()));
                    XmlSerializer xmlSerializer = new XmlSerializer(type);
                    object result;
                    try
                    {
                        result = xmlSerializer.Deserialize(xmlReader);
                    }
                    catch (InvalidOperationException arg)
                    {
                        throw new Exception(arg + ", --- xml:" + stringWriter);
                    }
                    return result;
                }
                public void LoadHtmlAsXml(string htmlUrl, string xsltUrl, XsltArgumentList xsltArgs, XmlTextWriter writer)
                {
                    this.LoadHtmlAsXml(htmlUrl, xsltUrl, xsltArgs, writer, null);
                }
                public void LoadHtmlAsXml(string htmlUrl, string xsltUrl, XsltArgumentList xsltArgs, XmlTextWriter writer, string xmlPath)
                {
                    if (htmlUrl == null)
                    {
                        throw new ArgumentNullException("htmlUrl");
                    }
                    HtmlDocument htmlDocument = this.Load(htmlUrl);
                    if (xmlPath != null)
                    {
                        XmlTextWriter xmlTextWriter = new XmlTextWriter(xmlPath, htmlDocument.Encoding);
                        htmlDocument.Save(xmlTextWriter);
                        xmlTextWriter.Close();
                    }
                    if (xsltArgs == null)
                    {
                        xsltArgs = new XsltArgumentList();
                    }
                    xsltArgs.AddParam("url", "", htmlUrl);
                    xsltArgs.AddParam("requestDuration", "", this.RequestDuration);
                    xsltArgs.AddParam("fromCache", "", this.FromCache);
                    XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
                    xslCompiledTransform.Load(xsltUrl);
                    xslCompiledTransform.Transform(htmlDocument, xsltArgs, writer);
                }
                private bool _autoDetectEncoding = true;
                private bool _cacheOnly;
                private string _cachePath;
                private bool _fromCache;
                private int _requestDuration;
                private Uri _responseUri;
                private HttpStatusCode _statusCode = HttpStatusCode.OK;
                private int _streamBufferSize = 1024;
                private bool _useCookies;
                private bool _usingCache;
                private bool _usingCacheAndLoad;
                private bool _usingCacheIfExists;
                private string _userAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:x.x.x) Gecko/20041107 Firefox/x.x";
                public HtmlWeb.PostResponseHandler PostResponse;
                public HtmlWeb.PreHandleDocumentHandler PreHandleDocument;
                public HtmlWeb.PreRequestHandler PreRequest;
                private Encoding _encoding;
                private TimeSpan _browserTimeout = TimeSpan.FromSeconds(30.0);
                private TimeSpan _browserDelay = TimeSpan.FromMilliseconds(100.0);
                // (Invoke) Token: 0x060002FC RID: 764
                public delegate void PostResponseHandler(HttpWebRequest request, HttpWebResponse response);
                // (Invoke) Token: 0x06000300 RID: 768
                public delegate void PreHandleDocumentHandler(HtmlDocument document);
                // (Invoke) Token: 0x06000304 RID: 772
                public delegate bool PreRequestHandler(HttpWebRequest request);
            }
            public class HtmlWebException : Exception
            {
                public HtmlWebException(string message) : base(message)
                {
                }
            }
            internal struct IOLibrary
            {
                internal static void CopyAlways(string source, string target)
                {
                    if (!System.IO.File.Exists(source))
                    {
                        return;
                    }
                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(target));
                    IOLibrary.MakeWritable(target);
                    System.IO.File.Copy(source, target, true);
                }
                internal static void MakeWritable(string path)
                {
                    if (!System.IO.File.Exists(path))
                    {
                        return;
                    }
                    System.IO.File.SetAttributes(path, System.IO.File.GetAttributes(path) & ~System.IO.FileAttributes.ReadOnly);
                }
            }
            internal static class MimeTypeMap
            {
                public static IDictionary<string, string> Mappings = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {
                ".323",
                "text/h323"
            },
            {
                ".3g2",
                "video/3gpp2"
            },
            {
                ".3gp",
                "video/3gpp"
            },
            {
                ".3gp2",
                "video/3gpp2"
            },
            {
                ".3gpp",
                "video/3gpp"
            },
            {
                ".7z",
                "application/x-7z-compressed"
            },
            {
                ".aa",
                "audio/audible"
            },
            {
                ".AAC",
                "audio/aac"
            },
            {
                ".aaf",
                "application/octet-stream"
            },
            {
                ".aax",
                "audio/vnd.audible.aax"
            },
            {
                ".ac3",
                "audio/ac3"
            },
            {
                ".aca",
                "application/octet-stream"
            },
            {
                ".accda",
                "application/msaccess.addin"
            },
            {
                ".accdb",
                "application/msaccess"
            },
            {
                ".accdc",
                "application/msaccess.cab"
            },
            {
                ".accde",
                "application/msaccess"
            },
            {
                ".accdr",
                "application/msaccess.runtime"
            },
            {
                ".accdt",
                "application/msaccess"
            },
            {
                ".accdw",
                "application/msaccess.webapplication"
            },
            {
                ".accft",
                "application/msaccess.ftemplate"
            },
            {
                ".acx",
                "application/internet-property-stream"
            },
            {
                ".AddIn",
                "text/xml"
            },
            {
                ".ade",
                "application/msaccess"
            },
            {
                ".adobebridge",
                "application/x-bridge-url"
            },
            {
                ".adp",
                "application/msaccess"
            },
            {
                ".ADT",
                "audio/vnd.dlna.adts"
            },
            {
                ".ADTS",
                "audio/aac"
            },
            {
                ".afm",
                "application/octet-stream"
            },
            {
                ".ai",
                "application/postscript"
            },
            {
                ".aif",
                "audio/aiff"
            },
            {
                ".aifc",
                "audio/aiff"
            },
            {
                ".aiff",
                "audio/aiff"
            },
            {
                ".air",
                "application/vnd.adobe.air-application-installer-package+zip"
            },
            {
                ".amc",
                "application/mpeg"
            },
            {
                ".anx",
                "application/annodex"
            },
            {
                ".apk",
                "application/vnd.android.package-archive"
            },
            {
                ".application",
                "application/x-ms-application"
            },
            {
                ".art",
                "image/x-jg"
            },
            {
                ".asa",
                "application/xml"
            },
            {
                ".asax",
                "application/xml"
            },
            {
                ".ascx",
                "application/xml"
            },
            {
                ".asd",
                "application/octet-stream"
            },
            {
                ".asf",
                "video/x-ms-asf"
            },
            {
                ".ashx",
                "application/xml"
            },
            {
                ".asi",
                "application/octet-stream"
            },
            {
                ".asm",
                "text/plain"
            },
            {
                ".asmx",
                "application/xml"
            },
            {
                ".aspx",
                "application/xml"
            },
            {
                ".asr",
                "video/x-ms-asf"
            },
            {
                ".asx",
                "video/x-ms-asf"
            },
            {
                ".atom",
                "application/atom+xml"
            },
            {
                ".au",
                "audio/basic"
            },
            {
                ".avi",
                "video/x-msvideo"
            },
            {
                ".axa",
                "audio/annodex"
            },
            {
                ".axs",
                "application/olescript"
            },
            {
                ".axv",
                "video/annodex"
            },
            {
                ".bas",
                "text/plain"
            },
            {
                ".bcpio",
                "application/x-bcpio"
            },
            {
                ".bin",
                "application/octet-stream"
            },
            {
                ".bmp",
                "image/bmp"
            },
            {
                ".c",
                "text/plain"
            },
            {
                ".cab",
                "application/octet-stream"
            },
            {
                ".caf",
                "audio/x-caf"
            },
            {
                ".calx",
                "application/vnd.ms-office.calx"
            },
            {
                ".cat",
                "application/vnd.ms-pki.seccat"
            },
            {
                ".cc",
                "text/plain"
            },
            {
                ".cd",
                "text/plain"
            },
            {
                ".cdda",
                "audio/aiff"
            },
            {
                ".cdf",
                "application/x-cdf"
            },
            {
                ".cer",
                "application/x-x509-ca-cert"
            },
            {
                ".cfg",
                "text/plain"
            },
            {
                ".chm",
                "application/octet-stream"
            },
            {
                ".class",
                "application/x-java-applet"
            },
            {
                ".clp",
                "application/x-msclip"
            },
            {
                ".cmd",
                "text/plain"
            },
            {
                ".cmx",
                "image/x-cmx"
            },
            {
                ".cnf",
                "text/plain"
            },
            {
                ".cod",
                "image/cis-cod"
            },
            {
                ".config",
                "application/xml"
            },
            {
                ".contact",
                "text/x-ms-contact"
            },
            {
                ".coverage",
                "application/xml"
            },
            {
                ".cpio",
                "application/x-cpio"
            },
            {
                ".cpp",
                "text/plain"
            },
            {
                ".crd",
                "application/x-mscardfile"
            },
            {
                ".crl",
                "application/pkix-crl"
            },
            {
                ".crt",
                "application/x-x509-ca-cert"
            },
            {
                ".cs",
                "text/plain"
            },
            {
                ".csdproj",
                "text/plain"
            },
            {
                ".csh",
                "application/x-csh"
            },
            {
                ".csproj",
                "text/plain"
            },
            {
                ".css",
                "text/css"
            },
            {
                ".csv",
                "text/csv"
            },
            {
                ".cur",
                "application/octet-stream"
            },
            {
                ".cxx",
                "text/plain"
            },
            {
                ".dat",
                "application/octet-stream"
            },
            {
                ".datasource",
                "application/xml"
            },
            {
                ".dbproj",
                "text/plain"
            },
            {
                ".dcr",
                "application/x-director"
            },
            {
                ".def",
                "text/plain"
            },
            {
                ".deploy",
                "application/octet-stream"
            },
            {
                ".der",
                "application/x-x509-ca-cert"
            },
            {
                ".dgml",
                "application/xml"
            },
            {
                ".dib",
                "image/bmp"
            },
            {
                ".dif",
                "video/x-dv"
            },
            {
                ".dir",
                "application/x-director"
            },
            {
                ".disco",
                "text/xml"
            },
            {
                ".divx",
                "video/divx"
            },
            {
                ".dll",
                "application/x-msdownload"
            },
            {
                ".dll.config",
                "text/xml"
            },
            {
                ".dlm",
                "text/dlm"
            },
            {
                ".doc",
                "application/msword"
            },
            {
                ".docm",
                "application/vnd.ms-word.document.macroEnabled.12"
            },
            {
                ".docx",
                "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
            },
            {
                ".dot",
                "application/msword"
            },
            {
                ".dotm",
                "application/vnd.ms-word.template.macroEnabled.12"
            },
            {
                ".dotx",
                "application/vnd.openxmlformats-officedocument.wordprocessingml.template"
            },
            {
                ".dsp",
                "application/octet-stream"
            },
            {
                ".dsw",
                "text/plain"
            },
            {
                ".dtd",
                "text/xml"
            },
            {
                ".dtsConfig",
                "text/xml"
            },
            {
                ".dv",
                "video/x-dv"
            },
            {
                ".dvi",
                "application/x-dvi"
            },
            {
                ".dwf",
                "drawing/x-dwf"
            },
            {
                ".dwg",
                "application/acad"
            },
            {
                ".dwp",
                "application/octet-stream"
            },
            {
                ".dxf",
                "application/x-dxf"
            },
            {
                ".dxr",
                "application/x-director"
            },
            {
                ".eml",
                "message/rfc822"
            },
            {
                ".emz",
                "application/octet-stream"
            },
            {
                ".eot",
                "application/vnd.ms-fontobject"
            },
            {
                ".eps",
                "application/postscript"
            },
            {
                ".es",
                "application/ecmascript"
            },
            {
                ".etl",
                "application/etl"
            },
            {
                ".etx",
                "text/x-setext"
            },
            {
                ".evy",
                "application/envoy"
            },
            {
                ".exe",
                "application/octet-stream"
            },
            {
                ".exe.config",
                "text/xml"
            },
            {
                ".fdf",
                "application/vnd.fdf"
            },
            {
                ".fif",
                "application/fractals"
            },
            {
                ".filters",
                "application/xml"
            },
            {
                ".fla",
                "application/octet-stream"
            },
            {
                ".flac",
                "audio/flac"
            },
            {
                ".flr",
                "x-world/x-vrml"
            },
            {
                ".flv",
                "video/x-flv"
            },
            {
                ".fsscript",
                "application/fsharp-script"
            },
            {
                ".fsx",
                "application/fsharp-script"
            },
            {
                ".generictest",
                "application/xml"
            },
            {
                ".gif",
                "image/gif"
            },
            {
                ".gpx",
                "application/gpx+xml"
            },
            {
                ".group",
                "text/x-ms-group"
            },
            {
                ".gsm",
                "audio/x-gsm"
            },
            {
                ".gtar",
                "application/x-gtar"
            },
            {
                ".gz",
                "application/x-gzip"
            },
            {
                ".h",
                "text/plain"
            },
            {
                ".hdf",
                "application/x-hdf"
            },
            {
                ".hdml",
                "text/x-hdml"
            },
            {
                ".hhc",
                "application/x-oleobject"
            },
            {
                ".hhk",
                "application/octet-stream"
            },
            {
                ".hhp",
                "application/octet-stream"
            },
            {
                ".hlp",
                "application/winhlp"
            },
            {
                ".hpp",
                "text/plain"
            },
            {
                ".hqx",
                "application/mac-binhex40"
            },
            {
                ".hta",
                "application/hta"
            },
            {
                ".htc",
                "text/x-component"
            },
            {
                ".htm",
                "text/html"
            },
            {
                ".html",
                "text/html"
            },
            {
                ".htt",
                "text/webviewhtml"
            },
            {
                ".hxa",
                "application/xml"
            },
            {
                ".hxc",
                "application/xml"
            },
            {
                ".hxd",
                "application/octet-stream"
            },
            {
                ".hxe",
                "application/xml"
            },
            {
                ".hxf",
                "application/xml"
            },
            {
                ".hxh",
                "application/octet-stream"
            },
            {
                ".hxi",
                "application/octet-stream"
            },
            {
                ".hxk",
                "application/xml"
            },
            {
                ".hxq",
                "application/octet-stream"
            },
            {
                ".hxr",
                "application/octet-stream"
            },
            {
                ".hxs",
                "application/octet-stream"
            },
            {
                ".hxt",
                "text/html"
            },
            {
                ".hxv",
                "application/xml"
            },
            {
                ".hxw",
                "application/octet-stream"
            },
            {
                ".hxx",
                "text/plain"
            },
            {
                ".i",
                "text/plain"
            },
            {
                ".ico",
                "image/x-icon"
            },
            {
                ".ics",
                "application/octet-stream"
            },
            {
                ".idl",
                "text/plain"
            },
            {
                ".ief",
                "image/ief"
            },
            {
                ".iii",
                "application/x-iphone"
            },
            {
                ".inc",
                "text/plain"
            },
            {
                ".inf",
                "application/octet-stream"
            },
            {
                ".ini",
                "text/plain"
            },
            {
                ".inl",
                "text/plain"
            },
            {
                ".ins",
                "application/x-internet-signup"
            },
            {
                ".ipa",
                "application/x-itunes-ipa"
            },
            {
                ".ipg",
                "application/x-itunes-ipg"
            },
            {
                ".ipproj",
                "text/plain"
            },
            {
                ".ipsw",
                "application/x-itunes-ipsw"
            },
            {
                ".iqy",
                "text/x-ms-iqy"
            },
            {
                ".isp",
                "application/x-internet-signup"
            },
            {
                ".ite",
                "application/x-itunes-ite"
            },
            {
                ".itlp",
                "application/x-itunes-itlp"
            },
            {
                ".itms",
                "application/x-itunes-itms"
            },
            {
                ".itpc",
                "application/x-itunes-itpc"
            },
            {
                ".IVF",
                "video/x-ivf"
            },
            {
                ".jar",
                "application/java-archive"
            },
            {
                ".java",
                "application/octet-stream"
            },
            {
                ".jck",
                "application/liquidmotion"
            },
            {
                ".jcz",
                "application/liquidmotion"
            },
            {
                ".jfif",
                "image/pjpeg"
            },
            {
                ".jnlp",
                "application/x-java-jnlp-file"
            },
            {
                ".jpb",
                "application/octet-stream"
            },
            {
                ".jpe",
                "image/jpeg"
            },
            {
                ".jpeg",
                "image/jpeg"
            },
            {
                ".jpg",
                "image/jpeg"
            },
            {
                ".js",
                "application/javascript"
            },
            {
                ".json",
                "application/json"
            },
            {
                ".jsx",
                "text/jscript"
            },
            {
                ".jsxbin",
                "text/plain"
            },
            {
                ".latex",
                "application/x-latex"
            },
            {
                ".library-ms",
                "application/windows-library+xml"
            },
            {
                ".lit",
                "application/x-ms-reader"
            },
            {
                ".loadtest",
                "application/xml"
            },
            {
                ".lpk",
                "application/octet-stream"
            },
            {
                ".lsf",
                "video/x-la-asf"
            },
            {
                ".lst",
                "text/plain"
            },
            {
                ".lsx",
                "video/x-la-asf"
            },
            {
                ".lzh",
                "application/octet-stream"
            },
            {
                ".m13",
                "application/x-msmediaview"
            },
            {
                ".m14",
                "application/x-msmediaview"
            },
            {
                ".m1v",
                "video/mpeg"
            },
            {
                ".m2t",
                "video/vnd.dlna.mpeg-tts"
            },
            {
                ".m2ts",
                "video/vnd.dlna.mpeg-tts"
            },
            {
                ".m2v",
                "video/mpeg"
            },
            {
                ".m3u",
                "audio/x-mpegurl"
            },
            {
                ".m3u8",
                "audio/x-mpegurl"
            },
            {
                ".m4a",
                "audio/m4a"
            },
            {
                ".m4b",
                "audio/m4b"
            },
            {
                ".m4p",
                "audio/m4p"
            },
            {
                ".m4r",
                "audio/x-m4r"
            },
            {
                ".m4v",
                "video/x-m4v"
            },
            {
                ".mac",
                "image/x-macpaint"
            },
            {
                ".mak",
                "text/plain"
            },
            {
                ".man",
                "application/x-troff-man"
            },
            {
                ".manifest",
                "application/x-ms-manifest"
            },
            {
                ".map",
                "text/plain"
            },
            {
                ".master",
                "application/xml"
            },
            {
                ".mbox",
                "application/mbox"
            },
            {
                ".mda",
                "application/msaccess"
            },
            {
                ".mdb",
                "application/x-msaccess"
            },
            {
                ".mde",
                "application/msaccess"
            },
            {
                ".mdp",
                "application/octet-stream"
            },
            {
                ".me",
                "application/x-troff-me"
            },
            {
                ".mfp",
                "application/x-shockwave-flash"
            },
            {
                ".mht",
                "message/rfc822"
            },
            {
                ".mhtml",
                "message/rfc822"
            },
            {
                ".mid",
                "audio/mid"
            },
            {
                ".midi",
                "audio/mid"
            },
            {
                ".mix",
                "application/octet-stream"
            },
            {
                ".mk",
                "text/plain"
            },
            {
                ".mk3d",
                "video/x-matroska-3d"
            },
            {
                ".mka",
                "audio/x-matroska"
            },
            {
                ".mkv",
                "video/x-matroska"
            },
            {
                ".mmf",
                "application/x-smaf"
            },
            {
                ".mno",
                "text/xml"
            },
            {
                ".mny",
                "application/x-msmoney"
            },
            {
                ".mod",
                "video/mpeg"
            },
            {
                ".mov",
                "video/quicktime"
            },
            {
                ".movie",
                "video/x-sgi-movie"
            },
            {
                ".mp2",
                "video/mpeg"
            },
            {
                ".mp2v",
                "video/mpeg"
            },
            {
                ".mp3",
                "audio/mpeg"
            },
            {
                ".mp4",
                "video/mp4"
            },
            {
                ".mp4v",
                "video/mp4"
            },
            {
                ".mpa",
                "video/mpeg"
            },
            {
                ".mpe",
                "video/mpeg"
            },
            {
                ".mpeg",
                "video/mpeg"
            },
            {
                ".mpf",
                "application/vnd.ms-mediapackage"
            },
            {
                ".mpg",
                "video/mpeg"
            },
            {
                ".mpp",
                "application/vnd.ms-project"
            },
            {
                ".mpv2",
                "video/mpeg"
            },
            {
                ".mqv",
                "video/quicktime"
            },
            {
                ".ms",
                "application/x-troff-ms"
            },
            {
                ".msg",
                "application/vnd.ms-outlook"
            },
            {
                ".msi",
                "application/octet-stream"
            },
            {
                ".mso",
                "application/octet-stream"
            },
            {
                ".mts",
                "video/vnd.dlna.mpeg-tts"
            },
            {
                ".mtx",
                "application/xml"
            },
            {
                ".mvb",
                "application/x-msmediaview"
            },
            {
                ".mvc",
                "application/x-miva-compiled"
            },
            {
                ".mxp",
                "application/x-mmxp"
            },
            {
                ".nc",
                "application/x-netcdf"
            },
            {
                ".nsc",
                "video/x-ms-asf"
            },
            {
                ".nws",
                "message/rfc822"
            },
            {
                ".ocx",
                "application/octet-stream"
            },
            {
                ".oda",
                "application/oda"
            },
            {
                ".odb",
                "application/vnd.oasis.opendocument.database"
            },
            {
                ".odc",
                "application/vnd.oasis.opendocument.chart"
            },
            {
                ".odf",
                "application/vnd.oasis.opendocument.formula"
            },
            {
                ".odg",
                "application/vnd.oasis.opendocument.graphics"
            },
            {
                ".odh",
                "text/plain"
            },
            {
                ".odi",
                "application/vnd.oasis.opendocument.image"
            },
            {
                ".odl",
                "text/plain"
            },
            {
                ".odm",
                "application/vnd.oasis.opendocument.text-master"
            },
            {
                ".odp",
                "application/vnd.oasis.opendocument.presentation"
            },
            {
                ".ods",
                "application/vnd.oasis.opendocument.spreadsheet"
            },
            {
                ".odt",
                "application/vnd.oasis.opendocument.text"
            },
            {
                ".oga",
                "audio/ogg"
            },
            {
                ".ogg",
                "audio/ogg"
            },
            {
                ".ogv",
                "video/ogg"
            },
            {
                ".ogx",
                "application/ogg"
            },
            {
                ".one",
                "application/onenote"
            },
            {
                ".onea",
                "application/onenote"
            },
            {
                ".onepkg",
                "application/onenote"
            },
            {
                ".onetmp",
                "application/onenote"
            },
            {
                ".onetoc",
                "application/onenote"
            },
            {
                ".onetoc2",
                "application/onenote"
            },
            {
                ".opus",
                "audio/ogg"
            },
            {
                ".orderedtest",
                "application/xml"
            },
            {
                ".osdx",
                "application/opensearchdescription+xml"
            },
            {
                ".otf",
                "application/font-sfnt"
            },
            {
                ".otg",
                "application/vnd.oasis.opendocument.graphics-template"
            },
            {
                ".oth",
                "application/vnd.oasis.opendocument.text-web"
            },
            {
                ".otp",
                "application/vnd.oasis.opendocument.presentation-template"
            },
            {
                ".ots",
                "application/vnd.oasis.opendocument.spreadsheet-template"
            },
            {
                ".ott",
                "application/vnd.oasis.opendocument.text-template"
            },
            {
                ".oxt",
                "application/vnd.openofficeorg.extension"
            },
            {
                ".p10",
                "application/pkcs10"
            },
            {
                ".p12",
                "application/x-pkcs12"
            },
            {
                ".p7b",
                "application/x-pkcs7-certificates"
            },
            {
                ".p7c",
                "application/pkcs7-mime"
            },
            {
                ".p7m",
                "application/pkcs7-mime"
            },
            {
                ".p7r",
                "application/x-pkcs7-certreqresp"
            },
            {
                ".p7s",
                "application/pkcs7-signature"
            },
            {
                ".pbm",
                "image/x-portable-bitmap"
            },
            {
                ".pcast",
                "application/x-podcast"
            },
            {
                ".pct",
                "image/pict"
            },
            {
                ".pcx",
                "application/octet-stream"
            },
            {
                ".pcz",
                "application/octet-stream"
            },
            {
                ".pdf",
                "application/pdf"
            },
            {
                ".pfb",
                "application/octet-stream"
            },
            {
                ".pfm",
                "application/octet-stream"
            },
            {
                ".pfx",
                "application/x-pkcs12"
            },
            {
                ".pgm",
                "image/x-portable-graymap"
            },
            {
                ".pic",
                "image/pict"
            },
            {
                ".pict",
                "image/pict"
            },
            {
                ".pkgdef",
                "text/plain"
            },
            {
                ".pkgundef",
                "text/plain"
            },
            {
                ".pko",
                "application/vnd.ms-pki.pko"
            },
            {
                ".pls",
                "audio/scpls"
            },
            {
                ".pma",
                "application/x-perfmon"
            },
            {
                ".pmc",
                "application/x-perfmon"
            },
            {
                ".pml",
                "application/x-perfmon"
            },
            {
                ".pmr",
                "application/x-perfmon"
            },
            {
                ".pmw",
                "application/x-perfmon"
            },
            {
                ".png",
                "image/png"
            },
            {
                ".pnm",
                "image/x-portable-anymap"
            },
            {
                ".pnt",
                "image/x-macpaint"
            },
            {
                ".pntg",
                "image/x-macpaint"
            },
            {
                ".pnz",
                "image/png"
            },
            {
                ".pot",
                "application/vnd.ms-powerpoint"
            },
            {
                ".potm",
                "application/vnd.ms-powerpoint.template.macroEnabled.12"
            },
            {
                ".potx",
                "application/vnd.openxmlformats-officedocument.presentationml.template"
            },
            {
                ".ppa",
                "application/vnd.ms-powerpoint"
            },
            {
                ".ppam",
                "application/vnd.ms-powerpoint.addin.macroEnabled.12"
            },
            {
                ".ppm",
                "image/x-portable-pixmap"
            },
            {
                ".pps",
                "application/vnd.ms-powerpoint"
            },
            {
                ".ppsm",
                "application/vnd.ms-powerpoint.slideshow.macroEnabled.12"
            },
            {
                ".ppsx",
                "application/vnd.openxmlformats-officedocument.presentationml.slideshow"
            },
            {
                ".ppt",
                "application/vnd.ms-powerpoint"
            },
            {
                ".pptm",
                "application/vnd.ms-powerpoint.presentation.macroEnabled.12"
            },
            {
                ".pptx",
                "application/vnd.openxmlformats-officedocument.presentationml.presentation"
            },
            {
                ".prf",
                "application/pics-rules"
            },
            {
                ".prm",
                "application/octet-stream"
            },
            {
                ".prx",
                "application/octet-stream"
            },
            {
                ".ps",
                "application/postscript"
            },
            {
                ".psc1",
                "application/PowerShell"
            },
            {
                ".psd",
                "application/octet-stream"
            },
            {
                ".psess",
                "application/xml"
            },
            {
                ".psm",
                "application/octet-stream"
            },
            {
                ".psp",
                "application/octet-stream"
            },
            {
                ".pst",
                "application/vnd.ms-outlook"
            },
            {
                ".pub",
                "application/x-mspublisher"
            },
            {
                ".pwz",
                "application/vnd.ms-powerpoint"
            },
            {
                ".qht",
                "text/x-html-insertion"
            },
            {
                ".qhtm",
                "text/x-html-insertion"
            },
            {
                ".qt",
                "video/quicktime"
            },
            {
                ".qti",
                "image/x-quicktime"
            },
            {
                ".qtif",
                "image/x-quicktime"
            },
            {
                ".qtl",
                "application/x-quicktimeplayer"
            },
            {
                ".qxd",
                "application/octet-stream"
            },
            {
                ".ra",
                "audio/x-pn-realaudio"
            },
            {
                ".ram",
                "audio/x-pn-realaudio"
            },
            {
                ".rar",
                "application/x-rar-compressed"
            },
            {
                ".ras",
                "image/x-cmu-raster"
            },
            {
                ".rat",
                "application/rat-file"
            },
            {
                ".rc",
                "text/plain"
            },
            {
                ".rc2",
                "text/plain"
            },
            {
                ".rct",
                "text/plain"
            },
            {
                ".rdlc",
                "application/xml"
            },
            {
                ".reg",
                "text/plain"
            },
            {
                ".resx",
                "application/xml"
            },
            {
                ".rf",
                "image/vnd.rn-realflash"
            },
            {
                ".rgb",
                "image/x-rgb"
            },
            {
                ".rgs",
                "text/plain"
            },
            {
                ".rm",
                "application/vnd.rn-realmedia"
            },
            {
                ".rmi",
                "audio/mid"
            },
            {
                ".rmp",
                "application/vnd.rn-rn_music_package"
            },
            {
                ".roff",
                "application/x-troff"
            },
            {
                ".rpm",
                "audio/x-pn-realaudio-plugin"
            },
            {
                ".rqy",
                "text/x-ms-rqy"
            },
            {
                ".rtf",
                "application/rtf"
            },
            {
                ".rtx",
                "text/richtext"
            },
            {
                ".rvt",
                "application/octet-stream"
            },
            {
                ".ruleset",
                "application/xml"
            },
            {
                ".s",
                "text/plain"
            },
            {
                ".safariextz",
                "application/x-safari-safariextz"
            },
            {
                ".scd",
                "application/x-msschedule"
            },
            {
                ".scr",
                "text/plain"
            },
            {
                ".sct",
                "text/scriptlet"
            },
            {
                ".sd2",
                "audio/x-sd2"
            },
            {
                ".sdp",
                "application/sdp"
            },
            {
                ".sea",
                "application/octet-stream"
            },
            {
                ".searchConnector-ms",
                "application/windows-search-connector+xml"
            },
            {
                ".setpay",
                "application/set-payment-initiation"
            },
            {
                ".setreg",
                "application/set-registration-initiation"
            },
            {
                ".settings",
                "application/xml"
            },
            {
                ".sgimb",
                "application/x-sgimb"
            },
            {
                ".sgml",
                "text/sgml"
            },
            {
                ".sh",
                "application/x-sh"
            },
            {
                ".shar",
                "application/x-shar"
            },
            {
                ".shtml",
                "text/html"
            },
            {
                ".sit",
                "application/x-stuffit"
            },
            {
                ".sitemap",
                "application/xml"
            },
            {
                ".skin",
                "application/xml"
            },
            {
                ".skp",
                "application/x-koan"
            },
            {
                ".sldm",
                "application/vnd.ms-powerpoint.slide.macroEnabled.12"
            },
            {
                ".sldx",
                "application/vnd.openxmlformats-officedocument.presentationml.slide"
            },
            {
                ".slk",
                "application/vnd.ms-excel"
            },
            {
                ".sln",
                "text/plain"
            },
            {
                ".slupkg-ms",
                "application/x-ms-license"
            },
            {
                ".smd",
                "audio/x-smd"
            },
            {
                ".smi",
                "application/octet-stream"
            },
            {
                ".smx",
                "audio/x-smd"
            },
            {
                ".smz",
                "audio/x-smd"
            },
            {
                ".snd",
                "audio/basic"
            },
            {
                ".snippet",
                "application/xml"
            },
            {
                ".snp",
                "application/octet-stream"
            },
            {
                ".sol",
                "text/plain"
            },
            {
                ".sor",
                "text/plain"
            },
            {
                ".spc",
                "application/x-pkcs7-certificates"
            },
            {
                ".spl",
                "application/futuresplash"
            },
            {
                ".spx",
                "audio/ogg"
            },
            {
                ".src",
                "application/x-wais-source"
            },
            {
                ".srf",
                "text/plain"
            },
            {
                ".SSISDeploymentManifest",
                "text/xml"
            },
            {
                ".ssm",
                "application/streamingmedia"
            },
            {
                ".sst",
                "application/vnd.ms-pki.certstore"
            },
            {
                ".stl",
                "application/vnd.ms-pki.stl"
            },
            {
                ".sv4cpio",
                "application/x-sv4cpio"
            },
            {
                ".sv4crc",
                "application/x-sv4crc"
            },
            {
                ".svc",
                "application/xml"
            },
            {
                ".svg",
                "image/svg+xml"
            },
            {
                ".swf",
                "application/x-shockwave-flash"
            },
            {
                ".step",
                "application/step"
            },
            {
                ".stp",
                "application/step"
            },
            {
                ".t",
                "application/x-troff"
            },
            {
                ".tar",
                "application/x-tar"
            },
            {
                ".tcl",
                "application/x-tcl"
            },
            {
                ".testrunconfig",
                "application/xml"
            },
            {
                ".testsettings",
                "application/xml"
            },
            {
                ".tex",
                "application/x-tex"
            },
            {
                ".texi",
                "application/x-texinfo"
            },
            {
                ".texinfo",
                "application/x-texinfo"
            },
            {
                ".tgz",
                "application/x-compressed"
            },
            {
                ".thmx",
                "application/vnd.ms-officetheme"
            },
            {
                ".thn",
                "application/octet-stream"
            },
            {
                ".tif",
                "image/tiff"
            },
            {
                ".tiff",
                "image/tiff"
            },
            {
                ".tlh",
                "text/plain"
            },
            {
                ".tli",
                "text/plain"
            },
            {
                ".toc",
                "application/octet-stream"
            },
            {
                ".tr",
                "application/x-troff"
            },
            {
                ".trm",
                "application/x-msterminal"
            },
            {
                ".trx",
                "application/xml"
            },
            {
                ".ts",
                "video/vnd.dlna.mpeg-tts"
            },
            {
                ".tsv",
                "text/tab-separated-values"
            },
            {
                ".ttf",
                "application/font-sfnt"
            },
            {
                ".tts",
                "video/vnd.dlna.mpeg-tts"
            },
            {
                ".txt",
                "text/plain"
            },
            {
                ".u32",
                "application/octet-stream"
            },
            {
                ".uls",
                "text/iuls"
            },
            {
                ".user",
                "text/plain"
            },
            {
                ".ustar",
                "application/x-ustar"
            },
            {
                ".vb",
                "text/plain"
            },
            {
                ".vbdproj",
                "text/plain"
            },
            {
                ".vbk",
                "video/mpeg"
            },
            {
                ".vbproj",
                "text/plain"
            },
            {
                ".vbs",
                "text/vbscript"
            },
            {
                ".vcf",
                "text/x-vcard"
            },
            {
                ".vcproj",
                "application/xml"
            },
            {
                ".vcs",
                "text/plain"
            },
            {
                ".vcxproj",
                "application/xml"
            },
            {
                ".vddproj",
                "text/plain"
            },
            {
                ".vdp",
                "text/plain"
            },
            {
                ".vdproj",
                "text/plain"
            },
            {
                ".vdx",
                "application/vnd.ms-visio.viewer"
            },
            {
                ".vml",
                "text/xml"
            },
            {
                ".vscontent",
                "application/xml"
            },
            {
                ".vsct",
                "text/xml"
            },
            {
                ".vsd",
                "application/vnd.visio"
            },
            {
                ".vsi",
                "application/ms-vsi"
            },
            {
                ".vsix",
                "application/vsix"
            },
            {
                ".vsixlangpack",
                "text/xml"
            },
            {
                ".vsixmanifest",
                "text/xml"
            },
            {
                ".vsmdi",
                "application/xml"
            },
            {
                ".vspscc",
                "text/plain"
            },
            {
                ".vss",
                "application/vnd.visio"
            },
            {
                ".vsscc",
                "text/plain"
            },
            {
                ".vssettings",
                "text/xml"
            },
            {
                ".vssscc",
                "text/plain"
            },
            {
                ".vst",
                "application/vnd.visio"
            },
            {
                ".vstemplate",
                "text/xml"
            },
            {
                ".vsto",
                "application/x-ms-vsto"
            },
            {
                ".vsw",
                "application/vnd.visio"
            },
            {
                ".vsx",
                "application/vnd.visio"
            },
            {
                ".vtt",
                "text/vtt"
            },
            {
                ".vtx",
                "application/vnd.visio"
            },
            {
                ".wasm",
                "application/wasm"
            },
            {
                ".wav",
                "audio/wav"
            },
            {
                ".wave",
                "audio/wav"
            },
            {
                ".wax",
                "audio/x-ms-wax"
            },
            {
                ".wbk",
                "application/msword"
            },
            {
                ".wbmp",
                "image/vnd.wap.wbmp"
            },
            {
                ".wcm",
                "application/vnd.ms-works"
            },
            {
                ".wdb",
                "application/vnd.ms-works"
            },
            {
                ".wdp",
                "image/vnd.ms-photo"
            },
            {
                ".webarchive",
                "application/x-safari-webarchive"
            },
            {
                ".webm",
                "video/webm"
            },
            {
                ".webp",
                "image/webp"
            },
            {
                ".webtest",
                "application/xml"
            },
            {
                ".wiq",
                "application/xml"
            },
            {
                ".wiz",
                "application/msword"
            },
            {
                ".wks",
                "application/vnd.ms-works"
            },
            {
                ".WLMP",
                "application/wlmoviemaker"
            },
            {
                ".wlpginstall",
                "application/x-wlpg-detect"
            },
            {
                ".wlpginstall3",
                "application/x-wlpg3-detect"
            },
            {
                ".wm",
                "video/x-ms-wm"
            },
            {
                ".wma",
                "audio/x-ms-wma"
            },
            {
                ".wmd",
                "application/x-ms-wmd"
            },
            {
                ".wmf",
                "application/x-msmetafile"
            },
            {
                ".wml",
                "text/vnd.wap.wml"
            },
            {
                ".wmlc",
                "application/vnd.wap.wmlc"
            },
            {
                ".wmls",
                "text/vnd.wap.wmlscript"
            },
            {
                ".wmlsc",
                "application/vnd.wap.wmlscriptc"
            },
            {
                ".wmp",
                "video/x-ms-wmp"
            },
            {
                ".wmv",
                "video/x-ms-wmv"
            },
            {
                ".wmx",
                "video/x-ms-wmx"
            },
            {
                ".wmz",
                "application/x-ms-wmz"
            },
            {
                ".woff",
                "application/font-woff"
            },
            {
                ".woff2",
                "application/font-woff2"
            },
            {
                ".wpl",
                "application/vnd.ms-wpl"
            },
            {
                ".wps",
                "application/vnd.ms-works"
            },
            {
                ".wri",
                "application/x-mswrite"
            },
            {
                ".wrl",
                "x-world/x-vrml"
            },
            {
                ".wrz",
                "x-world/x-vrml"
            },
            {
                ".wsc",
                "text/scriptlet"
            },
            {
                ".wsdl",
                "text/xml"
            },
            {
                ".wvx",
                "video/x-ms-wvx"
            },
            {
                ".x",
                "application/directx"
            },
            {
                ".xaf",
                "x-world/x-vrml"
            },
            {
                ".xaml",
                "application/xaml+xml"
            },
            {
                ".xap",
                "application/x-silverlight-app"
            },
            {
                ".xbap",
                "application/x-ms-xbap"
            },
            {
                ".xbm",
                "image/x-xbitmap"
            },
            {
                ".xdr",
                "text/plain"
            },
            {
                ".xht",
                "application/xhtml+xml"
            },
            {
                ".xhtml",
                "application/xhtml+xml"
            },
            {
                ".xla",
                "application/vnd.ms-excel"
            },
            {
                ".xlam",
                "application/vnd.ms-excel.addin.macroEnabled.12"
            },
            {
                ".xlc",
                "application/vnd.ms-excel"
            },
            {
                ".xld",
                "application/vnd.ms-excel"
            },
            {
                ".xlk",
                "application/vnd.ms-excel"
            },
            {
                ".xll",
                "application/vnd.ms-excel"
            },
            {
                ".xlm",
                "application/vnd.ms-excel"
            },
            {
                ".xls",
                "application/vnd.ms-excel"
            },
            {
                ".xlsb",
                "application/vnd.ms-excel.sheet.binary.macroEnabled.12"
            },
            {
                ".xlsm",
                "application/vnd.ms-excel.sheet.macroEnabled.12"
            },
            {
                ".xlsx",
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            },
            {
                ".xlt",
                "application/vnd.ms-excel"
            },
            {
                ".xltm",
                "application/vnd.ms-excel.template.macroEnabled.12"
            },
            {
                ".xltx",
                "application/vnd.openxmlformats-officedocument.spreadsheetml.template"
            },
            {
                ".xlw",
                "application/vnd.ms-excel"
            },
            {
                ".xml",
                "text/xml"
            },
            {
                ".xmp",
                "application/octet-stream"
            },
            {
                ".xmta",
                "application/xml"
            },
            {
                ".xof",
                "x-world/x-vrml"
            },
            {
                ".XOML",
                "text/plain"
            },
            {
                ".xpm",
                "image/x-xpixmap"
            },
            {
                ".xps",
                "application/vnd.ms-xpsdocument"
            },
            {
                ".xrm-ms",
                "text/xml"
            },
            {
                ".xsc",
                "application/xml"
            },
            {
                ".xsd",
                "text/xml"
            },
            {
                ".xsf",
                "text/xml"
            },
            {
                ".xsl",
                "text/xml"
            },
            {
                ".xslt",
                "text/xml"
            },
            {
                ".xsn",
                "application/octet-stream"
            },
            {
                ".xss",
                "application/xml"
            },
            {
                ".xspf",
                "application/xspf+xml"
            },
            {
                ".xtp",
                "application/octet-stream"
            },
            {
                ".xwd",
                "image/x-xwindowdump"
            },
            {
                ".z",
                "application/x-compress"
            },
            {
                ".zip",
                "application/zip"
            },
            {
                "application/fsharp-script",
                ".fsx"
            },
            {
                "application/msaccess",
                ".adp"
            },
            {
                "application/msword",
                ".doc"
            },
            {
                "application/octet-stream",
                ".bin"
            },
            {
                "application/onenote",
                ".one"
            },
            {
                "application/postscript",
                ".eps"
            },
            {
                "application/step",
                ".step"
            },
            {
                "application/vnd.ms-excel",
                ".xls"
            },
            {
                "application/vnd.ms-powerpoint",
                ".ppt"
            },
            {
                "application/vnd.ms-works",
                ".wks"
            },
            {
                "application/vnd.visio",
                ".vsd"
            },
            {
                "application/x-director",
                ".dir"
            },
            {
                "application/x-shockwave-flash",
                ".swf"
            },
            {
                "application/x-x509-ca-cert",
                ".cer"
            },
            {
                "application/x-zip-compressed",
                ".zip"
            },
            {
                "application/xhtml+xml",
                ".xhtml"
            },
            {
                "application/xml",
                ".xml"
            },
            {
                "audio/aac",
                ".AAC"
            },
            {
                "audio/aiff",
                ".aiff"
            },
            {
                "audio/basic",
                ".snd"
            },
            {
                "audio/mid",
                ".midi"
            },
            {
                "audio/wav",
                ".wav"
            },
            {
                "audio/x-m4a",
                ".m4a"
            },
            {
                "audio/x-mpegurl",
                ".m3u"
            },
            {
                "audio/x-pn-realaudio",
                ".ra"
            },
            {
                "audio/x-smd",
                ".smd"
            },
            {
                "image/bmp",
                ".bmp"
            },
            {
                "image/jpeg",
                ".jpg"
            },
            {
                "image/pict",
                ".pic"
            },
            {
                "image/png",
                ".png"
            },
            {
                "image/x-png",
                ".png"
            },
            {
                "image/tiff",
                ".tiff"
            },
            {
                "image/x-macpaint",
                ".mac"
            },
            {
                "image/x-quicktime",
                ".qti"
            },
            {
                "message/rfc822",
                ".eml"
            },
            {
                "text/html",
                ".html"
            },
            {
                "text/plain",
                ".txt"
            },
            {
                "text/scriptlet",
                ".wsc"
            },
            {
                "text/xml",
                ".xml"
            },
            {
                "video/3gpp",
                ".3gp"
            },
            {
                "video/3gpp2",
                ".3gp2"
            },
            {
                "video/mp4",
                ".mp4"
            },
            {
                "video/mpeg",
                ".mpg"
            },
            {
                "video/quicktime",
                ".mov"
            },
            {
                "video/vnd.dlna.mpeg-tts",
                ".m2t"
            },
            {
                "video/x-dv",
                ".dv"
            },
            {
                "video/x-la-asf",
                ".lsf"
            },
            {
                "video/x-ms-asf",
                ".asf"
            },
            {
                "x-world/x-vrml",
                ".xof"
            }
        };
            }
            public class MissingXPathException : Exception
            {
                public MissingXPathException()
                {
                }
                public MissingXPathException(string message) : base(message)
                {
                }
                public MissingXPathException(string message, Exception inner) : base(message, inner)
                {
                }
            }
            public class MixedCodeDocument
            {
                public MixedCodeDocument()
                {
                    this._codefragments = new MixedCodeDocumentFragmentList(this);
                    this._textfragments = new MixedCodeDocumentFragmentList(this);
                    this._fragments = new MixedCodeDocumentFragmentList(this);
                }
                public string Code
                {
                    get
                    {
                        string text = "";
                        int num = 0;
                        foreach (MixedCodeDocumentFragment mixedCodeDocumentFragment in this._fragments)
                        {
                            MixedCodeDocumentFragmentType type = mixedCodeDocumentFragment._type;
                            if (type != MixedCodeDocumentFragmentType.Code)
                            {
                                if (type == MixedCodeDocumentFragmentType.Text)
                                {
                                    text = text + this.TokenResponseWrite + string.Format(this.TokenTextBlock, num) + "\n";
                                    num++;
                                }
                            }
                            else
                            {
                                text = text + ((MixedCodeDocumentCodeFragment)mixedCodeDocumentFragment).Code + "\n";
                            }
                        }
                        return text;
                    }
                }
                public MixedCodeDocumentFragmentList CodeFragments
                {
                    get
                    {
                        return this._codefragments;
                    }
                }
                public MixedCodeDocumentFragmentList Fragments
                {
                    get
                    {
                        return this._fragments;
                    }
                }
                public Encoding StreamEncoding
                {
                    get
                    {
                        return this._streamencoding;
                    }
                }
                public MixedCodeDocumentFragmentList TextFragments
                {
                    get
                    {
                        return this._textfragments;
                    }
                }
                public MixedCodeDocumentCodeFragment CreateCodeFragment()
                {
                    return (MixedCodeDocumentCodeFragment)this.CreateFragment(MixedCodeDocumentFragmentType.Code);
                }
                public MixedCodeDocumentTextFragment CreateTextFragment()
                {
                    return (MixedCodeDocumentTextFragment)this.CreateFragment(MixedCodeDocumentFragmentType.Text);
                }
                public void Load(System.IO.Stream stream)
                {
                    this.Load(new System.IO.StreamReader(stream));
                }
                public void Load(System.IO.Stream stream, bool detectEncodingFromByteOrderMarks)
                {
                    this.Load(new System.IO.StreamReader(stream, detectEncodingFromByteOrderMarks));
                }
                public void Load(System.IO.Stream stream, Encoding encoding)
                {
                    this.Load(new System.IO.StreamReader(stream, encoding));
                }
                public void Load(System.IO.Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks)
                {
                    this.Load(new System.IO.StreamReader(stream, encoding, detectEncodingFromByteOrderMarks));
                }
                public void Load(System.IO.Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
                {
                    this.Load(new System.IO.StreamReader(stream, encoding, detectEncodingFromByteOrderMarks, buffersize));
                }
                public void Load(string path)
                {
                    this.Load(new System.IO.StreamReader(path));
                }
                public void Load(string path, bool detectEncodingFromByteOrderMarks)
                {
                    this.Load(new System.IO.StreamReader(path, detectEncodingFromByteOrderMarks));
                }
                public void Load(string path, Encoding encoding)
                {
                    this.Load(new System.IO.StreamReader(path, encoding));
                }
                public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks)
                {
                    this.Load(new System.IO.StreamReader(path, encoding, detectEncodingFromByteOrderMarks));
                }
                public void Load(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int buffersize)
                {
                    this.Load(new System.IO.StreamReader(path, encoding, detectEncodingFromByteOrderMarks, buffersize));
                }
                public void Load(System.IO.TextReader reader)
                {
                    this._codefragments.Clear();
                    this._textfragments.Clear();
                    using (System.IO.StreamReader streamReader = reader as System.IO.StreamReader)
                    {
                        if (streamReader != null)
                        {
                            this._streamencoding = streamReader.CurrentEncoding;
                        }
                        this._text = reader.ReadToEnd();
                    }
                    this.Parse();
                }
                public void LoadHtml(string html)
                {
                    this.Load(new System.IO.StringReader(html));
                }
                public void Save(System.IO.Stream outStream)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(outStream, this.GetOutEncoding());
                    this.Save(writer);
                }
                public void Save(System.IO.Stream outStream, Encoding encoding)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(outStream, encoding);
                    this.Save(writer);
                }
                public void Save(string filename)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(filename, false, this.GetOutEncoding());
                    this.Save(writer);
                }
                public void Save(string filename, Encoding encoding)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(filename, false, encoding);
                    this.Save(writer);
                }
                public void Save(System.IO.StreamWriter writer)
                {
                    this.Save(writer);
                }
                public void Save(System.IO.TextWriter writer)
                {
                    writer.Flush();
                }
                internal MixedCodeDocumentFragment CreateFragment(MixedCodeDocumentFragmentType type)
                {
                    if (type == MixedCodeDocumentFragmentType.Code)
                    {
                        return new MixedCodeDocumentCodeFragment(this);
                    }
                    if (type == MixedCodeDocumentFragmentType.Text)
                    {
                        return new MixedCodeDocumentTextFragment(this);
                    }
                    throw new NotSupportedException();
                }
                internal Encoding GetOutEncoding()
                {
                    if (this._streamencoding != null)
                    {
                        return this._streamencoding;
                    }
                    return Encoding.UTF8;
                }
                private void IncrementPosition()
                {
                    this._index++;
                    if (this._c == 10)
                    {
                        this._lineposition = 1;
                        this._line++;
                        return;
                    }
                    this._lineposition++;
                }
                private void Parse()
                {
                    this._state = MixedCodeDocument.ParseState.Text;
                    this._index = 0;
                    this._currentfragment = this.CreateFragment(MixedCodeDocumentFragmentType.Text);
                    while (this._index < this._text.Length)
                    {
                        this._c = (int)this._text[this._index];
                        this.IncrementPosition();
                        MixedCodeDocument.ParseState state = this._state;
                        if (state != MixedCodeDocument.ParseState.Text)
                        {
                            if (state == MixedCodeDocument.ParseState.Code)
                            {
                                if (this._index + this.TokenCodeEnd.Length < this._text.Length && this._text.Substring(this._index - 1, this.TokenCodeEnd.Length) == this.TokenCodeEnd)
                                {
                                    this._state = MixedCodeDocument.ParseState.Text;
                                    this._currentfragment.Length = this._index + this.TokenCodeEnd.Length - this._currentfragment.Index;
                                    this._index += this.TokenCodeEnd.Length;
                                    this._lineposition += this.TokenCodeEnd.Length;
                                    this._currentfragment = this.CreateFragment(MixedCodeDocumentFragmentType.Text);
                                    this.SetPosition();
                                }
                            }
                        }
                        else if (this._index + this.TokenCodeStart.Length < this._text.Length && this._text.Substring(this._index - 1, this.TokenCodeStart.Length) == this.TokenCodeStart)
                        {
                            this._state = MixedCodeDocument.ParseState.Code;
                            this._currentfragment.Length = this._index - 1 - this._currentfragment.Index;
                            this._currentfragment = this.CreateFragment(MixedCodeDocumentFragmentType.Code);
                            this.SetPosition();
                        }
                    }
                    this._currentfragment.Length = this._index - this._currentfragment.Index;
                }
                private void SetPosition()
                {
                    this._currentfragment.Line = this._line;
                    this._currentfragment._lineposition = this._lineposition;
                    this._currentfragment.Index = this._index - 1;
                    this._currentfragment.Length = 0;
                }
                private int _c;
                internal MixedCodeDocumentFragmentList _codefragments;
                private MixedCodeDocumentFragment _currentfragment;
                internal MixedCodeDocumentFragmentList _fragments;
                private int _index;
                private int _line;
                private int _lineposition;
                private MixedCodeDocument.ParseState _state;
                private Encoding _streamencoding;
                internal string _text;
                internal MixedCodeDocumentFragmentList _textfragments;
                public string TokenCodeEnd = "%>";
                public string TokenCodeStart = "<%";
                public string TokenDirective = "@";
                public string TokenResponseWrite = "Response.Write ";
                private string TokenTextBlock = "TextBlock({0})";
                private enum ParseState
                {
                    Text,
                    Code
                }
            }
            public class MixedCodeDocumentCodeFragment : MixedCodeDocumentFragment
            {
                internal MixedCodeDocumentCodeFragment(MixedCodeDocument doc) : base(doc, MixedCodeDocumentFragmentType.Code)
                {
                }
                public string Code
                {
                    get
                    {
                        if (this._code == null)
                        {
                            this._code = base.FragmentText.Substring(this.Doc.TokenCodeStart.Length, base.FragmentText.Length - this.Doc.TokenCodeEnd.Length - this.Doc.TokenCodeStart.Length - 1).Trim();
                            if (this._code.StartsWith("="))
                            {
                                this._code = this.Doc.TokenResponseWrite + this._code.Substring(1, this._code.Length - 1);
                            }
                        }
                        return this._code;
                    }
                    set
                    {
                        this._code = value;
                    }
                }
                private string _code;
            }
            public abstract class MixedCodeDocumentFragment
            {
                internal MixedCodeDocumentFragment(MixedCodeDocument doc, MixedCodeDocumentFragmentType type)
                {
                    this.Doc = doc;
                    this._type = type;
                    if (type != MixedCodeDocumentFragmentType.Code)
                    {
                        if (type == MixedCodeDocumentFragmentType.Text)
                        {
                            this.Doc._textfragments.Append(this);
                        }
                    }
                    else
                    {
                        this.Doc._codefragments.Append(this);
                    }
                    this.Doc._fragments.Append(this);
                }
                public string FragmentText
                {
                    get
                    {
                        if (this._fragmentText == null)
                        {
                            this._fragmentText = this.Doc._text.Substring(this.Index, this.Length);
                        }
                        return this._fragmentText;
                    }
                    internal set
                    {
                        this._fragmentText = value;
                    }
                }
                public MixedCodeDocumentFragmentType FragmentType
                {
                    get
                    {
                        return this._type;
                    }
                }
                public int Line
                {
                    get
                    {
                        return this._line;
                    }
                    internal set
                    {
                        this._line = value;
                    }
                }
                public int LinePosition
                {
                    get
                    {
                        return this._lineposition;
                    }
                }
                public int StreamPosition
                {
                    get
                    {
                        return this.Index;
                    }
                }
                internal MixedCodeDocument Doc;
                private string _fragmentText;
                internal int Index;
                internal int Length;
                private int _line;
                internal int _lineposition;
                internal MixedCodeDocumentFragmentType _type;
            }
            public class MixedCodeDocumentFragmentList : IEnumerable
            {
                internal MixedCodeDocumentFragmentList(MixedCodeDocument doc)
                {
                    this._doc = doc;
                }
                public MixedCodeDocument Doc
                {
                    get
                    {
                        return this._doc;
                    }
                }
                public int Count
                {
                    get
                    {
                        return this._items.Count;
                    }
                }
                public MixedCodeDocumentFragment this[int index]
                {
                    get
                    {
                        return this._items[index];
                    }
                }
                IEnumerator IEnumerable.GetEnumerator()
                {
                    return this.GetEnumerator();
                }
                public void Append(MixedCodeDocumentFragment newFragment)
                {
                    if (newFragment == null)
                    {
                        throw new ArgumentNullException("newFragment");
                    }
                    this._items.Add(newFragment);
                }
                public MixedCodeDocumentFragmentList.MixedCodeDocumentFragmentEnumerator GetEnumerator()
                {
                    return new MixedCodeDocumentFragmentList.MixedCodeDocumentFragmentEnumerator(this._items);
                }
                public void Prepend(MixedCodeDocumentFragment newFragment)
                {
                    if (newFragment == null)
                    {
                        throw new ArgumentNullException("newFragment");
                    }
                    this._items.Insert(0, newFragment);
                }
                public void Remove(MixedCodeDocumentFragment fragment)
                {
                    if (fragment == null)
                    {
                        throw new ArgumentNullException("fragment");
                    }
                    int fragmentIndex = this.GetFragmentIndex(fragment);
                    if (fragmentIndex == -1)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    this.RemoveAt(fragmentIndex);
                }
                public void RemoveAll()
                {
                    this._items.Clear();
                }
                public void RemoveAt(int index)
                {
                    this._items.RemoveAt(index);
                }
                internal void Clear()
                {
                    this._items.Clear();
                }
                internal int GetFragmentIndex(MixedCodeDocumentFragment fragment)
                {
                    if (fragment == null)
                    {
                        throw new ArgumentNullException("fragment");
                    }
                    for (int i = 0; i < this._items.Count; i++)
                    {
                        if (this._items[i] == fragment)
                        {
                            return i;
                        }
                    }
                    return -1;
                }
                private MixedCodeDocument _doc;
                private IList<MixedCodeDocumentFragment> _items = new List<MixedCodeDocumentFragment>();
                public class MixedCodeDocumentFragmentEnumerator : IEnumerator
                {
                    internal MixedCodeDocumentFragmentEnumerator(IList<MixedCodeDocumentFragment> items)
                    {
                        this._items = items;
                        this._index = -1;
                    }
                    public MixedCodeDocumentFragment Current
                    {
                        get
                        {
                            return this._items[this._index];
                        }
                    }
                    object IEnumerator.Current
                    {
                        get
                        {
                            return this.Current;
                        }
                    }
                    public bool MoveNext()
                    {
                        this._index++;
                        return this._index < this._items.Count;
                    }
                    public void Reset()
                    {
                        this._index = -1;
                    }
                    private int _index;
                    private IList<MixedCodeDocumentFragment> _items;
                }
            }
            public enum MixedCodeDocumentFragmentType
            {
                Code,
                Text
            }
            public class MixedCodeDocumentTextFragment : MixedCodeDocumentFragment
            {
                internal MixedCodeDocumentTextFragment(MixedCodeDocument doc) : base(doc, MixedCodeDocumentFragmentType.Text)
                {
                }
                public string Text
                {
                    get
                    {
                        return base.FragmentText;
                    }
                    set
                    {
                        base.FragmentText = value;
                    }
                }
            }
            internal class NameValuePairList
            {
                internal NameValuePairList() : this(null)
                {
                }
                internal NameValuePairList(string text)
                {
                    this.Text = text;
                    this._allPairs = new List<KeyValuePair<string, string>>();
                    this._pairsWithName = new Dictionary<string, List<KeyValuePair<string, string>>>();
                    this.Parse(text);
                }
                internal static string GetNameValuePairsValue(string text, string name)
                {
                    return new NameValuePairList(text).GetNameValuePairValue(name);
                }
                internal List<KeyValuePair<string, string>> GetNameValuePairs(string name)
                {
                    if (name == null)
                    {
                        return this._allPairs;
                    }
                    if (!this._pairsWithName.ContainsKey(name))
                    {
                        return new List<KeyValuePair<string, string>>();
                    }
                    return this._pairsWithName[name];
                }
                internal string GetNameValuePairValue(string name)
                {
                    if (name == null)
                    {
                        throw new ArgumentNullException();
                    }
                    List<KeyValuePair<string, string>> nameValuePairs = this.GetNameValuePairs(name);
                    if (nameValuePairs.Count == 0)
                    {
                        return string.Empty;
                    }
                    return nameValuePairs[0].Value.Trim();
                }
                private void Parse(string text)
                {
                    this._allPairs.Clear();
                    this._pairsWithName.Clear();
                    if (text == null)
                    {
                        return;
                    }
                    foreach (string text2 in text.Split(new char[]
                    {
                ';'
                    }))
                    {
                        if (text2.Length != 0)
                        {
                            string[] array2 = text2.Split(new char[]
                            {
                        '='
                            }, 2);
                            if (array2.Length != 0)
                            {
                                KeyValuePair<string, string> item = new KeyValuePair<string, string>(array2[0].Trim().ToLowerInvariant(), (array2.Length < 2) ? "" : array2[1]);
                                this._allPairs.Add(item);
                                List<KeyValuePair<string, string>> list;
                                if (!this._pairsWithName.TryGetValue(item.Key, out list))
                                {
                                    list = new List<KeyValuePair<string, string>>();
                                    this._pairsWithName.Add(item.Key, list);
                                }
                                list.Add(item);
                            }
                        }
                    }
                }
                internal readonly string Text;
                private List<KeyValuePair<string, string>> _allPairs;
                private Dictionary<string, List<KeyValuePair<string, string>>> _pairsWithName;
            }
            public class NodeAttributeNotFoundException : Exception
            {
                public NodeAttributeNotFoundException()
                {
                }
                public NodeAttributeNotFoundException(string message) : base(message)
                {
                }
                public NodeAttributeNotFoundException(string message, Exception inner) : base(message, inner)
                {
                }
            }
            public class NodeNotFoundException : Exception
            {
                public NodeNotFoundException()
                {
                }
                public NodeNotFoundException(string message) : base(message)
                {
                }
                public NodeNotFoundException(string message, Exception inner) : base(message, inner)
                {
                }
            }
            public enum ReturnType
            {
                InnerText,
                InnerHtml,
                OuterHtml
            }
            internal static class Tools
            {
                internal static bool IsDefinedAttribute(this Type type, Type attributeType)
                {
                    if (type == null)
                    {
                        throw new ArgumentNullException("Parameter type is null when checking type defined attributeType or not.");
                    }
                    if (attributeType == null)
                    {
                        throw new ArgumentNullException("Parameter attributeType is null when checking type defined attributeType or not.");
                    }
                    return type.IsDefined(attributeType, false);
                }
                internal static IEnumerable<PropertyInfo> GetPropertiesDefinedXPath(this Type type)
                {
                    if (type == null)
                    {
                        throw new ArgumentNullException("Parameter type is null while retrieving properties defined XPathAttribute of Type type.");
                    }
                    return type.GetProperties().HAPWhere((PropertyInfo x) => x.IsDefined(typeof(XPathAttribute), false));
                }
                internal static bool IsIEnumerable(this PropertyInfo propertyInfo)
                {
                    if (propertyInfo == null)
                    {
                        throw new ArgumentNullException("Parameter propertyInfo is null while checking propertyInfo for being IEnumerable or not.");
                    }
                    return !(propertyInfo.PropertyType == typeof(string)) && typeof(IEnumerable).IsAssignableFrom(propertyInfo.PropertyType);
                }
                internal static IEnumerable<Type> GetGenericTypes(this PropertyInfo propertyInfo)
                {
                    if (propertyInfo == null)
                    {
                        throw new ArgumentNullException("Parameter propertyInfo is null while Getting generic types of Property.");
                    }
                    return propertyInfo.PropertyType.GetGenericArguments();
                }
                internal static MethodInfo GetMethodByItsName(this Type type, string methodName)
                {
                    if (type == null)
                    {
                        throw new ArgumentNullException("Parameter type is null while Getting method from it.");
                    }
                    if (methodName == null || methodName == "")
                    {
                        throw new ArgumentNullException("Parameter methodName is null while Getting method from Type type.");
                    }
                    return type.GetMethod(methodName);
                }
                internal static IList CreateIListOfType(this Type type)
                {
                    if (type == null)
                    {
                        throw new ArgumentNullException("Parameter type is null while creating List<type>.");
                    }
                    return Activator.CreateInstance(typeof(List<>).MakeGenericType(new Type[]
                    {
                type
                    })) as IList;
                }
                internal static T GetNodeValueBasedOnXPathReturnType<T>(HtmlNode htmlNode, XPathAttribute xPathAttribute)
                {
                    if (htmlNode == null)
                    {
                        throw new ArgumentNullException("parameter html node is null");
                    }
                    if (xPathAttribute == null)
                    {
                        throw new ArgumentNullException("parameter xpathAttribute is null");
                    }
                    Type typeFromHandle = typeof(T);
                    object obj;
                    switch (xPathAttribute.NodeReturnType)
                    {
                        case ReturnType.InnerText:
                            obj = Convert.ChangeType(htmlNode.InnerText, typeFromHandle);
                            break;
                        case ReturnType.InnerHtml:
                            obj = Convert.ChangeType(htmlNode.InnerHtml, typeFromHandle);
                            break;
                        case ReturnType.OuterHtml:
                            obj = Convert.ChangeType(htmlNode.OuterHtml, typeFromHandle);
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                    return (T)((object)obj);
                }
                internal static IList GetNodesValuesBasedOnXPathReturnType(HtmlNodeCollection htmlNodeCollection, XPathAttribute xPathAttribute, Type listGenericType)
                {
                    if (htmlNodeCollection == null || htmlNodeCollection.Count == 0)
                    {
                        throw new ArgumentNullException("parameter htmlNodeCollection is null or empty.");
                    }
                    if (xPathAttribute == null)
                    {
                        throw new ArgumentNullException("parameter xpathAttribute is null");
                    }
                    IList list = listGenericType.CreateIListOfType();
                    switch (xPathAttribute.NodeReturnType)
                    {
                        case ReturnType.InnerText:
                            break;
                        case ReturnType.InnerHtml:
                            using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator())
                            {
                                while (enumerator.MoveNext())
                                {
                                    HtmlNode htmlNode = enumerator.Current;
                                    list.Add(Convert.ChangeType(htmlNode.InnerHtml, listGenericType));
                                }
                                return list;
                            }
                        case ReturnType.OuterHtml:
                            goto IL_B9;
                        default:
                            return list;
                    }
                    using (IEnumerator<HtmlNode> enumerator = ((IEnumerable<HtmlNode>)htmlNodeCollection).GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            HtmlNode htmlNode2 = enumerator.Current;
                            list.Add(Convert.ChangeType(htmlNode2.InnerText, listGenericType));
                        }
                        return list;
                    }
                IL_B9:
                    foreach (HtmlNode htmlNode3 in ((IEnumerable<HtmlNode>)htmlNodeCollection))
                    {
                        list.Add(Convert.ChangeType(htmlNode3.OuterHtml, listGenericType));
                    }
                    return list;
                }
                internal static IEnumerable<TSource> HAPWhere<TSource>(this IEnumerable<TSource> source, Tools.HAPFunc<TSource, bool> predicate)
                {
                    foreach (TSource tsource in source)
                    {
                        if (predicate(tsource))
                        {
                            yield return tsource;
                        }
                    }
                    yield break;
                }
                internal static bool IsInstantiable(this Type type)
                {
                    if (type == null)
                    {
                        throw new ArgumentNullException("type is null");
                    }
                    return !(type.GetConstructor(Type.EmptyTypes) == null);
                }
                internal static int CountOfIEnumerable<T>(this IEnumerable<T> source)
                {
                    if (source == null)
                    {
                        throw new ArgumentNullException("Parameter source is null while counting the IEnumerable");
                    }
                    int num = 0;
                    foreach (T t in source)
                    {
                        num++;
                    }
                    return num;
                }
                internal delegate TResult HAPFunc<T, TResult>(T arg);
            }
            internal class Trace
            {
                internal static Trace Current
                {
                    get
                    {
                        if (Trace._current == null)
                        {
                            Trace._current = new Trace();
                        }
                        return Trace._current;
                    }
                }
                private void WriteLineIntern(string message, string category)
                {
                }
                public static void WriteLine(string message, string category)
                {
                    Trace.Current.WriteLineIntern(message, category);
                }
                internal static Trace _current;
            }
            internal static class Utilities
            {
                public static TValue GetDictionaryValueOrDefault<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, TValue defaultValue = default(TValue)) where TKey : class
                {
                    TValue result;
                    if (!dict.TryGetValue(key, out result))
                    {
                        return defaultValue;
                    }
                    return result;
                }
            }
            [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
            public sealed class XPathAttribute : Attribute
            {
                public string XPath { get; }
                public string AttributeName { get; set; }
                public ReturnType NodeReturnType { get; set; }
                public XPathAttribute(string xpathString, ReturnType nodeReturnType = ReturnType.InnerText)
                {
                    this.XPath = xpathString;
                    this.NodeReturnType = nodeReturnType;
                }
                public XPathAttribute(string xpathString, string attributeName)
                {
                    this.XPath = xpathString;
                    this.AttributeName = attributeName;
                }
            }
        }
        public static class Pastebin
        {
            public class Paste
            {
                public Paste() { }
                public Paste(string content, string title, string syntax)
                {
                    Content = content;
                    Title = title;
                    Syntax = syntax;
                }
                public string Content { get; set; }
                public string Title { get; set; }
                public string Syntax { get; private set; }
            }
            private static string GetLanguage(Syntax s)
            {
                switch (s)
                {
                    case Syntax.CSharp:
                        return s.ToString().ToLower();
                    case Syntax.C:
                        return s.ToString().ToLower();
                    case Syntax.CPlusPlus:
                        return "cpp".ToLower();
                    case Syntax.Lua:
                        return s.ToString().ToLower();
                    case Syntax.MySQL:
                        return s.ToString().ToLower();
                    case Syntax.HTML:
                        return "html4strict";
                    case Syntax.jQuery:
                        return s.ToString().ToLower();
                    case Syntax.HTML5:
                        return s.ToString().ToLower();
                    case Syntax.Java:
                        return s.ToString().ToLower();
                    case Syntax.JSON:
                        return s.ToString().ToLower();
                    case Syntax.Java5:
                        return s.ToString().ToLower();
                    case Syntax.Raw:
                        return "";
                    default:
                        return s.ToString().ToLower();
                }
            }
            private static string GetExpirationTime(ExpirationTime time)
            {
                switch (time)
                {
                    case ExpirationTime.Never:
                        return "N";
                    case ExpirationTime.OneHour:
                        return "1H";
                    case ExpirationTime.TenMinutes:
                        return "10M";
                    case ExpirationTime.OneDay:
                        return "1D";
                    case ExpirationTime.OneWeek:
                        return "1W";
                    case ExpirationTime.TwoWeeks:
                        return "2W";
                    case ExpirationTime.OneMonth:
                        return "1M";
                    case ExpirationTime.SixMonts:
                        return "6M";
                    case ExpirationTime.OneYear:
                        return "1Y";
                    default:
                        return time.ToString();
                }
            }
            public static bool UploadNew(string Username, string Password, string DevKey, string Text, string PasteName, Syntax Syntax, ExpirationTime ExpirationTime, Visibility Visibility)
            {
                //text, name, syntax, visibility, expiration
                string LoginURL = "http://pastebin.com/api/api_login.php";
                string PostURL = "http://pastebin.com/api/api_post.php";
                var IBody = Text;
                var IType = Convert.ToInt32(Visibility).ToString();
                var ITime = GetExpirationTime(ExpirationTime);
                var IFormat = GetLanguage(Syntax);
                NameValueCollection IQuery = new NameValueCollection
                {
                    { "api_dev_key", DevKey },
                    { "api_user_name", Username },
                    { "api_user_password", Password }
                };

                using (System.Net.WebClient wc = new System.Net.WebClient())
                {
                    byte[] respBytes = wc.UploadValues(LoginURL, IQuery);
                    string resp = Encoding.UTF8.GetString(respBytes);

                    if (resp.Contains("Bad API request"))
                    {
                        throw new System.Net.WebException("Bad Request", System.Net.WebExceptionStatus.SendFailure);
                    }
                    else
                    {
                        var UserKey = resp;
                        if (string.IsNullOrEmpty(IBody.Trim())) { return false; }
                        if (string.IsNullOrEmpty(PasteName.Trim())) { return false; }
                        IQuery = new NameValueCollection
                        {
                            { "api_dev_key", DevKey },
                            { "api_option", "paste" },
                            { "api_paste_code", IBody },
                            { "api_paste_private", IType },
                            { "api_paste_name", (string)PasteName },
                            { "api_paste_expire_date", ITime },
                            { "api_paste_format", IFormat },
                            { "api_user_key", UserKey }
                        };

                        using (System.Net.WebClient IClient = new System.Net.WebClient())
                        {
                            string IResponse = Encoding.UTF8.GetString(IClient.UploadValues(PostURL, IQuery));

                            if (!Uri.TryCreate(IResponse, UriKind.Absolute, out Uri isValid))
                            {
                                throw new System.Net.WebException("Paste Error", System.Net.WebExceptionStatus.SendFailure);
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            public static bool UploadNew(string Username, string Password, string DevKey, string Text, string PasteName, string Syntax, ExpirationTime ExpirationTime, Visibility Visibility)
            {
                //text, name, syntax, visibility, expiration
                string LoginURL = "http://pastebin.com/api/api_login.php";
                string PostURL = "http://pastebin.com/api/api_post.php";
                var IBody = Text;
                var IType = Convert.ToInt32(Visibility).ToString();
                var ITime = GetExpirationTime(ExpirationTime);
                var IFormat = Syntax;
                NameValueCollection nameValueCollection = new NameValueCollection
                {
                    { "api_dev_key", DevKey },
                    { "api_user_name", Username },
                    { "api_user_password", Password }
                };
                NameValueCollection IQuery = nameValueCollection;

                using (System.Net.WebClient wc = new System.Net.WebClient())
                {
                    byte[] respBytes = wc.UploadValues(LoginURL, IQuery);
                    string resp = Encoding.UTF8.GetString(respBytes);

                    if (resp.Contains("Bad API request"))
                    {
                        throw new System.Net.WebException("Bad Request", System.Net.WebExceptionStatus.SendFailure);
                    }
                    else
                    {
                        var UserKey = resp;
                        if (string.IsNullOrEmpty(IBody.Trim())) { return false; }
                        if (string.IsNullOrEmpty(PasteName.Trim())) { return false; }
                        IQuery = new NameValueCollection
                        {
                            { "api_dev_key", DevKey },
                            { "api_option", "paste" },
                            { "api_paste_code", IBody },
                            { "api_paste_private", IType },
                            { "api_paste_name", (string)PasteName },
                            { "api_paste_expire_date", ITime },
                            { "api_paste_format", IFormat },
                            { "api_user_key", UserKey }
                        };

                        using (System.Net.WebClient IClient = new System.Net.WebClient())
                        {
                            string IResponse = Encoding.UTF8.GetString(IClient.UploadValues(PostURL, IQuery));

                            if (Uri.TryCreate(IResponse, UriKind.Absolute, out Uri isValid))
                            {
                                return true;
                            }
                            else
                            {
                                throw new System.Net.WebException("Paste Error", System.Net.WebExceptionStatus.SendFailure);
                            }
                        }
                    }
                }
            }
            public static string GetRawData(string dataID)
            {
                return new System.Net.WebClient().DownloadString("https://pastebin.com/raw/" + dataID);
            }
            public static Paste GetPaste(Form frm, string pasteID)
            {
                if (frm == null)
                {
                    throw new ArgumentNullException(nameof(frm));
                }

                if (pasteID == null)
                {
                    throw new ArgumentNullException(nameof(pasteID));
                }

                var browser = new WebBrowser
                {
                    ScriptErrorsSuppressed = true
                };
                var content = browser.Document.GetElementById("paste)code").InnerHtml;
                var Divs = browser.Document.GetElementsByTagName("div");
                var title = "";
                foreach (HtmlElement div in Divs)
                {
                    if (div.OuterHtml.Contains("class=\"paste_box_line1\""))
                    {
                        title = div.FirstChild.InnerHtml;
                    }
                }
                var syntax = "Raw";
                if (browser.DocumentTitle.Contains("["))
                {
                    syntax = browser.DocumentTitle.Split(']')[0].Replace("[", "");
                }
                return new Paste(content, title, syntax);
            }
            public enum Syntax
            {
                CSharp, C, CPlusPlus, Lua, MySQL, HTML, HTML5,
                Java,
                JSON,
                Java5,
                jQuery,
                Raw
            }
            public enum ExpirationTime
            {
                Never,
                OneHour,
                TenMinutes,
                OneDay,
                OneWeek,
                TwoWeeks,
                OneMonth,
                SixMonts,
                OneYear
            }
            public enum Visibility
            {
                Public = 0,
                Unlisted = 1,
                Private = 2
            }
        }
        namespace Communication
        {
            public class TcpPackage
            {
                public static TcpPackage FromRawData(params byte[] rawData)
                {
                    var data = new byte[rawData.Length - 4];
                    for (int i = 0; i < rawData.Length - 4; i++)
                        data[i] = rawData[i + 4];
                    return new TcpPackage(data);
                }
                public TcpPackage(string data)
                {
                    SetData(Encoding.ASCII.GetBytes(data));
                }
                public override string ToString()
                {
                    return Encoding.ASCII.GetString(Data);
                }
                public TcpPackage(params byte[] data)
                {
                    SetData(data);
                }
                void SetData(byte[] data)
                {
                    Data = data;
                }
                public byte[] RawData
                {
                    get
                    {
                        List<byte> bytes = new List<byte>();
                        var s = Size.ToString("X8");
                        bytes.AddRange(Encoding.ASCII.GetBytes(s));
                        bytes.AddRange(Data);
                        return bytes.ToArray();
                    }
                }
                public static implicit operator TcpPackage(string v)
                {
                    return new TcpPackage(v);
                }
                public static implicit operator TcpPackage(byte[] v)
                {
                    return new TcpPackage(v);
                }
                public static implicit operator string(TcpPackage v)
                {
                    return v.ToString();
                }
                public static implicit operator byte[](TcpPackage v)
                {
                    return v.Data;
                }
                public static implicit operator int(TcpPackage v)
                {
                    return v.Size;
                }
                public int Size { get => Data.Length; }
                public byte[] Data { get; private set; }
            }
            public class TCPClient
            {
                public TCPClient(Socket clientSocket, IPAddress ip, ushort port)
                {
                    ClientSocket = clientSocket;
                    Port = port;
                    Ip = ip;
                }
                public TCPClient(Socket clientSocket)
                {
                    ClientSocket = clientSocket;
                    try
                    {
                        Port = (ushort)((IPEndPoint)clientSocket.RemoteEndPoint).Port;
                        Ip = ((IPEndPoint)clientSocket.RemoteEndPoint).Address;
                    }
                    catch { }
                }
                public TCPClient(string ip, ushort port = 0)
                {
                    if (!string.IsNullOrEmpty(ip) && Regex.IsMatch(ip, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"))
                        Ip = IPAddress.Parse(ip);
                    else
                        Ip = IPAddress.Parse("127.0.0.1");
                    if (port != 0)
                        Port = port;
                    else
                        Port = ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString());
                    Setup();
                }
                public TCPClient(IPAddress ip, ushort port = 0)
                {
                    Ip = ip;
                    if (port != 0)
                        Port = port;
                    else
                        Port = ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString());
                    Setup();
                }
                public TCPClient(ushort port = 0)
                {
                    if (port != 0)
                        Port = port;
                    else
                        Port = ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString());
                    Ip = IPAddress.Parse("127.0.0.1");
                    Setup();
                }
                public TCPClient(IPAddress ip)
                {
                    Ip = ip;
                    Port = ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString());
                    Setup();
                }
                public TCPClient()
                {
                    Ip = IPAddress.Parse("127.0.0.1");
                    Port = ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString());
                    Setup();
                }
                private void Setup()
                {
                    ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
                public void Connect(IPAddress ip)
                {
                    if (!Connected)
                        Connect(ip, Port);
                }
                public void Connect(string ip)
                {
                    if (!Connected)
                        try { Connect(IPAddress.Parse(ip)); } catch (Exception ex) { throw ex; }
                }
                public void Connect(IPAddress ip, ushort port)
                {
                    if (!Connected)
                    { try { ClientSocket.Connect(ip, port); } catch (Exception ex) { throw ex; } }
                }
                public bool Connected { get => ClientSocket.Connected; }
                public void Connect()
                {
                    if (!Connected)
                        Connect(Ip, Port);
                }
                public void Disconnect()
                {
                    if (Connected)
                    {
                        ClientSocket.Shutdown(SocketShutdown.Both);
                        ClientSocket.Close();
                    }
                }
                public int ReceiveTimeout { get => ClientSocket.ReceiveTimeout; set => ClientSocket.ReceiveTimeout = value; }
                public int SendTimeout { get => ClientSocket.SendTimeout; set => ClientSocket.SendTimeout = value; }
                public AddressFamily AddressFamily { get => ClientSocket.AddressFamily; }
                public int Avaliable { get => ClientSocket.Available; }
                public bool EnableBroadcast { get => ClientSocket.EnableBroadcast; set => ClientSocket.EnableBroadcast = value; }

                public Stream ReceiveFile()
                {
                    var package = ReceivePackage();
                    var buffer = package.Data;
                    return new MemoryStream(buffer);
                }
                public byte[] Receive()
                {
                    return Receive(2048);
                }
                public byte[] Receive(int bufferSize)
                {
                    var buffer = new byte[bufferSize];
                    int received = ClientSocket.Receive(buffer, SocketFlags.None);
                    if (received == 0) return null;
                    var data = new byte[received];
                    Array.Copy(buffer, data, received);
                    return data;
                }
                public void SendPackage(TcpPackage package)
                {
                    ClientSocket.Send(package.RawData, package.Size + 8, SocketFlags.None);
                }
                public void SendPackage(TcpPackage package, SocketFlags flags)
                {
                    ClientSocket.Send(package.RawData, package.Size + 8, flags);
                }
                public void SendPackage(TcpPackage package, SocketFlags flags, out SocketError errorCode)
                {
                    ClientSocket.Send(package.RawData, 0, package.Size + 8, flags, out errorCode);
                }
                public TcpPackage ReceivePackage()
                {
                    byte[] buffer = new byte[8];
                    ClientSocket.Receive(buffer, buffer.Length, SocketFlags.None);
                    var size = Convert.ToInt32("0x" + Encoding.ASCII.GetString(buffer), 16);
                    byte[] data = new byte[size];
                    ClientSocket.Receive(data, size, SocketFlags.None);
                    return new TcpPackage(data);
                }
                public string ReceiveString()
                {
                    return ReceiveString(2048);
                }
                public string ReceiveString(int bufferSize)
                {
                    string text = Encoding.ASCII.GetString(Receive(bufferSize));
                    return text;
                }
                public int Send(byte[] buffer)
                {
                    return ClientSocket.Send(buffer);
                }
                public int Send(byte[] buffer, SocketFlags flags)
                {
                    return ClientSocket.Send(buffer, flags);
                }
                public int Send(byte[] buffer, int size, SocketFlags flags)
                {
                    return ClientSocket.Send(buffer, size, flags);
                }
                public int Send(byte[] buffer, int offset, int size, SocketFlags flags)
                {
                    return ClientSocket.Send(buffer, offset, size, flags);
                }
                public int Send(byte[] buffer, int offset, int size, SocketFlags flags, out SocketError errorCode)
                {
                    return ClientSocket.Send(buffer, offset, size, flags, out errorCode);
                }
                public int SendString(string text)
                {
                    return Send(Encoding.ASCII.GetBytes(text));
                }
                public void SendFile(string file, SocketFlags flags, out SocketError errorCode)
                {
                    var reader = new BinaryReader(File.OpenRead(file));
                    var buffer = reader.ReadBytes((int)reader.BaseStream.Length);
                    reader.Close();
                    SendPackage(new TcpPackage(buffer), flags, out errorCode);
                }
                public void SendFile(string file, SocketFlags flags)
                {
                    SendFile(file, flags, out SocketError _);
                }
                public void SendFile(string file)
                {
                    SendFile(file, SocketFlags.None, out SocketError _);
                }
                public Socket ClientSocket { get; private set; }
                public IPAddress Ip { get; set; }

                private ushort _port;

                public ushort Port
                {
                    get { return _port; }
                    set
                    {
                        if (value != 0)
                            _port = value;
                        else
                            _port = _port == 0 ? ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString()) : _port;
                    }
                }

            }
            public class TCPServer
            {
                public TCPServer(string ip, ushort port = 0)
                {
                    if (!string.IsNullOrEmpty(ip) && Regex.IsMatch(ip, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}"))
                        Ip = IPAddress.Parse(ip);
                    else
                        Ip = IPAddress.Parse("127.0.0.1");
                    if (port != 0)
                        Port = port;
                    else
                        Port = ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString());
                    Setup();
                }
                public TCPServer(IPAddress ip, ushort port = 0)
                {
                    Ip = ip;
                    if (port != 0)
                        Port = port;
                    else
                        Port = ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString());
                    Setup();
                }
                public TCPServer(ushort port = 0)
                {
                    if (port != 0)
                        Port = port;
                    else
                        Port = ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString());
                    Ip = IPAddress.Parse("127.0.0.1");
                    Setup();
                }
                public TCPServer(IPAddress ip)
                {
                    Ip = ip;
                    Port = ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString());
                    Setup();
                }
                public TCPServer()
                {
                    Ip = IPAddress.Parse("127.0.0.1");
                    Port = ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString());
                    Setup();
                }
                public bool Running { get; private set; }
                readonly List<TCPClient> clients = new List<TCPClient>();
                public TCPClient[] ConnectedClients { get => clients.ToArray(); }
                public Socket ServerSocket { get; private set; }
                public bool BeginReceiveOnConnection { get; set; } = true;
                public bool AutoRelistenForMessages { get; set; } = true;
                public int PacketBufferSize { get => buffer.Length; set => buffer = new byte[value]; }
                void Setup()
                {
                    clients.Clear();
                    ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    ServerSocket.Bind(new IPEndPoint(IPAddress.Any, Port));
                }
                private byte[] buffer = new byte[2048];
                public void Shutdown()
                {
                    foreach (var client in ConnectedClients)
                        DisconnectClient(client, "Server shutdown.");
                    ServerSocket.Close();
                    Running = false;
                }
                void RemoveClient(Socket client)
                {
                    foreach (var c in clients)
                        if (c.ClientSocket == client)
                        { clients.Remove(c); break; }
                }
                TCPClient AddClient(Socket client)
                {
                    var c = new TCPClient(client);
                    clients.Add(c);
                    return c;
                }
                public enum DataReceiveType
                {
                    Normal,
                    TcpPackage
                }
                private void OnClientDataReceived(IAsyncResult data)
                {
                    Socket current = (Socket)data.AsyncState;
                    int received;

                    try
                    {
                        received = current.EndReceive(data);
                    }
                    catch
                    {
                        // Don't shutdown because the socket may be disposed and its disconnected anyway.
                        current.Close();
                        RemoveClient(current);
                        ClientDisconnected?.Invoke(this, new ClientConnectionArgs(new TCPClient(current), "Client forcefully disconnected"));
                        return;
                    }
                    byte[] recBuf = new byte[received];
                    Array.Copy(buffer, recBuf, received);
                    ClientDataReceived?.Invoke(this, new ClientDataArgs(new TCPClient(current), recBuf));
                    if (AutoRelistenForMessages)
                        try { current.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, OnClientDataReceived, current); } catch { }
                }
                public void SendPackageToClient(TCPClient client, TcpPackage package)
                {
                    client.SendPackage(package);
                }
                public TcpPackage ReceivePackageFromClient(TCPClient client)
                {
                    return client.ReceivePackage();
                }
                public int[] Broadcast(byte[] buffer)
                {
                    List<int> returns = new List<int>();
                    foreach (var c in clients)
                        returns.Add(SendToClient(c, buffer, SocketFlags.Broadcast));
                    return returns.ToArray();
                }
                public int[] Broadcast(byte[] buffer, int size)
                {
                    List<int> returns = new List<int>();
                    foreach (var c in clients)
                        returns.Add(SendToClient(c, buffer, size, SocketFlags.Broadcast));
                    return returns.ToArray();
                }
                public int[] Broadcast(byte[] buffer, int offset, int size)
                {
                    List<int> returns = new List<int>();
                    foreach (var c in clients)
                        returns.Add(SendToClient(c, buffer, offset, size, SocketFlags.Broadcast));
                    return returns.ToArray();
                }
                public int[] Broadcast(byte[] buffer, int offset, int size, out SocketError[] errorCodes)
                {
                    List<int> returns = new List<int>();
                    List<SocketError> errors = new List<SocketError>();
                    foreach (var c in clients)
                    {
                        returns.Add(SendToClient(c, buffer, offset, size, SocketFlags.Broadcast, out SocketError error));
                        errors.Add(error);
                    }
                    errorCodes = errors.ToArray();
                    return returns.ToArray();
                }
                public int[] BroadcastString(string text)
                {
                    List<int> returns = new List<int>();
                    foreach (var c in clients)
                        returns.Add(SendStringToClient(c, text));
                    return returns.ToArray();
                }
                public void BroadcastFile(string file)
                {
                    foreach (var c in clients)
                        SendFileToClient(c, file);
                }
                public void BroadcastFile(string file, out SocketError[] errorCode)
                {
                    List<SocketError> errorCodes = new List<SocketError>();
                    foreach (var c in clients)
                    { SendFileToClient(c, file, SocketFlags.Broadcast, out SocketError error); errorCodes.Add(error); }
                    errorCode = errorCodes.ToArray();
                }
                public void BroadcastFile(string file, SocketFlags flags, out SocketError[] errorCode)
                {
                    List<SocketError> errorCodes = new List<SocketError>();
                    foreach (var c in clients)
                    { SendFileToClient(c, file, flags, out SocketError error); errorCodes.Add(error); }
                    errorCode = errorCodes.ToArray();
                }
                public int SendToClient(TCPClient client, byte[] buffer)
                {
                    return client.Send(buffer);
                }
                public int SendToClient(TCPClient client, byte[] buffer, SocketFlags flags)
                {
                    return client.Send(buffer, flags);
                }
                public int SendToClient(TCPClient client, byte[] buffer, int size, SocketFlags flags)
                {
                    return client.Send(buffer, size, flags);
                }
                public int SendToClient(TCPClient client, byte[] buffer, int offset, int size, SocketFlags flags)
                {
                    return client.Send(buffer, offset, size, flags);
                }
                public int SendToClient(TCPClient client, byte[] buffer, int offset, int size, SocketFlags flags, out SocketError errorCode)
                {
                    return client.Send(buffer, offset, size, flags, out errorCode);
                }
                public int SendStringToClient(TCPClient client, string text)
                {
                    return SendToClient(client, Encoding.ASCII.GetBytes(text));
                }
                public void SendFileToClient(TCPClient client, string fileName)
                {
                    client.SendFile(fileName);
                }
                public void SendFileToClient(TCPClient client, string fileName, SocketFlags flags)
                {
                    client.SendFile(fileName, flags, out SocketError _);
                }
                public void SendFileToClient(TCPClient client, string fileName, SocketFlags flags, out SocketError errorCode)
                {
                    client.SendFile(fileName, flags, out errorCode);
                }
                private void RefuseConnection(ClientConnectionArgs e)
                {
                    DisconnectClient(e.Client, "Connection refused!");
                }
                private void OnClientConnection(IAsyncResult request)
                {
                    if (ClientTryConnect != null)
                    {
                        Socket socket = null;
                        try { socket = ServerSocket.EndAccept(request); }
                        catch (Exception ex) { OnClientConnectionFailed(socket, ex.Message); return; }
                        var client = new TCPClient(socket);
                        var args = new ClientConnectionArgs(client, "Client connecting...");
                        if (ClientTryConnect.Invoke(this, args))
                        {
                            clients.Add(client);
                            ClientConnected?.Invoke(this, new ClientConnectionArgs(client, "Client #" + (clients.IndexOf(client) + 1) + " connected"));
                            if (BeginReceiveOnConnection)
                                try { socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, OnClientDataReceived, socket); } catch { RemoveClient(socket); ClientDisconnected?.Invoke(this, new ClientConnectionArgs(new TCPClient(socket), "Client forcefully disconnected")); }
                            ServerSocket.BeginAccept(OnClientConnection, null);
                        }
                        else
                            RefuseConnection(args);
                    }
                    else
                    {
                        Socket socket = null;
                        try { socket = ServerSocket.EndAccept(request); }
                        catch (Exception ex) { OnClientConnectionFailed(socket, ex.Message); return; }
                        var client = AddClient(socket);
                        if (BeginReceiveOnConnection)
                            try { socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, OnClientDataReceived, socket); } catch { RemoveClient(socket); ClientDisconnected?.Invoke(this, new ClientConnectionArgs(new TCPClient(socket), "Client forcefully disconnected")); }
                        ClientConnected?.Invoke(this, new ClientConnectionArgs(client, "Client #" + (clients.IndexOf(client) + 1) + " connected"));
                        ServerSocket.BeginAccept(OnClientConnection, null);
                    }
                }
                public event EventHandler<ClientConnectionArgs> ClientConnectionRefused;
                public delegate bool ClientConnectionHandler(object sender, ClientConnectionArgs e);
                public event ClientConnectionHandler ClientTryConnect;
                private class ASResult : IAsyncResult
                {
                    public bool IsCompleted { get; set; }

                    public WaitHandle AsyncWaitHandle { get; set; }

                    public object AsyncState { get; set; }

                    public bool CompletedSynchronously { get; set; }
                }
                public void DisconnectClient(TCPClient client)
                {
                    try { client.ClientSocket.Shutdown(SocketShutdown.Both); } catch { }
                    try { client.ClientSocket.Close(); } catch { }
                    RemoveClient(client.ClientSocket);
                    ClientDisconnected?.Invoke(this, new ClientConnectionArgs(client, "Manual Disconnection through 'Server.DisconnectClient()'"));
                }
                public void DisconnectClient(TCPClient client, string msg)
                {
                    try { client.ClientSocket.Send(Encoding.ASCII.GetBytes(msg)); client.ClientSocket.Shutdown(SocketShutdown.Both); } catch { }
                    try { client.ClientSocket.Close(); } catch { }
                    RemoveClient(client.ClientSocket);
                    ClientDisconnected?.Invoke(this, new ClientConnectionArgs(client, msg));
                }
                public void BeginReceive(int clientIndex)
                {
                    BeginReceive(clients[clientIndex]);
                }
                public void BeginReceive(TCPClient client)
                {
                    if (clients.Contains(client))
                        client.ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, OnClientDataReceived, client);
                    else
                        throw new Exception("Client is either not connected or not been listed correctly!");
                }
                public void Start()
                {
                    ServerSocket.Listen(0);
                    ServerSocket.BeginAccept(OnClientConnection, null);
                    Running = true;
                }
                public IPAddress Ip { get; set; }
                public ushort Port { get; set; }
                private void OnClientConnectionFailed(Socket client, string msg = null)
                {
                    ClientConnectionFailed?.Invoke(this, new ClientConnectionArgs(new TCPClient(client), msg == null ? "" : msg));
                }
                public event EventHandler<ClientConnectionArgs> ClientConnectionFailed;
                public event EventHandler<ClientConnectionArgs> ClientConnected;
                public event EventHandler<ClientConnectionArgs> ClientDisconnected;
#pragma warning disable CS0067 // false warning disabled
                public event EventHandler<ClientDataArgs> ClientDataReceived;
#pragma warning restore CS0067
                public class ClientDataArgs : EventArgs
                {
                    public ClientDataArgs(TCPClient client, object data)
                    {
                        Client = client;
                        Data = data;
                    }

                    public TCPClient Client { get; }
                    public object Data { get; }
                }
                public class ClientConnectionArgs : EventArgs
                {
                    public ClientConnectionArgs(TCPClient client, string msg)
                    {
                        Client = client;
                        Msg = msg;
                    }

                    public TCPClient Client { get; }
                    public string Msg { get; }
                }
            }
            public class WebCommunicator
            {
                public event EventHandler<WebCommunicatorArgs> MessageReceived;
                public event EventHandler ListeningChanged;
                public WebCommunicator(FTPClient.FTPFile communicationFile)
                {
                    CommunicationFile = communicationFile;
                    updater.Interval = 1050;
                    updater.Tick += Updater_Tick;
                }
                private bool _h = false;
                public bool Listening { get => _h; internal set { _h = value; if (value) updater.Start(); else updater.Stop(); ListeningChanged?.Invoke(this, EventArgs.Empty); } }
                private bool _stopListening = true;
                public virtual void StartListening() => Listening = true;
                public virtual void StopListening() => Listening = false;
                public virtual void StartListeningUntilStopped() { Listening = true; _stopListening = false; }
                private void Updater_Tick(object sender, EventArgs e)
                {
                    var t = new Thread(CheckMsg);
                    t.Start();
                }
                void CheckMsg()
                {
                    if (Listening)
                        if (CommunicationFile.Exists())
                        { if (_stopListening) StopListening(); InternalGetMessage(); }
                }
                private void InternalGetMessage()
                {
                    GetMessage(out string args);
                    if (args != null)
                        MessageReceived?.Invoke(this, new WebCommunicatorArgs(args));
                }
                public virtual void GetMessage()
                {
                    GetMessage(out string args);
                    MessageReceived?.Invoke(this, new WebCommunicatorArgs(args));
                }
                public virtual void SendMessage(string msg)
                {
                    var t = new Thread(InternalSendMessage);
                    t.Start(msg);
                }
                internal virtual void InternalSendMessage(object msg)
                {
                    var request = CommunicationFile.GetRequest();
                    request.KeepAlive = true;
                    request.UseBinary = true;
                    request.UsePassive = true;
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    using (System.IO.Stream r = request.GetRequestStream())
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(r))
                        writer.Write(msg.ToString());
                }
                public virtual void GetMessage(out string content)
                {
                    FtpWebRequest request = Connection.CreateRequest(CommunicationFile.Path);
                    request.KeepAlive = true;
                    request.UsePassive = true;
                    request.UseBinary = true;
                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    try
                    {
                        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse()) // Error here
                        using (System.IO.Stream responseStream = response.GetResponseStream())
                        using (System.IO.StreamReader reader = new System.IO.StreamReader(responseStream))
                            content = reader.ReadToEnd();
                        CommunicationFile.Delete();
                    }
                    catch { content = null; }
                }
                Timer updater = new Timer();
                public FTPClient Connection { get => CommunicationFile.Client; }
                public FTPClient.FTPFile CommunicationFile { get; }
            }
            public class WebCommunicatorArgs : EventArgs
            {
                public WebCommunicatorArgs() { }
                public WebCommunicatorArgs(string args)
                {
                    Message = args;
                }
                public string Message { get; }
            }
        }
        public class FTPClient
        {
            internal static List<string> Add(List<string> list, List<string> add)
            {
                foreach (var val in add) list.Add(val); return list;
            }
            public class FTPDirectory
            {
                public static string GetPath(string path)
                {
                    return new FTPDirectory(null, path).Path;
                }
                public FTPDirectory(FTPClient client, string path)
                {
                    Client = client;
                    Path = path;
                }
                public void Move(string newPath)
                {
                    Name = newPath;
                    Path = newPath;
                }
                public string[] ListAllDirectories()
                {
                    List<string> dirs = new List<string>();
                    foreach (var directory in ListDirectories())
                        if (Client.IsDirectory(directory))
                            if (directory.Split('/').Last() != "." && directory.Split('/').Last() != "..")
                            { dirs.Add(Client.GetDirectory(directory).Path); dirs = Add(dirs, Client.GetDirectory(directory).ListAllDirectories().ToList()); }
                    return dirs.ToArray();
                }
                public string[] ListAllFiles()
                {
                    List<string> files = new List<string>();
                    files = Add(files, ListFiles().ToList());
                    foreach (var dir in ListAllDirectories())
                        files = Add(files, Client.GetDirectory(dir).ListFiles().ToList());
                    return files.ToArray();
                }
                public void Download(string dest)
                {
                    if (System.IO.Directory.Exists(dest))
                        Download(dest + "\\" + Name, true);
                    else
                    {
                        var directories = ListAllDirectories();
                        var files = ListAllFiles();
                        var dir = new System.IO.DirectoryInfo(dest);
                        if (dir.Exists)
                            dir.Delete(true);
                        dir.Create();
                        foreach (var d in directories)
                            new System.IO.DirectoryInfo(dir.FullName + "\\" + Client.GetDirectory(d).Path.Substring(this.Path.Length).Replace("/", "\\")).Create();
                        foreach (var f in files)
                            Client.GetFile(f).Download(new System.IO.FileInfo(dir.FullName + "\\" + Client.GetFile(f).Path.Substring(this.Path.Length).Replace("/", "\\")).FullName);
                    }
                }
                public void Download(string dest, bool overwrite)
                {
                    if (overwrite)
                        if (System.IO.Directory.Exists(dest))
                            System.IO.Directory.Delete(dest, true);
                    Download(dest);
                }
                private string GetDirectoryUploadPath(System.IO.DirectoryInfo root, System.IO.DirectoryInfo dir)
                {
                    return Path + (dir.FullName.Substring(root.FullName.Length)).Replace("\\", "/");
                }
                private string GetFileUploadPath(System.IO.DirectoryInfo root, System.IO.FileInfo file)
                {
                    return Path + (file.FullName.Substring(root.FullName.Length)).Replace("\\", "/");
                }
                public bool Exists()
                {
                    try
                    {
                        var request = Client.CreateRequest(Path + "/7192h89ca67384h18913nf8asuy934081h9.txt");
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        request.UseBinary = true;
                        request.UsePassive = true;
                        request.KeepAlive = true;
                        System.IO.Stream requestStream = request.GetRequestStream();
                        requestStream.Close();
                        request = Client.CreateRequest(Path + "/7192h89ca67384h18913nf8asuy934081h9.txt");
                        request.Method = WebRequestMethods.Ftp.DeleteFile;
                        request.GetResponse();
                        return true;
                    }
                    catch { return false; }
                }
                public void UploadAsync(string src)
                {
                    new System.Threading.Thread(new ParameterizedThreadStart(InternalUploadAsync)).Start(src);
                }
                public int MaxValue = -1;
                public event ProgressChangedEventHandler AsyncUploadProgressChanged;
                public event ProgressChangedEventHandler AsyncUploadComplete;
                public event EventHandler MaxValueObtained;
                void InternalUploadAsync(object src)
                {
                    if (Exists())
                        Delete(true);
                    Create();
                    var dir = new System.IO.DirectoryInfo(src.ToString());
                    var dirs = dir.GetAllDirectories();
                    var files = dir.GetAllFiles();
                    MaxValue = dirs.Length + files.Length * 100;
                    MaxValue--;
                    MaxValueObtained?.Invoke(this, EventArgs.Empty);
                    var progress = 0;
                    foreach (var directory in dirs)
                    {
                        new FTPDirectory(Client, GetDirectoryUploadPath(dir, directory)).Create();
                        progress++;
                        AsyncUploadProgressChanged?.Invoke(this, new ProgressChangedEventArgs(progress, "Creating Directory: " + directory.Name));
                    }
                    foreach (var file in files)
                    {
                        var request = Client.CreateRequest(GetFileUploadPath(dir, file));
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        request.UseBinary = true;
                        request.UsePassive = true;
                        var fs = System.IO.File.ReadAllBytes(file.FullName);
                        var rs = request.GetRequestStream();
                        var currentFileProgress = 0;
                        for (int offset = 0; offset < fs.Length; offset += 1024)
                        {
                            currentFileProgress = (int)(offset * 100 / fs.Length);
                            AsyncUploadProgressChanged?.Invoke(this, new ProgressChangedEventArgs(progress + currentFileProgress, "Uploading File: " + file.Name));
                            var cs = fs.Length - offset;
                            if (cs > 1024) cs = 1024;
                            rs.Write(fs, offset, cs);
                        }
                        progress += 100;
                        rs.Close();
                        rs.Dispose();
                    }
                    AsyncUploadComplete?.Invoke(this, new ProgressChangedEventArgs(MaxValue, "Complete"));
                }
                public void UploadDirectory(string src)
                {
                    if (Exists())
                        Delete(true);
                    Create();
                    var dir = new System.IO.DirectoryInfo(src);
                    foreach (var directory in dir.GetAllDirectories())
                        new FTPDirectory(Client, GetDirectoryUploadPath(dir, directory)).Create();
                    foreach (var file in dir.GetAllFiles())
                        new FTPFile(Client, GetFileUploadPath(dir, file)).UploadFile(file.FullName);
                }
                public string[] ListDirectories(bool fullnames = true)
                {
                    var all = List();
                    List<string> files = new List<string>();
                    foreach (var val in all)
                        if (Client.IsDirectory(val))
                            files.Add(val);
                    return files.ToArray();
                }
                public string[] ListFiles(bool fullnames = true)
                {
                    var all = List();
                    List<string> files = new List<string>();
                    foreach (var val in all)
                        if (!Client.IsDirectory(val))
                            files.Add(val);
                    return files.ToArray();
                }
                public string[] List(bool fullnames = true)
                {
                    StringBuilder result = new StringBuilder();
                    var request = Client.CreateRequest(Path);
                    request.Method = WebRequestMethods.Ftp.ListDirectory;
                    FtpWebResponse responseDir = (FtpWebResponse)request.GetResponse();
                    System.IO.StreamReader readerDir = new System.IO.StreamReader(responseDir.GetResponseStream());
                    string line = readerDir.ReadLine();
                    while (line != null)
                    {
                        if (line.Split('/').Last() != "." && line.Split('/').Last() != "..")
                        {
                            if (fullnames)
                                result.Append(Path + "/" + line.Split('/').Last());
                            else
                                result.Append("/" + line.Split('/').Last());
                            result.Append("\n");
                        }
                        line = readerDir.ReadLine();
                    }
                    if (result.ToString() == "")
                        return new string[0];
                    result.Remove(result.ToString().LastIndexOf('\n'), 1);
                    responseDir.Close();
                    return result.ToString().Split('\n');
                }
                public string Create()
                {
                    var request = Client.CreateRequest(Path);
                    request.Method = WebRequestMethods.Ftp.MakeDirectory;
                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                        return response.StatusDescription;
                }
                public void Delete(bool recursive = false)
                {
                    var list = List();
                    if (recursive)
                        if (list.Length != 0)
                            foreach (var file in list)
                                if (Client.IsDirectory(file))
                                    if (file.Split('/').Last() != "." && file.Split('/').Last() != "..")
                                        new FTPDirectory(Client, file).Delete(true);
                                    else { }
                                else
                                    if (file.Split('/').Last() != "." && file.Split('/').Last() != "..")
                                    if (new FTPFile(Client, file).Exists())
                                        new FTPFile(Client, file).Delete();
                    var request = Client.CreateRequest(Path);
                    request.Method = WebRequestMethods.Ftp.RemoveDirectory;
                    request.UseBinary = true;
                    request.UsePassive = true;
                    request.KeepAlive = true;
                    request.GetResponse().Close();
                }
                public string Name
                {
                    get
                    {
                        return Path.Split('/')[Path.Split('/').Length - 1];
                    }
                    set
                    {
                        var ftpRequest = Client.CreateRequest(Path);
                        ftpRequest.UseBinary = true;
                        ftpRequest.UsePassive = false;
                        ftpRequest.KeepAlive = false;
                        ftpRequest.Proxy = null;
                        ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                        ftpRequest.RenameTo = value;
                        var ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                        ftpResponse.Close();
                        var arr = Path.Split('/').ToList();
                        arr.RemoveAt(arr.Count - 1);
                        arr.Add(value);
                        var newPath = "";
                        foreach (var v in arr)
                            newPath += "/" + v;
                        Path = newPath;
                    }
                }

                public FTPClient Client { get; }
                private string _path = "";
                public string Path
                {
                    get => _path;
                    private set { _path = value.Replace("\\", "/"); if (value.Replace("\\", "/") == "/") return; if (_path.Last() == '/') _path = _path.Substring(0, _path.Length - 1); if (_path.Substring(0, 1) != "/") _path = "/" + _path; }
                }
            }
            public class FTPFile
            {
                public static string GetPath(string path)
                {
                    return new FTPFile(null, path).Path;
                }
                public FTPFile(FTPClient client, string path)
                {
                    Client = client;
                    Path = path;
                }
                public FTPClient Client { get; }
                private string _path = "";
                public string Path
                {
                    get => _path;
                    private set { if (value.Replace("\\", "/").Substring(0, 1) != "/") _path = "/" + value.Replace("\\", "/"); else _path = value.Replace("\\", "/"); }
                }
                public virtual void Move(string newPath)
                {
                    Name = newPath;
                    Path = newPath;
                }
                public FtpWebRequest GetRequest() => Client.CreateRequest(Path);
                public FtpWebRequest GetDownloadRequest()
                {
                    FtpWebRequest request = Client.CreateRequest(Path);
                    request.KeepAlive = true;
                    request.UsePassive = true;
                    request.UseBinary = true;
                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    return request;
                }
                public FtpWebRequest GetUploadRequest()
                {
                    var request = Client.CreateRequest(Path);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.UseBinary = true;
                    request.KeepAlive = true;
                    request.UsePassive = true;
                    return request;
                }
                public virtual string Create()
                {
                    var request = Client.CreateRequest(Path);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    System.IO.StreamWriter requestStream = new System.IO.StreamWriter(request.GetRequestStream());
                    requestStream.Write("");
                    requestStream.Close();
                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                        return $"Upload File Complete, status: {response.StatusDescription}";
                }
                public virtual void Download(string dest)
                {
                    FtpWebRequest request = Client.CreateRequest(Path);
                    request.KeepAlive = true;
                    request.UsePassive = true;
                    request.UseBinary = true;
                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse()) // Error here
                    using (System.IO.Stream responseStream = response.GetResponseStream())
                    using (System.IO.BinaryReader reader = new System.IO.BinaryReader(responseStream))
                    using (System.IO.BinaryWriter writer = new System.IO.BinaryWriter(new System.IO.FileInfo(dest).OpenWrite()))
                    {
                        while (true)
                            try { writer.Write(reader.ReadByte()); }
                            catch { writer.Close(); break; }
                    }
                }
                public static void DownloadFile(FTPClient connection, string webFile, string dest) => connection.GetFile(webFile).Download(dest);
                public virtual void UploadAsync(string src)
                {
                    new System.Threading.Thread(new ParameterizedThreadStart(InternalUploadAsync)).Start(src);
                }
                public event ProgressChangedEventHandler AsyncUploadProgressChanged;
                public event ProgressChangedEventHandler AsyncUploadComplete;
                void InternalUploadAsync(object src)
                {
                    var request = Client.CreateRequest(Path);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.UseBinary = true;
                    request.UsePassive = true;
                    var fs = System.IO.File.ReadAllBytes(src.ToString());
                    var rs = request.GetRequestStream();
                    for (int offset = 0; offset < fs.Length; offset += 1024)
                    {
                        AsyncUploadProgressChanged?.Invoke(this, new ProgressChangedEventArgs((int)(offset * 100 / fs.Length), "uploading"));
                        var cs = fs.Length - offset;
                        if (cs > 1024) cs = 1024;
                        rs.Write(fs, offset, cs);
                    }
                    rs.Close();
                    rs.Dispose();
                    AsyncUploadComplete?.Invoke(this, new ProgressChangedEventArgs(100, "complete"));
                }
                public virtual void UploadFile(string src)
                {
                    System.IO.FileStream fs = System.IO.File.OpenRead(src);
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    fs.Close();
                    try
                    {
                        var request = Client.CreateRequest(Path);
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        request.UseBinary = true;
                        request.UsePassive = true;
                        request.KeepAlive = true;
                        request.ConnectionGroupName = "group";
                        System.IO.Stream requestStream = request.GetRequestStream();
                        requestStream.Write(buffer, 0, buffer.Length);
                        requestStream.Flush();
                        requestStream.Close();
                    }
                    catch (Exception)
                    {
                        var request = Client.CreateRequest(Path);
                        request.Method = WebRequestMethods.Ftp.UploadFile;
                        request.UseBinary = true;
                        request.UsePassive = true;
                        request.KeepAlive = true;
                        request.ConnectionGroupName = "group";
                        System.IO.Stream requestStream = request.GetRequestStream();
                        requestStream.Write(buffer, 0, buffer.Length);
                        requestStream.Flush();
                        requestStream.Close();
                    }
                }
                public static void UploadFile(FTPClient connection, string webDest, string src) => connection.GetFile(webDest).UploadFile(src);
                public virtual bool Exists()
                {
                    var request = Client.CreateRequest(Path);
                    request.Method = WebRequestMethods.Ftp.GetFileSize;
                    try
                    {
                        FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                        return true;
                    }
                    catch (WebException ex)
                    {
                        FtpWebResponse response = (FtpWebResponse)ex.Response;
                        if (response.StatusCode ==
                            FtpStatusCode.ActionNotTakenFileUnavailable)
                        {
                            return false;
                        }
                    }
                    return false;
                }
                public FTPDirectory Directory
                {
                    get
                    {
                        if (Path == "/" + Name)
                            return new FTPDirectory(Client, "/");
                        else
                        {
                            var dir = "";
                            for (int i = 1; i < Path.Split('/').Length - 1; i++)
                                dir += "/" + Path.Split('/')[i];
                            return new FTPDirectory(Client, dir + "/");
                        }
                    }
                }
                public virtual string Delete()
                {
                    var request = Client.CreateRequest(Path);
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                        return response.StatusDescription;
                }
                public string Name
                {
                    get
                    {
                        return Path.Split('/')[Path.Split('/').Length - 1];
                    }
                    set
                    {
                        var ftpRequest = Client.CreateRequest(Path);
                        ftpRequest.UseBinary = true;
                        ftpRequest.UsePassive = false;
                        ftpRequest.KeepAlive = false;
                        ftpRequest.Proxy = null;
                        ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                        ftpRequest.RenameTo = value;
                        var ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                        ftpResponse.Close();
                        var arr = Path.Split('/').ToList();
                        arr.RemoveAt(arr.Count - 1);
                        arr.Add(value);
                        var newPath = "";
                        foreach (var v in arr)
                            newPath += "/" + v;
                        Path = newPath;
                    }
                }
            }
            public string UserName { get; private set; }
            public string Password { get; private set; }
            public int Port { get; private set; }
            public string Session { get; private set; }
            internal FtpWebRequest CreateRequest()
            {
                var request = (FtpWebRequest)WebRequest.Create("ftp://" + Session);
                request.Credentials = new NetworkCredential(this.UserName, this.Password);
                return request;
            }
            internal FtpWebRequest CreateRequest(string path)
            {
                var request = (FtpWebRequest)WebRequest.Create("ftp://" + Session + path);
                request.Credentials = new NetworkCredential(this.UserName, this.Password);
                return request;
            }
            public static FTPClient Create(string connectionString)
            {
                return new FTPClient(connectionString);
            }
            public FTPClient(string connectionString, char assigner = '=')
            {
                UserName = connectionString.GetRegexMatch("(" + "UserName".GetRegexLowerUpperPattern() + assigner.ToString() + ")+([\\w\\.\\@]+),?").Groups[2].Value;
                Password = connectionString.GetRegexMatch("(" + "Password".GetRegexLowerUpperPattern() + assigner.ToString() + ")+([\\w\\.\\@]+),?").Groups[2].Value;
                Session = connectionString.GetRegexMatch("(" + "Session".GetRegexLowerUpperPattern() + assigner.ToString() + ")+([\\w\\.\\@]+),?").Groups[2].Value;
                Port = 21;
            }
            public FTPClient(string _userName, string _password, string _session)
            {
                UserName = _userName;
                Password = _password;
                Session = _session;
                Port = 21;
            }
            public bool IsDirectory(string path)
            {
                return !path.Split('/').Last().Contains(".");
            }
            public void DeleteDirectory(string path, bool recursive = false) => GetDirectory(path).Delete(recursive);
            public void CreateDirectory(string path) => GetDirectory(path).Create();
            public void DeleteFile(string path) => GetFile(path).Delete();
            public void CreateFile(string path) => GetFile(path).Create();
            public void DownloadFile(string src, string dest) => GetFile(src).Download(dest);
            public void UploadFile(string src, string dest) => GetFile(dest).UploadFile(src);
            public void MoveFile(string path, string newPath)
            {
                var file = GetFile(path);
                file.Move(newPath);
            }
            public string[] ListDirectory(string path = "/")
            {
                return GetDirectory(path).List();
            }
            public FTPDirectory GetDirectory(string path = "/")
            {
                return new FTPDirectory(this, path);
            }
            public FTPFile GetFile(string path)
            {
                return new FTPFile(this, path);
            }
        }
    }
    namespace Code
    {
        public static class Compile
        {
            public static string[] GetDefaultUsedAssemblies
            {
                get
                {
                    return new[] { "mscorlib.dll", "System.Core.dll" };
                }
            }
            public static string GetDefaultFrameworkVersion
            {
                get
                {
                    return "v4.0";
                }
            }
            public static CompilerResults CSharpSourceCode(string sourceCode, string frameworkVersion, string outputFile, string[] referencedAssemblies, out string output)
            {
                CSharpCodeProvider csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", frameworkVersion } });
                var outputVariable = "";
                CompilerParameters parameters = new CompilerParameters(referencedAssemblies, outputFile, true)
                {
                    GenerateExecutable = true
                };
                CompilerResults results = csc.CompileAssemblyFromSource(parameters, sourceCode);
                if (results.Errors.HasErrors)
                    results.Errors.Cast<CompilerError>().ToList().ForEach(error => outputVariable += error.ErrorText + "\r\n");
                else
                    outputVariable = "----Build succeded----";
                output = outputVariable;
                return results;
            }
            public static CompilerResults VBSourceCode(string sourceCode, string frameworkVersion, string outputFile, string[] referencedAssemblies, out string output)
            {
                Microsoft.VisualBasic.VBCodeProvider vbc = new Microsoft.VisualBasic.VBCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", frameworkVersion } });
                var outputVariable = "";
                CompilerParameters parameters = new CompilerParameters(referencedAssemblies, outputFile, true)
                {
                    GenerateExecutable = true
                };
                CompilerResults results = vbc.CompileAssemblyFromSource(parameters, sourceCode);
                if (results.Errors.HasErrors)
                    results.Errors.Cast<CompilerError>().ToList().ForEach(error => outputVariable += error.ErrorText + "\r\n");
                else
                    outputVariable = "----Build succeded----";
                output = outputVariable;
                return results;
            }
            public static CompilerResults CSharpSourceFiles(string[] fileNames, string frameworkVersion, string outputFile, string[] referencedAssemblies, out string output)
            {
                CSharpCodeProvider csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", frameworkVersion } });
                var outputVariable = "";
                CompilerParameters parameters = new CompilerParameters(referencedAssemblies, outputFile, true)
                {
                    GenerateExecutable = true
                };
                CompilerResults results = csc.CompileAssemblyFromFile(parameters, fileNames);
                if (results.Errors.HasErrors)
                    results.Errors.Cast<CompilerError>().ToList().ForEach(error => outputVariable += error.ErrorText + "\r\n");
                else
                    outputVariable = "----Build succeded----";
                output = outputVariable;
                return results;
            }
            public static CompilerResults VBSourceFiles(string[] fileNames, string frameworkVersion, string outputFile, string[] referencedAssemblies, out string output)
            {
                CSharpCodeProvider vbc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", frameworkVersion } });
                var outputVariable = "";
                CompilerParameters parameters = new CompilerParameters(referencedAssemblies, outputFile, true)
                {
                    GenerateExecutable = true
                };
                CompilerResults results = vbc.CompileAssemblyFromFile(parameters, fileNames);
                if (results.Errors.HasErrors)
                    results.Errors.Cast<CompilerError>().ToList().ForEach(error => outputVariable += error.ErrorText + "\r\n");
                else
                    outputVariable = "----Build succeded----";
                output = outputVariable;
                return results;
            }
        }
    }
    public static class ConsoleWindow
    {
        public static bool Show()
        {
            return ShowWindow(GetConsoleWindow(), 1);
        }
        public static bool Hide()
        {
            return ShowWindow(GetConsoleWindow(), 0);
        }
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
    }
    //namespace Code
    //{
    //    public static class Python
    //    {
    //        public static void RunScript(string ScriptLocation, string pythonEXE)
    //        {
    //            RunScript(ScriptLocation, pythonEXE, new string[0]);
    //        }
    //        public static void RunScript(string ScriptLocation, string pythonEXE, bool showWindow)
    //        {
    //            RunScript(ScriptLocation, pythonEXE, new string[0]);
    //        }
    //        public static void RunScript(string ScriptLocation, string pythonEXE, string[] args, bool showWindow)
    //        {
    //            string arguments = $"\"{ScriptLocation}\" ";
    //            if (args.Length != 0)
    //            {
    //                foreach (string arg in args)
    //                {
    //                    arguments += $"\"{arg}\" ";
    //                }
    //            }
    //            ProcessStartInfo process = new ProcessStartInfo(pythonEXE, arguments);
    //            process.CreateNoWindow = !showWindow;
    //            process.RedirectStandardError = true;
    //            process.RedirectStandardOutput = true;
    //            process.UseShellExecute = false;
    //            Process.Start(process);
    //        }
    //        public static void RunScript(string ScriptLocation, string pythonEXE, string[] args)
    //        {
    //            RunScript(ScriptLocation, pythonEXE, args, true);
    //        }
    //    }
    //}
    public static class Strings
    {
        public static string StrReverse(string str)
        {
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i].ToString();
            }
            return rev;
        }
        public static char AddToChar(char Character, int Ammount = 1)
        {
            if (Ammount < 1)
            {
                return Character;
            }
            string newChar = Character.ToString();
            for (int i = 0; i < Ammount; i++)
            {
                byte btValue = Convert.ToByte(char.Parse(newChar));
                var arr = new byte[1];
                arr[0] = Convert.ToByte(btValue + 1);
                newChar = ASCIIEncoding.ASCII.GetString(arr);
                if (newChar == "{") { newChar = "a"; }
                if (newChar == "[") { newChar = "A"; }
            }
            return char.Parse(newChar);
        }
        public static string AddToChars(string chars, int Ammount = 1)
        {
            if (Ammount < 1)
            {
                return chars;
            }
            string newStr = "";
            foreach (char chr in chars.ToCharArray())
            {
                newStr += AddToChar(chr, Ammount);
            }
            return newStr;
        }
        public static string AddToChars(char[] chars, int Ammount = 1)
        {
            string Str = "";
            foreach (char chr in chars)
            {
                Str += chr.ToString();
            }
            return AddToChars(Str, Ammount);
        }
    }
    namespace DataTypeExtensions
    {
        namespace UI
        {
            public static class UIClassExtensions
            {
                public static void ChangeBGColorSmoothly(this Control control, Color color, int delay = 1)
                {
                    int a = control.BackColor.A;
                    int r = control.BackColor.R;
                    int g = control.BackColor.G;
                    int b = control.BackColor.B;
                    while (control.BackColor != color)
                    {
                        if (a < color.A)
                            a++;
                        else if (a > color.A)
                            a--;
                        if (r < color.R)
                            r++;
                        else if (r > color.R)
                            r--;
                        if (g < color.G)
                            g++;
                        else if (g > color.G)
                            g--;
                        if (b < color.B)
                            b++;
                        else if (b > color.B)
                            b--;
                        control.BackColor = Color.FromArgb(a, r, g, b);
                        System.Threading.Thread.Sleep(delay);
                    }
                }
                public static void CenterOnContainerX(this Control control) => control.Location = new Point(control.Parent.ClientRectangle.Size.Width / 2 - control.Size.Width / 2, control.Location.Y);
                public static void CenterOnContainerY(this Control control) => control.Location = new Point(control.Location.X, control.Parent.ClientRectangle.Height / 2 - control.Size.Height / 2);
                public static void CenterOnContainerX(this Control control, Control container)
                {
                    control.Parent = container;
                    control.CenterOnContainerX();
                }
                public static void CenterOnContainerY(this Control control, Control container)
                {
                    control.Parent = container;
                    control.CenterOnContainerY();
                }
                public static void CenterOnContainer(this Control control, Control container)
                {
                    control.Parent = container;
                    control.CenterOnContainer();
                }
                public static void CenterOnContainer(this Control control) => control.Location = new Point(control.Parent.ClientRectangle.Size.Width / 2 - control.Size.Width / 2, control.Parent.ClientRectangle.Size.Height / 2 - control.Size.Height / 2);
                public static decimal GetPercentage(this System.Windows.Forms.ProgressBar progressBar)
                {
                    decimal NTP = progressBar.Value * 100 / progressBar.Maximum;
                    if (NTP.ToString().Contains(","))
                        return Convert.ToDecimal(NTP.ToString().Substring(0, NTP.ToString().IndexOf(',') - 1));
                    else
                        return NTP;
                }
                public static TreeNode GetNodeByPath(this TreeView tree, string path)
                {
                    var paths = path.Split('\\');
                    TreeNode cNode = null;
                    foreach (TreeNode n in tree.Nodes)
                        if (n.Text == path.Split('\\')[0])
                        { cNode = n; break; }
                    if (path.Split('\\').Length == 1)
                        return cNode;
                    for (int i = 1; i < paths.Count(); i++)
                    {
                        var tmp = cNode;
                        foreach (TreeNode n in cNode.Nodes)
                            if (n.Text == paths[i])
                            { cNode = n; break; }
                        if (tmp == cNode)
                            throw new Exception("Path not found");
                    }
                    return cNode;
                }
                public static TreeNode GetNodeByPath(this TreeNode root, string path)
                {
                    var paths = path.Split('\\');
                    TreeNode cNode = root;
                    for (int i = 0; i < paths.Count(); i++)
                    {
                        var tmp = cNode;
                        foreach (TreeNode n in cNode.Nodes)
                            if (n.Text == paths[i])
                            { cNode = n; break; }
                        if (tmp == cNode)
                            throw new Exception("Path not found");
                    }
                    return cNode;
                }
                public static void Sort(this TreeNodeCollection nodes)
                {
                    List<string> sn = new List<string>();
                    foreach (TreeNode node in nodes)
                        sn.Add(node.Text);
                    sn.Sort();
                    nodes.Clear();
                    foreach (var item in sn)
                        nodes.Add(item);
                }
            }
        }
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
            public static Enumerator GetEnum<Enumerator>(this string obj, Enumerator defaultReturn) where Enumerator : Enum
            {
                foreach (var val in Enum.GetNames(typeof(Enumerator)))
                    if (val.ToString().ToLower() == obj.ToLower()) return (Enumerator)Enum.Parse(typeof(Enumerator), val);
                return defaultReturn;
            }
            public static Enumerator GetEnum<Enumerator>(this int obj, Enumerator defaultReturn) where Enumerator : Enum
            {
                foreach (var val in Enum.GetNames(typeof(Enumerator)))
                    if ((int)Enum.Parse(typeof(Enumerator), val) == obj)
                        return (Enumerator)Enum.Parse(typeof(Enumerator), val);
                return defaultReturn;
            }
            public static void Add<T>(this List<T> list, List<T> add)
            {
                foreach (var val in add)
                    list.Add(val);
            }
            public static bool ToBool(this string v) => (v == "true" || v == "1");
            public static T[] Search<T>(this T[] obj, string search, string propname) => obj.Search(search, propname, false);
            public static List<T> Search<T>(this List<T> obj, string search, string propname, bool caseSensitive) => obj.ToArray().Search(search, propname, caseSensitive).ToList();
            public static List<T> Search<T>(this List<T> obj, string search, string propname) => obj.ToList().Search(search, propname, false);
            public static List<string> Search(this List<string> obj, string search) => Search(obj.ToArray(), search).ToList();
            public static List<string> Search(this List<string> obj, string search, bool caseSensitive) => Search(obj.ToArray(), search, caseSensitive).ToList();
            public static string[] Search(this string[] obj, string search) => Search(obj, search, false);
            public static string[] Search(this string[] obj, string search, bool caseSensitive)
            {
                if (caseSensitive)
                {
                    List<string> ret = new List<string>();
                    foreach (var o in obj)
                        if (o.Contains(search))
                            ret.Add(o);
                    return ret.ToArray();
                }
                else
                {
                    List<string> ret = new List<string>();
                    foreach (var o in obj)
                        if (o.ToLower().Contains(search.ToLower()))
                            ret.Add(o);
                    return ret.ToArray();
                }
            }
            public static T[] Search<T>(this T[] obj, string search, string propname, bool caseSensitive)
            {
                List<T> res = new List<T>();
                foreach (var o in obj)
                    try { if (caseSensitive) if (o.GetType().GetProperty(propname).GetValue(o, null).ToString().Contains(search)) res.Add(o); else { } else if (o.GetType().GetProperty(propname).GetValue(o, null).ToString().ToLower().Contains(search.ToLower())) res.Add(o); }
                    catch { }
                return res.ToArray();
            }
            public static ResultType[] GetPropertyArray<ResultType>(this object[] obj, string propname)
            {
                List<ResultType> props = new List<ResultType>();
                foreach (var o in obj)
                    props.Add((ResultType)o.GetType().GetProperty(propname).GetValue(o, null));
                return props.ToArray();
            }
            public static object[] ToObjectArray<T>(this T[] obj)
            {
                List<object> objs = new List<object>();
                foreach (var o in obj)
                    objs.Add((object)o);
                return objs.ToArray();
            }
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
            #region Formatting
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
            #endregion
            #region Converter
            public static string ToHex(this int v)
            {
                return DecimalToHexadecimal(v);
            }
            public static string ToBinary(this int v)
            {
                return DecimalToBinary(v);
            }
            public static int ToOctal(this int v)
            {
                return int.Parse(DecimalToOctal(v));
            }
            public static int ToInt(this string v)
            {
                if (v.ToUpper().Contains("A") || v.ToUpper().Contains("B") || v.ToUpper().Contains("C") || v.ToUpper().Contains("D") || v.ToUpper().Contains("E") || v.ToUpper().Contains("F"))
                    return HexadecimalToDecimal(v);
                else
                    return int.Parse(v);
            }
            public static string ToBinary(this string v)
            {
                return TextToBinary(v);
            }
            public static string ToHex(this string v)
            {
                return TextToHexadecimal(v);
            }
            #endregion
        }
    }
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
            private static string ParseAspas(ref string thing)
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
            private static string ParseNormal(ref string thing)
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
                        cmds.Add(ParseAspas(ref a));
                    else
                        cmds.Add(ParseNormal(ref a));
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
        namespace SimpleJSON
        {
            public enum JSONTextMode
            {
                // Token: 0x040008AD RID: 2221
                Compact,
                // Token: 0x040008AE RID: 2222
                Indent
            }
            // Token: 0x02000131 RID: 305
            public class JSONString : JSONNode
            {
                // Token: 0x060009F5 RID: 2549 RVA: 0x00042E7B File Offset: 0x0004127B
                public JSONString(string aData)
                {
                    this.m_Data = aData;
                }

                // Token: 0x1700015A RID: 346
                // (get) Token: 0x060009F6 RID: 2550 RVA: 0x00042E8A File Offset: 0x0004128A
                public override JSONNodeType Tag
                {
                    get
                    {
                        return JSONNodeType.String;
                    }
                }

                // Token: 0x1700015B RID: 347
                // (get) Token: 0x060009F7 RID: 2551 RVA: 0x00042E8D File Offset: 0x0004128D
                public override bool IsString
                {
                    get
                    {
                        return true;
                    }
                }

                // Token: 0x1700015C RID: 348
                // (get) Token: 0x060009F8 RID: 2552 RVA: 0x00042E90 File Offset: 0x00041290
                // (set) Token: 0x060009F9 RID: 2553 RVA: 0x00042E98 File Offset: 0x00041298
                public override string Value
                {
                    get
                    {
                        return this.m_Data;
                    }
                    set
                    {
                        this.m_Data = value;
                    }
                }

                // Token: 0x060009FA RID: 2554 RVA: 0x00042EA1 File Offset: 0x000412A1
                public override void Serialize(System.IO.BinaryWriter aWriter)
                {
                    aWriter.Write(3);
                    aWriter.Write(this.m_Data);
                }

                // Token: 0x060009FB RID: 2555 RVA: 0x00042EB6 File Offset: 0x000412B6
                internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
                {
                    aSB.Append('"').Append(JSONNode.Escape(this.m_Data)).Append('"');
                }

                // Token: 0x060009FC RID: 2556 RVA: 0x00042ED8 File Offset: 0x000412D8
                public override bool Equals(object obj)
                {
                    if (base.Equals(obj))
                    {
                        return true;
                    }
                    string text = obj as string;
                    if (text != null)
                    {
                        return this.m_Data == text;
                    }
                    JSONString jsonstring = obj as JSONString;
                    return jsonstring != null && this.m_Data == jsonstring.m_Data;
                }

                // Token: 0x060009FD RID: 2557 RVA: 0x00042F33 File Offset: 0x00041333
                public override int GetHashCode()
                {
                    return this.m_Data.GetHashCode();
                }

                // Token: 0x040008B4 RID: 2228
                private string m_Data;
            }
            // Token: 0x02000130 RID: 304
            public class JSONObject : JSONNode, IEnumerable
            {
                // Token: 0x17000154 RID: 340
                // (get) Token: 0x060009E6 RID: 2534 RVA: 0x000426FA File Offset: 0x00040AFA
                public override JSONNodeType Tag
                {
                    get
                    {
                        return JSONNodeType.Object;
                    }
                }

                // Token: 0x17000155 RID: 341
                // (get) Token: 0x060009E7 RID: 2535 RVA: 0x000426FD File Offset: 0x00040AFD
                public override bool IsObject
                {
                    get
                    {
                        return true;
                    }
                }

                // Token: 0x17000156 RID: 342
                public override JSONNode this[string aKey]
                {
                    get
                    {
                        if (this.m_Dict.ContainsKey(aKey))
                        {
                            return this.m_Dict[aKey];
                        }
                        return new JSONLazyCreator(this, aKey);
                    }
                    set
                    {
                        if (value == null)
                        {
                            value = new JSONNull();
                        }
                        if (this.m_Dict.ContainsKey(aKey))
                        {
                            this.m_Dict[aKey] = value;
                        }
                        else
                        {
                            this.m_Dict.Add(aKey, value);
                        }
                    }
                }

                // Token: 0x17000157 RID: 343
                public override JSONNode this[int aIndex]
                {
                    get
                    {
                        if (aIndex < 0 || aIndex >= this.m_Dict.Count)
                        {
                            return null;
                        }
                        return this.m_Dict.ElementAt(aIndex).Value;
                    }
                    set
                    {
                        if (value == null)
                        {
                            value = new JSONNull();
                        }
                        if (aIndex < 0 || aIndex >= this.m_Dict.Count)
                        {
                            return;
                        }
                        string key = this.m_Dict.ElementAt(aIndex).Key;
                        this.m_Dict[key] = value;
                    }
                }

                // Token: 0x17000158 RID: 344
                // (get) Token: 0x060009EC RID: 2540 RVA: 0x0004280F File Offset: 0x00040C0F
                public override int Count
                {
                    get
                    {
                        return this.m_Dict.Count;
                    }
                }

                // Token: 0x060009ED RID: 2541 RVA: 0x0004281C File Offset: 0x00040C1C
                public override void Add(string aKey, JSONNode aItem)
                {
                    if (aItem == null)
                    {
                        aItem = new JSONNull();
                    }
                    if (!string.IsNullOrEmpty(aKey))
                    {
                        if (this.m_Dict.ContainsKey(aKey))
                        {
                            this.m_Dict[aKey] = aItem;
                        }
                        else
                        {
                            this.m_Dict.Add(aKey, aItem);
                        }
                    }
                    else
                    {
                        this.m_Dict.Add(Guid.NewGuid().ToString(), aItem);
                    }
                }

                // Token: 0x060009EE RID: 2542 RVA: 0x0004289C File Offset: 0x00040C9C
                public override JSONNode Remove(string aKey)
                {
                    if (!this.m_Dict.ContainsKey(aKey))
                    {
                        return null;
                    }
                    JSONNode result = this.m_Dict[aKey];
                    this.m_Dict.Remove(aKey);
                    return result;
                }

                // Token: 0x060009EF RID: 2543 RVA: 0x000428D8 File Offset: 0x00040CD8
                public override JSONNode Remove(int aIndex)
                {
                    if (aIndex < 0 || aIndex >= this.m_Dict.Count)
                    {
                        return null;
                    }
                    KeyValuePair<string, JSONNode> keyValuePair = this.m_Dict.ElementAt(aIndex);
                    this.m_Dict.Remove(keyValuePair.Key);
                    return keyValuePair.Value;
                }

                // Token: 0x060009F0 RID: 2544 RVA: 0x00042928 File Offset: 0x00040D28
                public override JSONNode Remove(JSONNode aNode)
                {
                    JSONNode result;
                    try
                    {
                        KeyValuePair<string, JSONNode> keyValuePair = (from k in this.m_Dict
                                                                       where k.Value == aNode
                                                                       select k).First<KeyValuePair<string, JSONNode>>();
                        this.m_Dict.Remove(keyValuePair.Key);
                        result = aNode;
                    }
                    catch
                    {
                        result = null;
                    }
                    return result;
                }

                // Token: 0x17000159 RID: 345
                // (get) Token: 0x060009F1 RID: 2545 RVA: 0x00042998 File Offset: 0x00040D98
                public override IEnumerable<JSONNode> Children
                {
                    get
                    {
                        foreach (KeyValuePair<string, JSONNode> N in this.m_Dict)
                        {
                            yield return N.Value;
                        }
                        yield break;
                    }
                }

                // Token: 0x060009F2 RID: 2546 RVA: 0x000429BC File Offset: 0x00040DBC
                public IEnumerator GetEnumerator()
                {
                    foreach (KeyValuePair<string, JSONNode> N in this.m_Dict)
                    {
                        yield return N;
                    }
                    yield break;
                }

                // Token: 0x060009F3 RID: 2547 RVA: 0x000429D8 File Offset: 0x00040DD8
                public override void Serialize(System.IO.BinaryWriter aWriter)
                {
                    aWriter.Write(2);
                    aWriter.Write(this.m_Dict.Count);
                    foreach (string text in this.m_Dict.Keys)
                    {
                        aWriter.Write(text);
                        this.m_Dict[text].Serialize(aWriter);
                    }
                }

                // Token: 0x060009F4 RID: 2548 RVA: 0x00042A64 File Offset: 0x00040E64
                internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
                {
                    aSB.Append('{');
                    bool flag = true;
                    if (this.inline)
                    {
                        aMode = JSONTextMode.Compact;
                    }
                    foreach (KeyValuePair<string, JSONNode> keyValuePair in this.m_Dict)
                    {
                        if (!flag)
                        {
                            aSB.Append(',');
                        }
                        flag = false;
                        if (aMode == JSONTextMode.Indent)
                        {
                            aSB.AppendLine();
                        }
                        if (aMode == JSONTextMode.Indent)
                        {
                            aSB.Append(' ', aIndent + aIndentInc);
                        }
                        aSB.Append('"').Append(JSONNode.Escape(keyValuePair.Key)).Append('"');
                        if (aMode == JSONTextMode.Compact)
                        {
                            aSB.Append(':');
                        }
                        else
                        {
                            aSB.Append(" : ");
                        }
                        keyValuePair.Value.WriteToStringBuilder(aSB, aIndent + aIndentInc, aIndentInc, aMode);
                    }
                    if (aMode == JSONTextMode.Indent)
                    {
                        aSB.AppendLine().Append(' ', aIndent);
                    }
                    aSB.Append('}');
                }

                // Token: 0x040008B2 RID: 2226
                private Dictionary<string, JSONNode> m_Dict = new Dictionary<string, JSONNode>();

                // Token: 0x040008B3 RID: 2227
                public bool inline;
            }
            // Token: 0x02000132 RID: 306
            public class JSONNumber : JSONNode
            {
                // Token: 0x060009FE RID: 2558 RVA: 0x00042F40 File Offset: 0x00041340
                public JSONNumber(double aData)
                {
                    this.m_Data = aData;
                }

                // Token: 0x060009FF RID: 2559 RVA: 0x00042F4F File Offset: 0x0004134F
                public JSONNumber(string aData)
                {
                    this.Value = aData;
                }

                // Token: 0x1700015D RID: 349
                // (get) Token: 0x06000A00 RID: 2560 RVA: 0x00042F5E File Offset: 0x0004135E
                public override JSONNodeType Tag
                {
                    get
                    {
                        return JSONNodeType.Number;
                    }
                }

                // Token: 0x1700015E RID: 350
                // (get) Token: 0x06000A01 RID: 2561 RVA: 0x00042F61 File Offset: 0x00041361
                public override bool IsNumber
                {
                    get
                    {
                        return true;
                    }
                }

                // Token: 0x1700015F RID: 351
                // (get) Token: 0x06000A02 RID: 2562 RVA: 0x00042F64 File Offset: 0x00041364
                // (set) Token: 0x06000A03 RID: 2563 RVA: 0x00042F78 File Offset: 0x00041378
                public override string Value
                {
                    get
                    {
                        return this.m_Data.ToString();
                    }
                    set
                    {
                        double data;
                        if (double.TryParse(value, out data))
                        {
                            this.m_Data = data;
                        }
                    }
                }

                // Token: 0x17000160 RID: 352
                // (get) Token: 0x06000A04 RID: 2564 RVA: 0x00042F99 File Offset: 0x00041399
                // (set) Token: 0x06000A05 RID: 2565 RVA: 0x00042FA1 File Offset: 0x000413A1
                public override double AsDouble
                {
                    get
                    {
                        return this.m_Data;
                    }
                    set
                    {
                        this.m_Data = value;
                    }
                }

                // Token: 0x06000A06 RID: 2566 RVA: 0x00042FAA File Offset: 0x000413AA
                public override void Serialize(System.IO.BinaryWriter aWriter)
                {
                    aWriter.Write(4);
                    aWriter.Write(this.m_Data);
                }

                // Token: 0x06000A07 RID: 2567 RVA: 0x00042FBF File Offset: 0x000413BF
                internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
                {
                    aSB.Append(this.m_Data);
                }

                // Token: 0x06000A08 RID: 2568 RVA: 0x00042FD0 File Offset: 0x000413D0
                private static bool IsNumeric(object value)
                {
                    return value is int || value is uint || value is float || value is double || value is decimal || value is long || value is ulong || value is short || value is ushort || value is sbyte || value is byte;
                }

                // Token: 0x06000A09 RID: 2569 RVA: 0x00043058 File Offset: 0x00041458
                public override bool Equals(object obj)
                {
                    if (obj == null)
                    {
                        return false;
                    }
                    if (base.Equals(obj))
                    {
                        return true;
                    }
                    JSONNumber jsonnumber = obj as JSONNumber;
                    if (jsonnumber != null)
                    {
                        return this.m_Data == jsonnumber.m_Data;
                    }
                    return JSONNumber.IsNumeric(obj) && Convert.ToDouble(obj) == this.m_Data;
                }

                // Token: 0x06000A0A RID: 2570 RVA: 0x000430B8 File Offset: 0x000414B8
                public override int GetHashCode()
                {
                    return this.m_Data.GetHashCode();
                }

                // Token: 0x040008B5 RID: 2229
                private double m_Data;
            }
            // Token: 0x02000134 RID: 308
            public class JSONNull : JSONNode
            {
                // Token: 0x17000165 RID: 357
                // (get) Token: 0x06000A18 RID: 2584 RVA: 0x000431AE File Offset: 0x000415AE
                public override JSONNodeType Tag
                {
                    get
                    {
                        return JSONNodeType.NullValue;
                    }
                }

                // Token: 0x17000166 RID: 358
                // (get) Token: 0x06000A19 RID: 2585 RVA: 0x000431B1 File Offset: 0x000415B1
                public override bool IsNull
                {
                    get
                    {
                        return true;
                    }
                }

                // Token: 0x17000167 RID: 359
                // (get) Token: 0x06000A1A RID: 2586 RVA: 0x000431B4 File Offset: 0x000415B4
                // (set) Token: 0x06000A1B RID: 2587 RVA: 0x000431BB File Offset: 0x000415BB
                public override string Value
                {
                    get
                    {
                        return "null";
                    }
                    set
                    {
                    }
                }

                // Token: 0x17000168 RID: 360
                // (get) Token: 0x06000A1C RID: 2588 RVA: 0x000431BD File Offset: 0x000415BD
                // (set) Token: 0x06000A1D RID: 2589 RVA: 0x000431C0 File Offset: 0x000415C0
                public override bool AsBool
                {
                    get
                    {
                        return false;
                    }
                    set
                    {
                    }
                }

                // Token: 0x06000A1E RID: 2590 RVA: 0x000431C2 File Offset: 0x000415C2
                public override bool Equals(object obj)
                {
                    return object.ReferenceEquals(this, obj) || obj is JSONNull;
                }

                // Token: 0x06000A1F RID: 2591 RVA: 0x000431DB File Offset: 0x000415DB
                public override int GetHashCode()
                {
                    return 0;
                }

                // Token: 0x06000A20 RID: 2592 RVA: 0x000431DE File Offset: 0x000415DE
                public override void Serialize(System.IO.BinaryWriter aWriter)
                {
                    aWriter.Write(5);
                }

                // Token: 0x06000A21 RID: 2593 RVA: 0x000431E7 File Offset: 0x000415E7
                internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
                {
                    aSB.Append("null");
                }
            }
            public enum JSONNodeType
            {
                // Token: 0x040008A5 RID: 2213
                Array = 1,
                // Token: 0x040008A6 RID: 2214
                Object,
                // Token: 0x040008A7 RID: 2215
                String,
                // Token: 0x040008A8 RID: 2216
                Number,
                // Token: 0x040008A9 RID: 2217
                NullValue,
                // Token: 0x040008AA RID: 2218
                Boolean,
                // Token: 0x040008AB RID: 2219
                None
            }
            public static class JSONNodeExtension
            {
                public static JSONNode Locate(this JSONNode node, string path)
                {
                    var n = node;
                    foreach (var v in path.Split('/'))
                        try { n = n[int.Parse(v)]; }
                        catch { n = n[v]; }
                    return n;
                }
                public static string Formatted(this JSONNode node)
                {
                    return JSON.Format(node.ToString());
                }
            }
            // Token: 0x0200012E RID: 302
            public abstract class JSONNode
            {
                // Token: 0x1700013B RID: 315
                public virtual JSONNode this[int aIndex]
                {
                    get
                    {
                        return null;
                    }
                    set
                    {
                    }
                }

                // Token: 0x1700013C RID: 316
                public virtual JSONNode this[string aKey]
                {
                    get
                    {
                        return null;
                    }
                    set
                    {
                    }
                }
                public virtual string Value
                {
                    get
                    {
                        return string.Empty;
                    }
                    set
                    {
                    }
                }
                public virtual int Count
                {
                    get
                    {
                        return 0;
                    }
                }
                public virtual bool IsNumber
                {
                    get
                    {
                        return false;
                    }
                }
                public virtual bool IsString
                {
                    get
                    {
                        return false;
                    }
                }
                public virtual bool IsBoolean
                {
                    get
                    {
                        return false;
                    }
                }
                public virtual bool IsNull
                {
                    get
                    {
                        return false;
                    }
                }
                public virtual bool IsArray
                {
                    get
                    {
                        return false;
                    }
                }
                public virtual bool IsObject
                {
                    get
                    {
                        return false;
                    }
                }
                public virtual void Add(string aKey, JSONNode aItem)
                {
                }
                public virtual void Add(JSONNode aItem)
                {
                    this.Add(string.Empty, aItem);
                }
                public virtual JSONNode Remove(string aKey)
                {
                    return null;
                }
                public virtual JSONNode Remove(int aIndex)
                {
                    return null;
                }
                public virtual JSONNode Remove(JSONNode aNode)
                {
                    return aNode;
                }
                public virtual IEnumerable<JSONNode> Children
                {
                    get
                    {
                        yield break;
                    }
                }
                public IEnumerable<JSONNode> DeepChildren
                {
                    get
                    {
                        foreach (JSONNode C in this.Children)
                        {
                            foreach (JSONNode D in C.DeepChildren)
                            {
                                yield return D;
                            }
                        }
                        yield break;
                    }
                }
                public override string ToString()
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    this.WriteToStringBuilder(stringBuilder, 0, 0, JSONTextMode.Compact);
                    return stringBuilder.ToString();
                }
                public virtual string ToString(int aIndent)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    this.WriteToStringBuilder(stringBuilder, 0, aIndent, JSONTextMode.Indent);
                    return stringBuilder.ToString();
                }
                internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
                public abstract JSONNodeType Tag { get; }
                public virtual double AsDouble
                {
                    get
                    {
                        double result = 0.0;
                        if (double.TryParse(this.Value, out result))
                        {
                            return result;
                        }
                        return 0.0;
                    }
                    set
                    {
                        this.Value = value.ToString();
                    }
                }
                public virtual int AsInt
                {
                    get
                    {
                        return (int)this.AsDouble;
                    }
                    set
                    {
                        this.AsDouble = (double)value;
                    }
                }
                public virtual float AsFloat
                {
                    get
                    {
                        return (float)this.AsDouble;
                    }
                    set
                    {
                        this.AsDouble = (double)value;
                    }
                }
                public virtual bool AsBool
                {
                    get
                    {
                        bool result = false;
                        if (bool.TryParse(this.Value, out result))
                        {
                            return result;
                        }
                        return !string.IsNullOrEmpty(this.Value);
                    }
                    set
                    {
                        this.Value = ((!value) ? "false" : "true");
                    }
                }
                public virtual JSONArray AsArray
                {
                    get
                    {
                        return this as JSONArray;
                    }
                }
                public virtual JSONObject AsObject
                {
                    get
                    {
                        return this as JSONObject;
                    }
                }
                public static implicit operator JSONNode(string s)
                {
                    return new JSONString(s);
                }
                public static implicit operator string(JSONNode d)
                {
                    return (!(d == null)) ? d.Value : null;
                }
                public static implicit operator JSONNode(double n)
                {
                    return new JSONNumber(n);
                }
                public static implicit operator double(JSONNode d)
                {
                    return (!(d == null)) ? d.AsDouble : 0.0;
                }
                public static implicit operator JSONNode(float n)
                {
                    return new JSONNumber((double)n);
                }
                public static implicit operator float(JSONNode d)
                {
                    return (!(d == null)) ? d.AsFloat : 0f;
                }
                public static implicit operator JSONNode(int n)
                {
                    return new JSONNumber((double)n);
                }
                public static implicit operator int(JSONNode d)
                {
                    return (!(d == null)) ? d.AsInt : 0;
                }
                public static implicit operator JSONNode(bool b)
                {
                    return new JSONBool(b);
                }
                public static implicit operator bool(JSONNode d)
                {
                    return !(d == null) && d.AsBool;
                }
                public static bool operator ==(JSONNode a, object b)
                {
                    if (object.ReferenceEquals(a, b))
                    {
                        return true;
                    }
                    bool flag = a is JSONNull || object.ReferenceEquals(a, null) || a is JSONLazyCreator;
                    bool flag2 = b is JSONNull || object.ReferenceEquals(b, null) || b is JSONLazyCreator;
                    return (flag && flag2) || a.Equals(b);
                }
                public static bool operator !=(JSONNode a, object b)
                {
                    return !(a == b);
                }
                public override bool Equals(object obj)
                {
                    return object.ReferenceEquals(this, obj);
                }
                public override int GetHashCode()
                {
                    return base.GetHashCode();
                }
                internal static string Escape(string aText)
                {
                    JSONNode.m_EscapeBuilder.Length = 0;
                    if (JSONNode.m_EscapeBuilder.Capacity < aText.Length + aText.Length / 10)
                    {
                        JSONNode.m_EscapeBuilder.Capacity = aText.Length + aText.Length / 10;
                    }
                    foreach (char c in aText)
                    {
                        switch (c)
                        {
                            case '\b':
                                JSONNode.m_EscapeBuilder.Append("\\b");
                                break;
                            case '\t':
                                JSONNode.m_EscapeBuilder.Append("\\t");
                                break;
                            case '\n':
                                JSONNode.m_EscapeBuilder.Append("\\n");
                                break;
                            default:
                                if (c != '"')
                                {
                                    if (c != '\\')
                                    {
                                        JSONNode.m_EscapeBuilder.Append(c);
                                    }
                                    else
                                    {
                                        JSONNode.m_EscapeBuilder.Append("\\\\");
                                    }
                                }
                                else
                                {
                                    JSONNode.m_EscapeBuilder.Append("\\\"");
                                }
                                break;
                            case '\f':
                                JSONNode.m_EscapeBuilder.Append("\\f");
                                break;
                            case '\r':
                                JSONNode.m_EscapeBuilder.Append("\\r");
                                break;
                        }
                    }
                    string result = JSONNode.m_EscapeBuilder.ToString();
                    JSONNode.m_EscapeBuilder.Length = 0;
                    return result;
                }

                // Token: 0x060009C5 RID: 2501 RVA: 0x000417E4 File Offset: 0x0003FBE4
                private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
                {
                    if (quoted)
                    {
                        ctx.Add(tokenName, token);
                        return;
                    }
                    string a = token.ToLower();
                    double n;
                    if (a == "false" || a == "true")
                    {
                        ctx.Add(tokenName, a == "true");
                    }
                    else if (a == "null")
                    {
                        ctx.Add(tokenName, null);
                    }
                    else if (double.TryParse(token, out n))
                    {
                        ctx.Add(tokenName, n);
                    }
                    else
                    {
                        ctx.Add(tokenName, token);
                    }
                }

                // Token: 0x060009C6 RID: 2502 RVA: 0x00041894 File Offset: 0x0003FC94
                public static JSONNode Parse(string aJSON)
                {
                    Stack<JSONNode> stack = new Stack<JSONNode>();
                    JSONNode jsonnode = null;
                    int i = 0;
                    StringBuilder stringBuilder = new StringBuilder();
                    string text = string.Empty;
                    bool flag = false;
                    bool flag2 = false;
                    while (i < aJSON.Length)
                    {
                        char c = aJSON[i];
                        switch (c)
                        {
                            case '\t':
                                goto IL_275;
                            case '\n':
                            case '\r':
                                break;
                            default:
                                switch (c)
                                {
                                    case '[':
                                        if (flag)
                                        {
                                            stringBuilder.Append(aJSON[i]);
                                            goto IL_371;
                                        }
                                        stack.Push(new JSONArray());
                                        if (jsonnode != null)
                                        {
                                            jsonnode.Add(text, stack.Peek());
                                        }
                                        text = string.Empty;
                                        stringBuilder.Length = 0;
                                        jsonnode = stack.Peek();
                                        goto IL_371;
                                    case '\\':
                                        i++;
                                        if (flag)
                                        {
                                            char c2 = aJSON[i];
                                            switch (c2)
                                            {
                                                case 'r':
                                                    stringBuilder.Append('\r');
                                                    break;
                                                default:
                                                    if (c2 != 'b')
                                                    {
                                                        if (c2 != 'f')
                                                        {
                                                            if (c2 != 'n')
                                                            {
                                                                stringBuilder.Append(c2);
                                                            }
                                                            else
                                                            {
                                                                stringBuilder.Append('\n');
                                                            }
                                                        }
                                                        else
                                                        {
                                                            stringBuilder.Append('\f');
                                                        }
                                                    }
                                                    else
                                                    {
                                                        stringBuilder.Append('\b');
                                                    }
                                                    break;
                                                case 't':
                                                    stringBuilder.Append('\t');
                                                    break;
                                                case 'u':
                                                    {
                                                        string s = aJSON.Substring(i + 1, 4);
                                                        stringBuilder.Append((char)int.Parse(s, NumberStyles.AllowHexSpecifier));
                                                        i += 4;
                                                        break;
                                                    }
                                            }
                                        }
                                        goto IL_371;
                                    case ']':
                                        break;
                                    default:
                                        switch (c)
                                        {
                                            case ' ':
                                                goto IL_275;
                                            default:
                                                switch (c)
                                                {
                                                    case '{':
                                                        if (flag)
                                                        {
                                                            stringBuilder.Append(aJSON[i]);
                                                            goto IL_371;
                                                        }
                                                        stack.Push(new JSONObject());
                                                        if (jsonnode != null)
                                                        {
                                                            jsonnode.Add(text, stack.Peek());
                                                        }
                                                        text = string.Empty;
                                                        stringBuilder.Length = 0;
                                                        jsonnode = stack.Peek();
                                                        goto IL_371;
                                                    default:
                                                        if (c != ',')
                                                        {
                                                            if (c != ':')
                                                            {
                                                                stringBuilder.Append(aJSON[i]);
                                                                goto IL_371;
                                                            }
                                                            if (flag)
                                                            {
                                                                stringBuilder.Append(aJSON[i]);
                                                                goto IL_371;
                                                            }
                                                            text = stringBuilder.ToString();
                                                            stringBuilder.Length = 0;
                                                            flag2 = false;
                                                            goto IL_371;
                                                        }
                                                        else
                                                        {
                                                            if (flag)
                                                            {
                                                                stringBuilder.Append(aJSON[i]);
                                                                goto IL_371;
                                                            }
                                                            if (stringBuilder.Length > 0 || flag2)
                                                            {
                                                                JSONNode.ParseElement(jsonnode, stringBuilder.ToString(), text, flag2);
                                                            }
                                                            text = string.Empty;
                                                            stringBuilder.Length = 0;
                                                            flag2 = false;
                                                            goto IL_371;
                                                        }
                                                    case '}':
                                                        break;
                                                }
                                                break;
                                            case '"':
                                                flag ^= true;
                                                flag2 = (flag2 || flag);
                                                goto IL_371;
                                        }
                                        break;
                                }
                                if (flag)
                                {
                                    stringBuilder.Append(aJSON[i]);
                                }
                                else
                                {
                                    if (stack.Count == 0)
                                    {
                                        throw new Exception("JSON Parse: Too many closing brackets");
                                    }
                                    stack.Pop();
                                    if (stringBuilder.Length > 0 || flag2)
                                    {
                                        JSONNode.ParseElement(jsonnode, stringBuilder.ToString(), text, flag2);
                                        flag2 = false;
                                    }
                                    text = string.Empty;
                                    stringBuilder.Length = 0;
                                    if (stack.Count > 0)
                                    {
                                        jsonnode = stack.Peek();
                                    }
                                }
                                break;
                        }
                    IL_371:
                        i++;
                        continue;
                    IL_275:
                        if (flag)
                        {
                            stringBuilder.Append(aJSON[i]);
                        }
                        goto IL_371;
                    }
                    if (flag)
                    {
                        throw new Exception("JSON Parse: Quotation marks seems to be messed up.");
                    }
                    return jsonnode;
                }

                // Token: 0x060009C7 RID: 2503 RVA: 0x00041C35 File Offset: 0x00040035
                public virtual void Serialize(System.IO.BinaryWriter aWriter)
                {
                }

                // Token: 0x060009C8 RID: 2504 RVA: 0x00041C38 File Offset: 0x00040038
                public void SaveToStream(System.IO.Stream aData)
                {
                    System.IO.BinaryWriter aWriter = new System.IO.BinaryWriter(aData);
                    this.Serialize(aWriter);
                }

                // Token: 0x060009C9 RID: 2505 RVA: 0x00041C53 File Offset: 0x00040053
                public void SaveToCompressedStream(System.IO.Stream aData)
                {
                    throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
                }

                // Token: 0x060009CA RID: 2506 RVA: 0x00041C5F File Offset: 0x0004005F
                public void SaveToCompressedFile(string aFileName)
                {
                    throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
                }

                // Token: 0x060009CB RID: 2507 RVA: 0x00041C6B File Offset: 0x0004006B
                public string SaveToCompressedBase64()
                {
                    throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
                }

                // Token: 0x060009CC RID: 2508 RVA: 0x00041C78 File Offset: 0x00040078
                public void SaveToFile(string aFileName)
                {
                    System.IO.Directory.CreateDirectory(new System.IO.FileInfo(aFileName).Directory.FullName);
                    using (System.IO.FileStream fileStream = System.IO.File.OpenWrite(aFileName))
                    {
                        this.SaveToStream(fileStream);
                    }
                }

                // Token: 0x060009CD RID: 2509 RVA: 0x00041CCC File Offset: 0x000400CC
                public string SaveToBase64()
                {
                    string result;
                    using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
                    {
                        this.SaveToStream(memoryStream);
                        memoryStream.Position = 0L;
                        result = Convert.ToBase64String(memoryStream.ToArray());
                    }
                    return result;
                }

                // Token: 0x060009CE RID: 2510 RVA: 0x00041D20 File Offset: 0x00040120
                public static JSONNode Deserialize(System.IO.BinaryReader aReader)
                {
                    JSONNodeType jsonnodeType = (JSONNodeType)aReader.ReadByte();
                    switch (jsonnodeType)
                    {
                        case JSONNodeType.Array:
                            {
                                int num = aReader.ReadInt32();
                                JSONArray jsonarray = new JSONArray();
                                for (int i = 0; i < num; i++)
                                {
                                    jsonarray.Add(JSONNode.Deserialize(aReader));
                                }
                                return jsonarray;
                            }
                        case JSONNodeType.Object:
                            {
                                int num2 = aReader.ReadInt32();
                                JSONObject jsonobject = new JSONObject();
                                for (int j = 0; j < num2; j++)
                                {
                                    string aKey = aReader.ReadString();
                                    JSONNode aItem = JSONNode.Deserialize(aReader);
                                    jsonobject.Add(aKey, aItem);
                                }
                                return jsonobject;
                            }
                        case JSONNodeType.String:
                            return new JSONString(aReader.ReadString());
                        case JSONNodeType.Number:
                            return new JSONNumber(aReader.ReadDouble());
                        case JSONNodeType.NullValue:
                            return new JSONNull();
                        case JSONNodeType.Boolean:
                            return new JSONBool(aReader.ReadBoolean());
                        default:
                            throw new Exception("Error deserializing JSON. Unknown tag: " + jsonnodeType);
                    }
                }

                // Token: 0x060009CF RID: 2511 RVA: 0x00041E09 File Offset: 0x00040209
                public static JSONNode LoadFromCompressedFile(string aFileName)
                {
                    throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
                }

                // Token: 0x060009D0 RID: 2512 RVA: 0x00041E15 File Offset: 0x00040215
                public static JSONNode LoadFromCompressedStream(System.IO.Stream aData)
                {
                    throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
                }

                // Token: 0x060009D1 RID: 2513 RVA: 0x00041E21 File Offset: 0x00040221
                public static JSONNode LoadFromCompressedBase64(string aBase64)
                {
                    throw new Exception("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
                }

                // Token: 0x060009D2 RID: 2514 RVA: 0x00041E30 File Offset: 0x00040230
                public static JSONNode LoadFromStream(System.IO.Stream aData)
                {
                    JSONNode result;
                    using (System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(aData))
                    {
                        result = JSONNode.Deserialize(binaryReader);
                    }
                    return result;
                }

                // Token: 0x060009D3 RID: 2515 RVA: 0x00041E70 File Offset: 0x00040270
                public static JSONNode LoadFromFile(string aFileName)
                {
                    JSONNode result;
                    using (System.IO.FileStream fileStream = System.IO.File.OpenRead(aFileName))
                    {
                        result = JSONNode.LoadFromStream(fileStream);
                    }
                    return result;
                }

                // Token: 0x060009D4 RID: 2516 RVA: 0x00041EB0 File Offset: 0x000402B0
                public static JSONNode LoadFromBase64(string aBase64)
                {
                    byte[] buffer = Convert.FromBase64String(aBase64);
                    return JSONNode.LoadFromStream(new System.IO.MemoryStream(buffer)
                    {
                        Position = 0L
                    });
                }

                // Token: 0x040008AF RID: 2223
                internal static StringBuilder m_EscapeBuilder = new StringBuilder();
            }
            // Token: 0x02000135 RID: 309
            internal class JSONLazyCreator : JSONNode
            {
                // Token: 0x06000A22 RID: 2594 RVA: 0x000431F5 File Offset: 0x000415F5
                public JSONLazyCreator(JSONNode aNode)
                {
                    this.m_Node = aNode;
                    this.m_Key = null;
                }

                // Token: 0x06000A23 RID: 2595 RVA: 0x0004320B File Offset: 0x0004160B
                public JSONLazyCreator(JSONNode aNode, string aKey)
                {
                    this.m_Node = aNode;
                    this.m_Key = aKey;
                }

                // Token: 0x17000169 RID: 361
                // (get) Token: 0x06000A24 RID: 2596 RVA: 0x00043221 File Offset: 0x00041621
                public override JSONNodeType Tag
                {
                    get
                    {
                        return JSONNodeType.None;
                    }
                }

                // Token: 0x06000A25 RID: 2597 RVA: 0x00043224 File Offset: 0x00041624
                private void Set(JSONNode aVal)
                {
                    if (this.m_Key == null)
                    {
                        this.m_Node.Add(aVal);
                    }
                    else
                    {
                        this.m_Node.Add(this.m_Key, aVal);
                    }
                    this.m_Node = null;
                }

                // Token: 0x1700016A RID: 362
                public override JSONNode this[int aIndex]
                {
                    get
                    {
                        return new JSONLazyCreator(this);
                    }
                    set
                    {
                        this.Set(new JSONArray
                {
                    value
                });
                    }
                }

                // Token: 0x1700016B RID: 363
                public override JSONNode this[string aKey]
                {
                    get
                    {
                        return new JSONLazyCreator(this, aKey);
                    }
                    set
                    {
                        this.Set(new JSONObject
                {
                    {
                        aKey,
                        value
                    }
                });
                    }
                }

                // Token: 0x06000A2A RID: 2602 RVA: 0x000432B4 File Offset: 0x000416B4
                public override void Add(JSONNode aItem)
                {
                    this.Set(new JSONArray
            {
                aItem
            });
                }

                // Token: 0x06000A2B RID: 2603 RVA: 0x000432D8 File Offset: 0x000416D8
                public override void Add(string aKey, JSONNode aItem)
                {
                    this.Set(new JSONObject
            {
                {
                    aKey,
                    aItem
                }
            });
                }

                // Token: 0x06000A2C RID: 2604 RVA: 0x000432FA File Offset: 0x000416FA
                public static bool operator ==(JSONLazyCreator a, object b)
                {
                    return b == null || object.ReferenceEquals(a, b);
                }

                // Token: 0x06000A2D RID: 2605 RVA: 0x0004330B File Offset: 0x0004170B
                public static bool operator !=(JSONLazyCreator a, object b)
                {
                    return !(a == b);
                }

                // Token: 0x06000A2E RID: 2606 RVA: 0x00043317 File Offset: 0x00041717
                public override bool Equals(object obj)
                {
                    return obj == null || object.ReferenceEquals(this, obj);
                }

                // Token: 0x06000A2F RID: 2607 RVA: 0x00043328 File Offset: 0x00041728
                public override int GetHashCode()
                {
                    return 0;
                }

                // Token: 0x1700016C RID: 364
                // (get) Token: 0x06000A30 RID: 2608 RVA: 0x0004332C File Offset: 0x0004172C
                // (set) Token: 0x06000A31 RID: 2609 RVA: 0x00043350 File Offset: 0x00041750
                public override int AsInt
                {
                    get
                    {
                        JSONNumber aVal = new JSONNumber(0.0);
                        this.Set(aVal);
                        return 0;
                    }
                    set
                    {
                        JSONNumber aVal = new JSONNumber((double)value);
                        this.Set(aVal);
                    }
                }

                // Token: 0x1700016D RID: 365
                // (get) Token: 0x06000A32 RID: 2610 RVA: 0x0004336C File Offset: 0x0004176C
                // (set) Token: 0x06000A33 RID: 2611 RVA: 0x00043394 File Offset: 0x00041794
                public override float AsFloat
                {
                    get
                    {
                        JSONNumber aVal = new JSONNumber(0.0);
                        this.Set(aVal);
                        return 0f;
                    }
                    set
                    {
                        JSONNumber aVal = new JSONNumber((double)value);
                        this.Set(aVal);
                    }
                }

                // Token: 0x1700016E RID: 366
                // (get) Token: 0x06000A34 RID: 2612 RVA: 0x000433B0 File Offset: 0x000417B0
                // (set) Token: 0x06000A35 RID: 2613 RVA: 0x000433DC File Offset: 0x000417DC
                public override double AsDouble
                {
                    get
                    {
                        JSONNumber aVal = new JSONNumber(0.0);
                        this.Set(aVal);
                        return 0.0;
                    }
                    set
                    {
                        JSONNumber aVal = new JSONNumber(value);
                        this.Set(aVal);
                    }
                }

                // Token: 0x1700016F RID: 367
                // (get) Token: 0x06000A36 RID: 2614 RVA: 0x000433F8 File Offset: 0x000417F8
                // (set) Token: 0x06000A37 RID: 2615 RVA: 0x00043414 File Offset: 0x00041814
                public override bool AsBool
                {
                    get
                    {
                        JSONBool aVal = new JSONBool(false);
                        this.Set(aVal);
                        return false;
                    }
                    set
                    {
                        JSONBool aVal = new JSONBool(value);
                        this.Set(aVal);
                    }
                }

                // Token: 0x17000170 RID: 368
                // (get) Token: 0x06000A38 RID: 2616 RVA: 0x00043430 File Offset: 0x00041830
                public override JSONArray AsArray
                {
                    get
                    {
                        JSONArray jsonarray = new JSONArray();
                        this.Set(jsonarray);
                        return jsonarray;
                    }
                }

                // Token: 0x17000171 RID: 369
                // (get) Token: 0x06000A39 RID: 2617 RVA: 0x0004344C File Offset: 0x0004184C
                public override JSONObject AsObject
                {
                    get
                    {
                        JSONObject jsonobject = new JSONObject();
                        this.Set(jsonobject);
                        return jsonobject;
                    }
                }

                // Token: 0x06000A3A RID: 2618 RVA: 0x00043467 File Offset: 0x00041867
                internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
                {
                    aSB.Append("null");
                }

                // Token: 0x040008B7 RID: 2231
                private JSONNode m_Node;

                // Token: 0x040008B8 RID: 2232
                private string m_Key;
            }
            // Token: 0x02000133 RID: 307
            public class JSONBool : JSONNode
            {
                // Token: 0x06000A0B RID: 2571 RVA: 0x000430CB File Offset: 0x000414CB
                public JSONBool(bool aData)
                {
                    this.m_Data = aData;
                }

                // Token: 0x06000A0C RID: 2572 RVA: 0x000430DA File Offset: 0x000414DA
                public JSONBool(string aData)
                {
                    this.Value = aData;
                }

                // Token: 0x17000161 RID: 353
                // (get) Token: 0x06000A0D RID: 2573 RVA: 0x000430E9 File Offset: 0x000414E9
                public override JSONNodeType Tag
                {
                    get
                    {
                        return JSONNodeType.Boolean;
                    }
                }

                // Token: 0x17000162 RID: 354
                // (get) Token: 0x06000A0E RID: 2574 RVA: 0x000430EC File Offset: 0x000414EC
                public override bool IsBoolean
                {
                    get
                    {
                        return true;
                    }
                }

                // Token: 0x17000163 RID: 355
                // (get) Token: 0x06000A0F RID: 2575 RVA: 0x000430EF File Offset: 0x000414EF
                // (set) Token: 0x06000A10 RID: 2576 RVA: 0x00043104 File Offset: 0x00041504
                public override string Value
                {
                    get
                    {
                        return this.m_Data.ToString();
                    }
                    set
                    {
                        bool data;
                        if (bool.TryParse(value, out data))
                        {
                            this.m_Data = data;
                        }
                    }
                }

                // Token: 0x17000164 RID: 356
                // (get) Token: 0x06000A11 RID: 2577 RVA: 0x00043125 File Offset: 0x00041525
                // (set) Token: 0x06000A12 RID: 2578 RVA: 0x0004312D File Offset: 0x0004152D
                public override bool AsBool
                {
                    get
                    {
                        return this.m_Data;
                    }
                    set
                    {
                        this.m_Data = value;
                    }
                }

                // Token: 0x06000A13 RID: 2579 RVA: 0x00043136 File Offset: 0x00041536
                public override void Serialize(System.IO.BinaryWriter aWriter)
                {
                    aWriter.Write(6);
                    aWriter.Write(this.m_Data);
                }

                // Token: 0x06000A14 RID: 2580 RVA: 0x0004314B File Offset: 0x0004154B
                internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
                {
                    aSB.Append((!this.m_Data) ? "false" : "true");
                }

                // Token: 0x06000A15 RID: 2581 RVA: 0x0004316E File Offset: 0x0004156E
                public override bool Equals(object obj)
                {
                    return obj != null && obj is bool && this.m_Data == (bool)obj;
                }

                // Token: 0x06000A16 RID: 2582 RVA: 0x00043193 File Offset: 0x00041593
                public override int GetHashCode()
                {
                    return this.m_Data.GetHashCode();
                }

                // Token: 0x040008B6 RID: 2230
                private bool m_Data;
            }
            // Token: 0x0200012F RID: 303
            public class JSONArray : JSONNode, IEnumerable
            {
                // Token: 0x1700014E RID: 334
                // (get) Token: 0x060009D7 RID: 2519 RVA: 0x0004218F File Offset: 0x0004058F
                public override JSONNodeType Tag
                {
                    get
                    {
                        return JSONNodeType.Array;
                    }
                }

                // Token: 0x1700014F RID: 335
                // (get) Token: 0x060009D8 RID: 2520 RVA: 0x00042192 File Offset: 0x00040592
                public override bool IsArray
                {
                    get
                    {
                        return true;
                    }
                }

                // Token: 0x17000150 RID: 336
                public override JSONNode this[int aIndex]
                {
                    get
                    {
                        if (aIndex < 0 || aIndex >= this.m_List.Count)
                        {
                            return new JSONLazyCreator(this);
                        }
                        return this.m_List[aIndex];
                    }
                    set
                    {
                        if (value == null)
                        {
                            value = new JSONNull();
                        }
                        if (aIndex < 0 || aIndex >= this.m_List.Count)
                        {
                            this.m_List.Add(value);
                        }
                        else
                        {
                            this.m_List[aIndex] = value;
                        }
                    }
                }

                // Token: 0x17000151 RID: 337
                public override JSONNode this[string aKey]
                {
                    get
                    {
                        return new JSONLazyCreator(this);
                    }
                    set
                    {
                        if (value == null)
                        {
                            value = new JSONNull();
                        }
                        this.m_List.Add(value);
                    }
                }

                // Token: 0x17000152 RID: 338
                // (get) Token: 0x060009DD RID: 2525 RVA: 0x00042243 File Offset: 0x00040643
                public override int Count
                {
                    get
                    {
                        return this.m_List.Count;
                    }
                }

                // Token: 0x060009DE RID: 2526 RVA: 0x00042250 File Offset: 0x00040650
                public override void Add(string aKey, JSONNode aItem)
                {
                    if (aItem == null)
                    {
                        aItem = new JSONNull();
                    }
                    this.m_List.Add(aItem);
                }

                // Token: 0x060009DF RID: 2527 RVA: 0x00042274 File Offset: 0x00040674
                public override JSONNode Remove(int aIndex)
                {
                    if (aIndex < 0 || aIndex >= this.m_List.Count)
                    {
                        return null;
                    }
                    JSONNode result = this.m_List[aIndex];
                    this.m_List.RemoveAt(aIndex);
                    return result;
                }

                // Token: 0x060009E0 RID: 2528 RVA: 0x000422B5 File Offset: 0x000406B5
                public override JSONNode Remove(JSONNode aNode)
                {
                    this.m_List.Remove(aNode);
                    return aNode;
                }

                // Token: 0x17000153 RID: 339
                // (get) Token: 0x060009E1 RID: 2529 RVA: 0x000422C8 File Offset: 0x000406C8
                public override IEnumerable<JSONNode> Children
                {
                    get
                    {
                        foreach (JSONNode N in this.m_List)
                        {
                            yield return N;
                        }
                        yield break;
                    }
                }

                // Token: 0x060009E2 RID: 2530 RVA: 0x000422EC File Offset: 0x000406EC
                public IEnumerator GetEnumerator()
                {
                    foreach (JSONNode N in this.m_List)
                    {
                        yield return N;
                    }
                    yield break;
                }

                // Token: 0x060009E3 RID: 2531 RVA: 0x00042308 File Offset: 0x00040708
                public override void Serialize(System.IO.BinaryWriter aWriter)
                {
                    aWriter.Write(1);
                    aWriter.Write(this.m_List.Count);
                    for (int i = 0; i < this.m_List.Count; i++)
                    {
                        this.m_List[i].Serialize(aWriter);
                    }
                }

                // Token: 0x060009E4 RID: 2532 RVA: 0x0004235C File Offset: 0x0004075C
                internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
                {
                    aSB.Append('[');
                    int count = this.m_List.Count;
                    if (this.inline)
                    {
                        aMode = JSONTextMode.Compact;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        if (i > 0)
                        {
                            aSB.Append(',');
                        }
                        if (aMode == JSONTextMode.Indent)
                        {
                            aSB.AppendLine();
                        }
                        if (aMode == JSONTextMode.Indent)
                        {
                            aSB.Append(' ', aIndent + aIndentInc);
                        }
                        this.m_List[i].WriteToStringBuilder(aSB, aIndent + aIndentInc, aIndentInc, aMode);
                    }
                    if (aMode == JSONTextMode.Indent)
                    {
                        aSB.AppendLine().Append(' ', aIndent);
                    }
                    aSB.Append(']');
                }

                // Token: 0x040008B0 RID: 2224
                private List<JSONNode> m_List = new List<JSONNode>();

                // Token: 0x040008B1 RID: 2225
                public bool inline;
            }
            // Token: 0x02000136 RID: 310
            public static class JSON
            {
                // Token: 0x06000A3B RID: 2619 RVA: 0x00043475 File Offset: 0x00041875
                public static JSONNode Parse(string aJSON)
                {
                    return JSONNode.Parse(aJSON);
                }
                public static string Format(string input, string Indent = "    ")
                {
                    var output = new StringBuilder(input.Length * 2);
                    char? quote = null;
                    int depth = 0;

                    for (int i = 0; i < input.Length; ++i)
                    {
                        char ch = input[i];

                        switch (ch)
                        {
                            case '{':
                            case '[':
                                output.Append(ch);
                                if (!quote.HasValue)
                                {
                                    output.AppendLine();
                                    output.Append(Repeat(Indent, ++depth));
                                }
                                break;
                            case '}':
                            case ']':
                                if (quote.HasValue)
                                    output.Append(ch);
                                else
                                {
                                    output.AppendLine();
                                    output.Append(Repeat(Indent, --depth));
                                    output.Append(ch);
                                }
                                break;
                            case '"':
                            case '\'':
                                output.Append(ch);
                                if (quote.HasValue)
                                {
                                    if (!IsEscaped(output, i))
                                        quote = null;
                                }
                                else quote = ch;
                                break;
                            case ',':
                                output.Append(ch);
                                if (!quote.HasValue)
                                {
                                    output.AppendLine();
                                    output.Append(Repeat(Indent, depth));
                                }
                                break;
                            case ':':
                                if (quote.HasValue) output.Append(ch);
                                else output.Append(" : ");
                                break;
                            default:
                                if (quote.HasValue || !char.IsWhiteSpace(ch))
                                    output.Append(ch);
                                break;
                        }
                    }

                    return output.ToString();
                }
                private static string Repeat(string str, int count)
                {
                    return new StringBuilder().Insert(0, str, count).ToString();
                }

                private static bool IsEscaped(string str, int index)
                {
                    bool escaped = false;
                    while (index > 0 && str[--index] == '\\') escaped = !escaped;
                    return escaped;
                }

                private static bool IsEscaped(StringBuilder str, int index)
                {
                    return IsEscaped(str.ToString(), index);
                }
            }
            internal static class Extensions
            {
                public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
                {
                    foreach (var i in ie)
                    {
                        action(i);
                    }
                }
            }
        }
        namespace Cryptography
        {
            public class XORAlgorithm
            {
                public string Encrypt(string Text, string key)
                {
                    byte[] data = UTF8Encoding.UTF8.GetBytes(Text);
                    using (System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                        using (System.Security.Cryptography.TripleDESCryptoServiceProvider tripDes = new System.Security.Cryptography.TripleDESCryptoServiceProvider() { Key = keys, Mode = System.Security.Cryptography.CipherMode.ECB, Padding = System.Security.Cryptography.PaddingMode.PKCS7 })
                        {
                            System.Security.Cryptography.ICryptoTransform transform = tripDes.CreateEncryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            return Convert.ToBase64String(results, 0, results.Length);
                        }
                    }
                }
                public string Decrypt(string Text, string key)
                {
                    byte[] data = Convert.FromBase64String(Text);
                    using (System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
                    {
                        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                        using (System.Security.Cryptography.TripleDESCryptoServiceProvider tripDes = new System.Security.Cryptography.TripleDESCryptoServiceProvider() { Key = keys, Mode = System.Security.Cryptography.CipherMode.ECB, Padding = System.Security.Cryptography.PaddingMode.PKCS7 })
                        {
                            System.Security.Cryptography.ICryptoTransform transform = tripDes.CreateDecryptor();
                            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                            return UTF8Encoding.UTF8.GetString(results);
                        }
                    }
                }
            }
            public class FileCryptor
            {
                /// <summary>
                /// Encrypt a file
                /// </summary>
                /// <param name="filePath">Self explanatory</param>
                /// <param name="key">A 8 char lenght key that must contain at least 1 letter (containing only numbers whill cause the function to return false)</param>
                /// <returns>True for success; False for fail</returns>
                public bool EncryptFile(string filePath, string key = "??9V0g?8")
                {
                    if (key.Length != 8)
                    {
                        return false;
                    }
                    try
                    {
                        byte[] plainContent = System.IO.File.ReadAllBytes(filePath);
                        using (var DES = new System.Security.Cryptography.DESCryptoServiceProvider())
                        {
                            DES.IV = Encoding.UTF8.GetBytes(key);
                            DES.Key = Encoding.UTF8.GetBytes(key);
                            DES.Mode = System.Security.Cryptography.CipherMode.CBC;
                            DES.Padding = System.Security.Cryptography.PaddingMode.PKCS7;


                            using (var memStream = new System.IO.MemoryStream())
                            {
                                System.Security.Cryptography.CryptoStream cryptoStream = new System.Security.Cryptography.CryptoStream(memStream, DES.CreateEncryptor(),
                                       System.Security.Cryptography.CryptoStreamMode.Write);

                                cryptoStream.Write(plainContent, 0, plainContent.Length);
                                cryptoStream.FlushFinalBlock();
                                System.IO.File.WriteAllBytes(filePath, memStream.ToArray());
                                return true;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                /// <summary>
                /// Decrypt a file
                /// </summary>
                /// <param name="filePath">Self explanatory</param>
                /// <param name="key">A 8 char lenght key that must contain at least 1 letter (containing only numbers whill cause the function to return false)</param>
                /// <returns>True for success; False for fail</returns>
                public bool DecryptFile(string filePath, string key = "??9V0g?8")
                {
                    if (key.Length != 8)
                    {
                        return false;
                    }
                    try
                    {
                        byte[] encrypted = System.IO.File.ReadAllBytes(filePath);
                        using (var DES = new System.Security.Cryptography.DESCryptoServiceProvider())
                        {
                            DES.IV = Encoding.UTF8.GetBytes(key);
                            DES.Key = Encoding.UTF8.GetBytes(key);
                            DES.Mode = System.Security.Cryptography.CipherMode.CBC;
                            DES.Padding = System.Security.Cryptography.PaddingMode.PKCS7;


                            using (var memStream = new System.IO.MemoryStream())
                            {
                                System.Security.Cryptography.CryptoStream cryptoStream = new System.Security.Cryptography.CryptoStream(memStream, DES.CreateDecryptor(),
                                System.Security.Cryptography.CryptoStreamMode.Write);

                                cryptoStream.Write(encrypted, 0, encrypted.Length);
                                cryptoStream.FlushFinalBlock();
                                System.IO.File.WriteAllBytes(filePath, memStream.ToArray());
                                return true;
                            }
                        }

                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                /// <summary>
                /// Generate a random DES key to be used with the functions: EncryptFile() ; DecryptFile()
                /// </summary>
                /// <returns>Returns a random DES key</returns>
                public string GenerateDESKey()
                {
                    System.Security.Cryptography.DESCryptoServiceProvider dESCrypto = (System.Security.Cryptography.DESCryptoServiceProvider)System.Security.Cryptography.DESCryptoServiceProvider.Create();
                    return ASCIIEncoding.ASCII.GetString(dESCrypto.Key);
                }
            }
            public class Base64Cryptor
            {
                public string DecryptUntilEnd(string StringToDecode)
                {
                    if (StringToDecode == null)
                    {
                        throw new ArgumentNullException(nameof(StringToDecode));
                    }

                    string OldCrypt = "";
                    string CurCrypt = "";
                    while (CurCrypt != "String could not be decoded")
                    {
                        OldCrypt = CurCrypt;
                        CurCrypt = Decode(CurCrypt);
                    }
                    return OldCrypt;
                }
                public string Encode(string StringToEncode)
                {
                    try
                    {
                        return Convert.ToBase64String(new System.Text.ASCIIEncoding().GetBytes(StringToEncode));
                    }
                    catch (Exception)
                    {
                        return "String could not be encoded!";
                    }
                }
                public string Decode(string StringToDecode)
                {
                    try
                    {
                        return new System.Text.ASCIIEncoding().GetString(Convert.FromBase64String(StringToDecode));
                    }
                    catch (Exception)
                    {
                        return "String could not be decoded!";
                    }
                }
                public string MultiEncode(string StringToEncode, int EncryptionAmmount)
                {
                    string crypted = StringToEncode;
                    int i = 0;
                    while (i != EncryptionAmmount)
                    {
                        crypted = Encode(crypted);
                        i++;
                    }
                    return crypted;
                }
                public string MultiDecode(string StringToDecode, int EncryptionAmmount)
                {
                    string decrypted = StringToDecode;
                    int i = 0;
                    while (i != EncryptionAmmount)
                    {
                        decrypted = Decode(decrypted);
                        i++;
                    }
                    return decrypted;
                }
            }
            public class CesarCodeCryptor
            {
                public string Encode(string StringToEncode, int key)
                {
                    string total = "";
                    int i;
                    for (i = 1; i == StringToEncode.Length; i++)
                    {
                        string tmp = StringToEncode[i].ToString();
                        tmp = Convert.ToChar(Convert.ToInt32(Convert.ToChar(Convert.ToByte(tmp))) + key).ToString();
                        total += tmp;
                    }
                    return total;
                }
                public string Decode(string StringToEncode, int key)
                {
                    string total = "";
                    int i;
                    for (i = 1; i == StringToEncode.Length; i++)
                    {
                        string tmp = StringToEncode[i].ToString();
                        tmp = Convert.ToChar(Convert.ToInt32(Convert.ToChar(Convert.ToByte(tmp))) - key).ToString();
                        total += tmp;
                    }
                    return total;
                }
            }
            public class Hasher
            {
                //public string RSAEncrypt(string Text)
                //{

                //}
                //public string RSADecrypt(string Text)
                //{

                //}
                public string SHA1Hash(string StringToHash)
                {
                    System.Security.Cryptography.SHA1CryptoServiceProvider ShaObj = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                    byte[] ByteString = Encoding.ASCII.GetBytes(StringToHash);
                    ByteString = ShaObj.ComputeHash(ByteString);
                    string FinalString = "";
                    foreach (byte bt in ByteString)
                    {
                        FinalString += bt.ToString("x2");
                    }
                    return FinalString;
                }
                public string SHA256Hash(string StringToHash)
                {
                    System.Security.Cryptography.SHA256CryptoServiceProvider ShaObj = new System.Security.Cryptography.SHA256CryptoServiceProvider();
                    byte[] ByteString = Encoding.ASCII.GetBytes(StringToHash);
                    ByteString = ShaObj.ComputeHash(ByteString);
                    string FinalString = "";
                    foreach (byte bt in ByteString)
                    {
                        FinalString += bt.ToString("x2");
                    }
                    return FinalString;
                }
                public string SHA384Hash(string StringToHash)
                {
                    System.Security.Cryptography.SHA384CryptoServiceProvider ShaObj = new System.Security.Cryptography.SHA384CryptoServiceProvider();
                    byte[] ByteString = Encoding.ASCII.GetBytes(StringToHash);
                    ByteString = ShaObj.ComputeHash(ByteString);
                    string FinalString = "";
                    foreach (byte bt in ByteString)
                    {
                        FinalString += bt.ToString("x2");
                    }
                    return FinalString;
                }
                public string SHA512Hash(string StringToHash)
                {
                    System.Security.Cryptography.SHA512CryptoServiceProvider ShaObj = new System.Security.Cryptography.SHA512CryptoServiceProvider();
                    byte[] ByteString = Encoding.ASCII.GetBytes(StringToHash);
                    ByteString = ShaObj.ComputeHash(ByteString);
                    string FinalString = "";
                    foreach (byte bt in ByteString)
                    {
                        FinalString += bt.ToString("x2");
                    }
                    return FinalString;
                }
                public string MD5Hash(string StringToHash)
                {
                    System.Security.Cryptography.MD5CryptoServiceProvider HashObj = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    byte[] ByteString = Encoding.ASCII.GetBytes(StringToHash);
                    ByteString = HashObj.ComputeHash(ByteString);
                    string FinalString = "";
                    foreach (byte bt in ByteString)
                    {
                        FinalString += bt.ToString("x2");
                    }
                    return FinalString;
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
                    string posText = HexadecimalToText(r.ReadByte().ToString("X2"));
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
                    string posText = HexadecimalToText(r.ReadByte().ToString("X2"));
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

    namespace UI
    {
        namespace Keyboard
        {
            public sealed class KeyboardHook : IDisposable
            {
                // Registers a hot key with Windows.
                [DllImport("user32.dll")]
                private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
                // Unregisters the hot key with Windows.
                [DllImport("user32.dll")]
                private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

                /// <summary>
                /// Represents the window that is used internally to get the messages.
                /// </summary>
                private class Window : NativeWindow, IDisposable
                {
                    private static int WM_HOTKEY = 0x0312;

                    public Window()
                    {
                        // create the handle for the window.
                        this.CreateHandle(new CreateParams());
                    }

                    /// <summary>
                    /// Overridden to get the notifications.
                    /// </summary>
                    /// <param name="m"></param>
                    protected override void WndProc(ref Message m)
                    {
                        base.WndProc(ref m);

                        // check if we got a hot key pressed.
                        if (m.Msg == WM_HOTKEY)
                        {
                            // get the keys.
                            Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                            ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 0xFFFF);

                            // invoke the event to notify the parent.
                            if (KeyPressed != null)
                                KeyPressed(this, new KeyPressedEventArgs(modifier, key));
                        }
                    }

                    public event EventHandler<KeyPressedEventArgs> KeyPressed;

                    #region IDisposable Members

                    public void Dispose()
                    {
                        this.DestroyHandle();
                    }

                    #endregion
                }

                private Window _window = new Window();
                private int _currentId;

                public KeyboardHook()
                {
                    // register the event of the inner native window.
                    _window.KeyPressed += delegate (object sender, KeyPressedEventArgs args)
                    {
                        if (KeyPressed != null)
                            KeyPressed(this, args);
                    };
                }

                /// <summary>
                /// Registers a hot key in the system.
                /// </summary>
                /// <param name="modifier">The modifiers that are associated with the hot key.</param>
                /// <param name="key">The key itself that is associated with the hot key.</param>
                public void RegisterHotKey(ModifierKeys modifier, Keys key)
                {
                    // increment the counter.
                    _currentId = _currentId + 1;

                    // register the hot key.
                    if (!RegisterHotKey(_window.Handle, _currentId, (uint)modifier, (uint)key))
                        throw new InvalidOperationException("Couldn’t register the hot key.");
                }

                /// <summary>
                /// A hot key has been pressed.
                /// </summary>
                public event EventHandler<KeyPressedEventArgs> KeyPressed;

                #region IDisposable Members

                public void Dispose()
                {
                    // unregister all the registered hot keys.
                    for (int i = _currentId; i > 0; i--)
                    {
                        UnregisterHotKey(_window.Handle, i);
                    }

                    // dispose the inner native window.
                    _window.Dispose();
                }

                #endregion
            }

            /// <summary>
            /// Event Args for the event that is fired after the hot key has been pressed.
            /// </summary>
            public class KeyPressedEventArgs : EventArgs
            {
                private ModifierKeys _modifier;
                private Keys _key;

                internal KeyPressedEventArgs(ModifierKeys modifier, Keys key)
                {
                    _modifier = modifier;
                    _key = key;
                }

                public ModifierKeys Modifier
                {
                    get { return _modifier; }
                }

                public Keys Key
                {
                    get { return _key; }
                }
            }

            /// <summary>
            /// The enumeration of possible modifiers.
            /// </summary>
            [Flags]
            public enum ModifierKeys : uint
            {
                Alt = 1,
                Control = 2,
                Shift = 4,
                Win = 8
            }
        }
        namespace Events
        {
            public class TreeViewEvents
            {
                public TreeViewEvents(TreeView treeview)
                {
                    treeview.MouseMove += this.Treeview_MouseMove;
                    treeview.MouseLeave += Treeview_MouseLeave;
                    Tree = treeview;
                }

                private void Treeview_MouseLeave(object sender, EventArgs e)
                {
                    if (_lastNode != null)
                        NodeMouseLeave?.Invoke(Tree, new TreeNodeMouseHoverEventArgs(_lastNode));
                }

                public TreeView Tree { get; private set; }
                public event TreeNodeMouseHoverEventHandler NodeMouseEnter;
                public event TreeNodeMouseHoverEventHandler NodeMouseMove;
                public event TreeNodeMouseHoverEventHandler NodeMouseLeave;
                private TreeNode _lastNode = null;
                private void Treeview_MouseMove(object sender, MouseEventArgs e)
                {
                    var node = Tree.GetNodeAt(e.Location);
                    if (node != null)
                    {
                        if (_lastNode != null && _lastNode != node) NodeMouseLeave?.Invoke(Tree, new TreeNodeMouseHoverEventArgs(_lastNode));
                        if (_lastNode != node) NodeMouseEnter?.Invoke(Tree, new TreeNodeMouseHoverEventArgs(node));
                        _lastNode = node;
                        NodeMouseMove?.Invoke(Tree, new TreeNodeMouseHoverEventArgs(node));
                    }
                    else
                        if (_lastNode != null)
                        NodeMouseLeave?.Invoke(Tree, new TreeNodeMouseHoverEventArgs(_lastNode)); _lastNode = node;
                }
            }
        }
        public class AtatchImage : PictureBox
        {
            public static AtatchImage Atatch(Image image, Control control) => new AtatchImage(image, control);
            public static AtatchImage Atatch(string imagePath, Control control) => new AtatchImage(imagePath, control);
            public static AtatchImage Atatch(Image image, Control control, Size size) => new AtatchImage(image, control) { Size = size };
            public static AtatchImage Atatch(string imagePath, Control control, Size size) => new AtatchImage(imagePath, control) { Size = size };
            public AtatchImage() => Visible = false;
            public AtatchImage(Image image)
            {
                Image = image;
                Visible = false;
                SizeMode = PictureBoxSizeMode.Zoom;
            }
            public AtatchImage(string imagePath)
            {
                Image = Image.FromFile(imagePath);
                Visible = false;
                SizeMode = PictureBoxSizeMode.Zoom;
            }
            public AtatchImage(Control control)
            {
                AtatchTo(control);
                Visible = false;
                SizeMode = PictureBoxSizeMode.Zoom;
            }
            public AtatchImage(Image image, Control control)
            {
                Image = image;
                AtatchTo(control);
                Visible = false;
                SizeMode = PictureBoxSizeMode.Zoom;
            }
            public AtatchImage(string imagePath, Control control)
            {
                Image = Image.FromFile(imagePath);
                AtatchTo(control);
                Visible = false;
                SizeMode = PictureBoxSizeMode.Zoom;
            }
            public Point Offset { get; set; } = new Point(0, 0);
            public Control AtatchedControl { get; private set; }
            protected virtual void OnAtatchedControlChanged(AtatchImageEventArgs e)
            {
                AtatchedControlChanged?.Invoke(this, e);
            }
            public event EventHandler<AtatchImageEventArgs> AtatchedControlChanged;
            public event EventHandler Shown;
            public event EventHandler Hiden;
            public virtual void AtatchTo(Control control)
            {
                var e = new AtatchImageEventArgs(AtatchedControl, control);
                Parent = control.TopLevelControl;
                try
                {
                    e.OldControl.MouseEnter -= Control_MouseEnter;
                    e.OldControl.MouseLeave -= Control_MouseLeave;
                    e.OldControl.MouseMove -= Control_MouseMove;
                }
                catch { }
                AtatchedControl = control;
                e.Control.MouseEnter += Control_MouseEnter;
                e.Control.MouseLeave += Control_MouseLeave;
                e.Control.MouseMove += Control_MouseMove;
                OnAtatchedControlChanged(e);
                BringToFront();
                BringToFront();
                BringToFront();
            }
            public void AdjustPosition() => Control_MouseMove(null, null);
            private void Control_MouseMove(object sender, MouseEventArgs e) => Location = new Point(AtatchedControl.Location.X + e.X + 7 + Offset.X, AtatchedControl.Location.Y + e.Y + 7 + Offset.Y);
            private void Control_MouseLeave(object sender, EventArgs e) { Visible = false; Hiden?.Invoke(this, EventArgs.Empty); }
            private void Control_MouseEnter(object sender, EventArgs e) { Visible = true; Shown?.Invoke(this, EventArgs.Empty); }
        }
        public class AtatchImageEventArgs : EventArgs
        {
            public AtatchImageEventArgs(Control oldControl, Control newControl)
            {
                OldControl = oldControl;
                Control = newControl;
            }

            public Control OldControl { get; }
            public Control Control { get; }
        }
        public class ControlGridBox<TControl> : Panel where TControl : Control
        {
            public ControlGridBox() { AutoScroll = true; BackColor = SystemColors.AppWorkspace; SizeChanged += ControlGridBox_SizeChanged; }
            private List<TControl> _items = new List<TControl>();
            [Browsable(false)]
            public TControl[] Items { get => _items.ToArray(); }
            protected virtual void OnItemSizeChanged()
            {
                if (AutoFitColumns)
                    AutoCalculateCols();
                UpdateItems();
            }

            private void ControlGridBox_SizeChanged(object sender, EventArgs e)
            {
                if (AutoFitColumns)
                    AutoCalculateCols();
            }
            private void AutoCalculateCols()
            {
                int cols = 1;
                if (ItemSize.Width == 0)
                    return;
                while (true)
                    if ((cols + 1) * ItemSize.Width + ((cols + 2) * ItemSpacing.X) < Size.Width)
                        cols++;
                    else
                        break;
                Columns = cols;
            }
            public virtual void AddItemRange(params TControl[] items) { foreach (var item in items) AddItem(item); }
            public virtual void AddItem(TControl item)
            {
                if (ItemSize.Width == 0 && ItemSize.Height == 0)
                    ItemSize = item.Size;
                if (VerticalScroll.Visible)
                    VerticalScroll.Value = 0;
                Controls.Add(item);
                _items.Add(item);
                if (AutoFitColumns)
                    AutoCalculateCols();
                UpdateItems();
            }
            protected virtual void OnColumnsChanged()
            {
                UpdateItems();
            }
            private int _cols = 3;
            private bool _afc = false;
            public bool AutoFitColumns { get => _afc; set { _afc = value; AutoCalculateCols(); } }
            public int Columns { get => _cols; set { if (value > 0) _cols = value; else _cols = 1; OnColumnsChanged(); } }
            private Point _itemSpacing = new Point(1, 1);
            public Point ItemSpacing
            {
                get => _itemSpacing;
                set
                {
                    _itemSpacing = value;
                    if (AutoFitColumns)
                        AutoCalculateCols();
                    UpdateItems();
                }
            }
            public virtual Size ItemSize { get => _itemSize; set { _itemSize = value; UpdateItems(); OnItemSizeChanged(); } }
            private Size _itemSize = new Size(0, 0);
            public virtual void RemoveItem(TControl item)
            {
                Controls.Remove(item);
                _items.Remove(item);
                if (AutoFitColumns)
                    AutoCalculateCols();
                UpdateItems();
            }
            public virtual void UpdateItems()
            {
                var cc = 0;
                var cr = 0;
                for (int i = 0; i < _items.Count; i++)
                {
                    var item = _items[i];
                    item.Size = ItemSize;
                    if (i == 0)
                    {
                        item.Location = new Point(ItemSpacing.X, ItemSpacing.Y);
                        if (cc + 1 == Columns)
                        {
                            cr++;
                            cc = 0;
                        }
                        else
                            cc++;
                    }
                    else
                    {
                        item.Location = new Point(ItemSize.Width * cc + ItemSpacing.X * (cc + 1), ItemSize.Height * cr + ItemSpacing.Y * (cr + 1));
                        if (cc + 1 == Columns)
                        {
                            cr++;
                            cc = 0;
                        }
                        else
                            cc++;
                    }
                }
            }
        }
        public class ControlGridBox : Panel
        {
            public ControlGridBox() { AutoScroll = true; BackColor = SystemColors.AppWorkspace; SizeChanged += ControlGridBox_SizeChanged; }
            private List<Control> _items = new List<Control>();
            [Browsable(false)]
            public Control[] Items { get => _items.ToArray(); }
            protected virtual void OnItemSizeChanged()
            {
                if (AutoFitColumns)
                    AutoCalculateCols();
                UpdateItems();
            }

            private void ControlGridBox_SizeChanged(object sender, EventArgs e)
            {
                if (AutoFitColumns)
                    AutoCalculateCols();
            }
            private void AutoCalculateCols()
            {
                int cols = 1;
                if (ItemSize.Width == 0)
                    return;
                while (true)
                    if ((cols + 1) * ItemSize.Width + ((cols + 2) * ItemSpacing.X) < Size.Width)
                        cols++;
                    else
                        break;
                Columns = cols;
            }
            public virtual void AddItemRange(params Control[] items) { foreach (var item in items) AddItem(item); }
            public virtual void AddItem(Control item)
            {
                if (ItemSize.Width == 0 && ItemSize.Height == 0)
                    ItemSize = item.Size;
                if (VerticalScroll.Visible)
                    VerticalScroll.Value = 0;
                Controls.Add(item);
                _items.Add(item);
                if (AutoFitColumns)
                    AutoCalculateCols();
                UpdateItems();
            }
            protected virtual void OnColumnsChanged()
            {
                UpdateItems();
            }
            private int _cols = 3;
            private bool _afc = false;
            public bool AutoFitColumns { get => _afc; set { _afc = value; AutoCalculateCols(); } }
            public int Columns { get => _cols; set { if (value > 0) _cols = value; else _cols = 1; OnColumnsChanged(); } }
            private Point _itemSpacing = new Point(1, 1);
            public Point ItemSpacing
            {
                get => _itemSpacing;
                set
                {
                    _itemSpacing = value;
                    if (AutoFitColumns)
                        AutoCalculateCols();
                    UpdateItems();
                }
            }
            public virtual Size ItemSize { get => _itemSize; set { _itemSize = value; UpdateItems(); OnItemSizeChanged(); } }
            private Size _itemSize = new Size(0, 0);
            public virtual void RemoveItem(Control item)
            {
                Controls.Remove(item);
                _items.Remove(item);
                if (AutoFitColumns)
                    AutoCalculateCols();
                UpdateItems();
            }
            public virtual void UpdateItems()
            {
                var cc = 0;
                var cr = 0;
                for (int i = 0; i < _items.Count; i++)
                {
                    var item = _items[i];
                    item.Size = ItemSize;
                    if (i == 0)
                    {
                        item.Location = new Point(ItemSpacing.X, ItemSpacing.Y);
                        if (cc + 1 == Columns)
                        {
                            cr++;
                            cc = 0;
                        }
                        else
                            cc++;
                    }
                    else
                    {
                        item.Location = new Point(ItemSize.Width * cc + ItemSpacing.X * (cc + 1), ItemSize.Height * cr + ItemSpacing.Y * (cr + 1));
                        if (cc + 1 == Columns)
                        {
                            cr++;
                            cc = 0;
                        }
                        else
                            cc++;
                    }
                }
            }
        }
        [DefaultEvent("ItemClick")]
        public class ControlListBox : Panel
        {
            public ControlListBox() { AutoScroll = true; BackColor = Color.White; }
            private List<Control> _items = new List<Control>();
            [Browsable(false)]
            public Control[] Items { get => _items.ToArray(); }
            public event EventHandler SpacingChanged;
            public event EventHandler ItemSizeChanged;
            public event EventHandler SpaceFirstChanged;
            public event EventHandler XoffsetChanged;
            public event EventHandler<ControlListBoxItemArgs> ItemClick;
            public event EventHandler<ControlListBoxItemArgs> ItemAdded;
            public event EventHandler<ControlListBoxItemArgs> ItemRemoved;
            public event EventHandler<ControlListBoxItemArgs> ItemUpdate;
            protected virtual void OnItemClick(Control item) => ItemClick?.Invoke(this, new ControlListBoxItemArgs(item, null));
            protected virtual void OnSpaceFirstChanged() => SpaceFirstChanged?.Invoke(this, EventArgs.Empty);
            protected virtual void OnItemSizeChanged() => ItemSizeChanged?.Invoke(this, EventArgs.Empty);
            protected virtual void OnSpacingChanged() => SpacingChanged?.Invoke(this, EventArgs.Empty);
            protected virtual void OnXoffsetChanged() => XoffsetChanged?.Invoke(this, EventArgs.Empty);
            protected virtual void OnItemClickHandler(object sender, EventArgs e) => OnItemClick((Control)sender);
            protected virtual void OnItemAdded(Control item)
            {
                UpdateItems();
                foreach (var _item in _items)
                { _item.Click -= OnItemClickHandler; _item.Click += OnItemClickHandler; }
                ItemAdded?.Invoke(this, new ControlListBoxItemArgs(item, null));
            }
            protected virtual void OnItemRemoved(Control item)
            {
                UpdateItems();
                foreach (var _item in _items)
                { _item.Click -= OnItemClickHandler; _item.Click += OnItemClickHandler; }
                ItemRemoved?.Invoke(this, new ControlListBoxItemArgs(item, null));
            }
            public virtual void UpdateItem(ControlListBoxItemArgs e)
            {
                ItemUpdate?.Invoke(this, e);
                if (e.LastItem == null)
                    if (SpaceFirstItem)
                        e.Item.Location = new Point(Xoffset, Spacing);
                    else
                        e.Item.Location = new Point(Xoffset, 0);
                else
                    e.Item.Location = new Point(Xoffset, e.LastItem.Location.Y + Spacing + e.Item.Size.Height);
            }
            public virtual void AddItemRange(params Control[] items) { foreach (var item in items) AddItem(item); }
            public virtual void AddItem(Control item)
            {
                Controls.Add(item);
                _items.Add(item);
                if (VerticalScroll.Visible)
                    VerticalScroll.Value = 0;
                OnItemAdded(item);
            }
            public virtual void InsertItem(Control item, int index)
            {
                _items.Insert(index, item);
                Controls.Add(item);
                if (VerticalScroll.Visible)
                    VerticalScroll.Value = 0;
                OnItemAdded(item);
            }
            public virtual void RemoveItem(Control item)
            {
                Controls.Remove(item);
                _items.Remove(item);
                if (VerticalScroll.Visible)
                    VerticalScroll.Value = 0;
                OnItemRemoved(item);
            }
            public virtual void RemoveItem(int index)
            {
                var item = _items[index];
                Controls.Remove(item);
                _items.RemoveAt(index);
                if (VerticalScroll.Visible)
                    VerticalScroll.Value = 0;
                OnItemRemoved(item);
            }
            private Size _itemSize = new Size(0, 0);
            private bool _spaceFirstItem = false;
            private int _spacing = 1;
            private int _xoffset = 0;
            public virtual Size ItemSize { get => _itemSize; set { _itemSize = value; UpdateItems(); OnItemSizeChanged(); } }
            public virtual bool SpaceFirstItem { get => _spaceFirstItem; set { _spaceFirstItem = value; UpdateItems(); OnSpaceFirstChanged(); } }
            public int Spacing { get => _spacing; set { _spacing = value; UpdateItems(); OnSpacingChanged(); } }
            public int Xoffset { get => _xoffset; set { _xoffset = value; UpdateItems(); OnXoffsetChanged(); } }
            public void AlignItems(HorizontalAlignment alignment)
            {
                switch (alignment)
                {
                    case HorizontalAlignment.Left: foreach (var item in Items) item.Location = new Point(0, item.Location.Y); break;
                    case HorizontalAlignment.Right: foreach (var item in Items) if (item.Size.Width > Width) item.Location = new Point(0, item.Location.Y); else item.Location = new Point(Size.Width - item.Size.Width, item.Location.Y); break;
                    case HorizontalAlignment.Center: foreach (var item in Items) if (item.Size.Width > Width) item.Location = new Point(0, item.Location.Y); else item.Location = new Point(Size.Width / 2 - item.Size.Width / 2, item.Location.Y); break;
                }
            }
            public void AlignItem(Control item, HorizontalAlignment alignment)
            {
                switch (alignment)
                {
                    case HorizontalAlignment.Left: item.Location = new Point(0, item.Location.Y); break;
                    case HorizontalAlignment.Right: if (item.Size.Width > Width) item.Location = new Point(0, item.Location.Y); else item.Location = new Point(Size.Width - item.Size.Width, item.Location.Y); break;
                    case HorizontalAlignment.Center: if (item.Size.Width > Width) item.Location = new Point(0, item.Location.Y); else item.Location = new Point(Size.Width / 2 - item.Size.Width / 2, item.Location.Y); break;
                }
            }
            public virtual void UpdateItems()
            {
                for (int i = 0; i < _items.Count; i++)
                {

                    if (i == 0)
                    {
                        var e = new ControlListBoxItemArgs(_items[i], null);
                        if (ItemSize.Width != 0 && ItemSize.Height != 0)
                        { e.Item.Size = ItemSize; }
                        else if (ItemSize.Width != 0)
                        { e.Item.Size = new Size(ItemSize.Width, e.Item.Size.Height); }
                        else if (ItemSize.Height != 0)
                            e.Item.Size = new Size(e.Item.Size.Width, ItemSize.Height);
                        UpdateItem(e);
                    }
                    else
                    {
                        var e = new ControlListBoxItemArgs(_items[i], _items[i - 1]);
                        if (ItemSize.Width != 0 && ItemSize.Height != 0)
                            e.Item.Size = ItemSize;
                        else if (ItemSize.Width != 0)
                            e.Item.Size = new Size(ItemSize.Width, e.Item.Size.Height);
                        else if (ItemSize.Height != 0)
                            e.Item.Size = new Size(e.Item.Size.Width, ItemSize.Height);
                        UpdateItem(e);
                    }
                }
            }
        }
        public class ControlListBoxItemArgs : EventArgs { public ControlListBoxItemArgs() { } public ControlListBoxItemArgs(Control item, Control lastItem) { Item = item; LastItem = lastItem; } public Control Item { get; } public Control LastItem { get; } }
        public class DownloaderProgressBar : ProgressBar
        {
            public DownloaderProgressBar() { }
            public bool AutoUpdateProgressBar { get; set; } = true;
            public event AsyncCompletedEventHandler DownloadFinished;
            public event System.Net.DownloadProgressChangedEventHandler DownloadProgressChanged;
            public void DownloadFileAsync(string URL, string Destination)
            {
                System.Net.WebClient net = new System.Net.WebClient();
                net.DownloadFileCompleted += Done;
                net.DownloadProgressChanged += ProgressChanged;
                net.DownloadFileAsync(new Uri(URL), Destination);
            }
            private void ProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
            {
                if (AutoUpdateProgressBar)
                {
                    this.Maximum = (int)e.TotalBytesToReceive / 100;
                    this.Value = (int)e.BytesReceived / 100;
                }
                DownloadProgressChanged?.Invoke(this, e);
            }
            private void Done(object sender, AsyncCompletedEventArgs e)
            {
                DownloadFinished?.Invoke(this, e);
            }
        }
        public class FilteredTextBox : TextBox
        {
            public FilteredTextBox()
            {
                this.KeyPress += HandleChars;
            }
            void LoadList(object sender, EventArgs e)
            {
                if (CharList.Length > 0)
                {
                    AcceptedChars = CharList.ToCharArray().ToList() as List<char>;
                }
            }
            public bool AcceptBackspace { get; set; } = true;
            public List<char> AcceptedChars { get; set; } = new List<char>();
            private string charListHolder = "";
            public string CharList
            {
                get
                {
                    return charListHolder;
                }
                set
                {
                    charListHolder = value;
                    LoadList(this, EventArgs.Empty);
                }
            }
            public bool IgnoreCases { get; set; } = false;
            void HandleChars(object sender, KeyPressEventArgs e)
            {
                char kchar = e.KeyChar;
                bool IsInList = false;
                if (AcceptBackspace)
                {
                    if (kchar == 8)
                    {
                        IsInList = true;
                    }
                }
                if (!IsInList)
                {
                    if (IgnoreCases)
                    {
                        for (int i = 0; i < AcceptedChars.Count; i++)
                        {
                            char currentInList = AcceptedChars[i].ToString().ToLower().ToCharArray()[0];
                            if (currentInList == kchar.ToString().ToLower().ToCharArray()[0])
                            {
                                IsInList = true;
                                i = AcceptedChars.Count + 2;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < AcceptedChars.Count; i++)
                        {
                            char currentInList = AcceptedChars[i];
                            if (currentInList == kchar)
                            {
                                IsInList = true;
                                i = AcceptedChars.Count + 2;
                            }
                        }
                    }
                }
                e.Handled = !IsInList;
            }
        }
        namespace Components
        {
            public class ArduinoController : Component
            {
                public event SerialDataReceivedEventHandler DataRecieved;
                public SerialPort Port { get; set; }
                public ArduinoController(int BaudRate)
                {
                    Port = new SerialPort()
                    {
                        DtrEnable = true,
                        DiscardNull = true,
                        BaudRate = BaudRate,
                    };
                    Port.DataReceived += OnDataRecieved;
                }
                public ArduinoController()
                {
                    Port = new SerialPort()
                    {
                        DtrEnable = true,
                        DiscardNull = true,
                        BaudRate = 9600,
                    };
                    Port.DataReceived += OnDataRecieved;
                }
                public void SendData(string data)
                {
                    if (Port.IsOpen)
                    {
                        Port.Write(data);
                    }
                }
                public string ReadExisting()
                {
                    return Port.ReadExisting();
                }
                public void Write(string text)
                {
                    Port.Write(text);
                }
                public void Write(byte[] buffer, int offset, int count)
                {
                    Port.Write(buffer, offset, count);
                }
                public void Write(char[] buffer, int offset, int count)
                {
                    Port.Write(buffer, offset, count);
                }
                public void Connect()
                {
                    if (!Port.IsOpen)
                    {
                        Port.Open();
                    }
                }
                public void Connect(string PortName)
                {
                    if (!Port.IsOpen)
                    {
                        Port.PortName = PortName;
                        Port.Open();
                    }
                }
                public void Connect(string PortName, int BaudRate)
                {
                    if (!Port.IsOpen)
                    {
                        this.PortName = PortName;
                        this.BaudRate = BaudRate;
                        Port.Open();
                    }
                }
                public void Connect(int BaudRate)
                {
                    if (!Port.IsOpen)
                    {
                        Port.BaudRate = BaudRate;
                        Port.Open();
                    }
                }
                private void OnDataRecieved(object sender, SerialDataReceivedEventArgs e)
                {
                    DataRecieved?.Invoke(this, e);
                }
                public override string ToString()
                {
                    var str = "ArduinoControler { Port=" + Port.ToString() + ", PortName=]" + PortName + " }";
                    return str;
                }
                public void Disconnect()
                {
                    if (Port.IsOpen)
                    {
                        Port.Close();
                    }
                }
                public string PortName { get => Port.PortName; set => Port.PortName = value; }
                public int BaudRate { get => Port.BaudRate; set => Port.BaudRate = value; }
            }
        }
        [DefaultEvent("DirectoryChanged")]
        public class FileExplorer : WebBrowser
        {
            public event EventHandler DirectoryChanged;
            public FileExplorer(string DirectoryPath)
            {
                this.Directory = DirectoryPath;
                Setup();
            }
            public FileExplorer()
            {
                this.Directory = Environment.GetLogicalDrives()[0];
                Setup();
            }
            void Setup()
            {
                this.ScriptErrorsSuppressed = true;
            }
            private string _dir = "";
            public string Directory
            {
                get
                {
                    return _dir;
                }
                set
                {
                    if (System.IO.Directory.Exists(value))
                    {
                        _dir = value;
                        try
                        {
                            this.Url = new Uri("file://" + value);
                        }
                        catch
                        {
                            try
                            {
                                this.Url = new Uri("file//" + value + "\\");
                            }
                            catch
                            {

                            }
                        }
                        DirectoryChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
        }
        namespace Grids
        {
            [DefaultEvent("ItemClicked")]
            public class FileListGrid : UserControl
            {
                private readonly IContainer components = null;
                protected override void Dispose(bool disposing)
                {
                    if (disposing && (components != null))
                    {
                        components.Dispose();
                    }
                    base.Dispose(disposing);
                }
                #region Código gerado pelo Designer de Componentes
                private void InitializeComponent()
                {
                    this.SuspendLayout();
                    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.BackColor = System.Drawing.Color.Gainsboro;
                    this.Name = "FileListGrid";
                    this.Size = new System.Drawing.Size(431, 239);
                    this.SizeChanged += new System.EventHandler(this.FileListGrid_SizeChanged);
                    this.ResumeLayout(false);
                }
                #endregion
                public FileListGrid()
                {
                    InitializeComponent();
                    AutoScroll = true;
                    ItemsNormalColor = Color.LightGray;
                    ItemsHoverColor = Color.Silver;
                }
                public delegate void FileListGridEventHandler(object sender, FileListGridItem item);
                public delegate void FileListGridMouseEventHandler(object sender, FileListGridItem item, MouseEventArgs e);
                public event FileListGridEventHandler ItemClicked;
                public event FileListGridMouseEventHandler ItemMouseDoubleClick;
                public event FileListGridEventHandler ItemAdded;
                public event FileListGridEventHandler ItemRemoved;
                public void LoadXML(string path)
                {
                    ClearItems();
                    _ = new List<FileItem>();
                    System.IO.TextReader tr = new System.IO.StreamReader(path);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<FileItem>));
                    List<FileItem> savedItemsAsXML;
                    try { savedItemsAsXML = serializer.Deserialize(tr) as List<FileItem>; } catch (InvalidOperationException ex) { tr.Close(); throw ex; }
                    foreach (FileItem savedItem in savedItemsAsXML)
                    {
                        AddItem(savedItem.ToFileListGridItem());
                    }
                    tr.Close();
                }
                public void SaveToXML(string path)
                {
                    List<FileItem> saveItems = new List<FileItem>();
                    foreach (FileListGridItem item in Items)
                    {
                        saveItems.Add(item.ToXmlInfo());
                    }
                    System.IO.TextWriter tw = new System.IO.StreamWriter(path);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<FileItem>));
                    try { serializer.Serialize(tw, saveItems); }
                    catch (InvalidOperationException ex)
                    {
                        tw.Close();
                        throw ex;
                    }
                    tw.Close();
                }
                protected virtual void OnItemAdded(FileListGridItem item)
                {
                    ItemAdded?.Invoke(this, item);
                }
                protected virtual void OnItemRemoved(FileListGridItem item)
                {
                    ItemRemoved?.Invoke(this, item);
                }
                protected virtual void OnItemClicked(FileListGridItem item)
                {
                    ItemClicked?.Invoke(this, item);
                }
                protected virtual void OnItemMouseDoubleClick(FileListGridItem item, MouseEventArgs e)
                {
                    ItemMouseDoubleClick?.Invoke(this, item, e);
                }
                private void OnAnyItemMouseDoubleClick(object sender, MouseEventArgs e)
                {
                    OnItemMouseDoubleClick((FileListGridItem)sender, e);
                }

                private void OnAnyItemClicked(object sender, EventArgs e)
                {
                    OnItemClicked((FileListGridItem)sender);
                }
                private Color _ItemsHoverColor = Color.Transparent;
                private Color _ItemsNormalColor = Color.Transparent;
                public Color ItemsHoverColor { get => _ItemsHoverColor; set { _ItemsHoverColor = value; UpdateItems(); } }
                public Color ItemsNormalColor { get => _ItemsNormalColor; set { _ItemsNormalColor = value; UpdateItems(); } }
                public int ItemSpacing { get; set; } = 0;
                public List<FileListGridItem> Items = new List<FileListGridItem>();
                public void ClearItems()
                {
                    Items.Clear();
                    Controls.Clear();
                    UpdateItems();
                    Update();
                }
                public void AddItem(FileListGridItem item)
                {
                    item.Size = new Size(Width - 18, 25);
                    Update();
                    Items.Add(item);
                    Controls.Add(item);
                    Update();
                    UpdateItems();
                    OnItemAdded(item);
                }
                public void AddEmptyItem()
                {
                    var item = new FileListGridItem()
                    {

                    };
                    item.File = FileListGridItem.EmptyFile;
                    AddItem(item);
                }
                public void AddItem(string File)
                {
                    var item = new FileListGridItem()
                    {
                        File = File,
                    };
                    AddItem(item);
                }
                public int GetItemIndex(FileListGridItem item)
                {
                    try
                    {
                        for (int i = 0; i < Items.Count; i++)
                        {
                            if (item.Equals(Items[i]))
                            {
                                return i;
                            }
                        }
                    }
                    catch { return -1; }
                    return -1;
                }
                public void RemoveItem(int itemIndex)
                {
                    var item = Items[itemIndex];
                    RemoveItem(item);
                }
                public void RemoveItem(FileListGridItem item)
                {
                    this.Controls.Remove(item);
                    this.Items.Remove(item);
                    UpdateItems();
                    OnItemRemoved(item);
                }
                public void UpdateItems()
                {
                    try
                    {
                        ScrollControlIntoView(Items[0]);
                        for (int i = 0; i < Items.Count; i++)
                        {
                            Items[i].NormalColor = ItemsNormalColor;
                            Items[i].HoverColor = ItemsHoverColor;
                            Update();
                            if (i != 0)
                            {
                                Items[i].Location = new Point(0, Items[i - 1].Location.Y + Items[i - 1].Size.Height + ItemSpacing);
                            }
                            else
                            {
                                Items[i].Location = new Point(0, 0);
                            }
                            if (!VScroll) { Items[i].Size = new Size(Width, Items[i].Size.Height); }
                            else
                            {
                                foreach (FileListGridItem item in Items)
                                {
                                    item.Size = new Size(Width - 18, item.Size.Height);
                                }
                            }
                        }
                    }
                    catch { }
                    UpdateEvents();
                    Update();
                }
                private void UpdateEvents()
                {
                    try
                    {
                        for (int i = 0; i < Items.Count; i++)
                        {
                            Items[i].GeneralClick -= OnAnyItemClicked;
                            Items[i].GeneralMouseDoubleClick -= OnAnyItemMouseDoubleClick;

                            Items[i].GeneralClick += OnAnyItemClicked;
                            Items[i].GeneralMouseDoubleClick += OnAnyItemMouseDoubleClick;
                        }
                    }
                    catch { }
                }

                private void FileListGrid_SizeChanged(object sender, EventArgs e)
                {
                    if (Items.Count != 0) { UpdateItems(); }
                }
            }
            public class FileListGridItem : UserControl
            {
                private readonly IContainer components = null;
                protected override void Dispose(bool disposing)
                {
                    if (disposing && (components != null))
                    {
                        components.Dispose();
                    }
                    base.Dispose(disposing);
                }
                #region Código gerado pelo Designer de Componentes
                private void InitializeComponent()
                {
                    this.label1 = new Label();
                    this.pictureBox1 = new PictureBox();
                    ((ISupportInitialize)(this.pictureBox1)).BeginInit();
                    this.SuspendLayout();
                    // 
                    // label1
                    // 
                    this.label1.AutoSize = true;
                    this.label1.Location = new System.Drawing.Point(37, 9);
                    this.label1.Name = "label1";
                    this.label1.Size = new System.Drawing.Size(77, 15);
                    this.label1.TabIndex = 0;
                    this.label1.Text = "{FilePath}";
                    // 
                    // pictureBox1
                    // 
                    this.pictureBox1.Location = new System.Drawing.Point(6, 6);
                    this.pictureBox1.Name = "pictureBox1";
                    this.pictureBox1.Size = new System.Drawing.Size(26, 21);
                    this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    this.pictureBox1.TabIndex = 1;
                    this.pictureBox1.TabStop = false;
                    // 
                    // FileListGridItem
                    // 
                    this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
                    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                    this.Controls.Add(this.pictureBox1);
                    this.Controls.Add(this.label1);
                    this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.Name = "FileListGridItem";
                    this.Size = new System.Drawing.Size(456, 33);
                    this.FontChanged += new System.EventHandler(this.FileListGridItem_FontChanged);
                    this.SizeChanged += new System.EventHandler(this.FileListGridItem_SizeChanged);
                    ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                    this.ResumeLayout(false);
                    this.PerformLayout();

                }

                #endregion

                private System.Windows.Forms.Label label1;
                private System.Windows.Forms.PictureBox pictureBox1;
                public FileListGridItem()
                {
                    InitializeComponent();
                    foreach (Control control in Controls)
                    {
                        control.Click += OnGeneralClick;
                        control.MouseDoubleClick += OnGeneralMouseDoubleClick;
                        control.MouseEnter += MHover;
                        control.MouseLeave += MLeave;
                    }
                    this.Click += OnGeneralClick;
                    this.MouseDoubleClick += OnGeneralMouseDoubleClick;
                    this.MouseEnter += MHover;
                    this.MouseLeave += MLeave;
                }
                public static string EmptyFile = "file.null";
                public event EventHandler GeneralClick;
                public event MouseEventHandler GeneralMouseDoubleClick;
                protected virtual void OnGeneralClick(object sender, EventArgs e)
                {
                    GeneralClick?.Invoke(this, EventArgs.Empty);
                }
                protected virtual void OnGeneralMouseDoubleClick(object sender, MouseEventArgs e)
                {
                    GeneralMouseDoubleClick?.Invoke(this, e);
                }
                public bool PathTextIsBiggerThanItem { get; private set; }
                private void FileListGridItem_SizeChanged(object sender, EventArgs e)
                {
                    PathTextIsBiggerThanItem = label1.Size.Width >= Size.Width;
                    UpdateLocations();
                }
                private void UpdateLocations()
                {
                    label1.Location = new Point(37, Height / 2 - label1.Size.Height / 2);
                    pictureBox1.Location = new Point(6, Height / 2 - pictureBox1.Size.Height / 2);
                }
                private Bitmap GetFileIcon(string file)
                {
                    return Icon.ExtractAssociatedIcon(file).ToBitmap();
                }
                private string _File = "";
                public string File
                {
                    get
                    {
                        return _File;
                    }
                    set
                    {
                        if (value == "file.null")
                        {
                            _File = value;
                            //pictureBox1.Image = GetFileIcon(value);
                            label1.Text = "";
                        }
                        else
                        {
                            if (System.IO.File.Exists(value))
                            {
                                _File = value;
                                pictureBox1.Image = GetFileIcon(value);
                                label1.Text = value;
                            }
                        }
                    }
                }
                public Image FileIcon { get => pictureBox1.Image; private set => pictureBox1.Image = value; }

                private void FileListGridItem_FontChanged(object sender, EventArgs e)
                {
                    label1.Font = this.Font;
                    UpdateLocations();
                }
                private Color _NormalColor = Color.Transparent;
                public Color NormalColor
                {
                    get => _NormalColor;
                    set
                    {
                        _NormalColor = value;
                        BackColor = value;
                    }
                }
                public Color HoverColor { get; set; }
                public FileItem ToXmlInfo()
                {
                    return new FileItem()
                    {
                        HoverColor = this.HoverColor,
                        NormalColor = this.NormalColor,
                        Path = this.File,
                    };
                }
                private void MHover(object sender, EventArgs e)
                {
                    BackColor = HoverColor;
                }
                private void MLeave(object sender, EventArgs e)
                {
                    BackColor = NormalColor;
                }
            }
            public class FileItem
            {
                public FileListGridItem ToFileListGridItem()
                {
                    return new FileListGridItem()
                    {
                        File = this.Path,
                        HoverColor = this.HoverColor,
                        NormalColor = this.NormalColor,
                    };
                }
                public string Path { get; set; }
                public Color HoverColor { get; set; }
                public Color NormalColor { get; set; }
            }
        }
        public class GradientPanel : Panel
        {
            public GradientPanel()
            {
                Angle = 90F;
            }
            public Color ColorTop { get; set; }
            public Color ColorBottom { get; set; }
            public float Angle { get; set; }
            protected override void OnPaint(PaintEventArgs e)
            {
                System.Drawing.Drawing2D.LinearGradientBrush lgb = new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, Angle);
                System.Drawing.Graphics g = e.Graphics;
                g.FillRectangle(lgb, this.ClientRectangle);
                base.OnPaint(e);
            }
        }
        [DefaultEvent("Click")]
        public class CircularButton : UserControl
        {
            private System.ComponentModel.IContainer components = null;
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #region Código gerado pelo Designer de Componentes
            private void InitializeComponent()
            {
                this.components = new System.ComponentModel.Container();
                this.bunifuElipse1 = new CSharpExtendedCommands.UI.BunifuElipse(this.components);
                this.SuspendLayout();
                // 
                // bunifuElipse1
                // 
                this.bunifuElipse1.ElipseRadius = 500;
                this.bunifuElipse1.TargetControl = this;
                // 
                // CircularButton
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.Name = "CircularButton";
                this.Size = new System.Drawing.Size(150, 125);
                this.ForeColor = Color.White;
                this.ResumeLayout(false);

            }

            #endregion

            private CSharpExtendedCommands.UI.BunifuElipse bunifuElipse1;
            public int CircleRadius
            {
                get { return bunifuElipse1.ElipseRadius; }
                set { bunifuElipse1.ElipseRadius = value; }
            }
            private Color _NormalColor = Color.DodgerBlue;
            private Color _HoverColor = Color.RoyalBlue;
            private Color _ActiveColor = Color.RoyalBlue;
            public Color NormalColor
            {
                get { return _NormalColor; }
                set { _NormalColor = value; BackColor = value; }
            }
            public Color HoverColor
            {
                get { return _HoverColor; }
                set { _HoverColor = value; ActiveColor = value; }
            }
            public Color ActiveColor
            {
                get { return _ActiveColor; }
                set { _ActiveColor = value; }
            }
            private string _ButtonText = "ButtonText";
            public string ButtonText
            {
                get { return _ButtonText; }
                set { _ButtonText = value; OnTextChanged(EventArgs.Empty); }
            }
            public CircularButton()
            {
                InitializeComponent();
                this.NormalColor = Color.DodgerBlue;
            }
            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);
                this.BackColor = HoverColor;
            }
            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
                this.BackColor = NormalColor;
            }
            protected override void OnMouseDown(MouseEventArgs e)
            {
                base.OnMouseDown(e);
                this.BackColor = ActiveColor;
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                TextFormatFlags flgs = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                TextRenderer.DrawText(this.CreateGraphics(), ButtonText, Font, new Point(Width + 3, Height / 2), ForeColor, flgs);
            }
        }
        [DefaultEvent("Click")]
        public class CheckButton : CustomControl
        {
            [Browsable(false)]
            public override bool UseCheckedStates { get; set; }
            public CheckButton()
            {
                UseCheckedStates = true;
                Checked = false;
            }
            public CheckButton(bool Checked)
            {
                UseCheckedStates = true;
                this.Checked = Checked;
            }
            public string ButtonText { get; set; }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter;
                TextRenderer.DrawText(e.Graphics, this.ButtonText, this.Font, new Point(Width + 3, Height / 2), this.ForeColor, flags);
            }
        }
        [System.ComponentModel.DefaultEvent("MouseClick")]
        public class CustomControl : Panel, IContainerControl
        {
            public CustomControl()
            {
                DummyControl = new Control();
                this.HoverColor = GetDarkerColor(this.BackColor);
                this.NormalColor = Color.Transparent;
                this.MouseEnter += This_Hover;
                this.MouseLeave += This_Leave;
                this.ControlAdded += This_ControlAdded;
                this.ControlRemoved += This_ControlRemoved;
                this.ForeColorChanged += This_ForeColorChanged;
            }
            public event EventHandler CheckedChanged;
            protected override void OnClick(EventArgs e)
            {
                Checked = !Checked;
                base.OnClick(e);
            }
            private bool _checked = false;
            public bool Checked
            {
                get
                {
                    return _checked;
                }
                set
                {
                    _checked = value;
                    CheckedChanged?.Invoke(this, EventArgs.Empty);
                    UpdateCheckedState();
                }
            }
            void UpdateCheckedState()
            {
                if (UseCheckedStates)
                {
                    if (Checked)
                    {
                        this.BackColor = CheckedColor;
                    }
                    else
                    {
                        this.BackColor = NormalColor;
                    }
                }
            }
            public virtual bool UseCheckedStates { get; set; } = false;
            public Color CheckedColor { get; set; } = Color.DodgerBlue;
            public Color CheckedHoverColor { get; set; } = Color.RoyalBlue;
            private Color GetDarkerColor(Color color, int ammount = 25)
            {
                int R = color.R;
                int G = color.G;
                int B = color.B;

                if (R - ammount < 0)
                {
                    R = 0;
                }
                else
                {
                    R -= ammount;
                }
                if (G - ammount < 0)
                {
                    G = 0;
                }
                else
                {
                    G -= ammount;
                }
                if (B - ammount < 0)
                {
                    B = 0;
                }
                else
                {
                    B -= ammount;
                }
                return Color.FromArgb(R, G, B);
            }
            void This_Click(object sender, EventArgs e)
            {
                OnClick(e);
            }
            void This_MouseClick(object sender, MouseEventArgs e)
            {
                OnMouseClick(e);
            }
            #region Settings
            private Color _NormalColor = Color.Black;
            private Control DummyControl { get; set; }
            public Color NormalColor { get { return _NormalColor; } set { this._NormalColor = value; this.BackColor = value; } }
            public Color HoverColor { get; set; }
            public Control ActiveControl { get => DummyControl; set => DummyControl = value; }
            #endregion
            #region Update Control
            private void This_ControlAdded(object sender, ControlEventArgs e)
            {
                e.Control.MouseEnter += This_Hover;
                e.Control.MouseLeave += This_Leave;
                e.Control.MouseClick += This_MouseClick;
                e.Control.Click += This_Click;
            }
            private void This_ControlRemoved(object sender, ControlEventArgs e)
            {
                e.Control.MouseEnter -= This_Hover;
                e.Control.MouseLeave -= This_Leave;
                e.Control.MouseClick -= This_MouseClick;
                e.Control.Click -= This_Click;
            }
            private void This_ForeColorChanged(object sender, EventArgs e)
            {
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = this.ForeColor;
                }
            }
            #endregion
            #region Graphics
            private void This_Hover(object sender, EventArgs e)
            {
                if (!UseCheckedStates)
                {
                    this.BackColor = this.HoverColor;
                }
                else
                {
                    if (Checked)
                    {
                        this.BackColor = CheckedHoverColor;
                    }
                    else
                    {
                        this.BackColor = HoverColor;
                    }
                }
            }
            private void This_Leave(object sender, EventArgs e)
            {
                if (!UseCheckedStates)
                {
                    this.BackColor = this.NormalColor;
                }
                else
                {
                    if (Checked)
                    {
                        this.BackColor = CheckedColor;
                    }
                    else
                    {
                        this.BackColor = NormalColor;
                    }
                }
            }
            public bool ActivateControl(Control active)
            {
                try
                {
                    active.Enabled = true;
                    active.Focus();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            #endregion
        }
        public class SmoothButton : Button
        {
            private readonly BunifuElipse elipse = new BunifuElipse();
            public int BorderRadius
            {
                get => elipse.ElipseRadius;
                set => elipse.ElipseRadius = value;
            }
            public new TextFormatFlags TextAlign => TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            #region Settings
            private Color _NormalColor = Color.DodgerBlue;
            public Color NormalColor
            {
                get { return this._NormalColor; }
                set { this._NormalColor = value; }
            }
            private Color _HoverColor = Color.RoyalBlue;
            public Color HoverColor
            {
                get { return _HoverColor; }
                set { _HoverColor = value; _ActiveColor = value; }
            }
            private Color _ActiveColor = Color.RoyalBlue;
            public Color ActiveColor
            {
                get { return _ActiveColor; }
                set { _ActiveColor = value; }
            }
            #endregion
            public SmoothButton()
            {
                elipse.TargetControl = this;
                this.BorderRadius = 5;
                this.ActiveColor = Color.RoyalBlue;
                this.HoverColor = Color.RoyalBlue;
                this.NormalColor = Color.DodgerBlue;
                this.Size = new Size(200, 30);
                BackColor = Color.DodgerBlue;
                ForeColor = Color.White;
            }
            private void InitializeComponent(object sender, EventArgs e)
            {
                string tmp = this.Text;
                this.Text = tmp.Substring(0, 1).ToUpper() + tmp.Substring(1);
            }
            protected override void OnPaint(PaintEventArgs pevent)
            {
                pevent.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, Width, Height);
                TextFormatFlags flags = this.TextAlign;
                TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
            }
            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);
                BackColor = HoverColor;
            }
            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
                BackColor = NormalColor;
            }
            protected override void OnMouseDown(MouseEventArgs mevent)
            {
                base.OnMouseDown(mevent);
                BackColor = ActiveColor;
            }
            protected override void OnMouseUp(MouseEventArgs mevent)
            {
                base.OnMouseUp(mevent);
                BackColor = NormalColor;
            }
        }
        [DefaultEvent("Click")]
        public class FlatButton : Button
        {
            public new TextFormatFlags TextAlign => TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            #region Settings
            private Color _NormalColor = Color.DodgerBlue;
            public Color NormalColor
            {
                get { return this._NormalColor; }
                set { this._NormalColor = value; }
            }
            private Color _HoverColor = Color.RoyalBlue;
            public Color HoverColor
            {
                get { return _HoverColor; }
                set { _HoverColor = value; _ActiveColor = value; }
            }
            private Color _ActiveColor = Color.RoyalBlue;
            public Color ActiveColor
            {
                get { return _ActiveColor; }
                set { _ActiveColor = value; }
            }
            #endregion
            public FlatButton()
            {
                this.ActiveColor = Color.RoyalBlue;
                this.HoverColor = Color.RoyalBlue;
                this.NormalColor = Color.DodgerBlue;
                this.Size = new Size(200, 30);
                BackColor = Color.DodgerBlue;
                ForeColor = Color.White;
            }
            private void InitializeComponent(object sender, EventArgs e)
            {
                string tmp = this.Text;
                this.Text = tmp.Substring(0, 1).ToUpper() + tmp.Substring(1);
            }
            protected override void OnPaint(PaintEventArgs pevent)
            {
                pevent.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, Width, Height);
                TextFormatFlags flags = this.TextAlign;
                TextRenderer.DrawText(pevent.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
            }
            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);
                BackColor = HoverColor;
            }
            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
                BackColor = NormalColor;
            }
            protected override void OnMouseDown(MouseEventArgs mevent)
            {
                base.OnMouseDown(mevent);
                BackColor = ActiveColor;
            }
            protected override void OnMouseUp(MouseEventArgs mevent)
            {
                base.OnMouseUp(mevent);
                BackColor = NormalColor;
            }
        }
        public static class GraphicalInterface
        {
            public static void CenterFormInForm(Form FormToBeCentered, Form FormToCenterIn)
            {
                FormToBeCentered.Location = new Point(0, 0);
                int h2 = FormToCenterIn.Size.Height / 2;
                int LocationX = FormToCenterIn.Location.X + (FormToCenterIn.Size.Width / 2 - FormToBeCentered.Size.Width / 2);
                int LocationY = FormToCenterIn.Location.Y + (h2 - FormToBeCentered.Size.Height / 2);
                FormToBeCentered.Location = new Point(LocationX, LocationY);
            }
        }
        public class DrawingRectangle
        {
            private Control Control { get; set; }
            public bool IsDraw { get; set; } = false;
            public DrawingRectangle(Control control)
            {
                graphics = control.CreateGraphics();
                Control = control;
                control.SizeChanged += UpdateControl;
            }
            private void UpdateControl(object sender, EventArgs e)
            {
                this.Control = (Control)sender;
                graphics = this.Control.CreateGraphics();
            }
            public Point DrawLocation { get; private set; } = new Point(0, 0);
            public Size DrawSize { get; private set; } = new Size(20, 20);
            private Point _Location = new Point(0, 0);
            public Point Location
            {
                get { return this._Location; }
                set
                {
                    this._Location = value;
                    if (IsDraw) { Update(); }
                }
            }
            private Size _Size = new Size(20, 20);
            public Size Size
            {
                get { return this._Size; }
                set
                {
                    this._Size = value;
                    if (IsDraw) { Update(); }
                }
            }
            public Color Color { get; set; } = Color.Black;
            private System.Drawing.Graphics graphics = null;
            public void Update()
            {
                Draw();
            }
            public void Remove()
            {
                IsDraw = false;
                graphics.FillRectangle(new SolidBrush(Control.BackColor), new Rectangle(DrawLocation, DrawSize));
            }
            public void Draw()
            {
                if (IsDraw) { this.Remove(); }
                IsDraw = true;
                var br = new SolidBrush(this.Color);
                graphics.FillRectangle(br, new Rectangle(Location, this.Size));
                DrawLocation = Location;
                DrawSize = Size;
            }
        }
        public class DrawingCircle
        {
            private Control Control { get; set; }
            public bool IsDraw { get; set; } = false;
            public DrawingCircle(Control control)
            {
                graphics = control.CreateGraphics();
                Control = control;
                control.SizeChanged += UpdateControl;
            }
            private void UpdateControl(object sender, EventArgs e)
            {
                this.Control = (Control)sender;
                graphics = this.Control.CreateGraphics();
            }
            public Point DrawLocation { get; private set; } = new Point(0, 0);
            public Size DrawSize { get; private set; } = new Size(20, 20);
            private Point _Location = new Point(0, 0);
            public Point Location
            {
                get { return this._Location; }
                set
                {
                    this._Location = value;
                    if (IsDraw) { Update(); }
                }
            }
            private Size _Size = new Size(20, 20);
            public Size Size
            {
                get { return this._Size; }
                set
                {
                    this._Size = value;
                    if (IsDraw) { Update(); }
                }
            }
            public Color Color { get; set; } = Color.Black;
            private System.Drawing.Graphics graphics = null;
            public void Update()
            {
                Draw();
            }
            public void Remove()
            {
                IsDraw = false;
                graphics.FillEllipse(new SolidBrush(Control.BackColor), new Rectangle(DrawLocation, DrawSize));
            }
            public void Draw()
            {
                if (IsDraw) { this.Remove(); }
                IsDraw = true;
                var br = new SolidBrush(this.Color);
                graphics.FillEllipse(br, new Rectangle(Location, this.Size));
                DrawLocation = Location;
                DrawSize = Size;
            }
        }
        public static class Info
        {
            public static Point GetMouseInFormLocation(Form frm, int Xoffset = 12, int Yoffset = 30)
            {
                return new Point(Control.MousePosition.X - frm.Location.X - Xoffset, Control.MousePosition.Y - frm.Location.Y - Yoffset);
            }
        }
        public class CustomMenu
        {
            public string ControlName { get; set; }
            public int Xoffset { get; set; }
            public int Yoffset { get; set; }
            public Control CustomControl { get; set; }
            public bool InsideInteractionEnabled { get; set; } = true;
            public Control TargetControl { get; set; }
            public CustomMenu(Form frm, Control CustomControl, Control TargetControl = null, int Xoffset = 12, int Yoffset = 30)
            {
                this.ControlName = CustomControl.Name;
                this.CustomControl = CustomControl;
                this.frm = frm;
                this.Xoffset = Xoffset;
                this.Yoffset = Yoffset;
                TargetControl.MouseClick += new MouseEventHandler(this.RightClicked);
                CustomControl.MouseClick += new MouseEventHandler(this.CRightClicked);
            }

            readonly Form frm = null;
            private void CRightClicked(object sender, MouseEventArgs e)
            {
                if (TargetControl == null) { throw new ArgumentNullException("TargetControl", "The target control was null"); }
                if (InsideInteractionEnabled)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        this.Show();
                    }
                    else
                    {
                        this.Hide();
                    }
                }
            }
            private void RightClicked(object sender, MouseEventArgs e)
            {
                if (TargetControl == null) { throw new ArgumentNullException("TargetControl", "The target control was null"); }
                if (e.Button == MouseButtons.Right)
                {
                    this.Show(e.X, e.Y);
                }
                else
                {
                    this.Hide();
                }
            }

            public bool Visible
            {
                get
                {
                    return CustomControl.Visible;
                }
                set
                {
                    CustomControl.Visible = value;
                }
            }
            public void Show(int x, int y)
            {
                CustomControl.Location = new Point(x, y);
                this.Visible = true;
            }
            public void Show()
            {
                CustomControl.Location = new Point(Control.MousePosition.X - frm.Location.X - Xoffset, Control.MousePosition.Y - frm.Location.Y - Yoffset);
                this.Visible = true;
            }
            public void Hide()
            {
                this.Visible = false;
            }
        }
        public static class CustomFont
        {
            public static Font CreateFromFile(string FilePath, float Size, FontStyle Style)
            {
                var pfc = new System.Drawing.Text.PrivateFontCollection();
                pfc.AddFontFile(FilePath);
                return new Font(pfc.Families[0], Size, Style);
            }
            public static Font CreateFromEmbeddedResource(string ResourcePath, float Size, FontStyle Style)
            {
                var pfc = new System.Drawing.Text.PrivateFontCollection();
                System.IO.Stream fontstream = Assembly.GetEntryAssembly().GetManifestResourceStream(ResourcePath);
                IntPtr data = Marshal.AllocCoTaskMem(int.Parse(fontstream.Length.ToString()));
                byte[] fontdata = new byte[int.Parse(fontstream.Length.ToString())];
                fontstream.Read(fontdata, 0, int.Parse(fontstream.Length.ToString()));
                Marshal.Copy(fontdata, 0, data, int.Parse(fontstream.Length.ToString()));
                pfc.AddMemoryFont(data, int.Parse(fontstream.Length.ToString()));
                fontstream.Close();
                Marshal.FreeCoTaskMem(data);
                return new Font(pfc.Families[0], Size, Style);
            }
        }
        public class ControlBorder : Panel
        {
            public event EventHandler TargetControlChanged;
            public event EventHandler HoverColorChanged;
            public event EventHandler NormalColorChanged;
            public event EventHandler BorderSizeChanged;
            protected virtual void OnHoverColorChanged()
            {
                HoverColorChanged?.Invoke(this, EventArgs.Empty);
                Update();
            }
            bool _mouseHover = false;
            protected virtual void OnNormalColorChanged()
            {
                NormalColorChanged?.Invoke(this, EventArgs.Empty);
                Update();
            }
            protected virtual void OnBorderSizeChanged()
            {
                BorderSizeChanged?.Invoke(this, EventArgs.Empty);
                Update();
            }
            protected virtual void OnTargetControl_ControlAdded(object sender, ControlEventArgs e)
            {
                e.Control.MouseEnter -= OnTargetControl_MouseEnter;
                e.Control.MouseLeave -= OnTargetControl_MouseLeave;
                e.Control.MouseEnter += OnTargetControl_MouseEnter;
                e.Control.MouseLeave += OnTargetControl_MouseLeave;
            }
            protected virtual void OnTargetControl_ControlRemoved(object sender, ControlEventArgs e)
            {
                e.Control.MouseEnter -= OnTargetControl_MouseEnter;
                e.Control.MouseLeave -= OnTargetControl_MouseLeave;
            }
            protected virtual void OnTargetControlChanged()
            {
                if (TargetControl != null)
                {
                    if (TargetControl.Container != null)
                    {
                        TargetControl.ControlAdded -= OnTargetControl_ControlAdded;
                        TargetControl.ControlAdded += OnTargetControl_ControlAdded;
                        TargetControl.ControlRemoved -= OnTargetControl_ControlRemoved;
                        TargetControl.ControlRemoved += OnTargetControl_ControlRemoved;
                        for (int i = 0; i < TargetControl.Controls.Count; i++)
                        {
                            var c = (Control)TargetControl.Controls[i];
                            c.MouseEnter -= OnTargetControl_MouseEnter;
                            c.MouseEnter += OnTargetControl_MouseEnter;
                            c.MouseLeave -= OnTargetControl_MouseLeave;
                            c.MouseLeave += OnTargetControl_MouseLeave;
                        }
                    }
                    TargetControl.MouseEnter -= OnTargetControl_MouseEnter;
                    TargetControl.MouseEnter += OnTargetControl_MouseEnter;
                    TargetControl.MouseLeave -= OnTargetControl_MouseLeave;
                    TargetControl.MouseLeave += OnTargetControl_MouseLeave;
                    TargetControl.SizeChanged -= OnTargetControl_SizeChanged;
                    TargetControl.SizeChanged += OnTargetControl_SizeChanged;
                    TargetControl.LocationChanged -= OnTargetControl_LocationChanged;
                    TargetControl.LocationChanged += OnTargetControl_LocationChanged;
                    AdjustObject();
                }
                TargetControlChanged?.Invoke(this, EventArgs.Empty);
            }
            public int BorderSize { get; set; } = 2;
            protected override void OnPaint(PaintEventArgs e)
            {
                if (TargetControl != null)
                    AdjustObject();
                base.OnPaint(e);
            }
            void AdjustObject()
            {
                this.SendToBack();
                this.Size = new Size(TargetControl.Size.Width + BorderSize + (BorderSize), TargetControl.Size.Height + (2 * BorderSize));
                this.Location = new Point(TargetControl.Location.X - BorderSize, TargetControl.Location.Y - BorderSize);
            }
            private void OnTargetControl_SizeChanged(object sender, EventArgs e)
            {
                AdjustObject();
            }
            private void OnTargetControl_LocationChanged(object sender, EventArgs e)
            {
                AdjustObject();
            }
            private Color _HoverColor = Color.DimGray;
            private Color _NormalColor = Color.Black;
            public Color HoverColor { get => _HoverColor; set { _HoverColor = value; if (!_mouseHover) BackColor = NormalColor; else BackColor = HoverColor; OnHoverColorChanged(); } }
            public Color NormalColor { get => _NormalColor; set { _NormalColor = value; if (!_mouseHover) BackColor = NormalColor; else BackColor = HoverColor; OnNormalColorChanged(); } }
            private void OnTargetControl_MouseEnter(object sender, EventArgs e)
            {
                this.BackColor = HoverColor;
                _mouseHover = true;
            }
            private void OnTargetControl_MouseLeave(object sender, EventArgs e)
            {
                this.BackColor = NormalColor;
                _mouseHover = false;
            }
            private Control _TargetControl = null;
            public Control TargetControl { get => _TargetControl; set { _TargetControl = value; OnTargetControlChanged(); } }
            public ControlBorder() { this.BackColor = NormalColor; }
            public ControlBorder(Control targetControl) { Visible = false; TargetControl = targetControl; }

        }
        public partial class ConsoleTextBox : RichTextBox
        {
            public ConsoleTextBox()
            {
                InitializeComponent();
                ConfigSettings(Color.FromArgb(200, 200, 200));
            }
            public void Log(string Text, Color color, bool DoNewLine = true)
            {
                this.SelectionColor = color;
                if (DoNewLine)
                {
                    this.SelectedText = Text + "\n";
                }
                else
                {
                    this.SelectedText = Text;
                }
            }
            public void Log(string Text, bool DoNewLine = true)
            {
                this.SelectionColor = this.DefaultLogColor;
                if (DoNewLine)
                    this.SelectedText = Text + "\n";
                else
                    this.SelectedText = Text;
            }

            private void ConsoleTextBox_ForeColorChanged(object sender, EventArgs e)
            {
                this.ForeColor = DefaultLogColor;
            }

            private void ConsoleTextBox_TextChanged(object sender, EventArgs e)
            {
                if (this.AutoScrollToEnd)
                {
                    ScrollOutputToEnd();
                }
            }
            /// <summary> 
            /// Variável de designer necessária.
            /// </summary>
            private readonly IContainer components = null;

            /// <summary> 
            /// Limpar os recursos que estão sendo usados.
            /// </summary>
            /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            private void ConfigSettings(System.Drawing.Color DefaultLogColor)
            {
                this.DefaultLogColor = DefaultLogColor;
                //this.EndLineChar = '\n';
                this.BackColor = System.Drawing.Color.Black;
                this.ForeColor = this.DefaultLogColor;
                this.ReadOnly = true;
                this.AutoScrollToEnd = true;
            }
            public void ScrollOutputToEnd()
            {
                this.SelectionStart = this.TextLength;
                this.ScrollToCaret();
            }
            public void ScrollOutputToStart()
            {
                this.SelectionStart = 0;
                this.ScrollToCaret();
            }
            public bool AutoScrollToEnd { get; set; }
            public System.Drawing.Color DefaultLogColor { get; set; }
            //public char EndLineChar { get; set; }

            /// <summary> 
            /// Método necessário para suporte ao Designer - não modifique 
            /// o conteúdo deste método com o editor de código.
            /// </summary>
            private void InitializeComponent()
            {
                this.SuspendLayout();
                // 
                // ConsoleTextBox
                // 
                this.Name = "Console1";
                this.Size = new System.Drawing.Size(300, 150);
                this.ForeColorChanged += new System.EventHandler(this.ConsoleTextBox_ForeColorChanged);
                this.TextChanged += new System.EventHandler(this.ConsoleTextBox_TextChanged);
                this.ResumeLayout(false);

            }
        }
        [DebuggerStepThrough]
        [ProvideProperty("BunifuFramework", typeof(Control))]
        public class BunifuElipse : Component
        {
            private ContainerControl containerControl_0;

            [CompilerGenerated]
            private EventHandler eventHandler_0;

            private Control control_0;

            private int int_0 = 5;

            private IContainer icontainer_0;

            private System.Windows.Forms.Timer timer_0;

            private ContainerControl ContainerControl
            {
                get
                {
                    return containerControl_0;
                }
                set
                {
                    containerControl_0 = value;
                    ApplyElipse();
                }
            }

            public override ISite Site
            {
                get
                {
                    return base.Site;
                }
                set
                {
                    base.Site = value;
                    if (value == null)
                    {
                        return;
                    }
                    if (value.GetService(typeof(IDesignerHost)) is IDesignerHost designerHost)
                    {
                        IComponent rootComponent = designerHost.RootComponent;
                        if (rootComponent is ContainerControl)
                        {
                            ContainerControl = (rootComponent as ContainerControl);
                            return;
                        }
                    }
                    int num = default;
                    int num2 = default;
                    while (num == num2)
                    {
                        num2 = 1;
                        int num3 = num;
                        num = 1;
                        if (1 > num3)
                        {
                            break;
                        }
                    }
                }
            }

            public Control TargetControl
            {
                get
                {
                    return control_0;
                }
                set
                {
                    control_0 = value;
                }
            }

            public int ElipseRadius
            {
                get
                {
                    return int_0;
                }
                set
                {
                    int_0 = value;
                    ApplyElipse();
                }
            }

            public event EventHandler TargetControlResized
            {
                [CompilerGenerated]
                add
                {
                    EventHandler eventHandler = eventHandler_0;
                    EventHandler eventHandler2;
                    do
                    {
                        eventHandler2 = eventHandler;
                        EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
                        eventHandler = System.Threading.Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
                    }
                    while ((object)eventHandler != eventHandler2);
                }
                [CompilerGenerated]
                remove
                {
                    EventHandler eventHandler = eventHandler_0;
                    EventHandler eventHandler2;
                    do
                    {
                        eventHandler2 = eventHandler;
                        EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
                        eventHandler = System.Threading.Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
                    }
                    while ((object)eventHandler != eventHandler2);
                }
            }

            public BunifuElipse()
            {
                Method_0();
                if (TargetControl == null)
                {
                    TargetControl = ContainerControl;
                    return;
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }

            private void Control_0_Resize(object sender, EventArgs e)
            {
                Elipse.Apply(control_0, int_0);
                if (eventHandler_0 != null)
                {
                    eventHandler_0(sender, e);
                    return;
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }

            public BunifuElipse(IContainer container)
            {
                container.Add(this);
                Method_0();
            }

            public void ApplyElipse(int Radius)
            {
                if (control_0 != null)
                {
                    Elipse.Apply(control_0, Radius);
                    return;
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }

            public void ApplyElipse()
            {
                try
                {
                    if (control_0 != null)
                    {
                        Elipse.Apply(control_0, int_0);
                    }
                }
                catch (Exception)
                {
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }

            public void ApplyElipse(Control control, int Radius)
            {
                if (control != null)
                {
                    Elipse.Apply(control, Radius);
                    return;
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }

            public void ApplyElipse(Control control)
            {
                if (control != null)
                {
                    Elipse.Apply(control, int_0);
                    return;
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }

            private void Timer_0_Tick(object sender, EventArgs e)
            {
                try
                {
                    timer_0.Stop();
                    if (control_0 != null)
                    {
                        control_0.Resize += Control_0_Resize;
                    }
                    else
                    {
                        control_0 = ContainerControl;
                        control_0.Resize += Control_0_Resize;
                    }
                    if (control_0.GetType() == typeof(Form))
                    {
                        ((Form)control_0).FormBorderStyle = FormBorderStyle.None;
                    }
                    ApplyElipse();
                }
                catch (Exception)
                {
                    timer_0.Start();
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }

            protected override void Dispose(bool disposing)
            {
                if (disposing && icontainer_0 != null)
                {
                    icontainer_0.Dispose();
                }
                base.Dispose(disposing);
            }

            private void Method_0()
            {
                icontainer_0 = new Container();
                timer_0 = new System.Windows.Forms.Timer(icontainer_0)
                {
                    Enabled = true
                };
                timer_0.Tick += Timer_0_Tick;
            }
        }
        [DebuggerStepThrough]
        public static class Elipse
        {
            [DllImport("Gdi32.dll")]
            private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

            public static void Apply(Form Form, int _Elipse)
            {
                try
                {
                    Form.FormBorderStyle = FormBorderStyle.None;
                    Form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Form.Width, Form.Height, _Elipse, _Elipse));
                }
                catch (Exception)
                {
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }

            public static void Apply(Control ctrl, int Elipse)
            {
                try
                {
                    ctrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, Elipse, Elipse));
                }
                catch (Exception)
                {
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }
        }
        [DebuggerStepThrough]
        [ProvideProperty("BunifuFramework", typeof(Control))]
        public class DragControl : Component
        {
            private readonly Drag drag_0 = new Drag();

            private Control control_0;

            private ContainerControl containerControl_0;

            private bool bool_0 = true;

            private bool bool_1 = true;

            private bool bool_2 = true;

            private IContainer icontainer_0;

            private Timer timer_0;

            public Control TargetControl
            {
                get
                {
                    return control_0;
                }
                set
                {
                    control_0 = value;
                }
            }

            private ContainerControl ContainerControl
            {
                get
                {
                    return containerControl_0;
                }
                set
                {
                    containerControl_0 = value;
                }
            }

            public override ISite Site
            {
                get
                {
                    return base.Site;
                }
                set
                {
                    base.Site = value;
                    if (value == null)
                    {
                        return;
                    }
                    if (value.GetService(typeof(IDesignerHost)) is IDesignerHost designerHost)
                    {
                        IComponent rootComponent = designerHost.RootComponent;
                        if (rootComponent is ContainerControl)
                        {
                            ContainerControl = (rootComponent as ContainerControl);
                            return;
                        }
                    }
                    int num = default;
                    int num2 = default;
                    while (num == num2)
                    {
                        num2 = 1;
                        int num3 = num;
                        num = 1;
                        if (1 > num3)
                        {
                            break;
                        }
                    }
                }
            }

            public bool Fixed
            {
                get
                {
                    return bool_0;
                }
                set
                {
                    bool_0 = value;
                }
            }

            public bool Vertical
            {
                get
                {
                    return bool_1;
                }
                set
                {
                    bool_1 = value;
                }
            }

            public bool Horizontal
            {
                get
                {
                    return bool_2;
                }
                set
                {
                    bool_2 = value;
                }
            }

            public DragControl()
            {
                Method_3();
                _ = LicenseManager.UsageMode;
            }

            public DragControl(IContainer container)
            {
                container.Add(this);
                Method_3();
            }

            public void Grab(Control _control)
            {
                drag_0.Grab(_control);
            }

            public void Grab()
            {
                Control a = containerControl_0;
                drag_0.Grab(a);
            }

            public void Release()
            {
                drag_0.Release();
            }

            public void Drag(bool horixontal = true, bool Vertical = true)
            {
                drag_0.MoveObject(Vertical, horixontal);
            }

            private void Timer_0_Tick(object sender, EventArgs e)
            {
                try
                {
                    timer_0.Stop();
                    Control containerControl = this.ContainerControl;
                    if (control_0 != null)
                    {
                        containerControl = control_0;
                    }
                    containerControl.MouseDown += Method_2;
                    containerControl.MouseMove += Method_0;
                    containerControl.MouseUp += Method_1;
                }
                catch (Exception)
                {
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }

            private void Method_0(object sender, MouseEventArgs e)
            {
                Drag(Vertical, Horizontal);
            }

            private void Method_1(object sender, MouseEventArgs e)
            {
                Release();
            }

            private void Method_2(object sender, MouseEventArgs e)
            {
                if (bool_0)
                {
                    Control control = (Control)sender;
                    while (control.Parent != null)
                    {
                        control = control.Parent;
                    }
                    Grab(control);
                }
                else
                {
                    Grab((Control)sender);
                }
            }

            protected override void Dispose(bool disposing)
            {
                if (disposing && icontainer_0 != null)
                {
                    icontainer_0.Dispose();
                }
                base.Dispose(disposing);
            }

            private void Method_3()
            {
                icontainer_0 = new Container();
                timer_0 = new Timer(icontainer_0)
                {
                    Enabled = true,
                    Interval = 1
                };
                timer_0.Tick += Timer_0_Tick;
            }
        }

        public class Drag
        {
            private bool bool_0;

            private int int_0;

            private int int_1;

            private Control control_0;

            public void Grab(Control a)
            {
                try
                {
                    control_0 = a;
                    bool_0 = true;
                    int_0 = Control.MousePosition.X - control_0.Left;
                    int_1 = Control.MousePosition.Y - control_0.Top;
                }
                catch (Exception)
                {
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }

            public void Release()
            {
                bool_0 = false;
            }

            public void MoveObject(bool Horizontal = true, bool Vertical = true)
            {
                try
                {
                    if (bool_0)
                    {
                        int x = Control.MousePosition.X;
                        int y = Control.MousePosition.Y;
                        if (Vertical)
                        {
                            control_0.Top = y - int_1;
                        }
                        if (Horizontal)
                        {
                            control_0.Left = x - int_0;
                        }
                    }
                }
                catch (Exception)
                {
                }
                int num = default;
                int num2 = default;
                while (num == num2)
                {
                    num2 = 1;
                    int num3 = num;
                    num = 1;
                    if (1 > num3)
                    {
                        break;
                    }
                }
            }
        }
    }
    public static class Converter
    {
        public static string[] ByteStringToByteArray(string Bytes)
        {
            int Cur = 0;
            string[] ByteArray = new string[Bytes.Length / 2];
            string temp = null;
            int index = 0;
            for (int i = 0; i <= Bytes.Length; i++)
            {
                if (Cur == 2)
                {
                    ByteArray[index] = temp;
                    temp = null;
                    index++;
                    i--;
                    Cur = 0;
                }
                else
                {
                    if (i == Bytes.Length)
                    {

                    }
                    else
                    {
                        temp += Bytes.Substring(i, 1);
                        Cur++;
                    }
                }
            }
            return ByteArray;
        }
        public static string ByteArrayToByteString(string[] Bytes)
        {
            string Data = null;
            foreach (string bt in Bytes)
            {
                Data += bt;
            }
            return Data;
        }
        public static string ReverseByteOrder(string Bytes)
        {
            string FinalResult = null;
            for (int Cur = ByteStringToByteArray(Bytes).Length - 1; Cur >= 0; Cur--)
            {
                FinalResult += ByteStringToByteArray(Bytes)[Cur];
            }
            return FinalResult;
        }
        public static string HexadecimalToBinary(string HexNumber)
        {
            int dec = HexadecimalToDecimal(HexNumber);
            return DecimalToBinary(dec);
        }
        public static string DecimalToBinary(int Number)
        {
            return Convert.ToString(Number, 2);
        }
        //public static string BinaryToText(string BinaryText)
        //{
        //    string Val = null;
        //    string Characters = System.Text.RegularExpressions.Regex.Replace(BinaryText, "[^01]", "");
        //    byte[] ByteArray = new byte[Convert.ToInt64((Characters.Length / 8.0))];
        //    for (int Index = 0; Index < ByteArray.Length; Index++)
        //    {
        //        ByteArray[Index] = Convert.ToByte(Characters.Substring(Index * 8, 8), 2);
        //    }
        //    Val = System.Text.ASCIIEncoding.ASCII.GetString(ByteArray);
        //    return Val;
        //}
        public static string BinaryToHexadecimal(string BinaryNumber)
        {
            int dec = BinaryToDecimal(BinaryNumber);
            return DecimalToHexadecimal(dec);
        }
        public static int BinaryToDecimal(string BinaryNumber)
        {
            int binarynum = 0;
            for (int bitcount = 1; bitcount <= BinaryNumber.Length; bitcount++)
            {
                binarynum = Convert.ToInt32(binarynum + (Convert.ToDouble(BinaryNumber.Substring(BinaryNumber.Length - bitcount, 1)) * (System.Math.Pow(2, bitcount - 1))));
            }
            return binarynum;
        }

        /// <summary>
        /// Swaps the given bytes (example "C0" = "0C")
        /// </summary>
        /// <param name="HexBytes">The bytes to swap</param>
        /// <returns>Returns the swaped bytes</returns>
        public static string SwapHexBytes(string HexBytes)
        {
            string l = HexBytes.Substring(0, 1);
            string r = HexBytes.Last().ToString();
            return r + l;
        }
        /// <summary>
        /// Swaps the given bytes (example "C054" = "54C0")
        /// </summary>
        /// <param name="HexBytes">The bytes to swap</param>
        /// <returns>Returns the swaped bytes</returns>
        public static string SwapHexBytesPair(string HexBytes)
        {
            if ((HexBytes.Length / 2) % 2 != 0 || HexBytes.Length <= 0) { return null; }
            string[] Bytes = ByteStringToByteArray(HexBytes);
            for (int i = 0; i <= Bytes.Length - 1; i += 2)
            {
                string bt = Bytes[i];
                Bytes[i] = Bytes[i + 1];
                Bytes[i + 1] = bt;
            }
            return ByteArrayToByteString(Bytes);
        }
        /// <summary>
        /// Inverts the given text (example "55" = "ÊÊ")
        /// </summary>
        /// <param name="Text">The text to invert</param>
        /// <returns>Returns the inverted text</returns>
        public static string InvertASCValue(string Text)
        {
            string hexV = TextToHexadecimal(Text);
            return HexadecimalToText(InvertHexBytes(hexV));
        }
        /// <summary>
        /// Inverts the given bytes (example "C0" = "3F")
        /// </summary>
        /// <param name="HexBytes">The bytes to invert</param>
        /// <returns>Returns the inverted bytes</returns>
        public static string InvertHexBytes(string HexBytes)
        {
            string InvertedBytes = null;
            foreach (var HexByte in HexBytes)
            {
                string var = HexByte.ToString().ToUpper();
                switch (var)
                {
                    case "0":
                        var = "F";
                        break;
                    case "1":
                        var = "E";
                        break;
                    case "2":
                        var = "D";
                        break;
                    case "3":
                        var = "C";
                        break;
                    case "4":
                        var = "B";
                        break;
                    case "5":
                        var = "A";
                        break;
                    case "6":
                        var = "9";
                        break;
                    case "7":
                        var = "8";
                        break;
                    case "8":
                        var = "7";
                        break;
                    case "9":
                        var = "6";
                        break;
                    case "A":
                        var = "5";
                        break;
                    case "B":
                        var = "4";
                        break;
                    case "C":
                        var = "3";
                        break;
                    case "D":
                        var = "2";
                        break;
                    case "E":
                        var = "1";
                        break;
                    case "F":
                        var = "0";
                        break;
                }
                InvertedBytes += var.ToString();
            }
            return InvertedBytes;
        }
        public static string DecimalToOctal(int Number)
        {
            return Convert.ToString(Number, 8);
        }
        public static int OctalToDecimal(int OctalNumber)
        {
            var octal = OctalNumber;
            var dec = 0;
            var remain = octal;
            var i = 0;
            while (remain > 0)
            {
                dec += remain % 10 * (int)System.Math.Pow(8, i);
                remain /= 10;
                i++;
            }
            return dec;
        }
        public static string DecimalToHexadecimal(int Number)
        {
            return Convert.ToString(Number, 16).ToUpper();
        }
        public static int HexadecimalToDecimal(string HexNumber)
        {
            return Convert.ToInt32(HexNumber, 16);
        }
        public static string TextToBinary(string Text)
        {
            StringBuilder Result = new StringBuilder();
            foreach (byte Character in System.Text.ASCIIEncoding.ASCII.GetBytes(Text))
            {
                Result.Append(Convert.ToString(Character, 2).PadLeft(8, '0'));
                Result.Append(" ");
            }
            string Val = Result.ToString().Substring(0, Result.ToString().Length - 1);
            return Val;
        }
        public static string BinaryToText(string BinaryString)
        {
            string Characters = System.Text.RegularExpressions.Regex.Replace(BinaryString, "[^01]", "");
            byte[] ByteArray = new byte[Characters.Length / 8 - 1];
            int index;
            for (index = 0; index == ByteArray.Length - 1; index++)
            {
                ByteArray[index] = Convert.ToByte(Characters.Substring(index * 8, 8), 2);
            }
            return System.Text.ASCIIEncoding.ASCII.GetString(ByteArray);
        }
        public static string TextToHexadecimal(string Text)
        {
            string outp = string.Empty;
            char[] value = Text.ToCharArray();
            foreach (char L in value)
            {
                int V = Convert.ToInt32(L);
                outp += string.Format("{0:x}", V);
            }
            return outp;
        }
        public static string HexadecimalToText(string HexNumber)
        {
            System.Text.StringBuilder text = new System.Text.StringBuilder(HexNumber.Length / 2);
            for (int i = 0; i <= HexNumber.Length - 2; i += 2)
            {
                text.Append((char)(Convert.ToByte(HexNumber.Substring(i, 2), 16)));
            }
            return text.ToString();
        }
    }
    public static class Generate
    {
        public static string GUID()
        {
            string[] bts = ByteStringToByteArray(RandomHexBytes(16, ""));
            return bts[3] + bts[2] + bts[1] + bts[0] + "-" + bts[5] + bts[4] + "-" + bts[6] + bts[7] + "-" + bts[8] + bts[9] + " " + bts[10] + bts[11] + bts[12] + bts[13] + bts[14] + bts[15];
        }
        public static string GUID(string HexadecimalBytes)
        {
            string[] bts = ByteStringToByteArray(HexadecimalBytes);
            return bts[3] + bts[2] + bts[1] + bts[0] + "-" + bts[5] + bts[4] + "-" + bts[6] + bts[7] + "-" + bts[8] + bts[9] + " " + bts[10] + bts[11] + bts[12] + bts[13] + bts[14] + bts[15];
        }
        /// <summary>
        /// Generates random Hexadecimal Bytes
        /// </summary>
        /// <param name="AmmountOfBytes">The ammount of bytes to be generated</param>
        public static string RandomHexBytes(int AmmountOfBytes, string spliter = " ")
        {
            int lenght = AmmountOfBytes * 2;
            int casing = 1;
            int content = 0;
            int CurLenght = 0;
            char[] LowAlph = "abcdef".ToCharArray();
            char[] UppAlph = "ABCDEF".ToCharArray();
            _ = "1234567890".ToCharArray();
            char addLetter = 'a';
            string gString = "";
            _ = "abcdef01234567890".ToCharArray();
            Random r = new Random();
            Random r1 = new Random();
            _ = new Random();
            while (gString.Length != lenght)
            {
                switch (casing)
                {
                    case 0:
                        switch (r.Next(0, 2))
                        {
                            case 0:
                                addLetter = LowAlph[r1.Next(0, 5)];
                                break;
                            case 1:
                                addLetter = UppAlph[r1.Next(0, 5)];
                                break;
                        }
                        break;
                    case 1:
                        addLetter = UppAlph[r1.Next(0, 5)];
                        break;
                    case 2:
                        addLetter = LowAlph[r1.Next(0, 5)];
                        break;
                }
                switch (content)
                {
                    case 0:
                        switch (r.Next(0, 2))
                        {
                            case 0:
                                gString += addLetter;
                                CurLenght++;
                                break;
                            case 1:
                                gString += r1.Next(0, 9);
                                CurLenght++;
                                break;
                        }
                        break;
                    case 1:
                        gString += r1.Next(0, 9);
                        CurLenght++;
                        break;
                    case 2:
                        gString += addLetter;
                        CurLenght++;
                        break;
                }
                if (CurLenght == 2)
                {
                    gString += spliter;
                    CurLenght = 0;
                    lenght++;
                }
            }
            return gString.Substring(0, gString.Length - 1);
        }
        /// <summary>
        /// Generates a random string
        /// </summary>
        /// <param name="lenght">The string lenght</param>
        /// <param name="content">0 = Numbers and Letters; 1 = Only Numbers; 2 = Only Letters</param>
        /// <param name="casing">0 = Random casing; 1 = Only Uppercase; 2 = Only Lowercase</param>
        public static string RandomString(int lenght, int content, int casing)
        {
            char[] LowAlph = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] UppAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            _ = "1234567890".ToCharArray();
            char addLetter = 'a';
            string gString = "";
            _ = "abcdefghijklmnopqrstuvwxyz01234567890".ToCharArray();
            Random r = new Random();
            Random r1 = new Random();
            _ = new Random();
            while (gString.Length != lenght)
            {
                switch (casing)
                {
                    case 0:
                        switch (r.Next(0, 2))
                        {
                            case 0:
                                addLetter = LowAlph[r1.Next(0, 25)];
                                break;
                            case 1:
                                addLetter = UppAlph[r1.Next(0, 25)];
                                break;
                        }
                        break;
                    case 1:
                        addLetter = UppAlph[r1.Next(0, 25)];
                        break;
                    case 2:
                        addLetter = LowAlph[r1.Next(0, 25)];
                        break;
                }
                switch (content)
                {
                    case 0:
                        switch (r.Next(0, 2))
                        {
                            case 0:
                                gString += addLetter;
                                break;
                            case 1:
                                gString += r1.Next(0, 9);
                                break;
                        }
                        break;
                    case 1:
                        gString += r1.Next(0, 9);
                        break;
                    case 2:
                        gString += addLetter;
                        break;
                }
            }
            return gString;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lenghtPerPart"> The lenght of each key part (total of 3 parts)</param>
        /// <param name="keyContent">0 = Numbers and letters; 1 = Numbers Only; 2 = Letters Only</param>
        /// <returns></returns>
        public static string LicenseKey(int lenghtPerPart, int keyContent)
        {
            string part1 = RandomString(lenghtPerPart, keyContent, 1);
            string rd1 = RandomString(50, keyContent, 1);
            string rd2 = RandomString(120, keyContent, 1);
            string part2 = rd1.Substring(rd1.Length - lenghtPerPart);
            string part3 = rd1.Substring(rd1.Length - lenghtPerPart);
            return part1 + "-" + part2 + "-" + part3;
        }
    }
    public static class Maths
    {
        public static string GetFraction(double val)
        {
            for (double i = 1; i <= (int)(val * 50 + 1); i++)
                for (double j = 1; j <= (int)(val * 50 + 1); j++)
                    if (j / i == val)
                        return j.ToString() + "/" + i.ToString();
            return "0";
        }
        public static string[] GetFraction(double val, bool _)
        {
            List<string> rets = new List<string>();
            for (double i = 1; i <= 5000; i++)
                for (double j = 1; j <= 5000; j++)
                    if (j / i == val)
                        rets.Add(j.ToString() + "/" + i.ToString());
            return rets.ToArray();
        }
        public static string[] GetFraction(double val, int rangeMultiplier = 50)
        {
            List<string> rets = new List<string>();
            for (double i = 1; i <= (int)(val * rangeMultiplier); i++)
                for (double j = 1; j <= (int)(val * rangeMultiplier); j++)
                    if (j / i == val)
                        rets.Add(j.ToString() + "/" + i.ToString());
            return rets.ToArray();
        }
        public static class RelativeFunction
        {
            public static void FillGrid(DataGridView grid, int[] A, int[] B)
            {
                grid.Rows.Clear();
                grid.Columns.Clear();
                foreach (var bv in B)
                    grid.Columns.Add("value_" + bv.ToString(), bv.ToString());
                grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.TopLeftHeaderCell.Value = "A\\B"; int i = 0;
                foreach (var av in A)
                {
                    List<string> range = new List<string>();
                    foreach (var bv in B)
                        range.Add("" + av.ToString() + ", " + bv.ToString() + "");
                    grid.Rows.Add(range.ToArray());
                    grid.Rows[i].HeaderCell.Value = av.ToString();
                    Application.DoEvents(); i++;
                }
            }
            private static bool IsCondition(int x, int y, string condition)
            {
                int xs = (int)Maths.MathParser.Parse(condition.Split('=')[0].Replace("x", x.ToString()));
                int ys = (int)Maths.MathParser.Parse(condition.Split('=')[1].Replace("y", y.ToString()));
                return xs == ys;
            }
            public static string Parse(Point[] groups)
            {
                string r = "{";
                foreach (var g in groups)
                    r += " (" + g.X.ToString() + ", " + g.Y.ToString() + ")";
                return r + " }";
            }
            public static int[] Parse(string RelativeFunction)
            {
                List<int> arr = new List<int>();
                foreach (var v in RelativeFunction.Replace("{", "").Replace("}", "").Split(','))
                    arr.Add(int.Parse(v.Replace(" ", "")));
                return arr.ToArray();
            }
            public static Point[] Solve(int[] A, int[] B, string condition)
            {
                List<Point> groups = new List<Point>();
                foreach (var av in A)
                    foreach (var bv in B)
                        if (IsCondition(av, bv, condition))
                            groups.Add(new Point(av, bv));
                return groups.ToArray();
            }
        }
        public static double[] Baskara(int a, int b, int c)
        {
            return Baskara(double.Parse(a.ToString()), double.Parse(b.ToString()), double.Parse(c.ToString()));
        }
        public static double[] Baskara(double a, double b, double c)
        {
            // Delta = bº - 4 * a * c
            // Baskara = ( - b +- sqrt(delta)) / 2

            var delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                var l = (new double[] { double.Parse(((-b + Math.Sqrt(delta)) / (2 * a)).ToString()), double.Parse(((-b - Math.Sqrt(delta)) / (2 * a)).ToString()) }).ToList();
                l.Sort();
                return l.ToArray() as double[];
            }
            else if (delta == 0)
            {
                var l = (new double[] { double.Parse(((-b + Math.Sqrt(delta)) / (2 * a)).ToString()) }).ToList();
                l.Sort();
                return l.ToArray() as double[];
            }
            else
            {
                return new double[0];
            }
        }
#pragma warning disable IDE0060 // Remover o parâmetro não utilizado
        public static object Baskara(int a, int b, int c, bool AsString)
#pragma warning restore IDE0060 // Remover o parâmetro não utilizado
        {
            return Baskara(double.Parse(a.ToString()), double.Parse(b.ToString()), double.Parse(c.ToString()));
        }
        public static object Baskara(double a, double b, double c, bool AsString)
        {
            var bask = Baskara(a, b, c);
            if (AsString)
            {
                var bRes = "S = {";
                foreach (var br in bask)
                {
                    bRes += " " + br.ToString() + "; ";
                }
                bRes = bRes.Substring(0, bRes.Length - 2);
                return bRes + " }";
            }
            else
            {
                return bask;
            }
        }
        public static string XOR(string[] bytes, byte initial = 0x00)
        {
            Byte _CheckSum = initial;
            for (int i = 0; i < bytes.Length; i++)
            {
                var cB = Convert.ToByte(HexadecimalToDecimal(bytes[i]));
                _CheckSum ^= cB;
            }
            return DecimalToHexadecimal(int.Parse(_CheckSum.ToString()));
        }
        public static class Percentage
        {
            public static double NumberToPercent(double TotalNumber, double Number)
            {
                return TotalNumber / Number * 100.0;
            }
            public static double PercentToNumber(double TotalNumber, double Percentage)
            {
                return TotalNumber * Percentage / 100.0;
            }
        }
        /// <summary>
        /// Goes through each number in the given number and multiplies them
        /// </summary>
        /// <param name="Number">The given number</param>
        /// <returns>Returns the result</returns>
        public static long MultiplyChars(long Number)
        {
            long result = 1;
            for (long i = 0; i < Number.ToString().Length; i++)
            {
                int m = int.Parse(Number.ToString().ToCharArray()[i].ToString());
                result *= m;
            }
            return result;
        }
        /// <summary>
        /// Gets the multiplicative persistence of a 'x' number and returns a list wich index 0 = the number of steps and the rest are the results
        /// </summary>
        /// <param name="Number">The number to get the multiplicative persistence.</param>
        /// <returns></returns>
        public static List<ulong> GetMultiplicativePersistence(ulong Number)
        {
            var res = new List<ulong>
            {
                0
            };
            ulong steps = 0;
            ulong results = Number;
            while (results.ToString().Length != 1)
            {
                ulong tmpRes = 1;
                for (ulong i = 0; i < ulong.Parse(results.ToString().Length.ToString()); i++)
                {
                    ulong m = ulong.Parse(results.ToString().ToCharArray()[i].ToString());
                    tmpRes *= m;
                }
                results = tmpRes;
                res.Add(results);
                steps++;
            }
            res[0] = steps;
            return res;
        }
        public static int[] GetMultipliers(int number)
        {
            List<int> mults = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    mults.Add(i);
                }
            }
            return mults.ToArray();
        }
        public static bool IsPrime(int number)
        {
            int[] a = GetPrimeNumbers(number);
            return a.Contains(number);
        }
        public static int[] GetPrimeNumbers(int number)
        {
            List<int> arr = new List<int>();
            for (int j = 2; j < number; j++)
            {
                for (int i = 2; i < j && j % i != 0; i++)
                {
                    if (j == i + 1)
                    {
                        arr.Add(j);
                    }
                }
            }
            return arr.ToArray();
        }
        public class MathParser
        {
            #region Properties

            /// <summary>
            /// All operators that you want to define should be inside this property.
            /// </summary>
            public Dictionary<string, Func<double, double, double>> Operators { get; set; }

            /// <summary>
            /// All functions that you want to define should be inside this property.
            /// </summary>
            public Dictionary<string, Func<double[], double>> LocalFunctions { get; set; }

            /// <summary>
            /// All variables that you want to define should be inside this property.
            /// </summary>
            public Dictionary<string, double> LocalVariables { get; set; }

            /// <summary>
            /// When converting the result from the Parse method or ProgrammaticallyParse method ToString(),
            /// please use this culture info.
            /// </summary>
            public CultureInfo CultureInfo { get; }

            #endregion

            /// <summary>
            /// Initializes a new instance of the MathParser class, and optionally with
            /// predefined functions, operators, and variables.
            /// </summary>
            /// <param name="loadPreDefinedFunctions">This will load abs, cos, cosh, arccos, sin, sinh, arcsin, tan, tanh, arctan, sqrt, rem, and round.</param>
            /// <param name="loadPreDefinedOperators">This will load %, *, :, /, +, -, >, &lt;, and =</param>
            /// <param name="loadPreDefinedVariables">This will load pi, tao, e, phi, major, minor, pitograd, and piofgrad.</param>
            /// <param name="cultureInfo">The culture info to use when parsing. If null, defaults to invariant culture.</param>
            public MathParser(bool loadPreDefinedFunctions = true, bool loadPreDefinedOperators = true, bool loadPreDefinedVariables = true, CultureInfo cultureInfo = null)
            {
                if (loadPreDefinedOperators)
                {
                    Operators = new Dictionary<string, Func<double, double, double>>(10)
                    {
                        ["^"] = System.Math.Pow,
                        ["%"] = (a, b) => a % b,
                        [":"] = (a, b) => a / b,
                        ["/"] = (a, b) => a / b,
                        ["*"] = (a, b) => a * b,
                        ["-"] = (a, b) => a - b,
                        ["+"] = (a, b) => a + b,

                        [">"] = (a, b) => a > b ? 1 : 0,
                        ["<"] = (a, b) => a < b ? 1 : 0,
                        ["="] = (a, b) => System.Math.Abs(a - b) < 0.00000001 ? 1 : 0
                    };
                }
                else
                    Operators = new Dictionary<string, Func<double, double, double>>();

                if (loadPreDefinedFunctions)
                {
                    LocalFunctions = new Dictionary<string, Func<double[], double>>(26)
                    {
                        ["abs"] = inputs => System.Math.Abs(inputs[0]),

                        ["cos"] = inputs => System.Math.Cos(inputs[0]),
                        ["cosh"] = inputs => System.Math.Cosh(inputs[0]),
                        ["acos"] = inputs => System.Math.Acos(inputs[0]),
                        ["arccos"] = inputs => System.Math.Acos(inputs[0]),

                        ["sin"] = inputs => System.Math.Sin(inputs[0]),
                        ["sinh"] = inputs => System.Math.Sinh(inputs[0]),
                        ["asin"] = inputs => System.Math.Asin(inputs[0]),
                        ["arcsin"] = inputs => System.Math.Asin(inputs[0]),

                        ["tan"] = inputs => System.Math.Tan(inputs[0]),
                        ["tanh"] = inputs => System.Math.Tanh(inputs[0]),
                        ["atan"] = inputs => System.Math.Atan(inputs[0]),
                        ["arctan"] = inputs => System.Math.Atan(inputs[0]),

                        ["sqrt"] = inputs => System.Math.Sqrt(inputs[0]),
                        ["pow"] = inputs => System.Math.Pow(inputs[0], inputs[1]),
                        ["root"] = inputs => System.Math.Pow(inputs[0], 1 / inputs[1]),
                        ["rem"] = inputs => System.Math.IEEERemainder(inputs[0], inputs[1]),

                        ["sign"] = inputs => System.Math.Sign(inputs[0]),
                        ["exp"] = inputs => System.Math.Exp(inputs[0]),

                        ["floor"] = inputs => System.Math.Floor(inputs[0]),
                        ["ceil"] = inputs => System.Math.Ceiling(inputs[0]),
                        ["ceiling"] = inputs => System.Math.Ceiling(inputs[0]),
                        ["round"] = inputs => System.Math.Round(inputs[0]),
                        ["truncate"] = inputs => inputs[0] < 0 ? -System.Math.Floor(-inputs[0]) : System.Math.Floor(inputs[0]),

                        ["log"] = inputs =>
                        {
                            switch (inputs.Length)
                            {
                                case 1:
                                    return System.Math.Log10(inputs[0]);
                                case 2:
                                    return System.Math.Log(inputs[0], inputs[1]);
                                default:
                                    return 0;
                            }
                        },

                        ["ln"] = inputs => System.Math.Log(inputs[0])
                    };
                }
                else
                    LocalFunctions = new Dictionary<string, Func<double[], double>>();

                if (loadPreDefinedVariables)
                {
                    LocalVariables = new Dictionary<string, double>(8)
                    {
                        ["pi"] = 3.14159265358979,
                        ["tao"] = 6.28318530717959,

                        ["e"] = 2.71828182845905,
                        ["phi"] = 1.61803398874989,
                        ["major"] = 0.61803398874989,
                        ["minor"] = 0.38196601125011,

                        ["pitograd"] = 57.2957795130823,
                        ["piofgrad"] = 0.01745329251994
                    };
                }
                else
                    LocalVariables = new Dictionary<string, double>();

                CultureInfo = cultureInfo ?? CultureInfo.InvariantCulture;
            }

            /// <summary>
            /// Enter the math expression in form of a string.
            /// </summary>
            /// <param name="mathExpression">The math expression to parse.</param>
            /// <returns>The result of executing <paramref name="mathExpression"/>.</returns>
            public static double Parse(string mathExpression)
            {
                var parser = new MathParser();
                return parser.MathParserLogic(parser.Lexer(mathExpression));
            }

            /// <summary>
            /// Enter the math expression in form of a list of tokens.
            /// </summary>
            /// <param name="mathExpression">The math expression to parse.</param>
            /// <returns>The result of executing <paramref name="mathExpression"/>.</returns>
            public static double Parse(ReadOnlyCollection<string> mathExpression)
            {
                var parser = new MathParser();
                return parser.MathParserLogic(new List<string>(mathExpression));
            }

            /// <summary>
            /// Enter the math expression in form of a string. You might also add/edit variables using "let" keyword.
            /// For example, "let sampleVariable = 2+2".
            /// 
            /// Another way of adding/editing a variable is to type "varName := 20"
            /// 
            /// Last way of adding/editing a variable is to type "let varName be 20"
            /// </summary>
            /// <param name="mathExpression">The math expression to parse.</param>
            /// <param name="correctExpression">If true, correct <paramref name="correctExpression"/> of any typos.</param>
            /// <param name="identifyComments">If true, treat "#", "#{", and "}#" as comments.</param>
            /// <returns>The result of executing <paramref name="mathExpression"/>.</returns>
            public double ProgrammaticallyParse(string mathExpression, bool correctExpression = true, bool identifyComments = true)
            {
                if (identifyComments)
                {
                    // Delete Comments #{Comment}#
                    mathExpression = System.Text.RegularExpressions.Regex.Replace(mathExpression, "#\\{.*?\\}#", "");

                    // Delete Comments #Comment
                    mathExpression = System.Text.RegularExpressions.Regex.Replace(mathExpression, "#.*$", "");
                }

                if (correctExpression)
                {
                    // this refers to the Correction function which will correct stuff like artn to arctan, etc.
                    mathExpression = Correction(mathExpression);
                }

                string varName;
                double varValue;

                if (mathExpression.Contains("let"))
                {
                    if (mathExpression.Contains("be"))
                    {
                        varName = mathExpression.Substring(mathExpression.IndexOf("let", StringComparison.Ordinal) + 3,
                            mathExpression.IndexOf("be", StringComparison.Ordinal) -
                            mathExpression.IndexOf("let", StringComparison.Ordinal) - 3);
                        mathExpression = mathExpression.Replace(varName + "be", "");
                    }
                    else
                    {
                        varName = mathExpression.Substring(mathExpression.IndexOf("let", StringComparison.Ordinal) + 3,
                            mathExpression.IndexOf("=", StringComparison.Ordinal) -
                            mathExpression.IndexOf("let", StringComparison.Ordinal) - 3);
                        mathExpression = mathExpression.Replace(varName + "=", "");
                    }

                    varName = varName.Replace(" ", "");
                    mathExpression = mathExpression.Replace("let", "");

                    varValue = Parse(mathExpression);

                    if (LocalVariables.ContainsKey(varName))
                        LocalVariables[varName] = varValue;
                    else
                        LocalVariables.Add(varName, varValue);

                    return varValue;
                }

                if (!mathExpression.Contains(":="))
                    return Parse(mathExpression);

                //mathExpression = mathExpression.Replace(" ", ""); // remove white space
                varName = mathExpression.Substring(0, mathExpression.IndexOf(":=", StringComparison.Ordinal));
                mathExpression = mathExpression.Replace(varName + ":=", "");

                varValue = Parse(mathExpression);
                varName = varName.Replace(" ", "");

                if (LocalVariables.ContainsKey(varName))
                    LocalVariables[varName] = varValue;
                else
                    LocalVariables.Add(varName, varValue);

                return varValue;
            }

            /// <summary>
            /// This will convert a string expression into a list of tokens that can be later executed by Parse or ProgrammaticallyParse methods.
            /// </summary>
            /// <param name="mathExpression">The math expression to tokenize.</param>
            /// <returns>The resulting tokens of <paramref name="mathExpression"/>.</returns>
            public ReadOnlyCollection<string> GetTokens(string mathExpression)
            {
                return Lexer(mathExpression).AsReadOnly();
            }

            #region Core

            /// <summary>
            /// This will correct sqrt() and arctan() written in different ways only.
            /// </summary>
            /// <param name="input"></param>
            /// <returns></returns>
            private string Correction(string input)
            {
                // Word corrections

                input = System.Text.RegularExpressions.Regex.Replace(input, "\\b(sqr|sqrt)\\b", "sqrt",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                input = System.Text.RegularExpressions.Regex.Replace(input, "\\b(atan2|arctan2)\\b", "arctan2",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                //... and more

                return input;
            }

            /// <summary>
            /// Tokenizes <paramref name="expr"/>.
            /// </summary>
            /// <param name="expr">The expression to tokenize.</param>
            /// <returns>The tokens.</returns>
            private List<string> Lexer(string expr)
            {
                var token = "";
                var tokens = new List<string>();

                expr = expr.Replace("+-", "-");
                expr = expr.Replace("-+", "-");
                expr = expr.Replace("--", "+");

                for (var i = 0; i < expr.Length; i++)
                {
                    var ch = expr[i];

                    if (char.IsWhiteSpace(ch))
                        continue;

                    if (char.IsLetter(ch))
                    {
                        if (i != 0 && (char.IsDigit(expr[i - 1]) || expr[i - 1] == ')'))
                            tokens.Add("*");

                        token += ch;

                        while (i + 1 < expr.Length && char.IsLetterOrDigit(expr[i + 1]))
                            token += expr[++i];

                        tokens.Add(token);
                        token = "";

                        continue;
                    }

                    if (char.IsDigit(ch))
                    {
                        token += ch;

                        while (i + 1 < expr.Length && (char.IsDigit(expr[i + 1]) || expr[i + 1] == '.'))
                            token += expr[++i];

                        tokens.Add(token);
                        token = "";

                        continue;
                    }

                    if (ch == '.')
                    {
                        token += ch;

                        while (i + 1 < expr.Length && char.IsDigit(expr[i + 1]))
                            token += expr[++i];

                        tokens.Add(token);
                        token = "";

                        continue;
                    }

                    if (i + 1 < expr.Length && (ch == '-' || ch == '+') && char.IsDigit(expr[i + 1]) &&
                        (i == 0 || Operators.ContainsKey(expr[i - 1].ToString(
#if !NETSTANDARD1_4
                        CultureInfo
#endif
                        )) ||
                         i - 1 > 0 && expr[i - 1] == '('))
                    {
                        // if the above is true, then the token for that negative number will be "-1", not "-","1".
                        // to sum up, the above will be true if the minus sign is in front of the number, but
                        // at the beginning, for example, -1+2, or, when it is inside the brakets (-1).
                        // NOTE: this works for + as well!

                        token += ch;

                        while (i + 1 < expr.Length && (char.IsDigit(expr[i + 1]) || expr[i + 1] == '.'))
                            token += expr[++i];

                        tokens.Add(token);
                        token = "";

                        continue;
                    }

                    if (ch == '(')
                    {
                        if (i != 0 && (char.IsDigit(expr[i - 1]) || char.IsDigit(expr[i - 1]) || expr[i - 1] == ')'))
                        {
                            tokens.Add("*");
                            tokens.Add("(");
                        }
                        else
                            tokens.Add("(");
                    }
                    else
                        tokens.Add(ch.ToString());
                }

                return tokens;
            }

            private double MathParserLogic(List<string> tokens)
            {
                // Variables replacement
                for (var i = 0; i < tokens.Count; i++)
                {
                    if (LocalVariables.Keys.Contains(tokens[i]))
                        tokens[i] = LocalVariables[tokens[i]].ToString(CultureInfo);
                }

                while (tokens.IndexOf("(") != -1)
                {
                    // getting data between "(" and ")"
                    var open = tokens.LastIndexOf("(");
                    var close = tokens.IndexOf(")", open); // in case open is -1, i.e. no "(" // , open == 0 ? 0 : open - 1

                    if (open >= close)
                        throw new ArithmeticException("No closing bracket/parenthesis. Token: " + open.ToString(CultureInfo));

                    var roughExpr = new List<string>();

                    for (var i = open + 1; i < close; i++)
                        roughExpr.Add(tokens[i]);

                    double tmpResult;

                    var args = new List<double>();
                    var functionName = tokens[open == 0 ? 0 : open - 1];

                    if (LocalFunctions.Keys.Contains(functionName))
                    {
                        if (roughExpr.Contains(","))
                        {
                            // converting all arguments into a decimal array
                            for (var i = 0; i < roughExpr.Count; i++)
                            {
                                var defaultExpr = new List<string>();
                                var firstCommaOrEndOfExpression =
                                    roughExpr.IndexOf(",", i) != -1
                                        ? roughExpr.IndexOf(",", i)
                                        : roughExpr.Count;

                                while (i < firstCommaOrEndOfExpression)
                                    defaultExpr.Add(roughExpr[i++]);

                                args.Add(defaultExpr.Count == 0 ? 0 : BasicArithmeticalExpression(defaultExpr));
                            }

                            // finally, passing the arguments to the given function
                            tmpResult = double.Parse(LocalFunctions[functionName](args.ToArray()).ToString(CultureInfo), CultureInfo);
                        }
                        else
                        {
                            // but if we only have one argument, then we pass it directly to the function
                            tmpResult = double.Parse(LocalFunctions[functionName](new[]
                            {
                            BasicArithmeticalExpression(roughExpr)
                        }).ToString(CultureInfo), CultureInfo);
                        }
                    }
                    else
                    {
                        // if no function is need to execute following expression, pass it
                        // to the "BasicArithmeticalExpression" method.
                        tmpResult = BasicArithmeticalExpression(roughExpr);
                    }

                    // when all the calculations have been done
                    // we replace the "opening bracket with the result"
                    // and removing the rest.
                    tokens[open] = tmpResult.ToString(CultureInfo);
                    tokens.RemoveRange(open + 1, close - open);

                    if (LocalFunctions.Keys.Contains(functionName))
                    {
                        // if we also executed a function, removing
                        // the function name as well.
                        tokens.RemoveAt(open - 1);
                    }
                }

                // at this point, we should have replaced all brackets
                // with the appropriate values, so we can simply
                // calculate the expression. it's not so complex
                // any more!
                return BasicArithmeticalExpression(tokens);
            }

            private double BasicArithmeticalExpression(List<string> tokens)
            {
                // PERFORMING A BASIC ARITHMETICAL EXPRESSION CALCULATION
                // THIS METHOD CAN ONLY OPERATE WITH NUMBERS AND OPERATORS
                // AND WILL NOT UNDERSTAND ANYTHING BEYOND THAT.

                switch (tokens.Count)
                {
                    case 1:
                        return double.Parse(tokens[0], CultureInfo);
                    case 2:
                        var op = tokens[0];

                        if (op == "-" || op == "+")
                        {
                            var first = op == "+" ? "" : (tokens[1].Substring(0, 1) == "-" ? "" : "-");

                            return double.Parse(first + tokens[1], CultureInfo);
                        }

                        return Operators[op](0, double.Parse(tokens[1], CultureInfo));
                    case 0:
                        return 0;
                }

                foreach (var op in Operators)
                {
                    int opPlace;

                    while ((opPlace = tokens.IndexOf(op.Key)) != -1)
                    {
                        var rhs = double.Parse(tokens[opPlace + 1], CultureInfo);

                        if (op.Key == "-" && opPlace == 0)
                        {
                            var result = op.Value(0.0, rhs);
                            tokens[0] = result.ToString(CultureInfo);
                            tokens.RemoveRange(opPlace + 1, 1);
                        }
                        else
                        {
                            var result = op.Value(double.Parse(tokens[opPlace - 1], CultureInfo), rhs);
                            tokens[opPlace - 1] = result.ToString(CultureInfo);
                            tokens.RemoveRange(opPlace, 2);
                        }
                    }
                }

                return double.Parse(tokens[0], CultureInfo);
            }

            #endregion
        }
        public static double SolveEquation(string expression, string result, int limit = 100)
        {
            double addN = 0.01f;
            for (double i = 0; i < limit; i += addN)
            {
                string newExp = expression.ToLower().Replace("x", System.Math.Round(i, 2).ToString());
                double res = System.Math.Round(MathParser.Parse((newExp.Replace(",", "."))), 2);
                if (res == System.Math.Round(MathParser.Parse(result), 2))
                {
                    return System.Math.Round(i, 5);
                }
            }
            return 0f;
        }
        public static bool IsPair(int Number)
        {
            var res = Number % 2;
            if (res != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsPair(double Number)
        {
            var res = Number % 2;
            if (res != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool IsPair(float Number)
        {
            var res = Number % 2;
            if (res != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>Returns a specified number raised to the specified power.</summary>
        /// <returns>The number <paramref name="x" /> raised to the power <paramref name="y" />.</returns>
        /// <param name="x">A double-precision floating-point number to be raised to a power. </param>
        /// <param name="y">A double-precision floating-point number that specifies a power. </param>
        public static double Pow(double x, double y)
        {
            double result = 1d;
            for (int i = 1; i <= y; i++)
            {
                result = x * result;
            }
            return result;
        }
        public static double RootOf(int NumberToGetRoot, int Index = 2, int DecimalPlaces = 0)
        {
            if (NumberToGetRoot < 0 && Index % 2 == 0)
            {
                return 0d;
            }
            string Root = "0";
            int dPlaces = 0;
            //double addN = 0;
            string saddN = "0,1";
            for (int i = 0; i <= NumberToGetRoot; i++)
            {
                if (Math.Pow(i + 1, Index) > NumberToGetRoot)
                {
                    Root = i.ToString();
                    if (DecimalPlaces != 0) { Root += ","; }
                    break;
                }
            }
            if (Math.Pow(double.Parse(Root), Index) == NumberToGetRoot)
                return double.Parse(Root.Replace(",", ""));
            while (dPlaces < DecimalPlaces)
            {
                for (double i = double.Parse(saddN); i < NumberToGetRoot; i += double.Parse(saddN))
                {
                    var next = i + double.Parse(saddN);
                    var sum = next + double.Parse(Root);
                    var power = Math.Pow(sum, Index);
                    if (power > NumberToGetRoot)
                    {
                        Root += (sum - double.Parse(saddN)).ToString().Last().ToString();
                        saddN = saddN.Replace("1", "01");
                        dPlaces++;
                        break;
                    }
                }
            }
            return double.Parse(Root);
        }
        public static string RootOfAsString(int NumberToGetRoot, int Index = 2, int DecimalPlaces = 0)
        {
            if (NumberToGetRoot < 0 && Index % 2 == 0)
            {
                return "0";
            }
            string Root = "0";
            int dPlaces = 0;
            //double addN = 0;
            string saddN = "0,1";
            for (int i = 0; i <= NumberToGetRoot; i++)
            {
                if (Math.Pow(i + 1, Index) > NumberToGetRoot)
                {
                    Root = i.ToString();
                    if (DecimalPlaces != 0) { Root += ","; }
                    break;
                }
            }
            if (Math.Pow(double.Parse(Root), Index) == NumberToGetRoot)
                return Root.Replace(",", "");
            while (dPlaces < DecimalPlaces)
            {
                for (double i = double.Parse(saddN); i < NumberToGetRoot; i += double.Parse(saddN))
                {
                    var next = i + double.Parse(saddN);
                    var sum = next + double.Parse(Root);
                    var power = Math.Pow(sum, Index);
                    if (power > NumberToGetRoot)
                    {
                        Root += (sum - double.Parse(saddN)).ToString().Last().ToString();
                        saddN = saddN.Replace("1", "01");
                        dPlaces++;
                        break;
                    }
                }
            }
            return Root;
        }
        public static string XOR(string HexNumber1, string HexNumber2)
        {
            string[] Hbin1;
            string[] Hbin2;
            if (HexadecimalToBinary(HexNumber2).ToCharArray().Length > HexadecimalToBinary(HexNumber1).ToCharArray().Length)
            {
                Hbin1 = new string[HexadecimalToBinary(HexNumber2).ToCharArray().Length];
                Hbin2 = new string[HexadecimalToBinary(HexNumber2).ToCharArray().Length];
            }
            else
            {
                Hbin1 = new string[HexadecimalToBinary(HexNumber1).ToCharArray().Length];
                Hbin2 = new string[HexadecimalToBinary(HexNumber1).ToCharArray().Length];
            }
            int i = 0;
            foreach (char bit in HexadecimalToBinary(HexNumber1).ToCharArray())
            {
                Hbin1[i] = bit.ToString();
                i++;
            }
            i = 0;
            foreach (char bit in HexadecimalToBinary(HexNumber2).ToCharArray())
            {
                if (i == Hbin2.Length)
                {

                }
                else
                {
                    Hbin2[i] = bit.ToString();
                    i++;
                }
            }
            i = 0;
            string BinaryResult = null;
            string Hbin1Str = null;
            string Hbin2Str = null;
            foreach (string bit in Hbin1)
            {
                Hbin1Str += bit;
            }
            foreach (string bit in Hbin2)
            {
                Hbin2Str += bit;
            }
            string count1 = "0";
            foreach (string bit in Hbin1)
            {
                if (bit != null)
                {
                    count1 = Convert.ToString(Convert.ToInt64(count1) + 1);
                }
            }
            string count2 = "0";
            foreach (string bit in Hbin2)
            {
                if (bit != null)
                {
                    count2 = Convert.ToString(Convert.ToInt64(count2) + 1);
                }
            }
            if (Convert.ToInt32(count1) > Convert.ToInt32(count2))
            {
                while (Hbin2Str.Length != Hbin1Str.Length)
                {
                    Hbin2Str = Hbin2Str.Insert(0, "0");
                }
            }
            else
            {
                while (Hbin1Str.Length != Hbin2Str.Length)
                {
                    Hbin1Str = Hbin1Str.Insert(0, "0");
                }
            }
            foreach (char bit in Hbin1Str.ToCharArray())
            {
                if (bit.ToString() == Hbin2Str.ToCharArray()[i].ToString())
                {
                    string temp = Hbin1Str;
                    string tmp = Hbin2Str;
                    string tp = Hbin2Str.ToCharArray()[i].ToString();
                    BinaryResult += "0";
                    string z = temp + tmp + BinaryResult + bit + tp;
                }
                else
                {
                    string temp = Hbin1Str;
                    string tmp = Hbin2Str;
                    string tp = Hbin2Str.ToCharArray()[i].ToString();
                    BinaryResult += "1";
                    string z = temp + tmp + BinaryResult + bit + tp;
                }
                i++;
            }
            return BinaryToHexadecimal(BinaryResult);
        }
        private static string FromRight(string str, int lenght) => str.Substring(str.Length - lenght);
        public static int MakeNumberPositive(int Number)
        {
            return int.Parse(FromRight(Number.ToString(), Number.ToString().Length - 1));
        }
        public static int GetNumberFactorial(int Number)
        {
            int Factorial = 1;
            for (int i = Number; i > 1; i--)
                Factorial *= i;
            return Factorial;
        }
    }
    namespace IO
    {
        public class DirectoryCopy
        {
            public DirectoryCopy(string src, string dest)
            {
                Src = src;
                Dest = dest;
                new Thread(IndexFiles).Start();
                new Thread(IndexDirectories).Start();
            }
            List<System.IO.FileInfo> files = new List<System.IO.FileInfo>();
            List<System.IO.DirectoryInfo> directories = new List<System.IO.DirectoryInfo>();
            bool doneFiles = false;
            bool doneDirs = false;
            public event ProgressChangedEventHandler CopyComplete;
            public event ProgressChangedEventHandler CopyProgressChanged;
            public string CurrentFileName { get; private set; }
            public int MaxValue = -1;
            string GetNewPath(System.IO.FileInfo src)
            {
                var sdir = new System.IO.DirectoryInfo(Src);
                return System.IO.Path.Combine(new System.IO.DirectoryInfo(Dest).FullName, src.FullName.Substring(sdir.FullName.Length + 1));
            }
            string GetNewPath(System.IO.DirectoryInfo src)
            {
                var sdir = new System.IO.DirectoryInfo(Src);
                return System.IO.Path.Combine(new System.IO.DirectoryInfo(Dest).FullName, src.FullName.Substring(sdir.FullName.Length + 1));
            }
            void Update(int percentage)
            {
                currentProgress = percentage;
                CopyProgressChanged?.Invoke(this, new ProgressChangedEventArgs(percentage, CurrentFileName));
            }
            void Complete()
            {
                CopyComplete?.Invoke(this, new ProgressChangedEventArgs(100, "complete"));
            }
            void IndexFiles()
            {
                files = new System.IO.DirectoryInfo(Src).GetAllFiles().ToList();
                doneFiles = true;
            }

            void IndexDirectories()
            {
                directories = new System.IO.DirectoryInfo(Src).GetAllDirectories().ToList();
                doneDirs = true;
            }

            void CopyDir(object recursive)
            {
                while (doneDirs == false || doneFiles == false) { Thread.Sleep(50); }
                MaxValue = directories.Count + files.Count * 100;
                if (!System.IO.Directory.Exists(Dest))
                    System.IO.Directory.CreateDirectory(Dest);
                else
                {
                    if ((bool)recursive == true)
                    { System.IO.Directory.Delete(Dest, true); System.IO.Directory.CreateDirectory(Dest); }
                    else
                        try { System.IO.Directory.Delete(Dest); } catch { throw; }
                }
                currentProgress = 0;
                foreach (var dir in directories)
                {
                    System.IO.Directory.CreateDirectory(GetNewPath(dir));
                    currentProgress++;
                    Update(currentProgress);
                }
                System.Threading.Thread.Sleep(500);
                var fixedProgress = 0;
                foreach (var file in files)
                {
                    fixedProgress = currentProgress;
                    System.IO.FileStream fsrc = new System.IO.FileStream(file.FullName, System.IO.FileMode.Open);
                    System.IO.FileStream fout = new System.IO.FileStream(GetNewPath(file), System.IO.FileMode.Create);
                    byte[] bt = new byte[1048756];
                    int readByte;
                    while ((readByte = fsrc.Read(bt, 0, bt.Length)) > 0)
                    {
                        fout.Write(bt, 0, readByte);
                        Update(fixedProgress + (int)(fsrc.Position * 100 / fsrc.Length));
                    }
                    fsrc.Close();
                    fout.Close();
                }
                CopyComplete?.Invoke(this, new ProgressChangedEventArgs(currentProgress, "complete"));
            }
            int currentProgress = 0;
            private void File_CopyProgressChanged(object sender, ProgressChangedEventArgs e)
            {
                Update(currentProgress + e.ProgressPercentage);
            }

            void CopyDir() => CopyDir(false);
            public void CopyAsync() => new Thread(new ThreadStart(CopyDir)).Start();
            public void CopyAsync(bool recursive) => new Thread(new ParameterizedThreadStart(CopyDir)).Start(recursive);
            public string Src { get; }
            public string Dest { get; }
        }
        public class FileCopy
        {
            public FileCopy(string src, string dest)
            {
                Src = src;
                Dest = dest;
            }
            public event ProgressChangedEventHandler CopyProgressChanged;
            public event ProgressChangedEventHandler CopyComplete;
            public void CopyAsync() => new Thread(CopyFile).Start();
            void CopyFile()
            {
                System.IO.FileStream fout = new System.IO.FileStream(Dest, System.IO.FileMode.Create);
                System.IO.FileStream fsrc = new System.IO.FileStream(Src, System.IO.FileMode.Open);
                byte[] bt = new byte[1048756];
                int readByte;
                while ((readByte = fsrc.Read(bt, 0, bt.Length)) > 0)
                {
                    fout.Write(bt, 0, readByte);
                    Update((int)(fsrc.Position * 100 / fsrc.Length));
                }
                fsrc.Close();
                fout.Close();
                Done();
            }
            private void Update(int percentage)
            {
                CopyProgressChanged?.Invoke(this, new ProgressChangedEventArgs(percentage, "copying"));
            }
            private void Done()
            {
                CopyComplete?.Invoke(this, new ProgressChangedEventArgs(100, "complete"));
            }
            //public string SrcName { get => new System.IO.FileInfo(Src).Name; }
            //public string DestName { get => new System.IO.FileInfo(Dest).Name; }
            public string Src { get; }
            public string Dest { get; }
        }
        public class HexDumpStream
        {
            readonly string file = null;
            private System.IO.FileStream OpenRead => System.IO.File.Open(file, System.IO.FileMode.Open);
            private System.IO.FileStream OpenWrite => System.IO.File.Open(file, System.IO.FileMode.OpenOrCreate);
            public HexDumpStream(string File)
            {
                file = File;
            }
            public string Checksum(int type, int StartAddress, int EndAddress)
            {
                string Data = ReadMultipleHexValues(StartAddress, EndAddress);
                int result = 0;
                foreach (string bt in Data.Split('-'))
                {
                    int Dec = Converter.HexadecimalToDecimal(bt);
                    result += Dec;
                }
                string hexResult = Converter.DecimalToHexadecimal(result).PadLeft(type / 4, '0');
                if (type == 64)
                {
                    string FinalResult = null;
                    string[] Arr = Converter.ByteStringToByteArray(hexResult);
                    for (int Cur = Arr.Length - 1; Cur >= 0; Cur--)
                    {
                        FinalResult += Arr[Cur];
                    }
                    return FinalResult;
                }
                else
                {
                    return hexResult.Substring(hexResult.Length - type / 4);
                }
            }
            public static string Checksum(int type, string ByteData)
            {
                int result = 0;
                foreach (string bt in ByteStringToByteArray(ByteData))
                {
                    int Dec = HexadecimalToDecimal(bt);
                    result += Dec;
                }
                string hexResult = DecimalToHexadecimal(result).PadLeft(type / 4, '0');
                if (type == 64)
                {
                    string FinalResult = null;
                    string[] Arr = ByteStringToByteArray(hexResult);
                    for (int Cur = Arr.Length - 1; Cur >= 0; Cur--)
                        FinalResult += Arr[Cur];
                    return FinalResult;
                }
                else
                {
                    return hexResult.Substring(hexResult.Length - type / 4);
                }
            }
            public static string XOR(string HexNumber1, string HexNumber2)
            {
                string[] Hbin1;
                string[] Hbin2;
                if (HexadecimalToBinary(HexNumber2).ToCharArray().Length > HexadecimalToBinary(HexNumber1).ToCharArray().Length)
                {
                    Hbin1 = new string[HexadecimalToBinary(HexNumber2).ToCharArray().Length];
                    Hbin2 = new string[HexadecimalToBinary(HexNumber2).ToCharArray().Length];
                }
                else
                {
                    Hbin1 = new string[HexadecimalToBinary(HexNumber1).ToCharArray().Length];
                    Hbin2 = new string[HexadecimalToBinary(HexNumber1).ToCharArray().Length];
                }
                int i = 0;
                foreach (char bit in HexadecimalToBinary(HexNumber1).ToCharArray())
                {
                    Hbin1[i] = bit.ToString();
                    i++;
                }
                i = 0;
                foreach (char bit in HexadecimalToBinary(HexNumber2).ToCharArray())
                {
                    if (i == Hbin2.Length)
                    {

                    }
                    else
                    {
                        Hbin2[i] = bit.ToString();
                        i++;
                    }
                }
                i = 0;
                string BinaryResult = null;
                string Hbin1Str = null;
                string Hbin2Str = null;
                foreach (string bit in Hbin1)
                {
                    Hbin1Str += bit;
                }
                foreach (string bit in Hbin2)
                {
                    Hbin2Str += bit;
                }
                string count1 = "0";
                foreach (string bit in Hbin1)
                {
                    if (bit != null)
                    {
                        count1 = Convert.ToString(Convert.ToInt64(count1) + 1);
                    }
                }
                string count2 = "0";
                foreach (string bit in Hbin2)
                {
                    if (bit != null)
                    {
                        count2 = Convert.ToString(Convert.ToInt64(count2) + 1);
                    }
                }
                if (Convert.ToInt32(count1) > Convert.ToInt32(count2))
                {
                    while (Hbin2Str.Length != Hbin1Str.Length)
                    {
                        Hbin2Str = Hbin2Str.Insert(0, "0");
                    }
                }
                else
                {
                    while (Hbin1Str.Length != Hbin2Str.Length)
                    {
                        Hbin1Str = Hbin1Str.Insert(0, "0");
                    }
                }
                foreach (char bit in Hbin1Str.ToCharArray())
                {
                    if (bit.ToString() == Hbin2Str.ToCharArray()[i].ToString())
                    {
                        string temp = Hbin1Str;
                        string tmp = Hbin2Str;
                        string tp = Hbin2Str.ToCharArray()[i].ToString();
                        BinaryResult += "0";
                        string z = temp + tmp + BinaryResult + bit + tp;
                    }
                    else
                    {
                        string temp = Hbin1Str;
                        string tmp = Hbin2Str;
                        string tp = Hbin2Str.ToCharArray()[i].ToString();
                        BinaryResult += "1";
                        string z = temp + tmp + BinaryResult + bit + tp;
                    }
                    i++;
                }
                return BinaryToHexadecimal(BinaryResult);
            }
            /// <summary>
            /// Fills a block of bytes with the given Pattern (only 2 chars)
            /// </summary>
            /// <param name="StartAddress">Block start address</param>
            /// <param name="EndAddress">Block end address</param>
            /// <param name="Value">Value pattern (2 chars)</param>
            /// <returns>Returns "true" for success and "false" for failure</returns>
            public bool FillBlock(int StartAddress, int EndAddress, string Value)
            {
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(OpenWrite);
                try
                {
                    int length = EndAddress - StartAddress + 1;
                    var v = "";
                    for (int i = 0; i < length; i++)
                        v += Value;
                    writer.BaseStream.Position = StartAddress;
                    writer.Write(GetBuffer(v));
                    writer.Close();
                    return true;
                }
                catch
                {
                    writer.Close();
                    return false;
                }
            }
            /// <summary>
            /// Checks if a block of bytes is all the given pattern (only 2 chars)
            /// </summary>
            /// <param name="StartAddress">Block start address</param>
            /// <param name="EndAddress">Block end address</param>
            /// <param name="Value">Value pattern (2 chars)</param>
            /// <returns></returns>
            public bool CheckBlock(int StartAddress, int EndAddress, string Value)
            {
                int CurAddress = StartAddress;
                if (Value.ToCharArray().Length != 2) { return false; }
                else
                {
                    while (CurAddress != EndAddress + 1)
                    {
                        if (ReadHexValue(CurAddress) != Value)
                        {
                            return false;
                        }
                        CurAddress++;
                    }
                }
                return true;
            }
            /// <summary>
            /// Read a value from the indicated address
            /// </summary>
            /// <param name="Address">The address of the byte to be readed (as 0x00000)</param>
            /// <returns>Returns the value of the bytes in Hexadecimal</returns>
            public string ReadHexValue(int Address, string Side = "Both")
            {
                System.IO.BinaryReader reader = new System.IO.BinaryReader(System.IO.File.OpenRead(file));
                reader.BaseStream.Position = Address;
                string thing = reader.ReadByte().ToString("X2");
                reader.Close();
                switch (Side)
                {
                    case "Left":
                        return thing.Substring(0, 1);
                    case "Right":
                        return thing.Substring(1);
                    default:
                        return thing;
                }
            }
            /// <summary>
            /// Read a value from the indicated address and inverts it
            /// </summary>
            /// <param name="Address">The address of the byte to be readed (as 0x00000)</param>
            /// <returns>Returns the value of the bytes in Hexadecimal</returns>
            public string ReadInvertedHexValue(int Address, string Side = "Both")
            {
                System.IO.BinaryReader reader = new System.IO.BinaryReader(System.IO.File.OpenRead(file));
                reader.BaseStream.Position = Address;
                string thing = reader.ReadByte().ToString("X2");
                reader.Close();
                switch (Side)
                {
                    case "Left":
                        return InvertHexBytes(thing.Substring(0, 1));
                    case "Right":
                        return InvertHexBytes(thing.Substring(1));
                    default:
                        return InvertHexBytes(thing);
                }
            }
            /// <summary>
            /// Reads multiple values from a start address to a end address
            /// </summary>
            /// <param name="StartAddress">The reading start address</param>
            /// <param name="EndAddress">The reading end address</param>
            /// <param name="spliter">(Optional) The char inserted to separed each byte (default = "-")</param>
            /// <returns></returns>
            public string ReadMultipleHexValues(int StartAddress, int EndAddress, string spliter = "-")
            {
                System.IO.BinaryReader reader = new System.IO.BinaryReader(OpenRead);
                reader.BaseStream.Position = StartAddress;
                int length = EndAddress - StartAddress + 1;
                var buffer = reader.ReadBytes(length); reader.Close();
                return ByteBufferToString(buffer);
            }
            /// <summary>
            /// Reads multiple values from a start address to a end address and inverts the values
            /// </summary>
            /// <param name="StartAddress">The reading start address</param>
            /// <param name="EndAddress">The reading end address</param>
            /// <param name="spliter">(Optional) The char inserted to separed each byte (default = "-")</param>
            /// <returns></returns>
            public string ReadMultipleInvertedHexValues(int StartAddress, int EndAddress, string spliter = "-") => ReadMultipleInvertedASCValues(StartAddress, EndAddress, spliter).ToHex();
            /// <summary>
            /// Read the text value form of the indicated address
            /// </summary>
            /// <param name="Address">The address of the byte to be readed (as 0x00000)</param>
            /// <returns>Returns the value of the bytes in Hexadecimal</returns>
            public string ReadASCValue(int Address)
            {
                System.IO.BinaryReader reader = new System.IO.BinaryReader(OpenRead);
                reader.BaseStream.Position = Address;
                var asc = Converter.HexadecimalToText(Converter.DecimalToHexadecimal((int)reader.ReadByte()));
                reader.Close();
                return asc;
            }
            /// <summary>
            /// Read the text value form of the indicated address as inverts it
            /// </summary>
            /// <param name="Address">The address of the byte to be readed (as 0x00000)</param>
            /// <returns>Returns the inverted value of the bytes in Hexadecimal</returns>
            public string ReadInvertedASCValue(int Address)
            {
                System.IO.BinaryReader reader = new System.IO.BinaryReader(System.IO.File.OpenRead(file));
                reader.BaseStream.Position = Address;
                string thing = reader.ReadByte().ToString("X2");
                reader.Close();
                return InvertASCValue(HexadecimalToText(thing));
            }
            private string ByteBufferToString(byte[] buffer)
            {
                var str = "";
                foreach (var b in buffer)
                    str += b.ToString("X2");
                return str;
            }
            /// <summary>
            /// Reads multiple text values from a start address to a end address
            /// </summary>
            /// <param name="StartAddress">The reading start address</param>
            /// <param name="EndAddress">The reading end address</param>
            /// <param name="spliter">(Optional) The char inserted to separed each char (default = null)</param>
            /// <returns></returns>
            public string ReadMultipleASCValues(int StartAddress, int EndAddress, string spliter = "")
            {
                System.IO.BinaryReader reader = new System.IO.BinaryReader(OpenRead);
                reader.BaseStream.Position = StartAddress;
                int length = EndAddress - StartAddress + 1;
                var buffer = reader.ReadBytes(length); reader.Close();
                return HexadecimalToText(ByteBufferToString(buffer));
            }
            /// <summary>
            /// Reads multiple text values from a start address to a end address
            /// </summary>
            /// <param name="StartAddress">The reading start address</param>
            /// <param name="EndAddress">The reading end address</param>
            /// <param name="spliter">(Optional) The char inserted to separed each char (default = null)</param>
            /// <returns></returns>
            public string ReadMultipleInvertedASCValues(int StartAddress, int EndAddress, string spliter = "") => InvertASCValue(ReadMultipleASCValues(StartAddress, EndAddress, spliter));
            /// <summary>
            /// Writes a Hexadecimal value to a file
            /// </summary>
            /// <param name="Address">The address in the file to writen</param>
            /// <param name="Value">(Optional) The value to be writen (default = 0)</param>
            /// <returns>Returns "true" for success; "false" for fail</returns>
            public bool WriteHexValue(int Address, string Value = "0", string Side = "Both")
            {
                try
                {
                    if (Side == "Right")
                    {
                        string LeftSide = HexadecimalToDecimal(ReadHexValue(Address, "Left")).ToString();
                        string RightSide = HexadecimalToDecimal(Value).ToString();
                        string Temp = LeftSide + RightSide;
                        int writeValue = Int32.Parse(Temp);
                        System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.OpenWrite(file));
                        writer.BaseStream.Position = Address;
                        writer.Write(Convert.ToByte(writeValue));
                        writer.Close();
                    }
                    if (Side == "Left")
                    {
                        string RightSide = HexadecimalToDecimal(ReadHexValue(Address, "Right")).ToString();
                        string LeftSide = HexadecimalToDecimal(Value).ToString();
                        string Temp = LeftSide + RightSide;
                        int writeValue = Int32.Parse(Temp);
                        System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.OpenWrite(file));
                        writer.BaseStream.Position = Address;
                        writer.Write(Convert.ToByte(writeValue));
                        writer.Close();
                    }
                    else
                    {
                        System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.OpenWrite(file));
                        writer.BaseStream.Position = Address;
                        writer.Write(Convert.ToByte(HexadecimalToDecimal(Value)));
                        writer.Close();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            /// <summary>
            /// Writes a inverted Hexadecimal value to a file
            /// </summary>
            /// <param name="Address">The address in the file to writen</param>
            /// <param name="Value">(Optional) The value to be writen (default = 0)</param>
            /// <returns>Returns "true" for success; "false" for fail</returns>
            public bool WriteInvertedHexValue(int Address, string Value = "0", string Side = "Both")
            {
                try
                {
                    if (Side == "Right")
                    {
                        string LeftSide = HexadecimalToDecimal(ReadHexValue(Address, "Left")).ToString();
                        string RightSide = HexadecimalToDecimal(Value).ToString();
                        string Temp = LeftSide + RightSide;
                        System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.OpenWrite(file));
                        writer.BaseStream.Position = Address;
                        writer.Write(Convert.ToByte(HexadecimalToDecimal(InvertHexBytes(Temp))));
                        writer.Close();
                    }
                    if (Side == "Left")
                    {
                        string RightSide = HexadecimalToDecimal(ReadHexValue(Address, "Right")).ToString();
                        string LeftSide = HexadecimalToDecimal(Value).ToString();
                        string Temp = LeftSide + RightSide;
                        System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.OpenWrite(file));
                        writer.BaseStream.Position = Address;
                        writer.Write(Convert.ToByte(HexadecimalToDecimal(InvertHexBytes(Temp))));
                        writer.Close();
                    }
                    else
                    {
                        System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.OpenWrite(file));
                        writer.BaseStream.Position = Address;
                        writer.Write(Convert.ToByte(HexadecimalToDecimal(InvertHexBytes(Value))));
                        writer.Close();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            /// <summary>
            /// Writes a ASCII value to a file
            /// </summary>
            /// <param name="Address">The address in the file to writen</param>
            /// <param name="Value">(Optional) The value to be writen (default = 0)</param>
            /// <returns>Returns "true" for success; "false" for fail</returns>
            public bool WriteASCValue(int Address, string Value = "0")
            {
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.OpenWrite(file));
                try
                {
                    writer.BaseStream.Position = Address;
                    writer.Write(Convert.ToByte(HexadecimalToDecimal(TextToHexadecimal(Value))));
                    writer.Close();
                    return true;
                }
                catch
                {
                    writer.Close();
                    return false;
                }
            }
            /// <summary>
            /// Writes a inverted ASCII value to a file
            /// </summary>
            /// <param name="Address">The address in the file to writen</param>
            /// <param name="Value">(Optional) The value to be writen (default = 0)</param>
            /// <returns>Returns "true" for success; "false" for fail</returns>
            public bool WriteInvertedASCValue(int Address, string Value = "0")
            {
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.OpenWrite(file));
                try
                {
                    writer.BaseStream.Position = Address;
                    writer.Write(Convert.ToByte(HexadecimalToDecimal(TextToHexadecimal(InvertASCValue(Value)))));
                    writer.Close();
                    return true;
                }
                catch
                {
                    writer.Close();
                    return false;
                }
            }
            /// <summary>
            /// Gets the total ammount of addresses
            /// </summary>
            /// <returns>Returns the total ammount of address in hexadecimal</returns>
            public string TotalAddresses
            {
                get
                {
                    using (System.IO.BinaryReader reader = new System.IO.BinaryReader(OpenRead))
                        return Convert.ToString(reader.BaseStream.Length - 1, 16).ToUpper();
                }
            }
            /// <summary>
            /// Swaps the byte in the specified address or if address not defined swaps every single byte in the archive
            /// </summary>
            /// <param name="Address">The byte address to swap</param>
            /// <returns>Returns the swaped bytes</returns>
            public string SwapBytes(int Address = -1)
            {
                string SwapedBytes = null;
                int CurAddress = 0;
                if (Address != -1)
                {
                    string bts = ReadHexValue(Address);
                    WriteHexValue(Address, SwapHexBytes(bts));
                    return SwapHexBytes(bts);
                }
                foreach (string bt in ReadAll().Split(' '))
                {
                    string SwapedByte = SwapHexBytes(bt);
                    SwapedBytes += SwapHexBytes(bt) + " ";
                    WriteHexValue(CurAddress, SwapedByte);
                    CurAddress++;
                }
                return SwapedBytes;
            }
            /// <summary>
            /// If addresses not defined swaps every single byte in the archive
            /// </summary>
            /// <param name="Address">The byte address to swap</param>
            /// <returns>Returns the swaped bytes</returns>
            public void SwapBytesPair(int Address = -1, int SecondAddress = -1)
            {
                int CurAddress = 0;
                if (Address != -1 && SecondAddress != -1)
                {
                    string bts = ReadHexValue(SecondAddress) + ReadHexValue(Address);
                    string[] swBts = ByteStringToByteArray(bts);
                    WriteHexValue(Address, swBts[0]);
                    WriteHexValue(SecondAddress, swBts[1]);
                }
                else
                {
                    foreach (string bt in ReadAll(16).Split('\n'))
                    {
                        string SwapedByte = SwapHexBytesPair(bt.Replace(" ", ""));
                        WriteMultipleHexValues(CurAddress, SwapedByte);
                        CurAddress += 16;
                    }
                }
            }
            public string InvertBytes(int StartAddress, int EndAddress)
            {
                string ret = "";
                for (int i = StartAddress; i <= EndAddress; i++)
                {
                    ret += InvertBytes(i);
                }
                return ret;
            }
            /// <summary>
            /// Inverts the byte in the specified address or if address not defined inverts every single byte in the archive
            /// </summary>
            /// <param name="Address">The byte address to invert</param>
            /// <returns>Returns the inverted bytes (Optional)</returns>
            public string InvertBytes(int Address = -1)
            {
                string InvBytes = null;
                int CurAddress = 0;
                if (Address != -1)
                {
                    string bts = ReadHexValue(Address);
                    WriteHexValue(Address, InvertHexBytes(bts));
                    return InvertHexBytes(bts);
                }
                foreach (string bt in ReadAll().Split(' '))
                {
                    string InvByte = Converter.InvertHexBytes(bt);
                    InvBytes += InvertHexBytes(bt) + " ";
                    WriteHexValue(CurAddress, InvByte);
                    CurAddress++;
                }
                return InvBytes;
            }
            public string ReadAll(int bytesPerColumn, string spliter = " ")
            {
                var bts = ReadAll(spliter);
                if (bts.Length % 2 != 0)
                    bts = "0" + bts;
                var newBytes = "";
                var cc = 1;
                for (int i = 0; i < bts.Length; i += 2)
                { newBytes += bts.Substring(i, 2); if (cc == bytesPerColumn) { newBytes += '\n'; cc = 1; } else { newBytes += spliter; cc++; } }
                return newBytes;
            }
            /// <summary>
            /// Reads all bytes in the archive
            /// </summary>
            /// <param name="spliter">The spliter between each byte (default = ' ')</param>
            /// <returns>Returns all bytes read</returns>
            public string ReadAll(string spliter = " ")
            {
                System.IO.BinaryReader reader = new System.IO.BinaryReader(OpenRead);
                var bytes = reader.ReadBytes(reader.BaseStream.Length.ToString().ToInt());
                reader.Close();
                var bts = "";
                foreach (var b in bytes)
                    bts += b.ToString("X2") + spliter;
                return bts.Substring(0, bts.Length - 1);
            }
            private byte[] GetBuffer(string bytes)
            {
                List<byte> bts = new List<byte>();
                var b = bytes.Replace(" ", "").Replace("-", "").Replace("\r", "");
                if (b.Length % 2 != 0)
                    b = "0" + b;
                for (int i = 0; i < b.Length; i += 2)
                    bts.Add((byte)Convert.ToInt32(b.Substring(i, 2), 16));
                return bts.ToArray();
            }
            /// <summary>
            /// Writes a string of Hexadecimal values to a file
            /// </summary>
            /// <param name="Address">The write address</param>
            /// <param name="Value">The hex string value to be writen</param>
            /// <returns>Returns "true" for success; "false" for fail</returns>
            public bool WriteMultipleHexValues(int Address, string Value)
            {
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(OpenWrite);
                try
                {

                    writer.BaseStream.Position = Address;
                    writer.Write(GetBuffer(Value));
                    writer.Close();
                    return true;
                }
                catch
                {
                    writer.Close();
                    return false;
                }
            }
            /// <summary>
            /// Writes a string of inverted Hexadecimal values to a file
            /// </summary>
            /// <param name="StartAddress">The write start address</param>
            /// <param name="EndAddress">The write end address</param>
            /// <param name="Value">The hex string value to be writen</param>
            /// <returns>Returns "true" for success; "false" for fail</returns>
            public bool WriteMultipleInvertedHexValues(int Address, string Value)
            {
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(System.IO.File.OpenWrite(file));
                try
                {
                    writer.BaseStream.Position = Address;
                    writer.Write(GetBuffer(InvertHexBytes(Value)));
                    writer.Close();
                    return true;
                }
                catch
                {
                    writer.Close();
                    return false;
                }
            }
            public bool WriteMultipleASCValues(int Address, string Value)
            {
                try
                {
                    WriteMultipleHexValues(Address, TextToHexadecimal(Value));
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            /// <summary>
            /// Writes a string of inverted ASCII values to a file
            /// </summary>
            /// <param name="StartAddress">The write start address</param>
            /// <param name="EndAddress">The write end address</param>
            /// <param name="Value">The ASCII string value to be writen</param>
            /// <returns>Returns "true" for success; "false" for fail</returns>
            public bool WriteMultipleInvertedASCValues(int Address, string Value)
            {
                try
                {
                    WriteMultipleInvertedHexValues(Address, TextToHexadecimal(Value));
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        class ProccessMemoryReaderApi
        {
            // constants information can be found in <winnt.h>
            [Flags]
            public enum ProcessAccessType
            {
                PROCESS_TERMINATE = (0x0001),
                PROCESS_CREATE_THREAD = (0x0002),
                PROCESS_SET_SESSIONID = (0x0004),
                PROCESS_VM_OPERATION = (0x0008),
                PROCESS_VM_READ = (0x0010),
                PROCESS_VM_WRITE = (0x0020),
                PROCESS_DUP_HANDLE = (0x0040),
                PROCESS_CREATE_PROCESS = (0x0080),
                PROCESS_SET_QUOTA = (0x0100),
                PROCESS_SET_INFORMATION = (0x0200),
                PROCESS_QUERY_INFORMATION = (0x0400),
                PROCESS_QUERY_LIMITED_INFORMATION = (0x1000)
            }

            // function declarations are found in the MSDN and in <winbase.h> 

            //		HANDLE OpenProcess(
            //			DWORD dwDesiredAccess,  // access flag
            //			BOOL bInheritHandle,    // handle inheritance option
            //			DWORD dwProcessId       // process identifier
            //			);
            [DllImport("kernel32.dll")]
            public static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, Int32 bInheritHandle, UInt32 dwProcessId);

            //		BOOL CloseHandle(
            //			HANDLE hObject   // handle to object
            //			);
            [DllImport("kernel32.dll")]
            public static extern Int32 CloseHandle(IntPtr hObject);

            //		BOOL ReadProcessMemory(
            //			HANDLE hProcess,              // handle to the process
            //			LPCVOID lpBaseAddress,        // base of memory area
            //			LPVOID lpBuffer,              // data buffer
            //			SIZE_T nSize,                 // number of bytes to read
            //			SIZE_T * lpNumberOfBytesRead  // number of bytes read
            //			);
            [DllImport("kernel32.dll")]
            public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

            //		BOOL WriteProcessMemory(
            //			HANDLE hProcess,                // handle to process
            //			LPVOID lpBaseAddress,           // base of memory area
            //			LPCVOID lpBuffer,               // data buffer
            //			SIZE_T nSize,                   // count of bytes to write
            //			SIZE_T * lpNumberOfBytesWritten // count of bytes written
            //			);
            [DllImport("kernel32.dll")]
            public static extern Int32 WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);
        }
        public class Memory
        {
            public uint ReadMemory(string ProccessName, int Address, uint BytesToRead, int ProccessModule = 0)
            {
                System.Diagnostics.Process process = System.Diagnostics.Process.GetProcessesByName(ProccessName).ToList().FirstOrDefault();
                ProccessMemoryReader mreader = new ProccessMemoryReader();
                if (process != null)
                {
                    mreader.ReadProcess = process;
                    mreader.OpenProccess();
                    uint result = BitConverter.ToUInt32(mreader.ReadMemory((IntPtr)(Address + (uint)process.Modules[ProccessModule].BaseAddress), BytesToRead, out _), 0);
                    mreader.CloseHandle();
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            public string WriteMemory(int Address, string ProccessName, int BytesToWrite, int ProccessModule = 0)
            {
                System.Diagnostics.Process process = System.Diagnostics.Process.GetProcessesByName(ProccessName).ToList().FirstOrDefault();
                ProccessMemoryReader mreader = new ProccessMemoryReader();
                if (process != null)
                {
                    mreader.ReadProcess = process;
                    mreader.OpenProccess();
                    mreader.WriteMemory((IntPtr)(Address + (uint)process.Modules[ProccessModule].BaseAddress), BitConverter.GetBytes(BytesToWrite), out int bytesWritten);
                    mreader.CloseHandle();
                    return bytesWritten.ToString();
                }
                else
                {
                    return "Failed";
                }
            }
        }
        public class ProccessMemoryReader
        {
            public System.Diagnostics.Process ReadProcess { get; set; }

            private IntPtr handle;
            public void OpenProccess()
            {
                ProccessMemoryReaderApi.ProcessAccessType access = ProccessMemoryReaderApi.ProcessAccessType.PROCESS_QUERY_INFORMATION |
                    ProccessMemoryReaderApi.ProcessAccessType.PROCESS_VM_READ |
                    ProccessMemoryReaderApi.ProcessAccessType.PROCESS_VM_WRITE |
                    ProccessMemoryReaderApi.ProcessAccessType.PROCESS_VM_OPERATION;
                handle = ProccessMemoryReaderApi.OpenProcess((uint)access, 1, (uint)ReadProcess.Id);
            }
            public void CloseHandle()
            {
                int returnValue = ProccessMemoryReaderApi.CloseHandle(handle);
                if (returnValue != 0)
                    throw new Exception("Closing handle failed.");
            }
            public byte[] ReadMemory(IntPtr memoryAddress, uint bytesToRead, out int bytesRead)
            {
                byte[] buffer = new byte[bytesToRead];
                ProccessMemoryReaderApi.ReadProcessMemory(handle, memoryAddress, buffer, bytesToRead, out var pBytesRead);
                bytesRead = pBytesRead.ToInt32();
                return buffer;
            }
            public void WriteMemory(IntPtr memoryAddress, byte[] buffer, out int bytesWritten)
            {
                ProccessMemoryReaderApi.WriteProcessMemory(handle, memoryAddress, buffer, (uint)buffer.Length, out IntPtr pBytesWritten);
                bytesWritten = pBytesWritten.ToInt32();
            }
        }
    }
    namespace Info
    {
        public static class UserInfo
        {
            public static bool IsAuthenticated()
            {
                return System.Threading.Thread.CurrentPrincipal.Identity.IsAuthenticated;
            }
            public static string UserName()
            {
                return System.Threading.Thread.CurrentPrincipal.Identity.Name;
            }
        }
        public static class HDInfo
        {
            public static long GetAvaliableFreeStorage(string DriveLetter)
            {
                System.IO.DriveInfo HD = new System.IO.DriveInfo(DriveLetter);
                return HD.AvailableFreeSpace;
            }
            public static string GetDriveFormat(string DriveLetter)
            {
                System.IO.DriveInfo HD = new System.IO.DriveInfo(DriveLetter);
                return HD.DriveFormat;
            }
            public static System.IO.DriveType GetDriveType(string DriveLetter)
            {
                System.IO.DriveInfo HD = new System.IO.DriveInfo(DriveLetter);
                return HD.DriveType;
            }
            public static bool IsReady(string DriveLetter)
            {
                System.IO.DriveInfo HD = new System.IO.DriveInfo(DriveLetter);
                return HD.IsReady;
            }
            public static string GetName(string DriveLetter)
            {
                System.IO.DriveInfo HD = new System.IO.DriveInfo(DriveLetter);
                return HD.Name;
            }
            public static System.IO.DirectoryInfo GetRootDirectory(string DriveLetter)
            {
                System.IO.DriveInfo HD = new System.IO.DriveInfo(DriveLetter);
                return HD.RootDirectory;
            }
            public static long GetTotalFreeSpace(string DriveLetter)
            {
                System.IO.DriveInfo HD = new System.IO.DriveInfo(DriveLetter);
                return HD.TotalFreeSpace;
            }
            public static long GetTotalSize(string DriveLetter)
            {
                System.IO.DriveInfo HD = new System.IO.DriveInfo(DriveLetter);
                return HD.TotalSize;
            }
            public static string GetVolumeLabel(string DriveLetter)
            {
                System.IO.DriveInfo HD = new System.IO.DriveInfo(DriveLetter);
                return HD.VolumeLabel;
            }
            public static void SetVolumeLabel(string DriveLetter, string VolumeLabel)
            {
#pragma warning disable IDE0017 // Simplificar a inicialização de objeto
                System.IO.DriveInfo HD = new System.IO.DriveInfo(DriveLetter);
#pragma warning restore IDE0017 // Simplificar a inicialização de objeto
                HD.VolumeLabel = VolumeLabel;
            }
        }
        public static class DirectoryInfo
        {
            public static System.Security.AccessControl.DirectorySecurity GetAccessControl(string DirectoryPath)
            {
                return System.IO.Directory.GetAccessControl(DirectoryPath);
            }
            public static System.IO.FileAttributes GetAttributes(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.Attributes;
            }
            public static DateTime GetCreationTime(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.CreationTime;
            }
            public static DateTime GetCreationTimeUtc(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.CreationTimeUtc;
            }
            public static string GetExtension(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.Extension;
            }
            public static string GetFullName(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.FullName;
            }
            public static DateTime GetLastAccessTime(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.LastAccessTime;
            }
            public static DateTime GetLastAccessTimeUtc(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.LastAccessTimeUtc;
            }
            public static DateTime GetLastWriteTime(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.LastWriteTime;
            }
            public static DateTime GetLastWriteTimeUtc(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.LastWriteTimeUtc;
            }
            public static string GetName(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.Name;
            }
            public static System.IO.DirectoryInfo GetParentDirectory(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.Parent;
            }
            public static System.IO.DirectoryInfo GetRootDirectory(string DirectoryPath)
            {
                System.IO.DirectoryInfo DirInfo = new System.IO.DirectoryInfo(DirectoryPath);
                return DirInfo.Root;
            }
            public static string[] GetFiles(string DirectoryPath)
            {
                return System.IO.Directory.GetFiles(DirectoryPath);
            }
            public static string[] GetDirectories(string DirectoryPath)
            {
                return System.IO.Directory.GetDirectories(DirectoryPath);
            }
            public static void SetAccessControl(string DirectoryPath, System.Security.AccessControl.DirectorySecurity DirectorySecurity)
            {
                System.IO.Directory.SetAccessControl(DirectoryPath, DirectorySecurity);
            }
            public static void SetCreationTime(string DirectoryPath, DateTime CreationTime)
            {
                System.IO.Directory.SetCreationTime(DirectoryPath, CreationTime);
            }
            public static void SetCreationTimeUtc(string DirectoryPath, DateTime CreationTimeUtc)
            {
                System.IO.Directory.SetCreationTimeUtc(DirectoryPath, CreationTimeUtc);
            }
            public static void SetCurrentDirectory(string Path)
            {
                System.IO.Directory.SetCurrentDirectory(Path);
            }
            public static void SetLastAcessTime(string DirectoryPath, DateTime LastAccessTime)
            {
                System.IO.Directory.SetLastAccessTime(DirectoryPath, LastAccessTime);
            }
            public static void SetLastAcessTimeUtc(string DirectoryPath, DateTime LastAccessTimeUtc)
            {
                System.IO.Directory.SetLastAccessTime(DirectoryPath, LastAccessTimeUtc);
            }
            public static void SetLastWriteTime(string DirectoryPath, DateTime LastWriteTime)
            {
                System.IO.Directory.SetLastWriteTime(DirectoryPath, LastWriteTime);
            }
            public static void SetLastWriteTimeUtc(string DirectoryPath, DateTime LastWriteTimeUtc)
            {
                System.IO.Directory.SetLastWriteTimeUtc(DirectoryPath, LastWriteTimeUtc);
            }
        }
        public enum HashingAlgorithm
        {
            MD5 = 1,
            SHA1 = 2,
            SHA256 = 3,
            SHA384 = 4,
            SHA512 = 5
        }
        public static class FileInfo
        {
            public static void SetAttributes(string Path, params System.IO.FileAttributes[] attributes)
            {
                System.IO.FileAttributes atr = attributes[0];
                bool first = true;
                foreach (System.IO.FileAttributes attribute in attributes)
                {
                    if (first) { atr = attribute; first = false; } else { atr |= attribute; }
                }
                System.IO.File.SetAttributes(Path, atr);
            }
            public static System.Collections.Generic.List<System.IO.FileAttributes> GetAttributes(string Path)
            {
                System.Collections.Generic.List<System.IO.FileAttributes> rAtr = new System.Collections.Generic.List<System.IO.FileAttributes>();
                var atr = System.IO.File.GetAttributes(Path);
                if (atr.HasFlag(System.IO.FileAttributes.Archive)) { rAtr.Add(System.IO.FileAttributes.Archive); }
                if (atr.HasFlag(System.IO.FileAttributes.Compressed)) { rAtr.Add(System.IO.FileAttributes.Compressed); }
                if (atr.HasFlag(System.IO.FileAttributes.Device)) { rAtr.Add(System.IO.FileAttributes.Device); }
                if (atr.HasFlag(System.IO.FileAttributes.Directory)) { rAtr.Add(System.IO.FileAttributes.Directory); }
                if (atr.HasFlag(System.IO.FileAttributes.Encrypted)) { rAtr.Add(System.IO.FileAttributes.Encrypted); }
                if (atr.HasFlag(System.IO.FileAttributes.Hidden)) { rAtr.Add(System.IO.FileAttributes.Hidden); }
                if (atr.HasFlag(System.IO.FileAttributes.Normal)) { rAtr.Add(System.IO.FileAttributes.Normal); }
                if (atr.HasFlag(System.IO.FileAttributes.NotContentIndexed)) { rAtr.Add(System.IO.FileAttributes.NotContentIndexed); }
                if (atr.HasFlag(System.IO.FileAttributes.Offline)) { rAtr.Add(System.IO.FileAttributes.Offline); }
                if (atr.HasFlag(System.IO.FileAttributes.ReadOnly)) { rAtr.Add(System.IO.FileAttributes.ReadOnly); }
                if (atr.HasFlag(System.IO.FileAttributes.ReparsePoint)) { rAtr.Add(System.IO.FileAttributes.ReparsePoint); }
                if (atr.HasFlag(System.IO.FileAttributes.SparseFile)) { rAtr.Add(System.IO.FileAttributes.SparseFile); }
                if (atr.HasFlag(System.IO.FileAttributes.System)) { rAtr.Add(System.IO.FileAttributes.System); }
                if (atr.HasFlag(System.IO.FileAttributes.Temporary)) { rAtr.Add(System.IO.FileAttributes.Temporary); }
                return rAtr;
            }
            /// <summary>
            /// This function compares the data of two files and returns 'true' if they are equal and 'false' if they are different.
            /// </summary>
            /// <returns></returns>
            public static bool CompareFiles(string firstFile, string secondFile)
            {
                if (new CSharpExtendedCommands.IO.HexDumpStream(firstFile).ReadAll() == new CSharpExtendedCommands.IO.HexDumpStream(secondFile).ReadAll()) { return true; } else { return false; }
            }
            public static string GetFileHash(string File, HashingAlgorithm algorithm)
            {
                if (algorithm == HashingAlgorithm.MD5)
                {
                    string filePath = File;
                    byte[] buffer;
                    int bytesRead;
                    long size;
                    long totalBytesRead = 0;
                    using (System.IO.Stream file = System.IO.File.OpenRead(filePath))
                    {
                        size = file.Length;
                        using (System.Security.Cryptography.HashAlgorithm hasher = System.Security.Cryptography.MD5.Create())
                        {
                            do
                            {
                                buffer = new byte[4096];
                                bytesRead = file.Read(buffer, 0, buffer.Length);
                                totalBytesRead += bytesRead;
                                hasher.TransformBlock(buffer, 0, bytesRead, null, 0);
                            } while (bytesRead != 0);
                            hasher.TransformFinalBlock(buffer, 0, 0);
                            StringBuilder builder = new StringBuilder(40);
                            foreach (byte b in hasher.Hash)
                            {
                                builder.Append(b.ToString("X2").ToLower());
                            }
                            return builder.ToString();
                        }
                    }
                }
                else if (algorithm == HashingAlgorithm.SHA1)
                {
                    string filePath = File;
                    byte[] buffer;
                    int bytesRead;
                    long size;
                    long totalBytesRead = 0;
                    using (System.IO.Stream file = System.IO.File.OpenRead(filePath))
                    {
                        size = file.Length;
                        using (System.Security.Cryptography.HashAlgorithm hasher = System.Security.Cryptography.SHA1.Create())
                        {
                            do
                            {
                                buffer = new byte[4096];
                                bytesRead = file.Read(buffer, 0, buffer.Length);
                                totalBytesRead += bytesRead;
                                hasher.TransformBlock(buffer, 0, bytesRead, null, 0);
                            } while (bytesRead != 0);
                            hasher.TransformFinalBlock(buffer, 0, 0);
                            StringBuilder builder = new StringBuilder(40);
                            foreach (byte b in hasher.Hash)
                            {
                                builder.Append(b.ToString("X2").ToLower());
                            }
                            return builder.ToString();
                        }
                    }
                }
                else if (algorithm == HashingAlgorithm.SHA256)
                {
                    string filePath = File;
                    byte[] buffer;
                    int bytesRead;
                    long size;
                    long totalBytesRead = 0;
                    using (System.IO.Stream file = System.IO.File.OpenRead(filePath))
                    {
                        size = file.Length;
                        using (System.Security.Cryptography.HashAlgorithm hasher = System.Security.Cryptography.SHA256.Create())
                        {
                            do
                            {
                                buffer = new byte[4096];
                                bytesRead = file.Read(buffer, 0, buffer.Length);
                                totalBytesRead += bytesRead;
                                hasher.TransformBlock(buffer, 0, bytesRead, null, 0);
                            } while (bytesRead != 0);
                            hasher.TransformFinalBlock(buffer, 0, 0);
                            StringBuilder builder = new StringBuilder(40);
                            foreach (byte b in hasher.Hash)
                            {
                                builder.Append(b.ToString("X2").ToLower());
                            }
                            return builder.ToString();
                        }
                    }
                }
                else if (algorithm == HashingAlgorithm.SHA384)
                {
                    string filePath = File;
                    byte[] buffer;
                    int bytesRead;
                    long size;
                    long totalBytesRead = 0;
                    using (System.IO.Stream file = System.IO.File.OpenRead(filePath))
                    {
                        size = file.Length;
                        using (System.Security.Cryptography.HashAlgorithm hasher = System.Security.Cryptography.SHA384.Create())
                        {
                            do
                            {
                                buffer = new byte[4096];
                                bytesRead = file.Read(buffer, 0, buffer.Length);
                                totalBytesRead += bytesRead;
                                hasher.TransformBlock(buffer, 0, bytesRead, null, 0);
                            } while (bytesRead != 0);
                            hasher.TransformFinalBlock(buffer, 0, 0);
                            StringBuilder builder = new StringBuilder(40);
                            foreach (byte b in hasher.Hash)
                            {
                                builder.Append(b.ToString("X2").ToLower());
                            }
                            return builder.ToString();
                        }
                    }
                }
                else if (algorithm == HashingAlgorithm.SHA512)
                {
                    string filePath = File;
                    byte[] buffer;
                    int bytesRead;
                    long size;
                    long totalBytesRead = 0;
                    using (System.IO.Stream file = System.IO.File.OpenRead(filePath))
                    {
                        size = file.Length;
                        using (System.Security.Cryptography.HashAlgorithm hasher = System.Security.Cryptography.SHA512.Create())
                        {
                            do
                            {
                                buffer = new byte[4096];
                                bytesRead = file.Read(buffer, 0, buffer.Length);
                                totalBytesRead += bytesRead;
                                hasher.TransformBlock(buffer, 0, bytesRead, null, 0);
                            } while (bytesRead != 0);
                            hasher.TransformFinalBlock(buffer, 0, 0);
                            StringBuilder builder = new StringBuilder(40);
                            foreach (byte b in hasher.Hash)
                            {
                                builder.Append(b.ToString("X2").ToLower());
                            }
                            return builder.ToString();
                        }
                    }
                }
                return null;
            }
            public static System.Security.AccessControl.FileSecurity GetAccessControl(string FilePath)
            {
                return System.IO.File.GetAccessControl(FilePath);
            }
            public static DateTime GetCreationTime(string FilePath)
            {
                return System.IO.File.GetCreationTime(FilePath);
            }
            public static DateTime GetCreationTimeUtc(string FilePath)
            {
                return System.IO.File.GetCreationTimeUtc(FilePath);
            }
            public static string GetParentDirectory(string FilePath)
            {
                System.IO.FileInfo FileInf = new System.IO.FileInfo(FilePath);
                return FileInf.DirectoryName;
            }
            private static string FromLeft(string v, int lenght) => v.Substring(0, lenght);
            public static string AddToFileName(string FilePath, string ExtraThings)
            {
                return FromLeft(FilePath, FilePath.Length - GetExtension(FilePath).Length) + ExtraThings + GetExtension(FilePath);
            }
            public static string GetNameWithoutExtension(string FilePath)
            {
                return System.IO.Path.GetFileNameWithoutExtension(FilePath);
            }
            public static string GetExtension(string FilePath)
            {
                System.IO.FileInfo FileInf = new System.IO.FileInfo(FilePath);
                return FileInf.Extension;
            }
            public static string GetFullName(string FilePath)
            {
                System.IO.FileInfo FileInf = new System.IO.FileInfo(FilePath);
                return FileInf.FullName;
            }
            public static DateTime GetLastAccessTime(string FilePath)
            {
                return System.IO.File.GetLastAccessTime(FilePath);
            }
            public static DateTime GetLastAccessTimeUtc(string FilePath)
            {
                return System.IO.File.GetLastAccessTimeUtc(FilePath);
            }
            public static DateTime GetLastWriteTime(string FilePath)
            {
                return System.IO.File.GetLastWriteTime(FilePath);
            }
            public static DateTime GetLastWriteTimeUtc(string FilePath)
            {
                return System.IO.File.GetLastWriteTimeUtc(FilePath);
            }
            public static long GetSize(string FilePath)
            {
                System.IO.FileInfo FileInf = new System.IO.FileInfo(FilePath);
                return FileInf.Length;
            }
            public static Icon GetAssociatedIcon(string FilePath)
            {
                return Icon.ExtractAssociatedIcon(FilePath);
            }
            public static string GetName(string FilePath)
            {
                System.IO.FileInfo FileInf = new System.IO.FileInfo(FilePath);
                return FileInf.Name;
            }
            public static void SetAccessControl(string FilePath, System.Security.AccessControl.FileSecurity FileSecurity)
            {
                System.IO.File.SetAccessControl(FilePath, FileSecurity);
            }
            public static void SetAttributes(string FilePath, System.IO.FileAttributes Attributes)
            {
                System.IO.File.SetAttributes(FilePath, Attributes);
            }
            public static void SetCreationTime(string FilePath, DateTime CreationTime)
            {
                System.IO.File.SetCreationTime(FilePath, CreationTime);
            }
            public static void SetCreationTimeUtc(string FilePath, DateTime CreationTimeUtc)
            {
                System.IO.File.SetCreationTimeUtc(FilePath, CreationTimeUtc);
            }
            public static void SetLastAccessTime(string FilePath, DateTime LastAccessTime)
            {
                System.IO.File.SetLastAccessTime(FilePath, LastAccessTime);
            }
            public static void SetLastAccessTimeUtc(string FilePath, DateTime LastAccessTimeUtc)
            {
                System.IO.File.SetLastAccessTimeUtc(FilePath, LastAccessTimeUtc);
            }
            public static void SetLastWriteTime(string FilePath, DateTime LastWriteTime)
            {
                System.IO.File.SetLastWriteTime(FilePath, LastWriteTime);
            }
            public static void SetLastWriteTimeUtc(string FilePath, DateTime LastWriteTimeUtc)
            {
                System.IO.File.SetLastWriteTimeUtc(FilePath, LastWriteTimeUtc);
            }
        }
        public static partial class ComputerInfo
        {
            public static string Name { get => Environment.MachineName; }

            public static IPAddress[] LocalAddressList
            {
                get => System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList;
            }
            public static string ComputerHWID(bool Encrypted = false)
            {
                string hdd;
                string hwid;

                hdd = GetVolumeSerial("C");
                hwid = ProcessorId + hdd + MotherBoardID + MACAddress;
                Data.Cryptography.Hasher hash = new Data.Cryptography.Hasher();
                string hwidEncrypted = Convert.ToString(hash.MD5Hash(hwid)).ToUpper();
                if (Encrypted == true)
                {
                    return hwidEncrypted;
                }
                else
                {
                    return hwid;
                }
            }
            public static string ProcessorId
            {
                get
                {
                    string strProcessorId = string.Empty;
                    SelectQuery query = new SelectQuery("Win32_processor");
                    ManagementObjectSearcher search = new ManagementObjectSearcher(query);
                    foreach (ManagementObject info in search.Get())
                    {
                        strProcessorId = info["processorId"].ToString();
                    }
                    return strProcessorId;
                }
            }
            public static string MACAddress
            {
                get
                {
                    ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                    ManagementObjectCollection moc = mc.GetInstances();
                    string MACAddress = string.Empty;
                    foreach (ManagementObject mo in moc)
                    {
                        if (MACAddress.Equals(string.Empty))
                        {
                            if (Convert.ToBoolean(mo["IPEnabled"]))
                            {
                                MACAddress = mo["MacAddress"].ToString();
                            }
                            mo.Dispose();
                        }
                        MACAddress = MACAddress.Replace(":", string.Empty);
                    }
                    return MACAddress;
                }
            }
            public static string GetVolumeSerial(string strDriveLetter = "C")
            {
                ManagementObject disk = new ManagementObject(string.Format("win32_logicaldisk.deviceid=\"{0}:\"", strDriveLetter));
                disk.Get();
                return disk["VolumeSerialNumber"].ToString();
            }
            public static string MotherBoardID
            {
                get
                {
                    string strMotherBoardID = string.Empty;
                    SelectQuery query = new SelectQuery("Win32_BaseBoard");
                    ManagementObjectSearcher search = new ManagementObjectSearcher(query);
                    foreach (ManagementObject info in search.Get())
                    {
                        strMotherBoardID = info["product"].ToString();
                    }
                    return strMotherBoardID;
                }
            }
        }
    }
}