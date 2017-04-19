using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Models;

namespace SoftCinema.Services.Utilities
{
    public static class Constants
    {
        public const int MaxCategoryNameLength = 50;
        public const int MaxTownNameLength = 50;
        public const float MinRatingValue = 0;
        public const float MaxRatingValue = 10;
        public const int MaxCinemaNameLength = 50;
        public const int MaxActorNameLength = 50;
        public const int MaxMovieNameLength = 50;
        public const int MinUsernameLength = 3;
        public const int MaxUsernameLength = 25;
        public const decimal RegularTicketPrice = 9.00M;
        public const decimal ChildrenTicketPrice = 5.00M;
        public const decimal StudentsTicketPrice = 7.00M;
        public const decimal SeniorsrTicketPrice = 6.00M;

        public const string GreetingsMessage = "Hello, {0}!";
        public const string DeleteUserMessage = "Are you sure you wand to delete this user?";
        public const string DeleteCategoryMessage = "Are you sure you want to delete this category?";
        public const string DeleteCinemaMessage = "Are you sure you want to delete this cinema?";
        public const string SearchPlaceholder = "Search";
        public const string GoBackPrompt = "Go back?";
        public const string CategoryDeletePrompt = "Delete category?";
        public const string CinemaDeletePrompt = "Delete cinema?";
        public const string DeleteTicketMessage = "Are you sure you want to delete this ticket?";
        public const string TicketDeletePrompt = "Delete ticket?";

        /// <summary>
        /// Cinema {CinemaName} {CinemaTown}: {MovieName} {ScreeningDateTime}
        /// </summary>
        public const string ScreeningTitleLabel = "Cinema {0} {1}: {2} {3}";

        public const char TickMark = '✓';

        public const int MaxTicketCount = 10;

        public static class Colors
        {
            public static Color FreeSeatColor = Color.FromArgb(255, 53, 172, 73);
            public static Color SelectedSeatColor = Color.FromArgb(255, 245, 132, 36);
            public static Color TakenSeatColor = Color.FromArgb(255, 115, 115, 116);
            public static Color ReservedSeatColor = Color.FromArgb(255, 50, 100, 200);
        }

        public static class SuccessMessages
        {
            public const string SuccessfulLogout = "Successfully logged out!";
            public const string SuccessfulLogin = "Successfully logged in!";
            public const string SuccessfulRegister = "Successfully registered!";
            public const string UserUpdatedSuccessfully = "User updated successfully!";
            public const string DeleteUserSuccess = "User successfully deleted!";
            public const string CategoryUpdatedSuccessfully = "Category updated successfully!";
            public const string CategoryCreatedSuccessfully = "Category created successfully!";
            public const string CategoryDeletesSuccessfully = "Category deleted successfully!";
            public const string CinemaUpdatedSuccessfully = "Cinema updated successfully!";
            public const string CinemaDeletedSuccessfully = "Cinema deleted successfully!";
            public const string TicketUpdatedSuccessfully = "Ticket updated successfully!";
            public const string MovieRegisteredSuccessfully = "Movie registered successfully!";
            public const string TicketDeletedSuccessfully = "Ticket deleted successfully!";
        }

        public static class WarningMessages
        {
            public const string UnsavedChanges = "All your unsaved changes will be deleted.";
            public const string CategoryExists = "Category already exists!";
            public const string NoRoles = "(no roles)";
            public const string UsernameFormat = "Username must be 3-25 characters!";
            public const string UsernameTaken = "Username already taken!";
            public const string InvalidEmail = "Email is invalid!";
            public const string EmailTaken = "Email is already taken!";
            public const string PhoneFormat = "Phone must be in 08[789]... format!";
            public const string CinemaExists = "Cinema already exists!";
            public const string MoreThanMaxTicketCountPurchased = "You can't buy more than 10 tickets!";
            public const string noTicketsSelected = "You haven't selected any tickets!";
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
            public const string UserDeleteFail = "User deletion failed!";
            public const string UserIsInactive = "Deleted or inactive user!";
            public const string CategoriesUpdateErrorMessage = "Category update failed!";
            public const string CategoryCreateErrorMessage = "Category create failed!";
            public const string CategoriesDeleteMessage = "Category delete failed!";
            public const string CinemaUpdateErrorMessage = "Cinema update failed!";
            public const string CinemaDeleteMessage = "Cinema delete failed!";
            public const string LoginFirst = "You should log in first!";
            public const string TicketUpdateErrorMessage = "Ticket update failed!";
            public const string TicketDeleteMessage = "Ticket delete failed!";
        }

        public static class ImportSuccessMessages
        {
            public const string ActorAddedSuccess = "Actor {0} successfully added to the database!";

            public const string TownAddedSuccess = "Town {0} successfully added to the database!";

            public const string CategoryAddedSuccess = "Category {0} successfully added to the database!";

            public const string CinemaAddedSuccess = "Cinema {0} successfully added to the database!";

            public const string MoviesAddedSuccess = "Movie {0} successfully added to the database!";

            public const string AuditoriumAddedSuccess = "Auditorium {0} successfully added to cinema {1} - {2}!";

            public const string ScreeningAddedSuccess =
                "Screening successfully added to auditorium {0} in cinema {1}!";

            public const string SeatAddedSuccess =
                "Seat number {0} successfuly added to auditorium number {1} in cinema {2} - {3}!";
        }
    }
}