using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    [XmlRoot("AuditoriumCollection")]
    public class AuditoriumDTOCollection
    {
        public AuditoriumDTOCollection()
        {
            this.AudtioriumDtos = new List<AuditoriumDTO>();
        }

        [XmlArray("auditoriums")]
        [XmlArrayItem("auditorium", typeof(AuditoriumDTO))]
        public List<AuditoriumDTO> AudtioriumDtos { get; set; }
    }
}
