using ImportServices;
using SoftCinema.Import.ImportServices;

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
        public static void ImportTowns()
        {
            var townsJson = File.ReadAllText(DataPaths.TownsJson);
            var townDtos = JsonConvert.DeserializeObject<IEnumerable<TownDTO>>(townsJson);
            TownImportService.ImportTowns(townDtos);
        }

        public static void ImportActors()
        {
            var actorsJson = File.ReadAllText(DataPaths.ActorsJson);
            var actorsDtos = JsonConvert.DeserializeObject<IEnumerable<ActorDTO>>(actorsJson);
            ActorImportService.ImportActors(actorsDtos);
        }

        public static void ImportCategories()
        {
            var categoriesJson = File.ReadAllText(DataPaths.CategoriesJson);
            var categorysDtos = JsonConvert.DeserializeObject<IEnumerable<CategoryDTО>>(categoriesJson);
            CategoryImportServices.ImportCategories(categorysDtos);
        }
    }
}