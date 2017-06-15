using System;
using System.Collections.Generic;
using SoftCinema.DTOs;

namespace SoftCinema.Services.Utilities.Validators
{
    public class MovieValidator
    {
        private readonly MovieService movieService;

        public MovieValidator(MovieService movieService)
        {
            this.movieService = movieService;
        }

        public void ValidateMovieDoesNotExist(string movieName, int releaseYear)
        {
            if (movieService.IsMovieExisting(movieName, releaseYear))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.MovieAlreadyExists,movieName));
            }
        }

        public void CheckMoviesExist(List<ActorMovieDto> movies)
        {
            foreach (var movieDto in movies)
            {
                string movieName = movieDto.Name;
                int releaseYear = movieDto.ReleaseYear;
                this.CheckMovieExists(movieName, releaseYear);
            }
        }

        public void CheckMovieExists(string movieName, int releaseYear)
        {
            if (!movieService.IsMovieExisting(movieName, releaseYear))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.MovieDoesntExist, movieName));
            }
        }
    }
}

