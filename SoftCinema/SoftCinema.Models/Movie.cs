using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Models
{
    public class Movie
    {
        public Movie()
        {
            Actors = new HashSet<Actor>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public int Length { get; set; }

        public float Rating { get; set; }

        public string Synopsis { get; set; }

        public ICollection<Actor> Actors { get; set; }

        [Required]
        public string DirectorName { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        public string ReleaseCountry { get; set; }

        //TODO:make enum type
        [Required]
        public string AgeRestriction { get; set; }

        //TODO:categories table
    }
}