using System.Collections.Generic;

namespace SoftCinema.DTOs
{
    public class ActorDto
    {
        public ActorDto()
        {
            this.Movies = new List<ActorMovieDto>();
        }

        public string Name { get; set; }
        public float? Rating { get; set; }

        public List<ActorMovieDto> Movies { get; set; }
    }
}