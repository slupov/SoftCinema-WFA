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


        public static void ValidateScreeningAvailable(int screeningId, DateTime startTime)
        {
            if (!ScreeningService.IsScreeningAvailable(screeningId, startTime))
            {
                throw new InvalidOperationException();
            }
        }
    }
}