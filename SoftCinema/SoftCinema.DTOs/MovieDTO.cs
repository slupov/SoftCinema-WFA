using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    [Serializable()]
    public class MovieDTO
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Length")]
        public int Length { get; set; }

        [XmlElement("Rating")]
        public float Rating { get; set; }

        [XmlElement("Synopsis")]
        public string Synopsis { get; set; }

        [XmlElement("DirectorName")]
        public string DirectorName { get; set; }

        [XmlElement("ReleaseYear")]
        public int ReleaseYear { get; set; }

        [XmlElement("ReleaseCountry")]
        public string ReleaseCountry { get; set; }

        [XmlElement("AgeRestriction")]
        public string AgeRestriction { get; set; }
    }
}
