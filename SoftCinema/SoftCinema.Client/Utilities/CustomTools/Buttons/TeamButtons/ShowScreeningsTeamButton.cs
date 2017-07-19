using SoftCinema.Client.Forms.EmployeeForms;
using System;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    internal class ShowScreeningsTeamButton : TeamButton
    {
        public ShowScreeningsTeamButton() : base()
        {
            this.Text = "Show screenings";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new ShowScreeningsForm());
            base.OnClick(e);
        }
    }
}