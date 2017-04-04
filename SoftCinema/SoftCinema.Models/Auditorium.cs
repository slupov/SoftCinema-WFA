using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Models
{
    public class Auditorium
    {
        [Key]
        public int Id { get; set; }

        [Required]

        //Which auditorium at the cinema
        public byte Number { get; set; }

        [Required]
        //make enum in the future (or a new table)
        public string Schema { get; set; }

        [Required]
        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }
    }
}