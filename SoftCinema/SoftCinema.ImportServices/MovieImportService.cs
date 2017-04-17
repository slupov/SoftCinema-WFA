using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using SoftCinema.DTOs;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;

namespace ImportServices
{
    public class MovieImportService
    {
        public static MovieDTOCollection DeserializeMovies(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MovieDTOCollection));
            using (StreamReader reader = new StreamReader(path))
            {
                return (MovieDTOCollection)serializer.Deserialize(reader);
            }
        }

        public static void ImportMoviesCollection(MovieDTOCollection movieDtos)
        {
            foreach (var movieDto in movieDtos.MovieDTOs)
            {
                try
                {
                    ImportMovie(movieDto);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                   
                }
            }
        }

        
        public static void ImportMovie(MovieDTO movieDto)
        {
            string movieName = movieDto.Name;
            InputDataValidator.ValidateStringMaxLength(movieName, Constants.MaxMovieNameLength);

            float? rating = movieDto.Rating;
            InputDataValidator.ValidateFloatInRange(rating, Constants.MinRatingValue, Constants.MaxRatingValue);

            int releaseYear = movieDto.ReleaseYear;
            MovieValidator.ValidateMovieDoesNotExist(movieName,releaseYear);

            List<string> categories = movieDto.Categories.Select(c => c.Name).ToList();
            CategoryValidator.CheckCategoriesExist(categories);

            string directorName = movieDto.DirectorName;
            int length = movieDto.Length;
            AgeRestriction ageRestriction =(AgeRestriction)Enum.Parse(typeof(AgeRestriction),movieDto.AgeRestriction);
            string synopsis = movieDto.Synopsis;
            string releaseCountry = movieDto.ReleaseCountry;
            byte[] image = movieDto.Image;
            
            
            MovieService.AddMovie(movieName, rating, length, directorName, releaseYear, ageRestriction, synopsis,
                releaseCountry,image);
            MovieImportService.AddCategoriesToMovie(movieName,releaseYear,categories);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.MoviesAddedSuccess,movieName));


        }

        public static void AddCategoriesToMovie(string movieName, int releaseYear, List<string> categories)
        {
            foreach (var categoryName in categories)
            {
                MovieService.AddCategoryToMovie(categoryName, movieName, releaseYear);
            }
        }
    }
}
