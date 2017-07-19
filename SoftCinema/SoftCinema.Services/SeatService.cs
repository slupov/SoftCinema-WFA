using SoftCinema.Data;
using SoftCinema.Models;
using System.Collections.Generic;
using System.Linq;

namespace SoftCinema.Services
{
    public class SeatService
    {
        public void AddSeat(int number, int row, int auditoriumId)
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

        public Seat GetSeat(int auditoriumId, byte number)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Seats.FirstOrDefault(s => s.AuditoriumId == auditoriumId && s.Number == number);
            }
        }

        public int[] GetFreeSeatsForScreening(int ticketScreeningId, int auditoriumId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Screening screening = context.Screenings.Find(ticketScreeningId);
                Auditorium auditorium = context.Auditoriums.Find(auditoriumId);
                var seatsId = context.Auditoriums.Find(auditoriumId).Seats.Select(s => s.Id);
                var takenSeatsId = context.Screenings.Find(ticketScreeningId).Tickets.Select(t => t.SeatId);
                var freeSeatsId = seatsId.Where(s => !takenSeatsId.Any(ts => ts == s));
                List<int> seatNumbers = new List<int>();

                foreach (var seat in context.Seats.Where(s => s.AuditoriumId == auditoriumId))
                {
                    if (freeSeatsId.Contains(seat.Id))
                    {
                        seatNumbers.Add(seat.Number);
                    }
                }
                return seatNumbers.ToArray();
            }
        }

        public bool IsSeatExisting(int number, int auditoriumId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Seats.Any(s => s.Number == number && s.AuditoriumId == auditoriumId);
            }
        }
    }
}