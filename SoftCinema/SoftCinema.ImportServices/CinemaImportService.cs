using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ImportServices.Utilities;
using SoftCinema.DTOs;
using SoftCinema.Service;
using SoftCinema.Service.Utilities;
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
            string cinemaName = cinemaDto.Name;
            string townName = cinemaDto.TownName;
            DataValidator.ValidateStringMaxLength(cinemaName,Constants.MaxCinemaNameLength);
            DataValidator.ValidateStringMaxLength(townName,Constants.MaxTownNameLength);
            TownService.AddTownIfNotExisting(townName);
            int townId = TownService.GetTownId(townName);
            DataValidator.ValidateCinemaExisting(cinemaName, townId);
            CinemaService.AddCinema(cinemaName, townId);
            Console.WriteLine(string.Format(SuccessMessages.CinemaAddedSuccess,cinemaName));
        }
    }
}
