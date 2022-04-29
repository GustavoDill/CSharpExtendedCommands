using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExtendedCommands.Info
{
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
    /* public static class DirectoryInfo
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
    */
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
        public static PlatformID OSPlatform
        {
            get => Environment.OSVersion.Platform;
        }
        public static Version OSVersion
        {
            get => Environment.OSVersion.Version;
        }
        public static Rectangle PrimaryScreenBounds
        {
            get => Screen.PrimaryScreen.Bounds;
        }
        public static int ScreenWidth
        {
            get => PrimaryScreenBounds.Size.Width;
        }
        public static int ScreenHeight
        {
            get => PrimaryScreenBounds.Size.Width;
        }
        public static Image TakeScreenshot(Rectangle dimensions)
        {
            Bitmap bmp = new Bitmap(dimensions.Width, dimensions.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graph = Graphics.FromImage(bmp);
            graph.CopyFromScreen(dimensions.X, dimensions.Y, 0, 0, dimensions.Size, CopyPixelOperation.SourceCopy);
            return bmp;
        }
        public static Image TakeScreenshot(int x, int y, Size size)
        {
            return TakeScreenshot(new Point(x, y), size);
        }
        public static Image TakeScreenshot(int x, int y, int width, int height)
        {
            return TakeScreenshot(new Rectangle(x, y, width, height));
        }
        public static Image TakeScreenshot(Point location, int width, int height)
        {
            return TakeScreenshot(location, new Size(width, height));
        }
        public static Image TakeScreenshot(Point location, Size size)
        {
            return TakeScreenshot(new Rectangle(location, size));
        }
        public static Image Screenshot
        {
            get
            {
                Rectangle bound = Screen.PrimaryScreen.Bounds;
                Bitmap bmp = new Bitmap(bound.Width, bound.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                Graphics graph = Graphics.FromImage(bmp);
                graph.CopyFromScreen(bound.X, bound.Y, 0, 0, bound.Size, CopyPixelOperation.SourceCopy);
                return bmp;
            }
        }
        public static string Name { get => Environment.MachineName; }

        public static IPAddress[] LocalAddressList
        {
            get => System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList;
        }
        public static IPAddress ExternalIpAddress
        {
            get
            {
                try
                {
                    var req = new WebClient().DownloadString("http://ifconfig.me");
                    if (IPAddress.TryParse(req, out IPAddress _))
                        return IPAddress.Parse(req);
                    else
                        return null;
                }
                catch { return null; }
            }
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
