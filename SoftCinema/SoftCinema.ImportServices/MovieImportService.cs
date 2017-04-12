using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ImportServices.Utilities;
using SoftCinema.DTOs;
using SoftCinema.Models;
using SoftCinema.Service.Utilities;
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
            foreach (var movieDto in movieDtos.MovieDTtos)
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

        //TODO: Add additional validations
        private static void ImportMovie(MovieDTO movieDto)
        {
            string movieName = movieDto.Name;
            string directorName = movieDto.DirectorName;
            float? rating = movieDto.Rating;
            int length = movieDto.Length;
            int releaseYear = movieDto.ReleaseYear;
            AgeRestriction ageRestriction =(AgeRestriction)Enum.Parse(typeof(AgeRestriction),movieDto.AgeRestriction);
            string synopsis = movieDto.Synopsis;
            string releaseCountry = movieDto.ReleaseCountry;
            DataValidator.ValidateFloatInRange(rating, Constants.MinRatingValue, Constants.MaxRatingValue);
            MovieService.AddMovie(movieName, rating, length, directorName, releaseYear, ageRestriction, synopsis,
                releaseCountry);
            Console.WriteLine(string.Format(SuccessMessages.MoviesAddedSuccess,movieName));


        }
    }
}
