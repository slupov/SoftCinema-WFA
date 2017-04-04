using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Models
{
    public class Town
    {
        public Town()
        {
            this.Cinemas = new HashSet<Cinema>();
            this.ActorsBorn = new HashSet<Actor>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Cinema> Cinemas { get; set; }

        public virtual ICollection<Actor> ActorsBorn { get; set; }
    }
}
