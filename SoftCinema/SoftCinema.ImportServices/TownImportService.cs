using System;
using System.Collections.Generic;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;

namespace ImportServices
{
    
    public  class TownImportService
    {
        private readonly TownService townService;
        private readonly TownValidator townValidator;

        public TownImportService()
        {
            this.townService = new TownService();
            this.townValidator = new TownValidator(townService);
        }

        public  void ImportTowns(IEnumerable<TownDto> towns)
        {
            foreach (var townDto in towns)
            {
                try
                {
                    ImportTown(townDto);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public  void ImportTown(TownDto townDto)
        {
            string townName = townDto.Name;
            InputDataValidator.ValidateStringMaxLength(townName, Constants.MaxTownNameLength);
            townValidator.ValidateTownDoesNotExist(townName);

            townService.AddTown(townName);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.TownAddedSuccess, townName));
        }
    }
}