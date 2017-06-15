using System.Collections.Generic;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    [XmlRoot("CinemasCollection")]
    public class CinemaDtoCollection
    {
        public CinemaDtoCollection()
        {
            this.CinemaDtos = new List<CinemaDto>();
        }

        [XmlArray("Cinemas")]
        [XmlArrayItem("Cinema",typeof(CinemaDto))]
        public List<CinemaDto> CinemaDtos { get; set; }
    }
}
