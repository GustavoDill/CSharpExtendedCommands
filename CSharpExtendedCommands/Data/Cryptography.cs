using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExtendedCommands.Data
{
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
}
