using System.Collections.Generic;
using SoftCinema.Data;
using SoftCinema.DTOs;
using SoftCinema.Models;
using SoftCinema.Service.Utilities;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Service
{
    public class ActorService
    {
        
        public static void AddActor(string name, float? rating, int bornTownId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Actor actor = new Actor()
                {
                    Name = name,
                    Rating = rating,
                    BornTownId = bornTownId
                };
                context.Actors.Add(actor);
                context.SaveChanges();
            }
        }


    }
}
