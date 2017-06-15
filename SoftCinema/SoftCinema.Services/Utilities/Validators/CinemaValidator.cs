using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public class CinemaValidator
    {
        private CinemaService cinemaService;

        public CinemaValidator(CinemaService cinemaService)
        {
            this.cinemaService = cinemaService;
        }

        public  void ValidateCinemaDoesNotExist(string cinemaName, int townId)
        {
            if (cinemaService.IsCinemaExisting(cinemaName, townId))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.CinemaAlreadyExists,cinemaName));
            }
        }

        public  void CheckCinemaExisting(string cinemaName, int townId)
        {
            if (!cinemaService.IsCinemaExisting(cinemaName, townId))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.CinemaDoesntExist, cinemaName));
            }
        }
    }
}