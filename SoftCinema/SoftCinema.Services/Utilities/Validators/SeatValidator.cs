using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public static class SeatValidator
    {
        public static void ValidateSeatDoesntExist(int seatNumber, int auditoriumId, int auditoriumNumber)
        {
            if (SeatService.IsSeatExisting(seatNumber, auditoriumId))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.SeatAlreadyExists,seatNumber,auditoriumNumber));
            }
        }
    }
}