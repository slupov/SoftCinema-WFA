using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Models;

namespace SoftCinema.Services.Utilities
{
    public static class TicketTypeProcessor
    {
        public static List<string> GetTicketTypes()
        {
            List<string> types = new List<string>();
            foreach (var type in Enum.GetValues(typeof(TicketType)))
            {
                types.Add(type.ToString());
            }
            return types;
        }
    }
}
