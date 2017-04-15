using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public static class ScreeningValidator
    {
        public static void ValidateScreeningDoesntExist( int auditoriumId, DateTime date)
        {
            if (ScreeningService.IsScreeningExisting(auditoriumId, date))
            {
                throw new InvalidOperationException(Constants.ErrorMessages.ScreeningAlreadyExists);
            }
        }
    }
}