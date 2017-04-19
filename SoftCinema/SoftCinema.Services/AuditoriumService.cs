using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class AuditoriumService
    {
        public static void AddAuditorium(byte number, int cinemaId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Auditorium auditorium = new Auditorium()
                {
                    CinemaId = cinemaId,
                    Number = number,
                };
                context.Auditoriums.Add(auditorium);
                context.SaveChanges();
            }
        }

        public static int GetAuditoriumId(byte auditoriumNumber, int cinemaId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Auditoriums.First(a => a.CinemaId == cinemaId && a.Number == auditoriumNumber).Id;
            }
        }

        public static List<byte> GetAuditoriumsForScreening(string movieName, int movieYear, int cinemaId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Screenings.Where(s => s.Movie.Name == movieName && s.Movie.ReleaseYear == movieYear && s.Auditorium.CinemaId == cinemaId)
                    .Select(s => s.Auditorium.Number).Distinct().ToList();
            }
        }

        public static List<Auditorium> GetAudtitoriums(int cinemaId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Find(cinemaId).Auditoriums.ToList();
            }
        }

        public static bool IsAuditoriumExisting(byte number, int cinemaId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Auditoriums.Any(a => a.CinemaId == cinemaId && a.Number == number);
            }
        }


        
    }
}
