using SoftCinema.Client.Forms.ContentHolders;
using System;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    internal class RegisterTeamButton : TeamButton
    {
        public RegisterTeamButton() : base()
        {
            this.Text = "Register";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new RegisterForm());
            base.OnClick(e);
        }
    }
}