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
    public class CinemaDTO
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("TownName")]
        public string TownName { get; set; }


    }
}
