using System.IO;
using System.Runtime.Remoting.Channels;
using SoftCinema.Data.Utilities;
using SoftCinema.Models;

namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Drawing;
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
            SeedEmployees(context);
            
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

            context.Users.AddOrUpdate(u => u.Username, admin);
            context.SaveChanges();
        }

        private void SeedEmployees(SoftCinemaContext context)
        {
            User employee1 = new User()
            {
                Username = "employee1",
                PasswordHash = PasswordHasher.ComputeHash("123", PasswordHasher.Supported_HA.SHA512, null),
                Email = "peshka@softcinema.bg",
                Role = Role.Employee
            };

            User employee2 = new User()
            {
                Username = "employee2",
                PasswordHash = PasswordHasher.ComputeHash("123", PasswordHasher.Supported_HA.SHA512, null),
                Email = "pesho@softcinema.bg",
                Role = Role.Employee
            };

            User employee3 = new User()
            {
                Username = "employee3",
                PasswordHash = PasswordHasher.ComputeHash("123", PasswordHasher.Supported_HA.SHA512, null),
                Email = "vasilka@softcinema.bg",
                Role = Role.Employee
            };

            context.Users.AddOrUpdate(u => u.Username, employee1, employee2, employee3);
            context.SaveChanges();
        }
   
    }
}