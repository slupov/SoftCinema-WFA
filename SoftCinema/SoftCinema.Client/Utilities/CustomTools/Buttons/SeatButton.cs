using System;
using SoftCinema.Client.Forms;
using SoftCinema.Models;

namespace SoftCinema.Client.Utilities.CustomTools
{
    using System.Drawing;
    using System.Windows.Forms;

    public class SeatButton : Button
    {
        private static Font _normalFont = new Font("Arial", 10F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte) (0)));

        private static Color _back = System.Drawing.Color.FromArgb(255, 53, 172, 73);
        private static Color _border = System.Drawing.Color.Black;
        private static Color _activeBorder = System.Drawing.Color.FromArgb(255, 245, 132, 36);
        private static Color _fore = System.Drawing.Color.White;

        private static Padding _margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        private static Padding _padding = new System.Windows.Forms.Padding(3, 3, 3, 3);

        private static Size _minSize = new System.Drawing.Size(10, 10);
        private bool _active;
        private bool _selected;
      
        public int Row { get; set; }
        public int Number { get; set; }

        public SeatButton(int number, int row) : base()
        {
            base.Font = _normalFont;
            base.BackColor = _back;
            base.ForeColor = _fore;
            base.FlatAppearance.BorderColor = _back;
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.Margin = _margin;
            base.Padding = _padding;
            base.MinimumSize = _minSize;
            base.Text = number.ToString();
            base.Size = new Size(20, 20);

            this.Row = row;
            this.Number = number;

            this._selected = false;
        }

        public SeatButton() : base()
        {
            base.Font = _normalFont;
            base.BackColor = _back;
            base.ForeColor = _fore;
            base.FlatAppearance.BorderColor = _back;
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.Margin = _margin;
            base.Padding = _padding;
            base.MinimumSize = _minSize;
            base.Size = new Size(20, 20);

            this._selected = false;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            UseVisualStyleBackColor = false;
        }

        protected override void OnClick(EventArgs e)
        {
            if (this._selected)
            {
                this._selected = false;
                this.BackColor = System.Drawing.Color.FromArgb(255, 53, 172, 73);
            }
            else
            {
                this._selected = true;
                this.BackColor = System.Drawing.Color.FromArgb(255, 245, 132, 36);
            }
           
            AuditoriumSeatsSchema.LimitSeatsSelection();
            var form = (AuditoriumSeatsSchema) this.Parent;
            form.UpdateReserveButton();
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
        }

        public void SetStateActive()
        {
            _active = true;
        }

        public void SetStateNormal()
        {
            _active = false;
        }

        public bool isSelected()
        {
            return this._selected;
        }
    }
}