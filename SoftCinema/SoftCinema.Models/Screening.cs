using System.ComponentModel.DataAnnotations.Schema;

namespace SoftCinema.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Screening
    {
        public Screening()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        [Key]
        public int Id { get; set; }

        [Required, Index("IX_MovieAuditoriumDate", 3, IsUnique = true)]
        public DateTime Start { get; set; }

        [Required, Index("IX_MovieAuditoriumDate", 2, IsUnique = true)]
        public int AuditoriumId { get; set; }

        public virtual Auditorium Auditorium { get; set; }

        [Required, Index("IX_MovieAuditoriumDate", 1, IsUnique = true)]
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public bool Contains(int seatNumber)
        {
            foreach (var ticket in this.Tickets)
            {
                if (ticket.Seat.Number == seatNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }
}