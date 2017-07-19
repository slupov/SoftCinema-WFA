using SoftCinema.Data.Utilities;
using SoftCinema.Services.Utilities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace SoftCinema.Services
{
    using SoftCinema.Data;
    using SoftCinema.Models;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class UserService
    {
        public bool isUserValid(string username, string password, string repeatpassword, string email,
            string phone)
        {
            return !isUsernameExisting(username) && isUsernameValid(username)
                   && isPasswordValid(password) && isRepeatPasswordValid(password, repeatpassword)
                   && isEmailValid(email) && isPhoneValid(phone);
        }

        public bool isUsernameValid(string username)
        {
            //TODO: Check for SqlInjection
            if (username.Length > 25)
            {
                return false;
            }

            return true;
        }

        public bool isUsernameExisting(string username)
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Users.Any(u => u.Username == username);
            }
        }

        public bool isPasswordValid(string password)
        {
            if (password.Length < 3 || password.Length > 25)
            {
                return false;
            }
            return true;
        }

        public bool isRepeatPasswordValid(string password, string repeatpassword)
        {
            if (repeatpassword == password)
            {
                return true;
            }

            return false;
        }

        public bool isEmailValid(string email)
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

        public bool isPhoneValid(string phone)
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

        public bool isUsernamePasswordMatching(string username, string password)
        {
            using (var db = new SoftCinemaContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Username == username);
                return PasswordHasher.Confirm(password, user.PasswordHash, PasswordHasher.Supported_HA.SHA512);
            }
        }

        public bool IsEmailTaken(string email)
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Users.Any(u => u.Email == email);
            }
        }

        public bool IsRoleValid(string role)
        {
            return RoleProcessor.GetRoles().Contains(role);
        }

        public bool IsUserDeleted(string username)
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Users.FirstOrDefault(u => u.Username == username).IsDeleted;
            }
        }

        public void EditUser(string username, string email, string phoneNumber, string password, Image profilePic)
        {
            using (var db = new SoftCinemaContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username);
                user.Email = email;
                user.PhoneNumber = phoneNumber;
                if (password != string.Empty)
                {
                    user.PasswordHash = PasswordHasher.ComputeHash(password, PasswordHasher.Supported_HA.SHA512, null);
                }
                if (profilePic != null)
                {
                    user.ProfilePicture = profilePic;
                }
                db.SaveChanges();
            }
        }

        public void AddUser(string username, string password, string email, string phone, byte[] image)
        {
            using (var db = new SoftCinemaContext())
            {
                var user = new User()
                {
                    Username = username,
                    PasswordHash = PasswordHasher.ComputeHash(password, PasswordHasher.Supported_HA.SHA512, null),
                    Email = email,
                    PhoneNumber = phone,
                    Role = Role.User,
                    ProfilePicture = new Image() { Content = image }
                };

                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void AddOrUpdateUser(string username, string password, string email, string phone, Role role, Image profilePicture)
        {
            using (var db = new SoftCinemaContext())
            {
                var user = new User()
                {
                    Username = username,
                    PasswordHash = PasswordHasher.ComputeHash(password, PasswordHasher.Supported_HA.SHA512, null),
                    Email = email,
                    PhoneNumber = phone,
                    Role = role,
                    ProfilePicture = profilePicture
                };

                db.Users.AddOrUpdate(u => u.Username, user);
                db.SaveChanges();
            }
        }

        public User GetUser(string username)
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Users.Include(u => u.ProfilePicture).FirstOrDefault(u => u.Username == username);
            }
        }

        public List<User> GetUsers()
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Users.ToList();
            }
        }

        public string[] GetUsernames()
        {
            return GetUsers().Select(u => u.Username).ToArray();
        }

        public string GetPassword(string username)
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Users.FirstOrDefault(u => u.Username == username).PasswordHash;
            }
        }

        public void UpdateUser(string oldUsername, string newUsername, string email, string phoneNumber, Role role, bool isDeleted)
        {
            using (var db = new SoftCinemaContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Username == oldUsername);
                user.Username = newUsername;
                user.Email = email;
                user.PhoneNumber = phoneNumber;
                user.Role = role;
                user.IsDeleted = isDeleted;
                db.SaveChanges();
            }
        }

        public void DeleteUser(string userUsername)
        {
            using (var db = new SoftCinemaContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Username == userUsername);
                user.IsDeleted = true;
                db.SaveChanges();
            }
        }

        public void AddImageToUser(User user, Image image)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                user = context.Users.FirstOrDefault(u => u.Username == user.Username);
                user.ProfilePicture = image;
                user.ProfilePictureId = image.Id;
                context.SaveChanges();
            }
        }
    }
}