using System.ComponentModel.DataAnnotations.Schema;

namespace SoftCinema.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        [Key]
        public int Id { get; set; }

        public int Size { get; set; }

        [Required]
        public byte[] Content { get; set; }
    }
}