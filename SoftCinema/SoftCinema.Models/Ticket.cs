namespace SoftCinema.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int HolderId { get; set; }

        public virtual User Holder { get; set; }

        [Required,Index("IX_ScreeningSeat", 1, IsUnique = true)]
        public int ScreeningId { get; set; }

        public virtual Screening Screening { get; set; }

        [Required,Index("IX_ScreeningSeat", 2, IsUnique = true)]
        public int SeatId { get; set; }

        public virtual Seat Seat { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public TicketType Type { get; set; }
    }
}