using SoftCinema.Client.Forms.ContentHolders;
using System;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    internal class LoginTeamButton : TeamButton
    {
        public LoginTeamButton() : base()
        {
            this.Text = "Login";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new LoginForm());
            base.OnClick(e);
        }
    }
}