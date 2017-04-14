namespace SoftCinema.Import
{
    using Newtonsoft.Json;
    using System.IO;
    using System.Collections.Generic;
    using SoftCinema.DTOs;
    using ImportServices;


    public static class JSONImport
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
            CategoryImportService.ImportCategories(categorysDtos);
        }

        public static void ImportScreenings()
        {
            var screeningsJson = File.ReadAllText(DataPaths.ScreeningsJson);
            var screeningDtos = JsonConvert.DeserializeObject<IEnumerable<ScreeeningDto>>(screeningsJson);
            ScreeningImportService.ImportScreenings(screeningDtos);
        }

        public static void ImportSeats()
        {
            var seatsJson = File.ReadAllText(DataPaths.SeatsJson);
            var seatsDtos = JsonConvert.DeserializeObject<IEnumerable<SeatDto>>(seatsJson);
            SeatImportService.ImportSeats(seatsDtos);
        }
    }
}