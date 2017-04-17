using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Client.Forms.AdminForms;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    class AdminMenuTeamButton : TeamButton
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
