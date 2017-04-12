using System;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Service.Utilities
{
    //TODO: Add data validations
    public static class DataValidator
    {
        public static void ValidateCategoryExisting(string categoryName)
        {
            if (CategoryService.IsCategoryExisting(categoryName))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.CategoryAlreadyExists, categoryName));
            }
        }

        public static void ValidateTownExisting(string townName)
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

        public static void ValidateStringMaxLength(string input, int length)
        {
            if (input.Length > length)
            {
                throw new ArgumentException(string.Format(ErrorMessages.StringExceedsLength,length));
            }
        }

        public static void ValidateFloatInRange(float? input, int minValue, int maxValue)
        {
            if (input!= null && (input < minValue || input > maxValue))
            {
                throw new ArgumentException(string.Format(ErrorMessages.FloatNotInRange,minValue,maxValue));
            }
        }

        public static void ValidateCinemaExisting(string cinemaName, int townId)
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

        public static void ValidateAuditoriumExisting(byte number, int cinemaId, string cinemaName)
        {
            if (AuditoriumService.IsAuditoriumExisting(number, cinemaId))
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.AuditoriumAlreadyExists,number,cinemaName));
            }
        }
    }
}
