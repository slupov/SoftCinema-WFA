using System;
using System.IO;
using System.Xml.Serialization;
using ImportServices.Utilities;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace ImportServices
{
    public static class CinemaImportService
    {
        public static CinemaDTOCollection DeserializeCinemas(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CinemaDTOCollection));
            using (StreamReader reader = new StreamReader(path))
            {
                return (CinemaDTOCollection) serializer.Deserialize(reader);
            }
        }

        public static void ImportCinemasCollection(CinemaDTOCollection cinemaDtos)
        {
            foreach (var cinemaDto in cinemaDtos.CinemaDtos)
            {
                try
                {
                    ImportCinema(cinemaDto);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void ImportCinema(CinemaDTO cinemaDto)
        {
   
            string townName = cinemaDto.TownName;
            DataValidator.ValidateStringMaxLength(townName,Constants.MaxTownNameLength);
            
            string cinemaName = cinemaDto.Name;
            DataValidator.ValidateStringMaxLength(cinemaName, Constants.MaxCinemaNameLength);

            TownService.AddTownIfNotExisting(townName);
            int townId = TownService.GetTownId(townName);
            DataValidator.ValidateCinemaDoesNotExist(cinemaName, townId);

            CinemaService.AddCinema(cinemaName, townId);

            Console.WriteLine(string.Format(SuccessMessages.CinemaAddedSuccess,cinemaName));
        }
    }
}
