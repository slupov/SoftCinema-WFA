using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Models;

namespace SoftCinema.Client.Forms.ContentHolders
{
    public partial class SelectSeatsForm : ContentHolderForm
    {
        private Screening _screening { get; set; }
        private int _seatCount { get; set; }
        private AuditoriumSeatsSchema _seatsSchema { get; set; }

        public SelectSeatsForm(Screening screening, int seatCount)
        {
            this._screening = screening;
            this._seatCount = seatCount;
            InitializeComponent();
        }

        private void SelectSeatsForm_Load(object sender, EventArgs e)
        {
            InitializeSeatsSchema();
            this.Controls.Add(this._seatsSchema);
            
        }

        private void InitializeSeatsSchema()
        {
            var startingPoint = new Point(this.freeSeatsLegendLabel.Location.X,
                this.freeSeatsLegendLabel.Location.Y + 30);
            int width = this.reserveButton.Location.X + this.reserveButton.Size.Width - startingPoint.X;

            this._seatsSchema = new AuditoriumSeatsSchema(this._screening.Auditorium, startingPoint, width,
                this._seatCount);
        }

       private void reserveButton_Click(object sender, EventArgs e)
        {
            
        }
        private void reserveButton_Enter(object sender, EventArgs e)
        {
            this.reserveButton.BackColor = Color.FromArgb(255, 41, 60, 76);
            this.reserveButton.ForeColor = Color.White;
            }
        private void reserveButton_MouseLeave(object sender, EventArgs e)
        {
            this.reserveButton.BackColor = Color.Silver;
            this.reserveButton.ForeColor = Color.FromArgb(255, 41, 60, 76);
        }

    }
}