using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class CinemaService
    {
        public static bool IsCinemaExisting(string cinemaName, int townId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Any(c => c.Name == cinemaName && c.TownId == townId);
            }
        }

        public static void AddCinema(string cinemaName, int townId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Cinema cinema = new Cinema()
                {
                    Name = cinemaName,
                    TownId = townId
                };
                context.Cinemas.Add(cinema);
                context.SaveChanges();
            }
        }
    }
}
