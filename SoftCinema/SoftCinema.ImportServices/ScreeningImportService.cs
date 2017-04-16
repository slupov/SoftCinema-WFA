using System;
using System.Collections.Generic;
using ImportServices.Utilities;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;

namespace ImportServices
{
    public static class ScreeningImportService
    {
        public static void ImportScreenings(IEnumerable<ScreeeningDto> screeningDtos)
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


        public static void ImportScreening(ScreeeningDto screeningDto)
        {

            byte auditoriumNumber = screeningDto.AuditoriumNumber;

            string cinemaTown = screeningDto.CinemaTown;
            TownValidator.CheckTownExisting(cinemaTown);

            int townId = TownService.GetTownId(cinemaTown);
            string cinemaName = screeningDto.CinemaName;
            CinemaValidator.CheckCinemaExisting(cinemaName,townId);

            int cinemaId = CinemaService.GetCinemaId(cinemaName, townId);
            AuditoriumValidator.CheckAuditoriumExists(auditoriumNumber,cinemaId,cinemaName);

            string movieName = screeningDto.MovieName;
            int movieReleaseYear = screeningDto.MovieReleaseYear;
            MovieValidator.CheckMovieExists(movieName,movieReleaseYear);

            int auditoriumId = AuditoriumService.GetAuditoriumId(auditoriumNumber,cinemaId);
            DateTime date = screeningDto.Date;
            ScreeningValidator.ValidateScreeningDoesntExist(auditoriumId, date);

            int movieId = MovieService.GetMovieId(movieName, movieReleaseYear);

            ScreeningService.AddScreening(auditoriumId, movieId, date);

            Console.WriteLine(string.Format(ImportSuccessMessages.ScreeningAddedSuccess,auditoriumNumber,cinemaName));

        }
    }
}
