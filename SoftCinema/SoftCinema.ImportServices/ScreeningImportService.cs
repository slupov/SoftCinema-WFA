using System;
using System.Collections.Generic;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;

namespace ImportServices
{
    public  class ScreeningImportService
    {
        private readonly AuditoriumService auditoriumService;
        private readonly AuditoriumValidator auditoriumValidator;
        private readonly CinemaService cinemaService;
        private readonly CinemaValidator cinemaValidator;
        private readonly TownService townService;
        private readonly TownValidator townValidator;
        private readonly MovieService movieService;
        private readonly MovieValidator movieValidator;
        private readonly ScreeningService screeningService;
        private readonly ScreeningValidator screeningValidator;


        public ScreeningImportService()
        {
            this.auditoriumService = new AuditoriumService();
            this.cinemaService = new CinemaService();
            this.auditoriumValidator = new AuditoriumValidator(auditoriumService);
            this.cinemaValidator = new CinemaValidator(cinemaService);
            this.movieService = new MovieService();
            this.movieValidator = new MovieValidator(movieService);
            this.townService = new TownService();
            this.townValidator = new TownValidator(townService);
            this.screeningService = new ScreeningService();
            this.screeningValidator = new ScreeningValidator(screeningService);
        }

        public  void ImportScreenings(IEnumerable<ScreeeningDto> screeningDtos)
        {
            foreach (var screeningDto in screeningDtos)
            {
                try
                {
                    ImportScreening(screeningDto);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                  
                }
            }
        }


        public  void ImportScreening(ScreeeningDto screeningDto)
        {

            byte auditoriumNumber = screeningDto.AuditoriumNumber;

            string cinemaTown = screeningDto.CinemaTown;
            townValidator.CheckTownExisting(cinemaTown);

            int townId = townService.GetTownId(cinemaTown);
            string cinemaName = screeningDto.CinemaName;
            cinemaValidator.CheckCinemaExisting(cinemaName,townId);

            int cinemaId = cinemaService.GetCinemaId(cinemaName, townId);
            auditoriumValidator.CheckAuditoriumExists(auditoriumNumber,cinemaId,cinemaName);

            string movieName = screeningDto.MovieName;
            int movieReleaseYear = screeningDto.MovieReleaseYear;
            movieValidator.CheckMovieExists(movieName,movieReleaseYear);

            int auditoriumId = auditoriumService.GetAuditoriumId(auditoriumNumber,cinemaId);
            DateTime date = screeningDto.Date;
            screeningValidator.ValidateScreeningDoesntExist(auditoriumId, date);

            int movieId = movieService.GetMovieId(movieName, movieReleaseYear);

            screeningService.AddScreening(auditoriumId, movieId, date);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.ScreeningAddedSuccess,auditoriumNumber,cinemaName));

        }
    }
}
