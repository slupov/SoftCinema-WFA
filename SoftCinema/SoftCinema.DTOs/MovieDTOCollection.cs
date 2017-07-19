using System.Collections.Generic;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    [XmlRoot("MoviesCollection")]
    public class MovieDtoCollection
    {
        public MovieDtoCollection()
        {
            this.MovieDTOs = new List<MovieDto>();
        }

        [XmlArray("movies")]
        [XmlArrayItem("movie", typeof(MovieDto))]
        public List<MovieDto> MovieDTOs { get; set; }
    }
}