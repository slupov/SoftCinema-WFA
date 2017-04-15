using SoftCinema.Services.Utilities.Validators;

namespace ImportServices
{
    using System;
    using System.Collections.Generic;
    using ImportServices.Utilities;
    using SoftCinema.DTOs;
    using SoftCinema.Services.Utilities;
    using SoftCinema.Services;

    public static class ActorImportService
    {
        public static void ImportActors(IEnumerable<ActorDTO> actors)
        {
            foreach (var actorDto in actors)
            {
                try
                {
                    ImportActor(actorDto);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static void ImportActor(ActorDTO actorDto)
        {
            string actorName = actorDto.Name;
            DataValidator.ValidateStringMaxLength(actorName, Constants.MaxActorNameLength);
            ActorValidator.ValidateActorDoesntExist(actorName);

            float? actorRating = actorDto.Rating;
            DataValidator.ValidateFloatInRange(actorRating, Constants.MinRatingValue, Constants.MaxRatingValue);

            List<ActorMovieDto> movies = actorDto.Movies;
            MovieValidator.CheckMoviesExist(movies);

            ActorService.AddActor(actorName, actorRating);
            ActorImportService.AddMoviesToActor(actorName, movies);

            Console.WriteLine(string.Format(SuccessMessages.ActorAddedSuccess, actorName));
        }

        public static void AddMoviesToActor(string actorName, List<ActorMovieDto> movies)
        {
            foreach (var movieDto in movies)
            {
                string movieName = movieDto.Name;
                int releaseYear = movieDto.ReleaseYear;
                ActorService.AddMovieToActor(actorName, movieName, releaseYear);
            }
        }
    }
}