using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImportServices.Utilities;
using SoftCinema.DTOs;
using SoftCinema.Service;
using SoftCinema.Service.Utilities;
using SoftCinema.Services;

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
            DataValidator.CheckTownExisting(cinemaTown);

            int townId = TownService.GetTownId(cinemaTown);
            string cinemaName = screeningDto.CinemaName;
            DataValidator.CheckCinemaExisting(cinemaName,townId);

            int cinemaId = CinemaService.GetCinemaId(cinemaName, townId);
            DataValidator.CheckAuditoriumExists(auditoriumNumber,cinemaId,cinemaName);

            string movieName = screeningDto.MovieName;
            int movieReleaseYear = screeningDto.MovieReleaseYear;
            DataValidator.CheckMovieExists(movieName,movieReleaseYear);

            int auditoriumId = AuditoriumService.GetAuditoriumId(auditoriumNumber,cinemaId);
            DateTime date = screeningDto.Date;
            DataValidator.ValidateScreeningDoesntExist(auditoriumId, date);

            int movieId = MovieService.GetMovieId(movieName, movieReleaseYear);

            ScreeningService.AddScreening(auditoriumId, movieId, date);

            Console.WriteLine(string.Format(SuccessMessages.ScreeningAddedSuccess,auditoriumNumber,cinemaName));

        }
    }
}
