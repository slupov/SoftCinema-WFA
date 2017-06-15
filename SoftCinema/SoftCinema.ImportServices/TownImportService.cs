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
            TownValidator.ValidateTownDoesNotExist(townName);

            TownService.AddTown(townName);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.TownAddedSuccess, townName));
        }
    }
}