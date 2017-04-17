using System;
using System.Collections.Generic;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;

namespace ImportServices
{
    public static class TownImportService
    {
        public static void ImportTowns(IEnumerable<TownDTO> towns)
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

        public static void ImportTown(TownDTO townDto)
        {
            string townName = townDto.Name;
            InputDataValidator.ValidateStringMaxLength(townName, Constants.MaxTownNameLength);
            TownValidator.ValidateTownDoesNotExist(townName);

            TownService.AddTown(townName);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.TownAddedSuccess, townName));
        }
    }
}