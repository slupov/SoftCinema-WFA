using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    [Serializable()]
    public class AuditoriumDTO
    {
        [XmlElement("CinemaName")]
        public string CinemaName { get; set; }

        [XmlElement("Number")]
        public byte Number { get; set; }

        [XmlElement("SeatsCount")]
        public int SeatsCount { get; set; }

        [XmlElement("TownName")]
        public string CinemaTownName { get; set; }
    }
}
