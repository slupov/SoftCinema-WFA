using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Models
{
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
