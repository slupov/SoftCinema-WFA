using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Services.Utilities
{
    public static class ErrorMessages
    {
        public const string CategoryAlreadyExists = "Category {0} already exists in the database!";

        public const string TownAlreadyExists = "Town {0} already exists in the database!";

        public const string StringExceedsLength = "Input exceeds maximum allowed length : {0} !";

        public const string FloatNotInRange = "Input not in allowed range : [{0},{1}] !";

        public const string CinemaAlreadyExists = "Cinema {0} already exists in the database!";

        public const string AuditoriumAlreadyExists = "Auditorium number {0} already exists in cinema {1}!";

        public const string CinemaDoesntExist =  "Cinema {0} doesn't exist in the database!";

        public const string TownDoesntExist = "Town {0} doesn't exist in the database!";

        public const string MovieAlreadyExists = "Movie {0} already exists in the database!";

        public const string CategoryDoesntExist = "Category {0} doesn't exist in the database!";

        public const string MovieDoesntExist = "Movie {0} doesn't exists in the database!";

        public const string AuditoriumDoesntExist = "Auditorium number {0} doesn't exist in the cinema {1}!";

        public const string ScreeningAlreadyExists = "There is already a screening for the given time!";
    }
    
}
