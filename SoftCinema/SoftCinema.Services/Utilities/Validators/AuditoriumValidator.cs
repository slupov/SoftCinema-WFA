using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public static class AuditoriumValidator
    {
        public static void ValidateAuditoriumDoesNotExist(byte number, int cinemaId, string cinemaName)
        {
            if (AuditoriumService.IsAuditoriumExisting(number, cinemaId))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.AuditoriumAlreadyExists,number,cinemaName));
            }
        }

        public static void CheckAuditoriumExists(byte number, int cinemaId, string cinemaName)
        {
            if (!AuditoriumService.IsAuditoriumExisting(number, cinemaId))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.AuditoriumDoesntExist, number, cinemaName));
            }
        }
    }
}