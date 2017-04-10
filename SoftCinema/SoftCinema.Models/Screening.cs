
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

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public int AuditoriumId { get; set; }

        public virtual Auditorium Auditorium { get; set; }

        [Required]
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}