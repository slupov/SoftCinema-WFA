using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                    .Distinct()
                    .ToArray();

             
                return arr;
            }
        }

        public static Cinema GetCinema(string cinemaName, string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Include(c => c.Town).First(c => c.Name == cinemaName && c.Town.Name == townName);
            }
        }

        public static Cinema GetCinemaById(int cinemaId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Find(cinemaId);
            }
        }

        public static Cinema GetCinemaWithScreenings(int cinemaId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Include(c => c.Auditoriums)
                    .Include(c => c.Auditoriums.Select(a => a.Screenings))
                    .Include(c => c.Auditoriums.Select(a => a.Screenings.Select(s => s.Movie)))
                    .Include(c => c.Town)
                    .FirstOrDefault(c => c.Id == cinemaId);
            }
        }

        public static bool IsCinemaExisting(string cinemaName, int townId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Any(c => c.Name == cinemaName && c.TownId == townId);
            }
        }

        public static bool IsCinemaExistingByTownName(string cinemaName, string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Any(c => c.Name == cinemaName && c.Town.Name == townName);
            }
        }

        public static void UpdateCinema(string oldCinemaName, string oldTownName, string newCinemaName, string newTownName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Cinema cinema =
                    context.Cinemas.FirstOrDefault(c => c.Name == oldCinemaName && c.Town.Name == oldTownName);
                TownService.AddTownIfNotExisting(newTownName);
                cinema.Name = newCinemaName;
                cinema.TownId = TownService.GetTownId(newTownName);
                context.SaveChanges();
            }
        }

        public static void RemoveCinema(string cinemaName,string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Cinema cinema =
                    context.Cinemas.FirstOrDefault(c => c.Name == cinemaName && c.Town.Name == townName);
                var auditoriums = cinema.Auditoriums.ToList();
                foreach (var auditorium in auditoriums)
                {
                    var screenings = auditorium.Screenings.ToList();
                    foreach (var screening in screenings)
                    {
                        var tickets = screening.Tickets.ToList();
                        foreach (var ticket in tickets)
                        {
                            context.Tickets.Remove(ticket);
                        }
                        context.Screenings.Remove(screening);
                    }
                    var seats = auditorium.Seats.ToList();
                    foreach (var seat in seats)
                    {
                        context.Seats.Remove(seat);
                    }
                    context.Auditoriums.Remove(auditorium);
                }
                context.Cinemas.Remove(cinema);
                context.SaveChanges();

            }
        }


        
    }
}
