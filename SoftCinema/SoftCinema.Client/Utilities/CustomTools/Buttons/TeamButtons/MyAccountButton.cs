using SoftCinema.Client.Forms.ContentHolders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    class MyAccountButton : TeamButton
    {
        public MyAccountButton() : base()
        {
            this.Text = "My Account";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new MyAccountForm());
            base.OnClick(e);
        }
    }
}