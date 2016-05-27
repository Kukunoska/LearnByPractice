using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LearnByPractice
{

    public enum Supported_HASH
    {
        SHA256
    }

    class Hashing
    {
        const int saltLength = 16;

        public static byte[] ComputeHash(string plainText, Supported_HASH hash, byte[] salt)
        {

            //int minSaltLength = 4;
            //int maxSaltLength = 16;
            //int saltLength = 16;

            byte[] saltBytes = null;

            if (salt != null)
            {
                saltBytes = salt;
            }
            else
            {
                //Random r = new Random();
                //int saltLength = r.Next(minSaltLength, maxSaltLength);
                saltBytes = new byte[saltLength];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(saltBytes);
                rng.Dispose();
            }

            byte[] plainData = Encoding.UTF8.GetBytes(plainText);
            byte[] plainDataAndSalt = new byte[plainData.Length + saltBytes.Length];

            for (int x = 0; x < plainData.Length; x++)
                plainDataAndSalt[x] = plainData[x];

            for (int n = 0; n < saltBytes.Length; n++)
                plainDataAndSalt[plainData.Length + n] = saltBytes[n];

            byte[] hashValue = null;

            SHA256Managed sha = new SHA256Managed();
            hashValue = sha.ComputeHash(plainDataAndSalt);
            sha.Dispose();

            byte[] result = new byte[hashValue.Length + saltBytes.Length];

            for (int x = 0; x < hashValue.Length; x++)
                result[x] = hashValue[x];
            for (int n = 0; n < saltBytes.Length; n++)
                result[hashValue.Length + n] = saltBytes[n];

            //return Convert.ToBase64String(result);

            //И овај код работи со Confirm методот.
            //StringBuilder sb = new StringBuilder();
            //foreach (byte b in result)
            //{
            //    sb.Append(b.ToString("x2"));
            //}
            //return sb.ToString();

            return result;
        }

        public static bool Confirm(string plainText, byte[] hashBytes, Supported_HASH hash)
        {
            //byte[] hashBytes = Convert.FromBase64String(hashValue);
            
            //int hashSize = 32;
            int saltSize = 32;
            byte[] saltBytes = new byte[hashBytes.Length - saltSize];

            for (int x = 0; x < saltBytes.Length; x++)
                saltBytes[x] = hashBytes[saltSize + x];

            byte[] newHash = ComputeHash(plainText, hash, saltBytes);

            if (newHash.Length != hashBytes.Length) return false;
            for (int i = 0; i < hashBytes.Length; i++)
            {
                if (hashBytes[i] != newHash[i]) return false;
            }

            return true;
        }
    }
}
