using System;
using System.Drawing;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms
{
    public partial class ContentHolderForm : Form
    {
        public ContentHolderForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            this.Width = 769;
            this.Height = 418;
            this.Location = new Point(0, 0);
            this.Margin = new Padding(3,3,3,3);

            InitializeComponent();
        }

        private void ContentHolderForm_Load(object sender, EventArgs e)
        {

        }
    }
}
