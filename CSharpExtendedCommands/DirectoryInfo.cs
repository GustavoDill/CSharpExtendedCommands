using System;

namespace CSharpExtendedCommands.Info
{
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
}
