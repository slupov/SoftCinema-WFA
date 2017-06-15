using SoftCinema.Import;
using SoftCinema.Test.Contracts;

namespace SoftCinema.Test
{
    class StartUp
    {
        static void Main(string[] args)
        { 
            IImportEngine engine = new ImportEngine();
            engine.ImportData();
        }
    }
}
