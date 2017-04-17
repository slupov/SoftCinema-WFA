using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Models;

namespace SoftCinema.Services.Utilities
{
    public static class RoleProcessor
    {
        public static List<string> GetRoles()
        {
            List<string> roles = new List<string>();
            foreach (var role in Enum.GetValues(typeof(Role)))
            {
               roles.Add(role.ToString());
            }
            return roles;
        }
    }
}
