using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Models
{
    public class Show
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        [Required]
        public int AuditoriumId { get; set; }

        public virtual Auditorium Auditorium { get; set; }

        [Required]
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}