using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public static class TownValidator
    {
        public static void ValidateTownDoesNotExist(string townName)
        {
            if (TownService.IsTownExisting(townName))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.TownAlreadyExists,townName));
            }
        }

        public static void CheckTownExisting(string townName)
        {
            if (!TownService.IsTownExisting(townName))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.TownDoesntExist, townName));
            }
        }
    }
}