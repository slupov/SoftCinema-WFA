using SoftCinema.DTOs;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ImportServices
{
    public class MovieImportService
    {
        private readonly CategoryService categoryService;
        private readonly CategoryValidator categoryValidator;
        private readonly MovieService movieService;
        private readonly MovieValidator movieValidator;

        public MovieImportService()
        {
            this.categoryService = new CategoryService();
            this.categoryValidator = new CategoryValidator(categoryService);
            this.movieService = new MovieService();
            this.movieValidator = new MovieValidator(movieService);
        }

        public MovieDtoCollection DeserializeMovies(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MovieDtoCollection));
            using (StreamReader reader = new StreamReader(path))
            {
                return (MovieDtoCollection)serializer.Deserialize(reader);
            }
        }

        public void ImportMoviesCollection(MovieDtoCollection movieDtos)
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

        public void ImportMovie(MovieDto movieDto)
        {
            string movieName = movieDto.Name;
            InputDataValidator.ValidateStringMaxLength(movieName, Constants.MaxMovieNameLength);

            float? rating = movieDto.Rating;
            InputDataValidator.ValidateFloatInRange(rating, Constants.MinRatingValue, Constants.MaxRatingValue);

            int releaseYear = movieDto.ReleaseYear;
            movieValidator.ValidateMovieDoesNotExist(movieName, releaseYear);

            List<string> categories = movieDto.Categories.Select(c => c.Name).ToList();
            categoryValidator.CheckCategoriesExist(categories);

            string directorName = movieDto.DirectorName;
            int length = movieDto.Length;
            AgeRestriction ageRestriction = (AgeRestriction)Enum.Parse(typeof(AgeRestriction), movieDto.AgeRestriction);
            string synopsis = movieDto.Synopsis;
            string releaseCountry = movieDto.ReleaseCountry;
            byte[] image = movieDto.Image;

            movieService.AddMovie(movieName, rating, length, directorName, releaseYear, ageRestriction, synopsis,
                releaseCountry, image);
            this.AddCategoriesToMovie(movieName, releaseYear, categories);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.MoviesAddedSuccess, movieName));
        }

        public void AddCategoriesToMovie(string movieName, int releaseYear, List<string> categories)
        {
            foreach (var categoryName in categories)
            {
                movieService.AddCategoryToMovie(categoryName, movieName, releaseYear);
            }
        }
    }
}