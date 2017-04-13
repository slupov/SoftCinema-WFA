namespace SoftCinema.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Seat
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Row { get; set; }

        [Required,Index("IX_SeatNumberAuditorium", 1, IsUnique = true)]
        public int Number { get; set; }

        [Required, Index("IX_SeatNumberAuditorium", 2, IsUnique = true)]
        public int AuditoriumId { get; set; }

        public virtual Auditorium Auditorium { get; set; }

    }
}
