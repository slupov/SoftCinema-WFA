using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class CategoryService
    {
      
        public static void AddCategory(string categoryName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Category category = new Category()
                {
                    Name = categoryName
                };
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public static Category GetCategory(string categoryName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Categories.FirstOrDefault(c => c.Name == categoryName);
            }
        }

        public static bool IsCategoryExisting(string categoryName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                {
                    return (context.Categories.Any(c => c.Name == categoryName));
                }
            }
        }


        public static string[] GetCategoriesNames()
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                {
                    return (context.Categories.Select(c => c.Name).ToArray());
                }
            }
        }

        public static string[] GetMoviesNameAndYearInCategory(string categoryName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                
                    return (context.Categories.FirstOrDefault(c => c.Name == categoryName)
                        .Movies.Select(m => $"\"{m.Name},{m.ReleaseYear}\"").ToArray());
                
            }
        }

        public static string[] GetMoviesNotInCategory(string categoryName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                {
                    List<string> result = new List<string>();
                    foreach (var m in context.Movies)
                    {
                        if (m.Categories.All(c => c.Name != categoryName))
                        {
                            result.Add($"\"{m.Name},{m.ReleaseYear}\"");
                        }
                    }
                    return result.ToArray();

                }
            }
        }


        public static void UpdateCategory(string oldCategoryName, string newCategoryName, List<Tuple<string, int>> addedMovies, List<Tuple<string, int>> notAddedMovies)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Category category = context.Categories.FirstOrDefault(c => c.Name == oldCategoryName);
                category.Name = newCategoryName;
                foreach (var movieTuple in addedMovies)
                {
                    Movie movie = context.Movies.First(m => m.Name == movieTuple.Item1 && m.ReleaseYear == movieTuple.Item2);
                    movie.Categories.Add(category);
                }
                foreach (var movieTuple in notAddedMovies)
                {
                    Movie movie = context.Movies.First(m => m.Name == movieTuple.Item1 && m.ReleaseYear == movieTuple.Item2);
                    movie.Categories.Remove(category);
                }
                context.SaveChanges();
            }
        }

        public static void AddCategoryWithMovies(string categoryName, List<Tuple<string, int>> movies)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Category category = new Category()
                {
                    Name = categoryName
                };
                foreach (var movieTuple in movies)
                {
                    Movie movie =
                        context.Movies.First(m => m.Name == movieTuple.Item1 && m.ReleaseYear == movieTuple.Item2);
                    movie.Categories.Add(category);
                }
                context.SaveChanges();
            }
        }

        public static void RemoveCategory(string categoryName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Category category = context.Categories.FirstOrDefault(c => c.Name == categoryName);
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
