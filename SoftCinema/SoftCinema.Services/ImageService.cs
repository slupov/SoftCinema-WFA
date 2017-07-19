using SoftCinema.Data;
using SoftCinema.Models;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;

namespace SoftCinema.Services
{
    public class ImageService
    {
        public void AddImage(byte[] imageIn)
        {
            var img = new Image()
            {
                Content = imageIn,
            };

            using (var db = new SoftCinemaContext())
            {
                db.Images.Add(img);
                db.SaveChanges();
            }
        }

        public System.Drawing.Image CreateImage(string path)
        {
            return System.Drawing.Image.FromFile(path);
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }

        public System.Drawing.Image ScaleImage(System.Drawing.Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new System.Drawing.Bitmap(newWidth, newHeight);
            System.Drawing.Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
            return newImage;
        }

        public byte[] GetProfilePicture(string username)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                User user = context.Users.Include(u => u.ProfilePicture).FirstOrDefault(u => u.Username == username);
                if (user.ProfilePicture != null)
                {
                    return user.ProfilePicture.Content;
                }
                return null;
            }
        }
    }
}