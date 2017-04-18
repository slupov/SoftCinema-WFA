﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.Models;
using SoftCinema.Models.Constants;

namespace SoftCinema.Services
{
    public static class TicketService
    {
      
        public static void AddTicket(int screeningId, TicketType type, int seatId,int holderId)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                decimal price = 0;
                switch (type)
                {
                    case TicketType.Children:
                        price = Constants.ChildrenTicketPrice;
                        break;
                    case TicketType.Students:
                        price = Constants.StudentsTicketPrice;
                        break;
                    case TicketType.Regular:
                        price = Constants.RegularTicketPrice;
                        break;
                    case TicketType.Seniors:
                        price = Constants.SeniorsrTicketPrice;
                        break;
                    default:
                        break;
                }
                Ticket ticket = new Ticket()
                {
                    HolderId = holderId,
                    ScreeningId = screeningId,
                    SeatId = seatId,
                    Type = type,
                    Price = price
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