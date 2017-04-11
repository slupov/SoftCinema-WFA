using SoftCinema.Dtos;
using SoftCinema.Service;

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
            var towns = JsonConvert.DeserializeObject<IEnumerable<TownDto>>(json);
            TownService.ImportTowns(towns, context);
        }

        public static void ImportActors(SoftCinemaContext context)
        {
            var json = File.ReadAllText(@"..\..\Resources\actors.json");
            var actors = JsonConvert.DeserializeObject<IEnumerable<ActorDto>>(json);
            ActorService.ImportActors(actors, context);
        }

        public static void ImportCategories(SoftCinemaContext context)
        {
            var json = File.ReadAllText(@"..\..\Resources\categories.json");
            var categories = JsonConvert.DeserializeObject<IEnumerable<CategoryDto>>(json);
            CategoryService.ImportCategories(categories, context);

        }
    }
}
