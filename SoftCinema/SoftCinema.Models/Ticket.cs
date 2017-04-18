namespace SoftCinema.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Ticket
    {
        public Ticket()
        {
            
        }
        public Ticket(int holderId, int screeningId, int seatId, TicketType type)
        {
            HolderId = holderId;
            ScreeningId = screeningId;
            SeatId = seatId;
            Type = type;
            switch (type)
            {
                case TicketType.Children:
                    Price = Constants.Constants.ChildrenTicketPrice;
                    break;
                case TicketType.Students:
                    Price = Constants.Constants.StudentsTicketPrice;
                    break;
                case TicketType.Regular:
                    Price = Constants.Constants.RegularTicketPrice;
                    break;
                case TicketType.Seniors:
                    Price = Constants.Constants.SeniorsrTicketPrice;
                    break;
                default:
                    break;
            }
        }

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
        public decimal Price { get; set; }
    
        [Required]
        public TicketType Type { get; set; }
    }
}