using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibTrainning.Utils
{
    public class PasswordHasher
    {
        public static string CreateHash(string newPassword)
        {
            return getHashSha256(newPassword);
        }

        public static bool Verify(string PasswordHash, string passwordCandidate)
        {
            return string.Equals(PasswordHash, getHashSha256(passwordCandidate));
        }


        private static string getHashSha256(string text)
        { 
            SHA256Managed sha256 = new SHA256Managed();
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }
    }
}
