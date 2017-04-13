using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class ScreeningService
    {
        public static bool IsScreeningExisting(int auditoriumId, DateTime date)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Screenings.Any(s => s.AuditoriumId == auditoriumId && s.Start == date);
            }
        }

        public static void AddScreening(int auditoriumId, int movieId, DateTime date)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Screening screening = new Screening()
                {
                    MovieId = movieId,
                    AuditoriumId = auditoriumId,
                    Start = date
                };
                context.Screenings.Add(screening);
                context.SaveChanges();
            }
        }
    }
}
