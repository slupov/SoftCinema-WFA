using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportServices.Utilities
{
    public static class SuccessMessages
    {
        public const string ActorAddedSuccess = "Actor {0} successfully added to the database!";

        public const string TownAddedSuccess = "Town {0} successfully added to the database!";

        public const string CategoryAddedSuccess = "Category {0} successfully added to the database!";

        public const string CinemaAddedSuccess = "Cinema {0} successfully added to the database!";

        public const string MoviesAddedSuccess = "Movie {0} successfully added to the database!";

        public const string AuditoriumAddedSuccess = "Auditorium {0} successfully added to cinema {1} - {2}!";

        public const string ScreeningAddedSuccess = "Screening successfully added to auditorium {0} in cinema {1}!";

        public const string SeatAddedSuccess =
            "Seat number {0} successfuly added to auditorium number {1} in cinema {2} - {3}!";
    }
}
