using System;
using SoftCinema.Models;

namespace SoftCinema.Service
{
    public class AuthenticationManager
    {
        private static User currentUser;

        public static bool IsAuthenticated()
        {
            return currentUser != null;
        }

        public static void Authorize()
        {
            if (currentUser == null)
            {
                throw new InvalidOperationException("You should log in first!");
            }
        }


        public static void Logout()
        {
            if (currentUser == null)
            {
                throw new InvalidOperationException("You should login first");
            }

            currentUser = null;
        }

        public static void Login(User user)
        {
            currentUser = user;
        }

        public static User GetCurrentUser()
        {
            if (currentUser == null)
            {
                throw new InvalidOperationException("You should log in first!");
            }

            return currentUser;
        }
    }
}