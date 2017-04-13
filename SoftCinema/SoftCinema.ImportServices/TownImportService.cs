using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImportServices.Utilities;
using SoftCinema.DTOs;
using SoftCinema.Service;
using SoftCinema.Service.Utilities;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Import.ImportServices
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
            DataValidator.ValidateStringMaxLength(townName, Constants.MaxTownNameLength);
            DataValidator.ValidateTownDoesNotExist(townName);

            TownService.AddTown(townName);

            Console.WriteLine(string.Format(SuccessMessages.TownAddedSuccess, townName));
        }

    }
}
