using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Models;

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
                    ma.MapLeftKey("ActorId");
                    ma.MapRightKey("MovieId");
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
