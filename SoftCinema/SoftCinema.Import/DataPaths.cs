using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Import
{
    public static class DataPaths
    {
        public const string ActorsJson = @"..\..\..\SoftCinema.Import\Resources\actors.json";

        public const string TownsJson = @"..\..\..\SoftCinema.Import\Resources\towns.json";

        public const string CategoriesJson = @"..\..\..\SoftCinema.Import\Resources\categories.json";

        public const string ScreeningsJson = @"..\..\..\SoftCinema.Import\Resources\screenings.json";

        public const string CinemasXml = @"../../../SoftCinema.Import/Resources/cinemas.xml";

        public const string MoviesXml = @"../../../SoftCinema.Import/Resources/movies.xml";

        public const string AuditoriumsXml = @"../../../SoftCinema.Import/Resources/auditoriums.xml";
    }
}
