using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class TicketService
    {
        //TODO: Additional checks and applying discount to ticket price
        public static void AddTicket(Screening screening, decimal price, TicketType type, Seat seat)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                if (!AuthenticationManager.IsAuthenticated())
                {
                    throw new InvalidOperationException("You must log in first!");
                }

                User holder = AuthenticationManager.GetCurrentUser();

                Ticket ticket = new Ticket()
                {
                    HolderId = holder.Id,
                    Price = price,
                    ScreeningId = screening.Id,
                    SeatId = seat.Id,
                    Type = type
                };

                context.Tickets.Add(ticket);
                context.SaveChanges();
            }
        }

        public static List<Ticket> GetTicketsInfo(string username)
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Tickets
                    .Where(t => t.Holder.Username == username)
                    .Include(t => t.Screening.Auditorium)
                    .Include(t => t.Screening.Auditorium.Cinema)
                    .Include(t => t.Screening.Auditorium.Cinema.Town)
                    .Include(t => t.Seat)
                    .Include(t => t.Screening.Movie.Image)
                    .Include(t => t.Screening.Movie)
                    .ToList();
            }
        }
    }
}