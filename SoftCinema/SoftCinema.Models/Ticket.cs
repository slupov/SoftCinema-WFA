namespace SoftCinema.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Ticket
    {
        private decimal price;

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
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                switch (this.Type)
                {
                    case TicketType.Children:
                        this.price = 5.00M;
                        break;
                    case TicketType.Students:
                        this.price = 6.00M;
                        break;
                    case TicketType.Regular:
                        this.price = 9.00M;
                        break;
                    case TicketType.Seniors:
                        this.price = 7.00M;
                        break;
                    default:
                        break;
                }
            }
        }
        [Required]
        public TicketType Type { get; set; }
    }
}