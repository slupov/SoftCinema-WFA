using System.Linq;
using SoftCinema.Data;
using SoftCinema.Models;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Services
{
    public class ImageService
    {
        public static void AddImage(byte[] imageIn)
        {
            var img = new Image()
            {
                Content = imageIn
            };

            using (var db = new SoftCinemaContext())
            {
                db.Images.Add(img);
                db.SaveChanges();
            }
        }
    }
}