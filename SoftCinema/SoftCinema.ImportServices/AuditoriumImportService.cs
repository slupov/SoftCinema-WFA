using System;
using System.IO;
using System.Xml.Serialization;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;

namespace ImportServices
{
    public class AuditoriumImportService
    {
        private readonly AuditoriumService auditoriumService;
        private readonly AuditoriumValidator auditoriumValidator;
        private readonly CinemaService cinemaService;
        private readonly CinemaValidator cinemaValidator;
        private readonly TownService townService;
        private readonly TownValidator townValidator;


        public AuditoriumImportService()
        {
            this.auditoriumService = new AuditoriumService();
            this.auditoriumValidator = new AuditoriumValidator(auditoriumService);
            this.cinemaService = new CinemaService();
            this.cinemaValidator = new CinemaValidator(cinemaService);
            this.townService = new TownService();
            this.townValidator = new TownValidator(townService);
        }

        public  AuditoriumDtoCollection DeserializeAuditoriums(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AuditoriumDtoCollection));
            using (StreamReader reader = new StreamReader(path))
            {
                return (AuditoriumDtoCollection)serializer.Deserialize(reader);
            }
        }

        public  void ImportAuditoriumCollection(AuditoriumDtoCollection auditoriumDtos)
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

        private  void ImportAuditorium(AuditoriumDto auditoriumDto)
        {
            string cinemaName = auditoriumDto.CinemaName;
            InputDataValidator.ValidateStringMaxLength(cinemaName,Constants.MaxCinemaNameLength);

            string townName = auditoriumDto.CinemaTownName;
            townValidator.CheckTownExisting(townName);

            int townId = townService.GetTownId(townName);
            int cinemaId = cinemaService.GetCinemaId(cinemaName, townId);
            cinemaValidator.CheckCinemaExisting(cinemaName, townId);

            byte number = auditoriumDto.Number;
            auditoriumValidator.ValidateAuditoriumDoesNotExist(number, cinemaId, cinemaName);

   

            auditoriumService.AddAuditorium(number,cinemaId);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.AuditoriumAddedSuccess, number, cinemaName,townName));





        }
    }
}
