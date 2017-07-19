using SoftCinema.Client.Forms.AdminForms;
using System;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    internal class AdminMenuTeamButton : TeamButton
    {
        public AdminMenuTeamButton() : base()
        {
            this.Text = "Admin menu";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new AdminMenuForm());
            base.OnClick(e);
        }
    }
}