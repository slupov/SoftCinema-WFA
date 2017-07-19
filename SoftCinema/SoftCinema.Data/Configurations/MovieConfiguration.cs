using SoftCinema.Models;
using System.Data.Entity.ModelConfiguration;

namespace SoftCinema.Data.Configurations
{
    public class MovieConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            this
                 .HasMany(m => m.Cast)
                 .WithMany(a => a.Movies)
                 .Map(ma =>
                 {
                     ma.MapLeftKey("MovieId");
                     ma.MapRightKey("ActorId");
                     ma.ToTable("ActorMovies");
                 });

            this
                .HasMany(m => m.Categories)
                .WithMany(c => c.Movies)
                .Map(mc =>
                {
                    mc.MapLeftKey("MovieId");
                    mc.MapRightKey("CategoryId");
                    mc.ToTable("MoviesCategories");
                });
        }
    }
}