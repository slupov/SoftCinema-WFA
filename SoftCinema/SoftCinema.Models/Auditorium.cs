using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Models
{
    public class Auditorium
    {
        public Auditorium()
        {
            this.Screenings = new HashSet<Screening>();
            this.Seats = new HashSet<Seat>();
        }

        [Key]
        public int Id { get; set; }

        [Required, Index("IX_CinemaNumber", 1, IsUnique = true)]
        public byte Number { get; set; }

        [Required, Index("IX_CinemaNumber", 2, IsUnique = true)]
        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual ICollection<Screening> Screenings { get; set; }

        public virtual ICollection<Seat> Seats { get; set; }

        [Required]
        public int SeatsCount { get; set; }
    }
}