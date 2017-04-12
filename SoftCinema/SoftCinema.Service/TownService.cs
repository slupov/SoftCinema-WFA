using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.DTOs;
using SoftCinema.Models;

namespace SoftCinema.Service
{
    public class TownService
    {
        public static void ImportTowns(IEnumerable<TownDТО> towns, SoftCinemaContext context)
        {
            foreach (var townDto in towns)
            {
                if (context.Towns.Any(t => t.Name == townDto.Name))
                {
                    Console.WriteLine($"Town {townDto.Name} has already been imported!");
                    continue;
                }
                if (townDto.Name.Length > 50)
                {
                    Console.WriteLine($"Town name is too long!");
                    continue;
                }
                AddTown(townDto.Name,context);
            }
        }

        public static Town GetTown(string townName,SoftCinemaContext context)
        {
            return context.Towns.FirstOrDefault(t => t.Name == townName);
        }

        public static void AddTown(string townName, SoftCinemaContext context)
        {
            Town town = new Town()
            {
                Name = townName
            };
            context.Towns.Add(town);
            context.SaveChanges();
        }
    }
}
