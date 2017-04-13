using System.Collections.Generic;

namespace SoftCinema.DTOs
{
    public class ActorDTO
    {
        public ActorDTO()
        {
            this.Movies = new List<ActorMovieDto>();
        }

        public string Name { get; set; }
        public float? Rating { get; set; }
        public string BornTownName { get; set; }

        public List<ActorMovieDto> Movies { get; set; }
    }
}