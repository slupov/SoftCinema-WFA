using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;
using System;
using System.Collections.Generic;

namespace ImportServices
{
    public class SeatImportService
    {
        private readonly AuditoriumService auditoriumService;
        private readonly AuditoriumValidator auditoriumValidator;
        private readonly CinemaService cinemaService;
        private readonly CinemaValidator cinemaValidator;
        private readonly TownService townService;
        private readonly TownValidator townValidator;
        private readonly SeatService seatService;
        private readonly SeatValidator seatValidator;

        public SeatImportService()
        {
            this.auditoriumService = new AuditoriumService();
            this.cinemaService = new CinemaService();
            this.auditoriumValidator = new AuditoriumValidator(auditoriumService);
            this.cinemaValidator = new CinemaValidator(cinemaService);
            this.townService = new TownService();
            this.townValidator = new TownValidator(townService);
            this.seatService = new SeatService();
            this.seatValidator = new SeatValidator(seatService);
        }

        public void ImportSeats(IEnumerable<SeatDto> seatsDtos)
        {
            foreach (var seatDto in seatsDtos)
            {
                try
                {
                    ImportSeat(seatDto);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void ImportSeat(SeatDto seatDto)
        {
            string cinemaTown = seatDto.CinemaTown;
            townValidator.CheckTownExisting(cinemaTown);

            int townId = townService.GetTownId(cinemaTown);
            string cinemaName = seatDto.CinemaName;
            cinemaValidator.CheckCinemaExisting(cinemaName, townId);

            int cinemaId = cinemaService.GetCinemaId(cinemaName, townId);
            byte auditoriumNumber = seatDto.AuditoriumNumber;
            auditoriumValidator.CheckAuditoriumExists(auditoriumNumber, cinemaId, cinemaName);

            int auditoriumId = auditoriumService.GetAuditoriumId(auditoriumNumber, cinemaId);
            int row = seatDto.Row;
            int number = seatDto.Number;
            seatValidator.ValidateSeatDoesntExist(number, auditoriumId, auditoriumNumber);

            seatService.AddSeat(number, row, auditoriumId);
            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.SeatAddedSuccess, number, auditoriumNumber, cinemaName, cinemaTown));
        }
    }
}