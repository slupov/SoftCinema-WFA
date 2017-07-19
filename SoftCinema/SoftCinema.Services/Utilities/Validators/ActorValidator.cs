using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public class ActorValidator
    {
        private readonly ActorService actorService;

        public ActorValidator(ActorService actorService)
        {
            this.actorService = actorService;
        }

        public void ValidateActorDoesntExist(string actorName)
        {
            if (actorService.IsActorExisting(actorName))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.ActorAlreadyExists, actorName));
            }
        }
    }
}