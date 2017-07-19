using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;
using System;
using System.Collections.Generic;

namespace ImportServices
{
    public class ActorImportService
    {
        private readonly ActorService actorService;
        private readonly ActorValidator actorValidator;
        private readonly MovieService movieService;
        private readonly MovieValidator movieValidator;

        public ActorImportService()
        {
            this.actorService = new ActorService();
            this.actorValidator = new ActorValidator(actorService);
            this.movieService = new MovieService();
            this.movieValidator = new MovieValidator(movieService);
        }

        public void ImportActors(IEnumerable<ActorDto> actors)
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

        public void ImportActor(ActorDto actorDto)
        {
            string actorName = actorDto.Name;
            InputDataValidator.ValidateStringMaxLength(actorName, Constants.MaxActorNameLength);
            actorValidator.ValidateActorDoesntExist(actorName);

            float? actorRating = actorDto.Rating;
            InputDataValidator.ValidateFloatInRange(actorRating, Constants.MinRatingValue, Constants.MaxRatingValue);

            List<ActorMovieDto> movies = actorDto.Movies;
            movieValidator.CheckMoviesExist(movies);

            actorService.AddActor(actorName, actorRating);
            this.AddMoviesToActor(actorName, movies);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.ActorAddedSuccess, actorName));
        }

        public void AddMoviesToActor(string actorName, List<ActorMovieDto> movies)
        {
            foreach (var movieDto in movies)
            {
                string movieName = movieDto.Name;
                int releaseYear = movieDto.ReleaseYear;
                actorService.AddMovieToActor(actorName, movieName, releaseYear);
            }
        }
    }
}