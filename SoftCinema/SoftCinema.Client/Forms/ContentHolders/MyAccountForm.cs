using SoftCinema.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;
using Image = System.Drawing.Image;

namespace SoftCinema.Client.Forms.ContentHolders
{
    public partial class MyAccountForm : ContentHolderForm
    {
        public static User _currentUser;
        private byte[] movieImageBytes { get; set; }
        private readonly ImageService imageService;
        private readonly UserService userService;

        public MyAccountForm()
        {
            this.userService = new UserService();
            this.imageService = new ImageService();
            InitializeComponent();
            _currentUser = userService.GetUser(AuthenticationManager.GetCurrentUser().Username);
            
        }

       

        
        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var mainForm = (SoftCinemaForm)((Button)sender).Parent.Parent.Parent;
            mainForm.RenderSideBar();
            SoftCinemaForm.SetContentHolderForm(new EditUserForm());
        }

        private void MyAccountForm_Load(object sender, EventArgs e)
        {
           
            if (imageService.GetProfilePicture(_currentUser.Username) != null)
            {
                var _image = imageService.byteArrayToImage(_currentUser.ProfilePicture.Content);
                this.pictureBoxPhoto.Image = imageService.ScaleImage(_image, 215, 258);
                
            }
            else
            {
                var _image = Image.FromFile(@"../../Utilities/Images/default.jpg");
                this.pictureBoxPhoto.Image = imageService.ScaleImage(_image, 215, 258);
            }
            this.pictureBoxPhoto.Size = new Size(this.pictureBoxPhoto.Image.Width, this.pictureBoxPhoto.Image.Height);
            this.emailInfoLabel.Text = _currentUser.Email;
            this.emailInfoLabel.MaximumSize = new Size(500, 30);
            this.phoneNumberInfoLabel.Text = _currentUser.PhoneNumber;
            this.usernameInfoLabel.Text = _currentUser.Username;
        }
    }
}
