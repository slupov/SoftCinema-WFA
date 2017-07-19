using SoftCinema.Models;
using System;
using System.Collections.Generic;

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