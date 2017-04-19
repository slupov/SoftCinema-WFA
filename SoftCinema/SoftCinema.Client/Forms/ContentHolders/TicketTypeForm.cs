using System;
using System.Drawing;
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
              var restr = TicketForm.Screening.Movie.AgeRestriction;
              if (restr != AgeRestriction.D && restr != AgeRestriction.X)
                  return true;
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
                    SelectSeatsForm selectSeatsForm = new SelectSeatsForm(TicketForm.Screening, ticketsQuantity);
                   
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
            var children = int.Parse(this.childrenQuantityComboBox.SelectedItem.ToString());
            var regular = int.Parse(this.regularQuantityComboBox.SelectedItem.ToString());
            var seniors = int.Parse(this.seniorsQuantityComboBox.SelectedItem.ToString());
            var students = int.Parse(this.studentsQuantityComboBox.SelectedItem.ToString());

            return regular + children + seniors + students;
        }

        private void TicketTypeForm_Load(object sender, EventArgs e)
        {
            this.regularQuantityComboBox.SelectedIndex = 0;
            this.childrenQuantityComboBox.SelectedIndex = 0;
            this.seniorsQuantityComboBox.SelectedIndex = 0;
            this.studentsQuantityComboBox.SelectedIndex = 0;
            this.ticketLimit.Hide();
        }

        private decimal GetAllPrices()
        {
            return this._regularPrice + this._childrenPrice + this._studentPrice + this._seniorPrice;
        }

        private void regularQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var regularCount = int.Parse(this.regularQuantityComboBox.SelectedItem.ToString());
            this._regularPrice = regularCount*Services.Utilities.Constants.RegularTicketPrice;
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
            var childrenCount = int.Parse(this.childrenQuantityComboBox.SelectedItem.ToString());
            this._childrenPrice = childrenCount*Constants.ChildrenTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();
        }

        private void seniorsQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seniorsCount = int.Parse(this.seniorsQuantityComboBox.SelectedItem.ToString());
            this._seniorPrice = seniorsCount*Constants.SeniorsrTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();
        }

        private void studentsQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studentsCount = int.Parse(this.studentsQuantityComboBox.SelectedItem.ToString());
            this._studentPrice = studentsCount*Constants.StudentsTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();
        }
    }
}