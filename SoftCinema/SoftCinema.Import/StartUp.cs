using SoftCinema.Data;

namespace SoftCinema.Import
{
    class StartUp
    {
        static void Main(string[] args)
        {
            using (var context = new SoftCinemaContext())
            {
                //JSONImport.ImportTowns(context);
                //JSONImport.ImportActors(context);
                //JSONImport.ImportCategories(context);
                //XMLImport.ImportCinemas(context);
                //XMLImport.ImportMovies(context);
                //XMLImport.ImportAuditoriums(context);

                //TODO: Add categories,screenings, etc.
            }
        }
    }
}
