using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Service
{
    public class UserService
    {
        public class PasswordHasher
        {
            public enum Supported_HA
            {
                SHA256,
                SHA512
            }

            public static string ToHashed(string plainText, Supported_HA hash, byte[] salt)
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

                byte[] plainData = Encoding.UTF8.GetBytes(plainText);
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

                string NewHash = ToHashed(plainText, hash, saltBytes);

                return hashvalue == NewHash;
            }
        }

        public class Validations
        {
            public static bool isUserValid(string username, string password, string repeatpassword, string email,
                string phone)
            {
                return !isUsernameExisting(username) && isUsernameValid(username)
                       && isPasswordValid(password) && isRepeatPasswordValid(password, repeatpassword)
                       && isEmailValid(email) && isPhoneValid(phone);
            }

            public static bool isUsernameValid(string username)
            {
                //TODO: Check for SqlInjection 
                if (username.Length > 25)
                {
                    return false;
                }

                return true;
            }

            public static bool isUsernameExisting(string username)
            {
                using (var db = new SoftCinemaContext())
                {
                    return db.Users.Any(u => u.Username == username);
                }
            }

            public static bool isPasswordValid(string password)
            {
                if (password.Length < 3 && password.Length > 25)
                {
                    return false;
                }
                return true;
            }

            public static bool isRepeatPasswordValid(string password, string repeatpassword)
            {
                if (repeatpassword == password)
                {
                    return true;
                }

                return false;
            }

            public static bool isEmailValid(string email)
            {
                var emailRegex =
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

                if (!Regex.IsMatch(email, emailRegex))
                {
                    return false;
                }
                return true;
            }

            public static bool isPhoneValid(string phone)
            {
                if (phone == "" || phone == string.Empty)
                {
                    return true;
                }

                var phoneRegex = @"08[789]\d{7}";

                if (!Regex.IsMatch(phone, phoneRegex))
                {
                    return false;
                }

                return true;
            }

            public static bool isUsernamePasswordMatching(string username, string password)
            {
                throw new NotImplementedException();
                using (var db = new SoftCinemaContext())
                {
//                    User user = db.Users.FirstOrDefault(u => u.Username == username);
//                    var hashedPassword = Convert.ToBase64String(user.PasswordHash);
//                    var toConfirm = PasswordHasher.ToHashed(password, PasswordHasher.Supported_HA.SHA512,
//                        Convert.ToBase64String(user.PasswordSalt));
//
//                    return hashedPassword == toConfirm;
                }
            }
        }

        public static void AddUser(string username, string password, string repeatPassword, string email, string phone)
        {
            using (var db = new SoftCinemaContext())
            {
                var user = new User()
                {
                    Username = username,
                    PasswordHash =
                        Encoding.UTF8.GetBytes(PasswordHasher.ToHashed(password, PasswordHasher.Supported_HA.SHA512,
                            null)),
                    Email = email,
                    PhoneNumber = phone,
                    Role = Role.User
                };

                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}