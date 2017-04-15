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

        public static bool IsScreeningExisting(int auditoriumId, DateTime date)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Screenings.Any(s => s.AuditoriumId == auditoriumId && s.Start == date);
            }
        }

        public static string[] GetAllDates(string town, string cinema, string movie)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                var list=new List<string>();
                var dates= context.Screenings.Where(s => s.Movie.Name==movie && s.Auditorium.Cinema.Town.Name==town && s.Auditorium.Cinema.Name==cinema).Select(s=>s.Start).ToArray();
                foreach (var dateTime in dates)
                {
                    var day = dateTime.ToString("dd");
                    var month = dateTime.ToString("MMM");
                    var weekDay = dateTime.DayOfWeek.ToString();
                    list.Add($"{day} {month} {weekDay}");
                }
                return list.Distinct().ToArray();
            }
        }
    }
}
