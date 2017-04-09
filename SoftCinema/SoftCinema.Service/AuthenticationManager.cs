using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
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

        public static void Logout()
        {
            if (!IsAuthenticated())
            {
                throw new InvalidOperationException("You should login first!");
            }

            currentUser = null;
        }

        public static void Login(User user)
        {
            if (IsAuthenticated())
            {
                throw new InvalidOperationException("You should logout first!");
            }

            if (user == null)
            {
                throw new InvalidOperationException("User to log in is invalid!");
            }

            currentUser = user;
        }

        public static User GetCurrentUser()
        {
            return currentUser;
        }
    }
}
