using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Models
{
    public class Cinema
    {
        public Cinema()
        {
            this.Auditoriums = new HashSet<Auditorium>();;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? TownId { get; set; }

        public virtual Town Town { get; set; }

        public virtual ICollection<Auditorium> Auditoriums { get; set; }

    }
}
