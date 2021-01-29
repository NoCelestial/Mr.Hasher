using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Mr.Hasher.Bussines.API
{
    public class Hashing : IHashAPI
    {
        public string HashByMD5(string Values)
        {
            MD5 md5 = MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Values);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public string HashBySHA160(string Values)
        {
           SHA1 md5 = SHA1.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Values);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public string HashBySHA256(string Values)
        {
            SHA256 md5 = SHA256.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Values);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public string HashBySHA384(string Values)
        {
            SHA384 md5 = SHA384.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Values);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            return sb.ToString();
        }

        public string HashBySHA512(string Values)
        {
           SHA512 md5 = SHA512.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Values);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            return sb.ToString();
        }
        public string HashByRIPEMD160(string Values)
        {
            RIPEMD160 md5 = RIPEMD160.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Values);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
