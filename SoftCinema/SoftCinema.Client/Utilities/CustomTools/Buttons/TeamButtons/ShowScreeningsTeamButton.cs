using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Client.Forms.ContentHolders;
using SoftCinema.Client.Forms.EmployeeForms;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    class ShowScreeningsTeamButton : TeamButton
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