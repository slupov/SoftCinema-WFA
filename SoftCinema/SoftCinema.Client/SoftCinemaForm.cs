using SoftCinema.Client.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Client.Forms.AdminForms;
using SoftCinema.Client.Forms.ContentHolders;
using SoftCinema.Client.Utilities.CustomSidebars;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client
{
    public partial class SoftCinemaForm : Form
    {
        private SideBar SideBar { get; set; }

        public SoftCinemaForm()
        {
            InitializeComponent();
        }

        public static void SetContentHolderForm(Form a)
        {
            a.TopLevel = false;
            ContentHolder.Controls.Clear();
            ContentHolder.Controls.Add(a);
            a.Show();
        }

        private void SoftCinemaForm_Load(object sender, EventArgs e)
        {
            SetContentHolderForm(new HomeForm());
            RenderTopPanelForm();
            RenderSideBar();
        }

        /// <summary>
        /// Renders a side bar view for users based on their user type
        /// </summary>
        public void RenderSideBar()
        {
            if (!AuthenticationManager.IsAuthenticated())
            {
                this.SideBar = new LoggedOutSidebar();
                this.Controls.Add(this.SideBar);
                return;
            }

            var userRole = AuthenticationManager.GetCurrentUser().Role;
            switch (userRole)
            {
                case Role.User:
                    this.SideBar = new UserSideBar();
                    break;
                case Role.Admin:
                    this.SideBar = new AdminSideBar();
                    break;
                case Role.Employee:
                    this.SideBar = new EmployeeSideBar();
                    break;
                default:
                    this.SideBar = new LoggedOutSidebar();
                    break;
            }

            this.Controls.Add(this.SideBar);
        }

        public void RenderTopPanelForm()
        {
            TopPanelForm topPanel = new TopPanelForm();
            topPanel.TopLevel = false;
            topPanel.AutoScroll = true;
            this.TopPanel.Controls.Clear();
            this.TopPanel.Controls.Add(topPanel);
            topPanel.Show();
        }
        
    }
}