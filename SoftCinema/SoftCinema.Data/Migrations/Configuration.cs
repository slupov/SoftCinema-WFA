using SoftCinema.Models;

namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SoftCinema.Data.SoftCinemaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SoftCinema.Data.SoftCinemaContext context)
        {
            
        }

    }
}
