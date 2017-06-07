using System;
using System.Text;
using System.Security.Cryptography;

namespace LearnByPractice.BLL.Managers.Security
{
    public static class Hashing
    {
       public  const int SaltLength = 16;

        public static byte[] ComputeHash(string plainText, byte[] salt)
        {
            byte[] plainData = Encoding.UTF8.GetBytes(plainText);
            byte[] saltAndPlainData = new byte[salt.Length + plainData.Length];
            Array.Copy(salt, saltAndPlainData, salt.Length);
            Array.Copy(plainData, 0, saltAndPlainData, salt.Length, plainData.Length);

            byte[] hashValue = null;

            using (SHA256Managed sha = new SHA256Managed())
            {
                hashValue = sha.ComputeHash(saltAndPlainData);
            }

            byte[] result = new byte[salt.Length + hashValue.Length];
            Array.Copy(salt, result, salt.Length);
            Array.Copy(hashValue, 0, result, salt.Length, hashValue.Length);

            return result;
        }

        public static bool HashesEqual(string plainText, byte[] hashBytes)
        {
            // Првите saltLength од hashBytes ја содржат „солта“
            byte[] saltBytes = new byte[SaltLength];
            Array.Copy(hashBytes, saltBytes, SaltLength);

            byte[] newHash = ComputeHash(plainText, saltBytes);

            if (newHash.Length != hashBytes.Length) return false;
            for (int i = 0; i < hashBytes.Length; i++)
            {
                if (hashBytes[i] != newHash[i]) return false;
            }

            return true;
        }
    }
}
