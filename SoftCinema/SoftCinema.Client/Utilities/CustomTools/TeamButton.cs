using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoftCinema.Client.Utilities.CustomTools
{
    public class TeamButton : Button
    {
        protected static Font _normalFont = new Font("Century Gothic", 14.25F);

        protected static Color _back = System.Drawing.Color.FromArgb(255, 26, 32, 40);
        protected static Color _fore = System.Drawing.Color.White;

        protected static Padding _margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        protected static Padding _padding = new System.Windows.Forms.Padding(3, 3, 3, 3);

        protected static Size _minSize = new System.Drawing.Size(100, 30);

        protected bool _clicked;

        public TeamButton() : base()
        {
            base.MinimumSize = _minSize;
            this.Size = new Size(195, 57);
            base.Font = _normalFont;
            base.ForeColor = _fore;
            base.FlatAppearance.BorderColor = _back;
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.Margin = _margin;
            base.Padding = _padding;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            UseVisualStyleBackColor = false;
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(255, 31, 38, 48);
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackColor = System.Drawing.Color.FromArgb(255, 26, 32, 40);
        }

        public void SetStateActive()
        {
            _clicked = true;
            this.BackColor = System.Drawing.Color.FromArgb(255, 31, 38, 48);
        }

        public void SetStateNormal()
        {
            _clicked = false;
            this.BackColor = System.Drawing.Color.FromArgb(255, 26, 32, 40);
        }
    }
}