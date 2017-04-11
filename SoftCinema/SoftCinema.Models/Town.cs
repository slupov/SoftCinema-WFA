using System.ComponentModel.DataAnnotations.Schema;

namespace SoftCinema.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Town
    {
        public Town()
        {
            this.Cinemas = new HashSet<Cinema>();
            this.ActorsBorn = new HashSet<Actor>();
        }
        [Key]
        public int Id { get; set; }

        [Required,Index(IsUnique = true),MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Cinema> Cinemas { get; set; }

        public virtual ICollection<Actor> ActorsBorn { get; set; }
    }
}
