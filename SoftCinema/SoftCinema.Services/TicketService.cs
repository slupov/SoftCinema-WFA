﻿namespace SoftCinema.Service
{
    using System;
    using Data;
    using Models;

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
    }
}