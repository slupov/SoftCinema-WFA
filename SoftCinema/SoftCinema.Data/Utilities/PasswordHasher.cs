using System;
using System.Security.Cryptography;
using System.Text;

namespace SoftCinema.Data.Utilities
{
    public class PasswordHasher
    {
        public enum Supported_HA
        {
            SHA256,
            SHA512
        }

        public static string ComputeHash(string plainText, Supported_HA hash, byte[] salt)
        {
            int minSaltLength = 4;
            int maxSaltLength = 16;

            byte[] SaltBytes = null;

            if (salt != null)
            {
                SaltBytes = salt;
            }
            else
            {
                Random r = new Random();
                int SaltLength = r.Next(minSaltLength, maxSaltLength + 1);
                SaltBytes = new byte[SaltLength];
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                rng.GetNonZeroBytes(SaltBytes);
                rng.Dispose();
            }

            byte[] plainData = ASCIIEncoding.UTF8.GetBytes(plainText);
            byte[] plainDataAndSalt = new byte[plainData.Length + SaltBytes.Length];

            for (int i = 0; i < plainData.Length; i++)
            {
                plainDataAndSalt[i] = plainData[i];
            }
            for (int i = 0; i < SaltBytes.Length; i++)
            {
                plainDataAndSalt[plainData.Length + i] = SaltBytes[i];
            }

            byte[] HashValue = null;

            switch (hash)
            {
                case Supported_HA.SHA256:
                    SHA256Managed sha256 = new SHA256Managed();
                    HashValue = sha256.ComputeHash(plainDataAndSalt);
                    sha256.Dispose();
                    break;
                case Supported_HA.SHA512:
                    SHA512Managed sha512 = new SHA512Managed();
                    HashValue = sha512.ComputeHash(plainDataAndSalt);
                    sha512.Dispose();
                    break;
            }

            byte[] result = new byte[HashValue.Length + SaltBytes.Length];

            for (int i = 0; i < HashValue.Length; i++)
            {
                result[i] = HashValue[i];
            }
            for (int i = 0; i < SaltBytes.Length; i++)
            {
                result[HashValue.Length + i] = SaltBytes[i];
            }

            return Convert.ToBase64String(result);
        }

        public static bool Confirm(string plainText, string hashvalue, Supported_HA hash)
        {
            byte[] hashBytes = Convert.FromBase64String(hashvalue);

            int hashSize = 0;

            switch (hash)
            {
                case Supported_HA.SHA256:
                    hashSize = 32;
                    break;
                case Supported_HA.SHA512:
                    hashSize = 64;
                    break;
            }

            byte[] saltBytes = new byte[hashBytes.Length - hashSize];

            for (int i = 0; i < saltBytes.Length; i++)
            {
                saltBytes[i] = hashBytes[hashSize + i];
            }

            string NewHash = ComputeHash(plainText, hash, saltBytes);

            return hashvalue == NewHash;
        }
    }
}
