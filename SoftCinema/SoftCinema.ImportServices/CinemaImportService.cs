using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;
using System;
using System.IO;
using System.Xml.Serialization;

namespace ImportServices
{
    public class CinemaImportService
    {
        private readonly CinemaService cinemaService;
        private readonly CinemaValidator cinemaValidator;
        private readonly TownService townService;

        public CinemaImportService()
        {
            this.cinemaService = new CinemaService();
            this.cinemaValidator = new CinemaValidator(cinemaService);
            this.townService = new TownService();
        }

        public CinemaDtoCollection DeserializeCinemas(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CinemaDtoCollection));
            using (StreamReader reader = new StreamReader(path))
            {
                return (CinemaDtoCollection)serializer.Deserialize(reader);
            }
        }

        public void ImportCinemasCollection(CinemaDtoCollection cinemaDtos)
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

        private void ImportCinema(CinemaDto cinemaDto)
        {
            string townName = cinemaDto.TownName;
            InputDataValidator.ValidateStringMaxLength(townName, Constants.MaxTownNameLength);

            string cinemaName = cinemaDto.Name;
            InputDataValidator.ValidateStringMaxLength(cinemaName, Constants.MaxCinemaNameLength);

            townService.AddTownIfNotExisting(townName);
            int townId = townService.GetTownId(townName);
            cinemaValidator.ValidateCinemaDoesNotExist(cinemaName, townId);

            cinemaService.AddCinema(cinemaName, townId);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.CinemaAddedSuccess, cinemaName));
        }
    }
}