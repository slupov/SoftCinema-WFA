using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.Import.DTO;
using SoftCinema.Models;

namespace SoftCinema.Service
{
    public class ActorService
    {
        public static void ImportActors(IEnumerable<ActorDto> actors, SoftCinemaContext context)
        {
            foreach (var actorDto in actors)
            {
                Town town = TownService.GetTown(actorDto.BornTownName,context);
                if (town == null)
                {
                    TownService.AddTown(actorDto.BornTownName, context);
                    town = TownService.GetTown(actorDto.BornTownName, context);
                }
                Actor actor = new Actor()
                {
                    Name = actorDto.Name,
                    Rating = actorDto.Rating,
                    BornTownId = town.Id
                };
                context.Actors.Add(actor);
            }
            context.SaveChanges();
        }

        
    }
}
