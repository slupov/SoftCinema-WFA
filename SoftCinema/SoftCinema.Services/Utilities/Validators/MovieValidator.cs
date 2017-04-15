using System;
using System.Collections.Generic;
using SoftCinema.DTOs;

namespace SoftCinema.Services.Utilities.Validators
{
    public static class MovieValidator
    {
        public static void ValidateMovieDoesNotExist(string movieName, int releaseYear)
        {
            if (MovieService.IsMovieExisting(movieName, releaseYear))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.MovieAlreadyExists,movieName));
            }
        }

        public static void CheckMoviesExist(List<ActorMovieDto> movies)
        {
            foreach (var movieDto in movies)
            {
                string movieName = movieDto.Name;
                int releaseYear = movieDto.ReleaseYear;
                MovieValidator.CheckMovieExists(movieName, releaseYear);
            }
        }

        public static void CheckMovieExists(string movieName, int releaseYear)
        {
            if (!MovieService.IsMovieExisting(movieName, releaseYear))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.MovieDoesntExist, movieName));
            }
        }
    }
}

