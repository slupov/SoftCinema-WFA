using SoftCinema.Data.Migrations;
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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SoftCinemaContext, Configuration>());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Cinema> Cinemas { get; set; }
        public virtual DbSet<Auditorium> Auditoriums { get; set; }
        public virtual DbSet<Show> Shows { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Tickets)
                .WithRequired(t => t.Holder);

            modelBuilder.Entity<Cinema>()
                .HasMany(c => c.Auditoriums)
                .WithRequired(a => a.Cinema);

            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Actors)
                .WithMany(a => a.Movies);

            modelBuilder.Entity<Show>()
                .HasRequired(a => a.Auditorium);
        }
    }
}