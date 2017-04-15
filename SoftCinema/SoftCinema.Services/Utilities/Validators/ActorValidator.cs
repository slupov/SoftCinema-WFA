using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public static class ActorValidator
    {
        public static void ValidateActorDoesntExist(string actorName)
        {
            if (ActorService.IsActorExisting(actorName))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.ActorAlreadyExists,actorName));
            }
        }
    }
}