using CSharpExtendedCommands.DataTypeExtensions;
using CSharpExtendedCommands.DataTypeExtensions.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static CSharpExtendedCommands.Converter;

namespace CSharpExtendedCommands
{
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
        public class DumpStream : IDisposable
        {
            public DumpStream(string file)
            {
                FilePath = file;
                baseStream = File.Open(file,
                                       FileMode.OpenOrCreate,
                                       FileAccess.ReadWrite);
                writer = new BinaryWriter(baseStream);
                reader = new BinaryReader(baseStream);
            }
            public FileStream BaseStream { get => baseStream; }
            public long TotalAddresses { get { return baseStream.Length - 1; } }
            public string FilePath { get; }
            private FileStream baseStream;
            private BinaryReader reader;
            private BinaryWriter writer;
            public BinaryReader GetReader()
            {
                return reader;
            }
            public BinaryWriter GetWriter()
            {
                return writer;
            }
            public byte Read(long address)
            {
                baseStream.Position = address;
                return reader.ReadByte();
            }
            public byte[] Read(long startAddress, long endAddress)
            {
                baseStream.Position = startAddress;
                var bytes = reader.ReadBytes((int)(endAddress - startAddress + 1));
                return bytes;
            }
            public string ReadAsString(long startAddress, long endAddress)
            {
                var bts = Read(startAddress, endAddress);
                string str = "";
                for (int i = 0; i < bts.Length; i++)
                {
                    str += bts[i].ToString("X2");
                }
                return str;
            }
            public string ReadASC(long address)
            {
                baseStream.Position = address;
                return Encoding.UTF8.GetString(new byte[] { Read(address) });
            }
            public string ReadASC(long startAddress, long endAddress)
            {
                baseStream.Position = startAddress;
                return Encoding.UTF8.GetString(Read(startAddress, endAddress));
            }
            public bool WriteASC(string text, long address)
            {
                try
                {
                    baseStream.Position = address;
                    writer.Write(Encoding.UTF8.GetBytes(text));
                    return true;
                }
                catch { return false; }
            }
            public bool Write(byte value, long address)
            {
                try
                {
                    baseStream.Position = address;
                    writer.Write(value);
                    return true;
                }
                catch { return false; }
            }
            public bool Write(string values, long address)
            {
                if (values.Length <= 2)
                    return Write((byte)Convert.ToInt32(values, 16), address);
                else
                {
                    try
                    {
                        baseStream.Position = address;
                        for (int i = 0; i < values.Length; i += 2)
                        {
                            writer.Write((byte)Convert.ToInt32(values.Substring(i, 2), 16));
                        }
                        return true;
                    }
                    catch { return false; }
                }
            }
            public bool WriteBytes(byte[] bytes, long address)
            {
                try
                {
                    baseStream.Position = address;
                    writer.Write(bytes);
                    return true;
                }
                catch { return false; }
            }
            public void Flush()
            {
                writer.Flush();
            }
            public void Close()
            {
                Dispose();
            }
            public void Dispose()
            {
                writer.Close();
                reader.Close();
                BaseStream.Close();
            }
            public long Checksum(long startAddress, long endAddress)
            {
                var bts = Read(startAddress, endAddress);
                long s = 0;
                foreach (var b in bts)
                    s += b;
                return s;
            }
            public bool FillBlock(long startAddress, long endAddress, byte value)
            {
                try
                {
                    baseStream.Position = startAddress;
                    long length = endAddress - startAddress + 1;
                    for (int i = 0; i < length; i++)
                    {
                        writer.Write(value);
                    }
                    return true;
                }
                catch { return false; }
            }
            public bool FillBlock(long startAddress, long endAddress, string value)
            {
                return FillBlock(startAddress, endAddress, (byte)Convert.ToInt32(value, 16));
            }
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
                return HexDumpStream.Checksum(type, Data);
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
            string RepeatString(string v, int count)
            {
                string r = "";
                for (int i = 0; i < count; i++)
                {
                    r += v;
                }
                return r;
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
                var total = (EndAddress - StartAddress + 1);
                string fillValue;
                if (Value.Length == 1)
                    fillValue = "0" + Value;
                else if (Value.Length == 2)
                    fillValue = Value;
                else
                    fillValue = Value;
                string data;
                if (fillValue.Length > 2)
                    data = RepeatString(fillValue, total / (fillValue.Length / 2));
                else
                    data = RepeatString(fillValue, total);
                return WriteMultipleHexValues(StartAddress, data);
                //    System.IO.BinaryWriter writer = new System.IO.BinaryWriter(OpenWrite);
                //try
                //{
                //    int length = EndAddress - StartAddress + 1;
                //    var v = "";
                //    for (int i = 0; i < length; i++)
                //        v += Value;
                //    writer.BaseStream.Position = StartAddress;
                //    writer.Write(GetBuffer(v));
                //    writer.Close();
                //    return true;
                //}
                //catch
                //{
                //    writer.Close();
                //    return false;
                //}
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
                        string LeftSide = ReadHexValue(Address, "Left").ToString();
                        string RightSide = Value[Value.Length - 1].ToString();
                        string Temp = LeftSide + RightSide;
                        return WriteHexValue(Address, LeftSide + RightSide);
                    }
                    if (Side == "Left")
                    {
                        string RightSide = ReadHexValue(Address, "Right");
                        string LeftSide = Value[0].ToString();
                        string Temp = LeftSide + RightSide;
                        return WriteHexValue(Address, LeftSide + RightSide);
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
                try
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
                catch (Exception)
                {

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
                try
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
                catch (Exception)
                {

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
                try
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
                catch (Exception)
                {

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
                try
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
                catch (Exception)
                {

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
}
