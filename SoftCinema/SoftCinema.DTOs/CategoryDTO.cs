using System;
using System.Xml;
using System.Xml.Serialization;

namespace SoftCinema.DTOs
{
    public class CategoryDTО
    {
        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
