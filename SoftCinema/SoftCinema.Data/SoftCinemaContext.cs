using SoftCinema.Data.Configurations;
using SoftCinema.Models;

namespace SoftCinema.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SoftCinemaContext : DbContext
    {
        public SoftCinemaContext()
            : base("name=SoftCinemaContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<Auditorium> Auditoriums { get; set; }
        public virtual DbSet<Screening> Screenings { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieConfiguration());
            modelBuilder.Configurations.Add(new SeatsConfiguration());
        }
    }
}