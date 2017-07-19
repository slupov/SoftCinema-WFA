using SoftCinema.Client.Forms.ContentHolders;
using System;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    internal class MyAccountButton : TeamButton
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