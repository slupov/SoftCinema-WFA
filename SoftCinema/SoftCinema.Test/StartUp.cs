using SoftCinema.Import;

namespace SoftCinema.Test
{
    class StartUp
    {
        static void Main(string[] args)
        { 
            JSONImport.ImportTowns();
            XMLImport.ImportCinemas();
            XMLImport.ImportAuditoriums();
            JSONImport.ImportCategories();
            XMLImport.ImportMovies();
            JSONImport.ImportActors();
            JSONImport.ImportScreenings();
            JSONImport.ImportSeats();
        }
    }
}
