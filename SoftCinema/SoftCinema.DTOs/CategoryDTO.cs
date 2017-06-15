using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    public class CategoryDto
    {
        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
