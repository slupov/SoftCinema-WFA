using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImportServices.Utilities;
using SoftCinema.DTOs;
using SoftCinema.Models;
using SoftCinema.Service;
using SoftCinema.Service.Utilities;
using SoftCinema.Services.Utilities;

namespace ImportServices
{
    public static class ActorImportService
    {
        public static void ImportActors(IEnumerable<ActorDTO> actors)
        {

            foreach (var actorDto in actors)
            {
                try
                {
                    ImportActor(actorDto);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }

        public static void ImportActor(ActorDTO actorDto)
        {
            string actorName = actorDto.Name;
            float? actorRating = actorDto.Rating;
            string townName = actorDto.BornTownName;
            DataValidator.ValidateStringMaxLength(townName, Constants.MaxTownNameLength);
            DataValidator.ValidateFloatInRange(actorRating.Value, Constants.MinRatingValue, Constants.MaxRatingValue);
            Town town = TownService.GetTown(townName);
            if (town == null)
            {
                TownService.AddTown(townName);
                town = TownService.GetTown(townName);
            }
            int bornTownId = town.Id;
            ActorService.AddActor(actorName, actorRating, bornTownId);
            Console.WriteLine(string.Format(SuccessMessages.ActorAddedSuccess,actorName));
        }
    }
}
