using System;
using System.IO;
using System.Xml.Serialization;
using ImportServices.Utilities;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;

namespace ImportServices
{
    public class AuditoriumImportService
    {
        public static AuditoriumDTOCollection DeserializeAuditoriums(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AuditoriumDTOCollection));
            using (StreamReader reader = new StreamReader(path))
            {
                return (AuditoriumDTOCollection)serializer.Deserialize(reader);
            }
        }

        public static void ImportAuditoriumCollection(AuditoriumDTOCollection auditoriumDtos)
        {
            foreach (var auditoriumDto in auditoriumDtos.AudtioriumDtos)
            {
                try
                {
                    ImportAuditorium(auditoriumDto);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                }
            }
        }

        private static void ImportAuditorium(AuditoriumDTO auditoriumDto)
        {
            string cinemaName = auditoriumDto.CinemaName;
            DataValidator.ValidateStringMaxLength(cinemaName,Constants.MaxCinemaNameLength);

            string townName = auditoriumDto.CinemaTownName;
            TownValidator.CheckTownExisting(townName);

            int townId = TownService.GetTownId(townName);
            int cinemaId = CinemaService.GetCinemaId(cinemaName, townId);
            CinemaValidator.CheckCinemaExisting(cinemaName, townId);

            byte number = auditoriumDto.Number;
            AuditoriumValidator.ValidateAuditoriumDoesNotExist(number, cinemaId, cinemaName);

   

            AuditoriumService.AddAuditorium(number,cinemaId);

            Console.WriteLine(string.Format(SuccessMessages.AuditoriumAddedSuccess, number, cinemaName,townName));





        }
    }
}
