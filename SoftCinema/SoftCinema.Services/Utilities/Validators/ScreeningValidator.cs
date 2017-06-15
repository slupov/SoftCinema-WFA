using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public  class ScreeningValidator
    {
        private readonly ScreeningService screeningService;

        public ScreeningValidator(ScreeningService screeningService)
        {
            this.screeningService = screeningService;
        }

        public  void ValidateScreeningDoesntExist( int auditoriumId, DateTime date)
        {
            if (screeningService.IsScreeningExisting(auditoriumId, date))
            {
                throw new InvalidOperationException(Constants.ErrorMessages.ScreeningAlreadyExists);
            }
        }


        public  void ValidateScreeningAvailable(int screeningId, DateTime startTime)
        {
            if (!screeningService.IsScreeningAvailable(screeningId, startTime))
            {
                throw new InvalidOperationException();
            }
        }

        public  void ValidateScreeningTimeAvailable(DateTime startTime, int auditoriumId,string movieName,int movieYear)
        {
            if (!screeningService.IsScreeningAvailableInAuditorium(auditoriumId, startTime,movieName,movieYear))
            {
                throw new InvalidOperationException();
            }
        }
    }
}