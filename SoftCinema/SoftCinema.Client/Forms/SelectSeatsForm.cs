using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Models;

namespace SoftCinema.Client.Forms
{
    public partial class SelectSeatsForm : Form
    {
        private SeatButton[,] _seatButtons { get; set; }
        private Screening _screening { get; set; }
        
        public SelectSeatsForm()
        {
            InitializeComponent();
        }

        public SelectSeatsForm(Screening screening)
        {
            InitializeComponent();
            this._screening = screening;

            var maxRowNumber = screening.Auditorium.Seats.Max(s => s.Row);
            var maxColNumber = screening.Auditorium.Seats.Max(s => s.Number);
            this._seatButtons = new SeatButton[maxRowNumber,maxColNumber];
        }

        private void teamButton1_Click(object sender, EventArgs e)
        {
        }

        private void SelectSeatsForm_Load(object sender, EventArgs e)
        {

        }
    }
}