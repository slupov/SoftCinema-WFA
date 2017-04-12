using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms
{
    public partial class RegisterForm : Form
    {
        private static RegisterForm instance;

       

        public static RegisterForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RegisterForm();
                }
                return instance;
            }
        }
        public RegisterForm()
        {
            if (instance == null)
            {
                InitializeComponent();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            var username = this.usernameTextBox.Text;
            var password = this.passwordTextBox.Text;
            var repeatPassword = this.repeatPasswordTextBox.Text;
            var email = this.emailTextBox.Text;
            var phone = this.phoneNumberTextBox.Text;


        }
    }
}
