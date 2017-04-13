using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.Models;
using SoftCinema.Service;

namespace SoftCinema.Services
{
    public static class MovieService
    {
        public static void AddMovie(string movieName, float? rating, int length, string directorName, int releaseYear, AgeRestriction ageRestriction, string synopsis, string releaseCountry)
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
                    Synopsis = synopsis

                };
                context.Movies.Add(movie);
                context.SaveChanges();
                
            }
        }

        public static void AddCategoriesToMovie(string movieName,int releaseYear,List<string> categories)
        {
            foreach (var categoryName in categories)
            {
                MovieService.AddCategoryToMovie(categoryName, movieName, releaseYear);
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

        public static bool IsMovieExisting(string movieName, int releaseYear)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Movies.Any(m => m.Name == movieName && m.ReleaseYear == releaseYear);
            }
        }

        
    }
}
