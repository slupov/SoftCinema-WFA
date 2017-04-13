using System.ComponentModel.DataAnnotations.Schema;

namespace SoftCinema.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public class Actor
    {
        public Actor()
        {
            this.Movies = new HashSet<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [Required,Index(IsUnique = true),MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

        [Range(0,10)]
        public float? Rating { get; set; }

        public int? BornTownId { get; set; }

        public virtual Town BornTown { get; set; }
    }
}