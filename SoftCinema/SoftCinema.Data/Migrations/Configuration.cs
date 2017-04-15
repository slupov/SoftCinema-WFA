using SoftCinema.Data.Utilities;
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
            SeedAdmin(context);
        }

        private void SeedAdmin(SoftCinemaContext context)
        {
            User admin = new User()
            {
                Username = "Admin",
                PasswordHash = PasswordHasher.ComputeHash("Admin13", PasswordHasher.Supported_HA.SHA512, null),
                Email = "admin@gmail.com",
                Role = Role.Admin,
                PhoneNumber = "0878000000"
            };
            
            context.Users.AddOrUpdate(u => u.Username,admin);
            context.SaveChanges();
        }
    }
}
