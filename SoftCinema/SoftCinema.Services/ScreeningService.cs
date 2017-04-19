using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.Models;
using System.Data.Entity;

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

        public static ICollection<Screening> GetScreeningsByTownCinemaAndMovie(string townName, string cinemaName, string movieName)
        {
            using (var db = new SoftCinemaContext())
            {
                return db
                    .Screenings
                    .Include("Auditorium")
                    .Include("Auditorium.Cinema")
                    .Include("Auditorium.Cinema.Town")
                    .Include("Movie")
                    .Where(s => s.Auditorium.Cinema.Name == cinemaName &&
                                s.Auditorium.Cinema.Town.Name == townName &&
                                s.Movie.Name == movieName)
                    .ToList();
            }
        }

        public static Screening GetScreeningUsingMovieYear(string townName, string cinemaName, string movieName, DateTime date, int movieYear)
        {
            using (var db = new SoftCinemaContext())
            {
                return
                    db.Screenings
                    .Include("Auditorium")
                    .Include("Auditorium.Seats")
                    .Include("Movie")
                    .Include("Tickets")
                    .FirstOrDefault(
                        s => s.Movie.Name == movieName &&
                             s.Start == date &&
                             s.Auditorium.Cinema.Town.Name == townName &&
                             s.Auditorium.Cinema.Name == cinemaName && s.Movie.ReleaseYear == movieYear);
            }
        }

        public static string[] GetAllDatesForMovieInCinema(string town, string cinema, string movie)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                var list = new List<string>();
                var dates =
                    context.Screenings.Where(
                        s =>
                            s.Movie.Name == movie && s.Auditorium.Cinema.Town.Name == town &&
                            s.Auditorium.Cinema.Name == cinema).Select(s => s.Start).ToArray();
                foreach (var dateTime in dates)
                {
                    var day = dateTime.Day.ToString();
                    var month = dateTime.ToString("MMM");
                    var weekDay = dateTime.DayOfWeek.ToString();
                    list.Add($"{day} {month} {weekDay}");
                }
                return list.Distinct().ToArray();
            }
        }

        public static string[] GetAllDatesForMovieInCinemaByNameAndYear(string town, string cinema, string movie,int year)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                var list = new List<string>();
                var dates =
                    context.Screenings.Where(
                        s =>
                            s.Movie.Name == movie && s.Auditorium.Cinema.Town.Name == town &&
                            s.Auditorium.Cinema.Name == cinema && s.Movie.ReleaseYear == year).Select(s => s.Start).ToArray();
                foreach (var dateTime in dates)
                {
                    var day = dateTime.Day.ToString();
                    var month = dateTime.ToString("MMM");
                    var weekDay = dateTime.DayOfWeek.ToString();
                    list.Add($"{day} {month} {weekDay}");
                }
                return list.Distinct().ToArray();
            }
        }
        public static string[] GetHoursForMoviesByDate(string town, string cinema, string movie, string date)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                var d = date.Split().ToArray();
                var day = d[0];
                var month = DateTime.ParseExact(d[1], "MMM", CultureInfo.CurrentCulture).Month.ToString();
                var list = new List<string>();
                var dates =
                    context.Screenings.Where(
                        s =>
                            s.Movie.Name == movie && s.Auditorium.Cinema.Town.Name == town &&
                            s.Auditorium.Cinema.Name == cinema && s.Start.Day.ToString() == day &&
                            s.Start.Month.ToString() == month).Select(s => s.Start).OrderBy(s => s.Hour).ToArray();

                foreach (var dateTime in dates)
                {
                    var hour = dateTime.ToString("hh");
                    var minutes = dateTime.ToString("mm");
                    var part = dateTime.ToString("tt", CultureInfo.InvariantCulture);
                    list.Add($"{hour}:{minutes} {part}");
                }
                return list.Distinct().ToArray();
            }
        }

        public static string[] GetHoursForMoviesByDateMovieNameAndYear(string town, string cinema, string movie, int movieYear, string date)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                var d = date.Split().ToArray();
                var day = d[0];
                var month = DateTime.ParseExact(d[1], "MMM", CultureInfo.CurrentCulture).Month.ToString();
                var list = new List<string>();
                var dates =
                    context.Screenings.Where(
                        s =>
                            s.Movie.Name == movie && s.Auditorium.Cinema.Town.Name == town &&
                            s.Auditorium.Cinema.Name == cinema && s.Start.Day.ToString() == day &&
                            s.Start.Month.ToString() == month && s.Movie.ReleaseYear == movieYear).Select(s => s.Start).OrderBy(s => s.Hour).ToArray();

                foreach (var dateTime in dates)
                {
                    var hour = dateTime.ToString("hh");
                    var minutes = dateTime.ToString("mm");
                    var part = dateTime.ToString("tt", CultureInfo.InvariantCulture);
                    list.Add($"{hour}:{minutes} {part}");
                }
                return list.Distinct().ToArray();
            }
        }

        public static DateTime GetDateTimeFromDateAndTime(string date, string time)
        {
            int day = int.Parse(date.Split()[0]);
            int month = int.Parse(DateTime.ParseExact(date.Split()[1], "MMM", CultureInfo.CurrentCulture).Month.ToString());
            int year = 2017;
            int hour = DateTime.ParseExact(time,"hh:mm tt", CultureInfo.CurrentCulture).Hour;
            int minutes= DateTime.ParseExact(time, "hh:mm tt", CultureInfo.CurrentCulture).Minute;
            return new DateTime(year,month,day,hour,minutes,0);
           }

        public static Screening GetScreening(string townName, string cinemaName, string movieName, DateTime date)
        {
            using (var db = new SoftCinemaContext())
            {
                return
                    db.Screenings
                    .Include("Auditorium")
                    .Include("Auditorium.Seats")
                    .Include("Movie")
                    .Include("Tickets")
                    .FirstOrDefault(
                        s => s.Movie.Name == movieName &&
                             s.Start == date &&
                             s.Auditorium.Cinema.Town.Name == townName &&
                             s.Auditorium.Cinema.Name == cinemaName);
            }
        }


        public static void UpdateScreening(int screeningId, DateTime startTime)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Screening screening = context.Screenings.Find(screeningId);
                screening.Start = startTime;
                context.SaveChanges();
            }
        }

        public static bool IsScreeningAvailable(int screeningId,DateTime screeningStart)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Screening screening = context.Screenings.Find(screeningId);
                foreach (var scr in context.Screenings.Where(s => s.AuditoriumId == screening.AuditoriumId &&
                (s.Start.Year == screening.Start.Year && s.Start.Month == screening.Start.Month && s.Start.Day == screening.Start.Day) && s.Id!=screeningId))
                {
                    var screenStart = screeningStart.TimeOfDay;
                    var screenEnd = screeningStart.AddMinutes(screening.Movie.Length).TimeOfDay;
                    var otherScreenStart = scr.Start.TimeOfDay;
                    var otherScreenEnd = scr.Start.AddMinutes(scr.Movie.Length).TimeOfDay;

                    if ((otherScreenStart < screenEnd &&
                        otherScreenEnd > screenStart)
                        || (screenStart < otherScreenEnd &&
                        screenEnd > otherScreenStart))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}