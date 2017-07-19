using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public class TownValidator
    {
        private readonly TownService townService;

        public TownValidator(TownService townService)
        {
            this.townService = townService;
        }

        public void ValidateTownDoesNotExist(string townName)
        {
            if (townService.IsTownExisting(townName))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.TownAlreadyExists, townName));
            }
        }

        public void CheckTownExisting(string townName)
        {
            if (!townService.IsTownExisting(townName))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.TownDoesntExist, townName));
            }
        }
    }
}