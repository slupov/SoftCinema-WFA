namespace SoftCinema.Import
{
    using Newtonsoft.Json;
    using Models;
    using System.IO;
    using System.Collections.Generic;
    using Data;
    using System.Data.Entity.Migrations;
    using DTO;
    using System.Linq;

    class JSONImport
    {
        public static void ImportTowns(SoftCinemaContext context)
        {
            var json = File.ReadAllText(@"..\..\Resources\towns.json");
            var towns = JsonConvert.DeserializeObject<IEnumerable<Town>>(json);

            foreach (var town in towns)
            {
                context.Towns.AddOrUpdate(t => t.Name,town);
            }
            context.SaveChanges();
        }

        public static void ImportActors(SoftCinemaContext context)
        {
            var json = File.ReadAllText(@"..\..\Resources\actors.json");
            var actors = JsonConvert.DeserializeObject<IEnumerable<ActorDTO>>(json);

            foreach (var actor in actors)
            {
                context.Actors.AddOrUpdate(a => a.Name, new Actor()
                {

                    Name = actor.Name,
                    Rating = actor.Rating,
                    BornTown = context.Towns.Single(t => t.Name == actor.BornTownName)
                });
            }
            context.SaveChanges();
        }

    }
}
