using SoftCinema.Test.Contracts;

namespace SoftCinema.Test
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            IImportEngine engine = new ImportEngine();
            engine.ImportData();
        }
    }
}