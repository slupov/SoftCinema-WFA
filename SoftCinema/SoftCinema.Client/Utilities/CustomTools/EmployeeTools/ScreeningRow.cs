using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Forms.EmployeeForms;
using SoftCinema.Models;

namespace SoftCinema.Client.Utilities.CustomTools.EmployeeTools
{
    class ScreeningRow : GroupBox
    {
        private Screening _screening { get; set; }
        private int _id { get; set; }
        private Color _back { get; set; }

        public ScreeningRow(Screening screening, int width, int id)
        {
            this._back = Color.FromArgb(255, 240, 240, 240);
            this.ForeColor = Color.Black;
            this.Size = new Size(width, 80);
            this._screening = screening;
            this._id = id;

            Label rowText = new Label();
            rowText.Font = new Font("Comic Sans MS",14);
            rowText.Text = $"{id}." +
                           new string(' ', 5) +
                           $"Auditorium: {_screening.Auditorium.Number}" +
                           new string(' ', 5) +
                           $"Date: {this._screening.Start.ToString("f")}";

            rowText.Location = new Point(this.Location.X + 5, this.Size.Height / 2 - 5);
            rowText.Size = new Size(width - 50, this.Size.Height / 3);
            this.Controls.Add(rowText);
        }

        protected override void OnClick(EventArgs e)
        {
            var reservationsForm = new ShowScreeningReservationsForm(_screening);
            reservationsForm.Show();

            base.OnClick(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackColor = this._back;
            base.OnMouseLeave(e);
        }
    }
}