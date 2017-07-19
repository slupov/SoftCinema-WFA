using System;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    [Serializable()]
    public class CinemaDto
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("TownName")]
        public string TownName { get; set; }
    }
}