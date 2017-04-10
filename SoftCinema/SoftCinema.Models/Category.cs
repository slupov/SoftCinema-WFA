namespace SoftCinema.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Category
    {
        public Category()
        {
            this.Movies = new HashSet<Movie>();
        }

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50),Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
