using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    [XmlRoot("CinemasCollection")]
    public class CinemaDTOCollection
    {
        public CinemaDTOCollection()
        {
            this.CinemaDtos = new List<CinemaDTO>();
        }

        [XmlArray("Cinemas")]
        [XmlArrayItem("Cinema",typeof(CinemaDTO))]
        public List<CinemaDTO> CinemaDtos { get; set; }
    }
}
