using System.Linq;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class CategoryService
    {
      
        public static void AddCategory(string categoryName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Category category = new Category()
                {
                    Name = categoryName
                };
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public static Category GetCategory(string categoryName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Categories.FirstOrDefault(c => c.Name == categoryName);
            }
        }

        public static bool IsCategoryExisting(string categoryName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                {
                    return (context.Categories.Any(c => c.Name == categoryName));
                }
            }
        }


        public static string[] GetCategoriesNames()
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                {
                    return (context.Categories.Select(c => c.Name).ToArray());
                }
            }
        }
    }
}
