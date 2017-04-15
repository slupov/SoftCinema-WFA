using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public static class CinemaValidator
    {
        public static void ValidateCinemaDoesNotExist(string cinemaName, int townId)
        {
            if (CinemaService.IsCinemaExisting(cinemaName, townId))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.CinemaAlreadyExists,cinemaName));
            }
        }

        public static void CheckCinemaExisting(string cinemaName, int townId)
        {
            if (!CinemaService.IsCinemaExisting(cinemaName, townId))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.CinemaDoesntExist, cinemaName));
            }
        }
    }
}