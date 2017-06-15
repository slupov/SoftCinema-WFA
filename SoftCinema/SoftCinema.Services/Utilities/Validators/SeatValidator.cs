using System;
using System.Drawing.Printing;

namespace SoftCinema.Services.Utilities.Validators
{
    public class SeatValidator
    {
        private readonly SeatService seatService;

        public SeatValidator(SeatService seatService)
        {
            this.seatService = seatService;
        }

        public void ValidateSeatDoesntExist(int seatNumber, int auditoriumId, int auditoriumNumber)
        {
            if (seatService.IsSeatExisting(seatNumber, auditoriumId))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.SeatAlreadyExists,seatNumber,auditoriumNumber));
            }
        }
    }
}