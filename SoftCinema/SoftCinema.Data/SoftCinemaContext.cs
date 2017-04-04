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
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Town> Towns { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Tickets)
                .WithRequired(t => t.Holder)
                .HasForeignKey(t => t.HolderId);
                

            modelBuilder.Entity<Cinema>()
                .HasMany(c => c.Auditoriums)
                .WithRequired(a => a.Cinema)
                .HasForeignKey(a => a.CinemaId);

            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Actors)
                .WithMany(a => a.Movies)
                .Map(ma =>
                {
                    ma.MapLeftKey("ActorId");
                    ma.MapRightKey("MovieId");
                    ma.ToTable("ActorMovies");
                });

            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Categories)
                .WithMany(c => c.Movies)
                .Map(mc =>
                {
                    mc.MapLeftKey("MovieId");
                    mc.MapRightKey("CategoryId");
                    mc.ToTable("MoviesCategories");
                });

            

            modelBuilder.Entity<Show>()
                .HasRequired(s => s.Auditorium)
                .WithMany(a => a.Shows);
        }
    }
}