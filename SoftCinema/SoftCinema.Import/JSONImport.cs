namespace SoftCinema.Import
{
    using Newtonsoft.Json;
    using System.IO;
    using System.Collections.Generic;
    using SoftCinema.DTOs;
    using ImportServices;


    public  class JSONImport
    {
        private readonly TownImportService townImportService;
        private readonly ActorImportService actorImportService;
        private readonly CategoryImportService categoryImportService;
        private readonly ScreeningImportService screeningImportService;
        private readonly SeatImportService seatImportService;

        public JSONImport()
        {
            this.screeningImportService = new ScreeningImportService();
            this.actorImportService = new ActorImportService();
            this.categoryImportService = new CategoryImportService();
            this.seatImportService = new SeatImportService();
            this.townImportService = new TownImportService();
        }

        public  void ImportTowns()
        {
            var townsJson = File.ReadAllText(DataPaths.TownsJson);
            var townDtos = JsonConvert.DeserializeObject<IEnumerable<TownDto>>(townsJson);
            townImportService.ImportTowns(townDtos);
        }

        public  void ImportActors()
        {
            var actorsJson = File.ReadAllText(DataPaths.ActorsJson);
            var actorsDtos = JsonConvert.DeserializeObject<IEnumerable<ActorDto>>(actorsJson);
            actorImportService.ImportActors(actorsDtos);
        }

        public  void ImportCategories()
        {
            var categoriesJson = File.ReadAllText(DataPaths.CategoriesJson);
            var categorysDtos = JsonConvert.DeserializeObject<IEnumerable<CategoryDto>>(categoriesJson);
            categoryImportService.ImportCategories(categorysDtos);
        }

        public  void ImportScreenings()
        {
            var screeningsJson = File.ReadAllText(DataPaths.ScreeningsJson);
            var screeningDtos = JsonConvert.DeserializeObject<IEnumerable<ScreeeningDto>>(screeningsJson);
            screeningImportService.ImportScreenings(screeningDtos);
        }

        public  void ImportSeats()
        {
            var seatsJson = File.ReadAllText(DataPaths.SeatsJson);
            var seatsDtos = JsonConvert.DeserializeObject<IEnumerable<SeatDto>>(seatsJson);
            seatImportService.ImportSeats(seatsDtos);
        }
    }
}