using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class SeatService
    {
        public static void AddSeat(int number, int row, int auditoriumId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Seat seat = new Seat()
                {
                    AuditoriumId = auditoriumId,
                    Row = row,
                    Number = number
                };
                context.Seats.Add(seat);
                context.SaveChanges();
            }
        }

        public static bool IsSeatExisting(int number, int auditoriumId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Seats.Any(s => s.Number == number && s.AuditoriumId == auditoriumId);
            }
        }

      
    }
}
