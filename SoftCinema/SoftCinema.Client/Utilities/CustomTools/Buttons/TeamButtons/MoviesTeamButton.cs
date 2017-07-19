using SoftCinema.Client.Forms.ContentHolders;
using System;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    internal class MoviesTeamButton : TeamButton
    {
        public MoviesTeamButton() : base()
        {
            this.Text = "Movies";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new MoviesForm());
            base.OnClick(e);
        }
    }
}