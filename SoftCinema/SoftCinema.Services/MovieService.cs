using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class MovieService
    {
        public static void AddMovie(string movieName, float? rating, int length, string directorName, int releaseYear,
            AgeRestriction ageRestriction, string synopsis, string releaseCountry, byte[] image)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Movie movie = new Movie()
                {
                    Name = movieName,
                    Rating = rating,
                    Length = length,
                    DirectorName = directorName,
                    ReleaseYear = releaseYear,
                    ReleaseCountry = releaseCountry,
                    AgeRestriction = ageRestriction,
                    Synopsis = synopsis,
                    Image = new Image() {Content = image}
                };
                context.Movies.AddOrUpdate(m => m.Name, movie);
                context.SaveChanges();
            }
        }

        public static void AddCategoryToMovie(string categoryName, string movieName, int releaseYear)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Movie movie = context.Movies.First(m => m.Name == movieName && m.ReleaseYear == releaseYear);
                Category category = context.Categories.First(c => c.Name == categoryName);
                movie.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public static int GetMovieId(string movieName, int releaseYear)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Movies.First(m => m.Name == movieName && m.ReleaseYear == releaseYear).Id;
            }
        }

        public static List<Movie> GetAllMovies()
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context
                    .Movies
                    .Include("Image")
                    .ToList();
            }
        }
        public static string[] GetMoviesNamesByCinema(string cinema,string town)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                var movies=   context.Screenings.Where(s => s.Auditorium.Cinema.Name == cinema && s.Auditorium.Cinema.Town.Name==town)
                        .Select(s => s.Movie.Name).Distinct()
                        .ToArray();
                return movies;
            }
        }

        public static bool IsMovieExisting(string movieName, int releaseYear)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Movies.Any(m => m.Name == movieName && m.ReleaseYear == releaseYear);
            }
        }

        public static AgeRestriction[] GetAgeRestrictions()
        {
            throw new System.NotImplementedException();
        }

        public static Movie GetMovie(string movieName)
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Movies
                    .Include("Image")
                    .Include("Categories")
                    .Include("Cast")
                    .FirstOrDefault(m => m.Name == movieName);
            }
        }
    }
}