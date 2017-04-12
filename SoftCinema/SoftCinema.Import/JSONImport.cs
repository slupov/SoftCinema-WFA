namespace SoftCinema.Import
{
    using Newtonsoft.Json;
    using System.IO;
    using System.Collections.Generic;
    using SoftCinema.Data;
    using SoftCinema.DTOs;
    using SoftCinema.Service;

    class JSONImport
    {
        public static void ImportTowns(SoftCinemaContext context)
        {
            var json = File.ReadAllText(@"..\..\Resources\towns.json");
            var towns = JsonConvert.DeserializeObject<IEnumerable<TownDТО>>(json);
            TownService.ImportTowns(towns, context);
        }

        public static void ImportActors(SoftCinemaContext context)
        {
            var json = File.ReadAllText(@"..\..\Resources\actors.json");
            var actors = JsonConvert.DeserializeObject<IEnumerable<ActorDТО>>(json);
            ActorService.ImportActors(actors, context);
        }

        public static void ImportCategories(SoftCinemaContext context)
        {
            var json = File.ReadAllText(@"..\..\Resources\categories.json");
            var categories = JsonConvert.DeserializeObject<IEnumerable<CategoryDТО>>(json);
            CategoryService.ImportCategories(categories, context);
        }
    }
}