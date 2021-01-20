using System;
using System.Security.Cryptography;
using System.Text;

namespace AdminTool
{
    public class Util
    {
        public static readonly string key = "!quake1234!";

        //public static string Decrypt(string textToDecrypt, string key)
        //{
        //    RijndaelManaged rijndaelCipher = new RijndaelManaged();
        //    rijndaelCipher.Mode = CipherMode.CBC;
        //    rijndaelCipher.Padding = PaddingMode.PKCS7;
        //    rijndaelCipher.KeySize = 128;
        //    rijndaelCipher.BlockSize = 128;

        //    byte[] encryptedData = Convert.FromBase64String(textToDecrypt);

        //    byte[] pwdBytes = Encoding.UTF8.GetBytes(key);

        //    byte[] keyBytes = new byte[16];

        //    int len = pwdBytes.Length;

        //    if (len > keyBytes.Length)
        //    {
        //        len = keyBytes.Length;
        //    }

        //    Array.Copy(pwdBytes, keyBytes, len);
        //    rijndaelCipher.Key = keyBytes;
        //    rijndaelCipher.IV = keyBytes;

        //    byte[] plainText = rijndaelCipher.CreateDecryptor().TransformFinalBlock(encryptedData, 0, encryptedData.Length);

        //    return Encoding.UTF8.GetString(plainText);
        //}

        public static string Encrypt(string textToEncrypt, string key)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged();
            rijndaelCipher.Mode = CipherMode.CBC;
            rijndaelCipher.Padding = PaddingMode.PKCS7;
            rijndaelCipher.KeySize = 128;
            rijndaelCipher.BlockSize = 128;

            byte[] pwdBytes = Encoding.UTF8.GetBytes(key);

            byte[] keyBytes = new byte[16];

            int len = pwdBytes.Length;

            if (len > keyBytes.Length)
            {
                len = keyBytes.Length;
            }

            Array.Copy(pwdBytes, keyBytes, len);
            rijndaelCipher.Key = keyBytes;
            rijndaelCipher.IV = keyBytes;
            ICryptoTransform transform = rijndaelCipher.CreateEncryptor();

            byte[] plainText = Encoding.UTF8.GetBytes(textToEncrypt);

            return Convert.ToBase64String(transform.TransformFinalBlock(plainText, 0, plainText.Length));
        }

        public static string GetMd5Hash(string input)
        {
            var md5Hash = MD5.Create();

            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; ++i)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }
    }
}
