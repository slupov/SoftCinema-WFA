using SoftCinema.Client.Forms.ContentHolders;
using System;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    internal class RegisterMovieTeamButton : TeamButton
    {
        public RegisterMovieTeamButton() : base()
        {
            this.Text = "Register movie";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new RegisterMovieForm());
            base.OnClick(e);
        }
    }
}