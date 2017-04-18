using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms.AdminForms.UserForms
{
    public partial class EditUserTicketsForm : Form
    {
        private User user;

        public EditUserTicketsForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        
        private void EditUserTicketsForm_Load(object sender, EventArgs e)
        {
            var tickets = TicketService.GetTicketsInfo(user.Username);
            var imageList = new ImageList();
            int curr = 1;
            foreach (var ticket in tickets)
            {


                imageList.Images.Add(curr.ToString(),ImageProcessor.byteArrayToImage(ticket.Screening.Movie.Image.Content));
                string cinema = ticket.Screening.Auditorium.Cinema.Name + " " +
                                ticket.Screening.Auditorium.Cinema.Town.Name;
                string auditorium = ticket.Screening.Auditorium.Number.ToString();
                string movie = ticket.Screening.Movie.Name + " - " + ticket.Screening.Movie.ReleaseYear;
                string start = ticket.Screening.Start.ToString();
                string seat = ticket.Seat.Number.ToString();
                string[] items = { movie,cinema,auditorium,start,seat};
                ListViewItem item = new ListViewItem(items);
                item.ImageKey = curr.ToString();
                curr++;
                this.TicketsList.Items.Add(item);





            }
            
            TicketsList.LargeImageList = imageList;
         
        }
    }
}
