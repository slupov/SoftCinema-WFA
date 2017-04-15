using System.IO;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.Models;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Services
{
    public class ImageService
    {
        public static void AddImage(byte[] imageIn, string name)
        {
            var img = new Image()
            {
                Content = imageIn,
                Name = name
            };

            using (var db = new SoftCinemaContext())
            {
                db.Images.Add(img);
                db.SaveChanges();
            }
        }

        public static System.Drawing.Image CreateImage(string path)
        {
            return System.Drawing.Image.FromFile(path);
        }

        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
    }
}