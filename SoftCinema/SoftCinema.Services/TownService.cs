using System.Collections.Generic;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class TownService
    {
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

        public static void AddTownIfNotExisting(string townName)
        {

            if (!IsTownExisting(townName))
            {
                AddTown(townName);
            }

        }

        public static Town GetTown(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Towns.FirstOrDefault(t => t.Name == townName);
            }
        }
        public static string[] GetTownNames()
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Towns.Select(t=>t.Name.ToString()).ToArray();
            }
        }
        public static int GetTownId(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Towns.First(t => t.Name == townName).Id;
            }
        }

        public static bool IsTownExisting(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Towns.Any(t => t.Name == townName);
            }
        }
    }
}
