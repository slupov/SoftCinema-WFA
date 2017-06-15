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
    public  class CinemaService
    {
        public  void AddCinema(string cinemaName, int townId)
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

        public  int GetCinemaId(string cinemaName, int townId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.First(c => c.Name == cinemaName && c.TownId == townId).Id;
            }
        }
        public  List<Cinema> GetAllCinemas()
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.ToList();
            }
        }
        public  string[] GetCinemasNamesBySelectedTown(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Where(c => c.Town.Name == townName).Select(c => c.Name).ToArray();
            }
        }

        public  string[] GetCinemasByMovieAndTown(string movieName, string townName)
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

        public  Cinema GetCinema(string cinemaName, string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Include(c => c.Town).First(c => c.Name == cinemaName && c.Town.Name == townName);
            }
        }

        public  Cinema GetCinemaById(int cinemaId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Find(cinemaId);
            }
        }

        public  Cinema GetCinemaWithScreenings(int cinemaId)
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

        public  bool IsCinemaExisting(string cinemaName, int townId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Any(c => c.Name == cinemaName && c.TownId == townId);
            }
        }

        public  bool IsCinemaExistingByTownName(string cinemaName, string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Cinemas.Any(c => c.Name == cinemaName && c.Town.Name == townName);
            }
        }

        public  void UpdateCinema(string oldCinemaName, string oldTownName, string newCinemaName, string newTownName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Cinema cinema =
                    context.Cinemas.FirstOrDefault(c => c.Name == oldCinemaName && c.Town.Name == oldTownName);
                if (!context.Towns.Any(t => t.Name == newTownName))
                {
                    context.Towns.Add(new Town()
                    {
                        Name = newTownName
                    });
                    context.SaveChanges();
                }
                cinema.Name = newCinemaName;
                cinema.TownId = context.Towns.FirstOrDefault(t => t.Name == newTownName).Id;
                context.SaveChanges();
            }
        }

        public  void RemoveCinema(string cinemaName,string townName)
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
