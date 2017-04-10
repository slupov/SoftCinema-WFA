namespace SoftCinema.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class Cinema
    {
        public Cinema()
        {
            this.Auditoriums = new HashSet<Auditorium>();;
        }

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50), Index("IX_CinemaTown", 1, IsUnique = true)]
        public string Name { get; set; }

        [Required,Index("IX_CinemaTown", 2, IsUnique = true)]
        public int TownId { get; set; }

        public virtual Town Town { get; set; }

        public virtual ICollection<Auditorium> Auditoriums { get; set; }

    }
}
