using System;
using System.Collections.Generic;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Service.Utilities
{
    public static class DataValidator
    {
        public static void ValidateStringMaxLength(string input, int length)
        {
            if (input.Length > length)
            {
                throw new ArgumentException(string.Format(ErrorMessages.StringExceedsLength, length));
            }
        }

        public static void ValidateFloatInRange(float? input, int minValue, int maxValue)
        {
            if (input != null && (input < minValue || input > maxValue))
            {
                throw new ArgumentException(string.Format(ErrorMessages.FloatNotInRange, minValue, maxValue));
            }
        }
        public static void ValidateCategoryDoesNotExist(string categoryName)
        {
            if (CategoryService.IsCategoryExisting(categoryName))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.CategoryAlreadyExists, categoryName));
            }
        }

        public static void CheckCategoriesExist(List<string> categories)
        {
            foreach (var category in categories)
            {
                CheckCategoryExists(category);
            }
        }

        private static void CheckCategoryExists(string categoryName)
        {
            if (!CategoryService.IsCategoryExisting(categoryName))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.CategoryDoesntExist, categoryName));
            }
        }

        public static void ValidateTownDoesNotExist(string townName)
        {
            if (TownService.IsTownExisting(townName))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.TownAlreadyExists,townName));
            }
        }

        public static void CheckTownExisting(string townName)
        {
            if (!TownService.IsTownExisting(townName))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.TownDoesntExist, townName));
            }
        }

        public static void ValidateCinemaDoesNotExist(string cinemaName, int townId)
        {
            if (CinemaService.IsCinemaExisting(cinemaName, townId))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.CinemaAlreadyExists,cinemaName));
            }
        }

        public static void CheckCinemaExisting(string cinemaName, int townId)
        {
            if (!CinemaService.IsCinemaExisting(cinemaName, townId))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.CinemaDoesntExist, cinemaName));
            }
        }

        public static void ValidateAuditoriumDoesNotExist(byte number, int cinemaId, string cinemaName)
        {
            if (AuditoriumService.IsAuditoriumExisting(number, cinemaId))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.AuditoriumAlreadyExists,number,cinemaName));
            }
        }

        public static void CheckAuditoriumExists(byte number, int cinemaId, string cinemaName)
        {
            if (!AuditoriumService.IsAuditoriumExisting(number, cinemaId))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.AuditoriumDoesntExist, number, cinemaName));
            }
        }

        public static void ValidateMovieDoesNotExist(string movieName, int releaseYear)
        {
            if (MovieService.IsMovieExisting(movieName, releaseYear))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.MovieAlreadyExists,movieName));
            }
        }

        public static void CheckMoviesExist(List<ActorMovieDto> movies)
        {
            foreach (var movieDto in movies)
            {
                string movieName = movieDto.Name;
                int releaseYear = movieDto.ReleaseYear;
                CheckMovieExists(movieName, releaseYear);
            }
        }

        public static void CheckMovieExists(string movieName, int releaseYear)
        {
            if (!MovieService.IsMovieExisting(movieName, releaseYear))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.MovieDoesntExist, movieName));
            }
        }


        public static void ValidateScreeningDoesntExist( int auditoriumId, DateTime date)
        {
            if (ScreeningService.IsScreeningExisting(auditoriumId, date))
            {
                throw new InvalidOperationException(ErrorMessages.ScreeningAlreadyExists);
            }
        }

        public static void ValidateSeatDoesntExist(int seatNumber, int auditoriumId, int auditoriumNumber)
        {
            if (SeatService.IsSeatExisting(seatNumber, auditoriumId))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.SeatAlreadyExists,seatNumber,auditoriumNumber));
            }
        }

        public static void ValidateActorDoesntExist(string actorName)
        {
            if (ActorService.IsActorExisting(actorName))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.ActorAlreadyExists,actorName));
            }
        }
    }
}
