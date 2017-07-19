namespace SoftCinema.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public byte[] Content { get; set; }
    }
}