using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RestfulSample.UnitTest
{
    public class Fun
    {
        protected int x ;

        public static void MyFun(Fun a, Fun b)
        {
            a.x = 1;
            b.x = 1;
        }
    }

    public class MyFun : Fun
    {
        public static void MyFun1(Fun a, Fun b)
        {
            //a.x = 1;
            //b.x = 1;
        }
    }

    [TestFixture]
   public class Decode64basetostring
    {
        private static string GetHiddenString()
        {
            return "123456789!@#$%^&*)";
        }


        [Test]
        public void aaa()
        {
           // Console.WriteLine(Security.Decrypt("94sQalqTn80=", "G3zt1ht6e7k="));
            Console.WriteLine(Security.Encrypt("7588", GetHiddenString()));
        }
        [Test]
        public void test()
        {
            string xxx = "sqhfUhQycXhR/n72yAwwF/DENA8wXzcW11dxV6ATc89wPqz21SIQRQ==";

       var temp=     Convert.FromBase64String(xxx);
            var r =System.Text.UTF8Encoding.UTF8.GetString(temp);
            Console.WriteLine(r);

            foreach (char c in r)
            {
                Console.WriteLine(c+ " - " +((int)c));
            }

            foreach (var c in "7588")
            {
                Console.WriteLine(c + " - " + ((int)c));
            }
        }
    }

    public class Security
    {
        // Methods
        public static string Decrypt(string strText, string sDecrKey)
        {
            byte[] rgbIV = new byte[] { 0x12, 0x34, 0x56, 120, 0x90, 0xab, 0xcd, 0xef };
            byte[] buffer = new byte[strText.Length + 1];
            //try
            //{
                if (sDecrKey.Length < 8)
                {
                    sDecrKey = sDecrKey + "ccccccccc";
                }
                byte[] bytes = Encoding.UTF8.GetBytes(sDecrKey.Substring(0, 8));
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                buffer = Convert.FromBase64String(strText);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(bytes, rgbIV), CryptoStreamMode.Write);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                return Encoding.UTF8.GetString(stream.ToArray());
            //}
            //catch (Exception exception)
            //{
            //    return exception.Message;
            //}
        }

        public static string Encrypt(string strText, string strEncrKey)
        {
            byte[] rgbIV = new byte[] { 0x12, 0x34, 0x56, 120, 0x90, 0xab, 0xcd, 0xef };
            //try
            //{
                if (strEncrKey.Length < 8)
                {
                    strEncrKey = strEncrKey + "ccccccccc";
                }
                byte[] bytes = Encoding.UTF8.GetBytes(strEncrKey.Substring(0, 8));
                byte[] buffer = Encoding.UTF8.GetBytes(strText);
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(bytes, rgbIV), CryptoStreamMode.Write);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                return Convert.ToBase64String(stream.ToArray());
            //}
            //catch (Exception exception)
            //{
            //    return exception.Message;
            //}
        }

        internal static string GetMachineCode()
        {
            ManagementObjectCollection objects = new ManagementObjectSearcher("select SerialNumber from Win32_BIOS").Get();
            foreach (ManagementObject obj2 in objects)
            {
                foreach (PropertyData data in obj2.Properties)
                {
                    if (data.Name == "SerialNumber")
                    {
                        string strText = data.Value.ToString();
                        string str2 = Encrypt(strText, strText);
                        long num = 0L;
                        for (int i = 0; i < str2.Length; i++)
                        {
                            num += (str2[i] * '\x0010') * (((i % 2) == 0) ? 0x10 : 0x100);
                        }
                        return num.ToString();
                    }
                }
            }
            return "";
        }
    }



}
