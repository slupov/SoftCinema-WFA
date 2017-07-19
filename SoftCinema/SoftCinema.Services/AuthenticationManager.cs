using SoftCinema.Services.Utilities;

namespace SoftCinema.Services
{
    using SoftCinema.Models;
    using System;

    public class AuthenticationManager
    {
        private static User currentUser;

        public static bool IsAuthenticated()
        {
            return currentUser != null;
        }

        public static bool HasSuperRights()
        {
            if (currentUser != null)
            {
                return currentUser.Role == Role.Admin || currentUser.Role == Role.Employee;
            }
            return false;
        }

        public static void Authorize()
        {
            if (currentUser == null)
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }
        }

        public static void Logout()
        {
            if (currentUser == null)
            {
                throw new InvalidOperationException(Constants.ErrorMessages.LoginFirst);
            }

            currentUser = null;
        }

        public static void Login(User user)
        {
            currentUser = user;
        }

        public static User GetCurrentUser()
        {
            Authorize();

            return currentUser;
        }
    }
}