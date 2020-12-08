﻿using System;
using System.IO;
using System.Text;

namespace CryptLab4
{
internal class Program
    {
            private static string _fullFilePath = "D:/4KNU/EnctTest/GMODvid.mp4";


            private static void Main(string[] args)
            {
                var rsa = new RSA(128);
                var m = "Hello";
                var bytes = Encoding.UTF8.GetBytes(m);
                var encoded = rsa.Encrypt(new System.Numerics.BigInteger(bytes));
                var decoded = rsa.Decrypt(encoded);
                var oaep = rsa.RSA_OAEP(bytes);
                var encoded2 = rsa.Encrypt(oaep);
                var decoded2 = rsa.Decrypt(encoded2);
            }
    }
}
