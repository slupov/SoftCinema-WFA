using System.Collections.Generic;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public  class TownService
    {
        public  void AddTown(string townName)
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

        public  void AddTownIfNotExisting(string townName)
        {

            if (!IsTownExisting(townName))
            {
                AddTown(townName);
            }

        }

        public  Town GetTown(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Towns.FirstOrDefault(t => t.Name == townName);
            }
        }
        public  string[] GetTownsNames()
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                var result= context.Towns.Select(t => t.Name).ToArray();
                return result;
            }
        }
        public  int GetTownId(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Towns.First(t => t.Name == townName).Id;
            }
        }

        public  bool IsTownExisting(string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Towns.Any(t => t.Name == townName);
            }
        }
    }
}
