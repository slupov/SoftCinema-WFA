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
            DataValidator.CheckTownExisting(townName);

            int townId = TownService.GetTownId(townName);
            int cinemaId = CinemaService.GetCinemaId(cinemaName, townId);
            DataValidator.CheckCinemaExisting(cinemaName, townId);

            byte number = auditoriumDto.Number;
            DataValidator.ValidateAuditoriumDoesNotExist(number, cinemaId, cinemaName);

   

            AuditoriumService.AddAuditorium(number,cinemaId);

            Console.WriteLine(string.Format(SuccessMessages.AuditoriumAddedSuccess, number, cinemaName));





        }
    }
}
