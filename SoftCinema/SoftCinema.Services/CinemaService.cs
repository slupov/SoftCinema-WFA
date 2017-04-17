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

        public static int GetCinemaId(string cinemaName, int townId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.First(c => c.Name == cinemaName && c.TownId == townId).Id;
            }
        }
        public static List<Cinema> GetAllCinemas()
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.ToList();
            }
        }
        public static string[] GetCinemasNamesBySelectedTown(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Where(c => c.Town.Name == townName).Select(c => c.Name).ToArray();
            }
        }

        public static string[] GetCinemasByMovieAndTown(string movieName, string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                var arr = context
                    .Screenings
                    .Where(s => s.Movie.Name == movieName)
                    .Where(s => s.Auditorium.Cinema.Town.Name == townName)
                    .Select(s => s.Auditorium.Cinema.Name)
                    .ToArray();

                HashSet<string> set = new HashSet<string>(arr);
                string[] result = new string[set.Count];
                set.CopyTo(result);

                return result;
            }
        }

        public static bool IsCinemaExisting(string cinemaName, int townId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Any(c => c.Name == cinemaName && c.TownId == townId);
            }
        }

        
    }
}
