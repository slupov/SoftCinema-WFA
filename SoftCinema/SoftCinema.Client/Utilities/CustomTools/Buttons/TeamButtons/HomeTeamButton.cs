using SoftCinema.Client.Forms.ContentHolders;
using System;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    internal class HomeTeamButton : TeamButton
    {
        public HomeTeamButton() : base()
        {
            this.Text = "Home";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new HomeForm());
            base.OnClick(e);
        }
    }
}