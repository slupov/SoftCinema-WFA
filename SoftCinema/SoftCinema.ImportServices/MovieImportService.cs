using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using ImportServices.Utilities;
using SoftCinema.DTOs;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

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

        
        private static void ImportMovie(MovieDTO movieDto)
        {
            string movieName = movieDto.Name;
            DataValidator.ValidateStringMaxLength(movieName, Constants.MaxMovieNameLength);

            float? rating = movieDto.Rating;
            DataValidator.ValidateFloatInRange(rating, Constants.MinRatingValue, Constants.MaxRatingValue);

            int releaseYear = movieDto.ReleaseYear;
            DataValidator.ValidateMovieDoesNotExist(movieName,releaseYear);

            List<string> categories = movieDto.Categories.Select(c => c.Name).ToList();
            DataValidator.CheckCategoriesExist(categories);

            string directorName = movieDto.DirectorName;
            int length = movieDto.Length;
            AgeRestriction ageRestriction =(AgeRestriction)Enum.Parse(typeof(AgeRestriction),movieDto.AgeRestriction);
            string synopsis = movieDto.Synopsis;
            string releaseCountry = movieDto.ReleaseCountry;
            
            
            MovieService.AddMovie(movieName, rating, length, directorName, releaseYear, ageRestriction, synopsis,
                releaseCountry);
            MovieService.AddCategoriesToMovie(movieName,releaseYear,categories);

            Console.WriteLine(string.Format(SuccessMessages.MoviesAddedSuccess,movieName));


        }
    }
}
