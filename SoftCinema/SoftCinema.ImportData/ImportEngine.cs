using SoftCinema.Import;
using SoftCinema.Test.Contracts;

namespace SoftCinema.Test
{
    public class ImportEngine : IImportEngine
    {
        private readonly JSONImport jsonImport;
        private readonly XMLImport xmlImport;

        public ImportEngine()
        {
            this.jsonImport = new JSONImport();
            this.xmlImport = new XMLImport();
        }

        public void ImportData()
        {
            jsonImport.ImportTowns();
            xmlImport.ImportCinemas();
            xmlImport.ImportAuditoriums();
            jsonImport.ImportCategories();
            xmlImport.ImportMovies();
            jsonImport.ImportActors();
            jsonImport.ImportScreenings();
            jsonImport.ImportSeats();
        }
    }
}