using SoftCinema.Client.Forms.ContentHolders;
using System;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    internal class BuyTicketsTeamButton : TeamButton
    {
        public BuyTicketsTeamButton() : base()
        {
            this.Text = "Buy Tickets";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new TicketForm());
            base.OnClick(e);
        }
    }
}