using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services.Utilities;


namespace SoftCinema.Client.Forms
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

        public TicketTypeForm()
        {
            InitializeComponent();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            var formsCount = ((Button) sender).Parent.Parent.Controls.Count;

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
                    selectSeatsForm.TopLevel = false;
                    selectSeatsForm.AutoScroll = true;
                    if (formsCount == 2)
                    {
                        ((Button) sender).Parent.Parent.Controls.Add(selectSeatsForm);
                        selectSeatsForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        ((Button) sender).Parent.Parent.Controls.RemoveAt(2);
                        ((Button) sender).Parent.Parent.Controls.Add(selectSeatsForm);
                        selectSeatsForm.Show();
                        this.Hide();
                    }
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
            this._regularPrice = regularCount*Models.Constants.Constants.RegularTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var first = ((Button) sender).Parent.Parent.Controls[0];
            first.Show();
            this.Hide();
        }

        private void childrenQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var childrenCount = int.Parse(this.childrenQuantityComboBox.SelectedItem.ToString());
            this._childrenPrice = childrenCount*Models.Constants.Constants.ChildrenTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();
        }

        private void seniorsQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seniorsCount = int.Parse(this.seniorsQuantityComboBox.SelectedItem.ToString());
            this._seniorPrice = seniorsCount*Models.Constants.Constants.SeniorsrTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();
        }

        private void studentsQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studentsCount = int.Parse(this.studentsQuantityComboBox.SelectedItem.ToString());
            this._studentPrice = studentsCount*Models.Constants.Constants.StudentsTicketPrice;
            this.price.Text = this.GetAllPrices().ToString();
        }
    }
}