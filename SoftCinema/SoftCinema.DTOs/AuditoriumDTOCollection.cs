using System.Collections.Generic;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    [XmlRoot("AuditoriumCollection")]
    public class AuditoriumDtoCollection
    {
        public AuditoriumDtoCollection()
        {
            this.AudtioriumDtos = new List<AuditoriumDto>();
        }

        [XmlArray("auditoriums")]
        [XmlArrayItem("auditorium", typeof(AuditoriumDto))]
        public List<AuditoriumDto> AudtioriumDtos { get; set; }
    }
}
