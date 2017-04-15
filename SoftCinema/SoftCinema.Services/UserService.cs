using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Security.Cryptography;
using System.Text;
using SoftCinema.Data.Utilities;

namespace SoftCinema.Services
{
    using System.Linq;
    using System.Text.RegularExpressions;
    using SoftCinema.Data;
    using SoftCinema.Models;

    public class UserService
    {
        

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
                using (var db = new SoftCinemaContext())
                {
                    User user = db.Users.FirstOrDefault(u => u.Username == username);
                    return PasswordHasher.Confirm(password, user.PasswordHash, PasswordHasher.Supported_HA.SHA512);
                }
            }
        }

        public static void AddUser(string username, string password, string email, string phone)
        {
            using (var db = new SoftCinemaContext())
            {
                var user = new User()
                {
                    Username = username,
                    PasswordHash = PasswordHasher.ComputeHash(password, PasswordHasher.Supported_HA.SHA512, null),
                    Email = email,
                    PhoneNumber = phone,
                    Role = Role.User
                };

                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public static void AddOrUpdateUser(string username, string password, string email, string phone,Role role)
        {
            using (var db = new SoftCinemaContext())
            {
                var user = new User()
                {
                    Username = username,
                    PasswordHash = PasswordHasher.ComputeHash(password, PasswordHasher.Supported_HA.SHA512, null),
                    Email = email,
                    PhoneNumber = phone,
                    Role = role
                };

                db.Users.AddOrUpdate(u=>u.Username, user);
                db.SaveChanges();
            }
        }

        public static User GetUser(string username)
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Users.FirstOrDefault(u => u.Username == username);
            }
        }

        public static List<User> GetUsers()
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Users.ToList();
            }
        }


        public static string[] GetUsernames()
        {
            return GetUsers().Select(u => u.Username).ToArray();
        }

        public static string GetPassword(string username)
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Users.FirstOrDefault(u => u.Username == username).PasswordHash;
            }
        }
    }
}