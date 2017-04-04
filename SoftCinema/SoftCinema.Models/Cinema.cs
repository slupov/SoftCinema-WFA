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
            Auditoriums = new HashSet<Auditorium>();;
        }
        [Key]
        public int Id { get; set; }

        [Required]

        public string Name { get; set; }

        //new table
        public string Town { get; set; }

        public virtual ICollection<Auditorium> Auditoriums { get; set; }

    }
}
