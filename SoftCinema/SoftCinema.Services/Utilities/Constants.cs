using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Services.Utilities
{
    public static class Constants
    {
        public const int MaxCategoryNameLength = 50;
        public const int MaxTownNameLength = 50;
        public const int MinRatingValue = 0;
        public const int MaxRatingValue = 10;
        public const int MaxCinemaNameLength = 50;
        public const int MaxActorNameLength = 50;
        public const int MaxMovieNameLength = 50;

        public const string GreetingsMessage = "Hello, {0}!";

        public static class SuccessMessages
        {
            public const string SuccessfulLogout = "Successfully logged out!";
            public const string SuccessfulLogin = "Successfully logged in!";
            public const string UserUpdatedSuccessfully = "User updated successfully!";
        }

        

        public static class ErrorMessages
        {
            public const string CategoryAlreadyExists = "Category {0} already exists in the database!";
            public const string TownAlreadyExists = "Town {0} already exists in the database!";
            public const string StringExceedsLength = "Input exceeds maximum allowed length : {0} !";
            public const string FloatNotInRange = "Input not in allowed range : [{0},{1}] !";
            public const string CinemaAlreadyExists = "Cinema {0} already exists in the database!";
            public const string AuditoriumAlreadyExists = "Auditorium number {0} already exists in cinema {1}!";
            public const string CinemaDoesntExist = "Cinema {0} doesn't exist in the database!";
            public const string TownDoesntExist = "Town {0} doesn't exist in the database!";
            public const string MovieAlreadyExists = "Movie {0} already exists in the database!";
            public const string CategoryDoesntExist = "Category {0} doesn't exist in the database!";
            public const string MovieDoesntExist = "Movie {0} doesn't exists in the database!";
            public const string AuditoriumDoesntExist = "Auditorium number {0} doesn't exist in the cinema {1}!";
            public const string ScreeningAlreadyExists = "There is already a screening for the given time!";
            public const string SeatAlreadyExists = "Seat number {0} already exists in auditorium number {1}!";
            public const string ActorAlreadyExists = "Actor {0} already exists in the database!";
            public const string InvalidLogin = "Login invalid!";
            public const string NoSuchUserExisting = "No such user available!";
            public const string UserUpdateErrorMesage = "User update failed!";
        }

        
    }
}