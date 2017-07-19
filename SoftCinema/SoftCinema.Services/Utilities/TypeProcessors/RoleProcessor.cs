using SoftCinema.Models;
using System;
using System.Collections.Generic;

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