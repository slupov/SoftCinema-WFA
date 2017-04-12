using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.DTOs;
using SoftCinema.Models;
using SoftCinema.Service.Utilities;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Service
{
    public class TownService
    {
        public static Town GetTown(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Towns.FirstOrDefault(t => t.Name == townName);
            }
        }

        public static void AddTown(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Town town = new Town()
                {
                    Name = townName
                };
                context.Towns.Add(town);
                context.SaveChanges();
            }
        }

        public static bool IsTownExisting(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Towns.Any(t => t.Name == townName);
            }
        }


        public static void AddTownIfNotExisting(string townName)
        {
            
            if (!IsTownExisting(townName))
            {
                AddTown(townName);
            }
            
        }

        public static int GetTownId(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Towns.First(t => t.Name == townName).Id;
            }
        }
    }
}
