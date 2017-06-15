using System;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    [Serializable()]
    public class AuditoriumDto
    {
        [XmlElement("CinemaName")]
        public string CinemaName { get; set; }

        [XmlElement("Number")]
        public byte Number { get; set; }

        [XmlElement("TownName")]
        public string CinemaTownName { get; set; }
    }
}
