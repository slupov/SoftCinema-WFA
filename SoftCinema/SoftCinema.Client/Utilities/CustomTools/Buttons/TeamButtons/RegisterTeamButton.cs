using System;
using SoftCinema.Client.Forms;
using SoftCinema.Client.Forms.ContentHolders;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    class RegisterTeamButton : TeamButton
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