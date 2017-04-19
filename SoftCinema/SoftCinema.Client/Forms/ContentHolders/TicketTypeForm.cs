using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms.ContentHolders
{
    public partial class TicketTypeForm : ContentHolderForm
    {
        private decimal _regularPrice = 0M;
        private decimal _childrenPrice = 0M;
        private decimal _seniorPrice = 0M;
        private decimal _studentPrice = 0M;
        private int ChildrenTicketsCount { get; set; }
        private int RegularTicketsCount { get; set; }
        private int SeniorsTicketsCount { get; set; }
        private int StudentsTicketsCount { get; set; }
        private bool areTicketsMoreThanMaxCount(int ticketsQuantity)
        {
            if (ticketsQuantity > Constants.MaxTicketCount)
            {
                return true;
            }
            return false;
        }
          private bool goodForChildren()
          {
              var restr = TicketForm.Screening.Movie.AgeRestriction.ToString();
              if (restr != "D" && restr != "X")
            { return true; }
                  
              return false;
          }
        public TicketTypeForm()
        {
            InitializeComponent();
            this.notGood.Hide();
            if (!this.goodForChildren())
            {
                this.childrenQuantityComboBox.Enabled = false;
                this.notGood.Text = "This movie is not appropriate for children!";
                this.notGood.ForeColor=Color.Red;
                this.notGood.Show();
            }
        }

        private void purchase_Click(object sender, EventArgs e)
        {
           
            var ticketsQuantity = calculate_Quantity();
            if (areTicketsMoreThanMaxCount(ticketsQuantity) == false)
            {
                if (ticketsQuantity == 0)
                {
                    this.ticketLimit.Text = Constants.WarningMessages.noTicketsSelected;
                    this.ticketLimit.Show();
                }
                else
                {
                    SelectSeatsForm selectSeatsForm = new SelectSeatsForm(TicketForm.Screening, ticketsQuantity,RegularTicketsCount,ChildrenTicketsCount,SeniorsTicketsCount,StudentsTicketsCount);
                    
                    selectSeatsForm.ShowDialog(this);
                    }
            }
            else
            {
                this.ticketLimit.Text = Constants.WarningMessages.MoreThanMaxTicketCountPurchased;
                this.ticketLimit.Show();
            }
        }

        
        private int calculate_Quantity()
        {
            return this.ChildrenTicketsCount + this.SeniorsTicketsCount + this.StudentsTicketsCount + this.RegularTicketsCount;
        }

        private void TicketTypeForm_Load(object sender, EventArgs e)
        {
            this.regularQuantityComboBox.SelectedIndex = 0;
            this.childrenQuantityComboBox.SelectedIndex = 0;
            this.seniorsQuantityComboBox.SelectedIndex = 0;
            this.studentsQuantityComboBox.SelectedIndex = 0;
            this.ticketLimit.Hide();
            if (ShouldCancelReservations(TicketForm.Screening, new TimeSpan(40, 20, 0)))
            {
                CancelReservations(TicketForm.Screening);
            }
        }
        public static bool ShouldCancelReservations(Screening screening, TimeSpan t)
        {
            var diffInMinutes = (screening.Start - DateTime.Now).TotalMinutes;
            if (diffInMinutes < t.TotalMinutes)
            {
                return true;
            }
            return false;
        }
        private void CancelReservations(Screening screening)
        {
            Services.TicketService.RemoveUnpaidTickets(screening);
        }
        private decimal GetAllPrices()
        {
            return this._regularPrice + this._childrenPrice + this._studentPrice + this._seniorPrice;
        }

        private void regularQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RegularTicketsCount = int.Parse(this.regularQuantityComboBox.SelectedItem.ToString());
            this._regularPrice = RegularTicketsCount * Services.Utilities.Constants.RegularTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();

        }

        private void back_Click(object sender, EventArgs e)
        {
            var i = ((Button)sender).Parent.Parent.Controls.IndexOf(this);
            var prev = ((Button)sender).Parent.Parent.Controls[i - 1];
            prev.Show();
        }

        private void childrenQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ChildrenTicketsCount = int.Parse(this.childrenQuantityComboBox.SelectedItem.ToString());
            this._childrenPrice = this.ChildrenTicketsCount * Constants.ChildrenTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();
        }

        private void seniorsQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SeniorsTicketsCount = int.Parse(this.seniorsQuantityComboBox.SelectedItem.ToString());
            this._seniorPrice = this.SeniorsTicketsCount * Constants.SeniorsrTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();
        }

        private void studentsQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.StudentsTicketsCount = int.Parse(this.studentsQuantityComboBox.SelectedItem.ToString());
            this._studentPrice = StudentsTicketsCount * Constants.StudentsTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();
        }
    }
}