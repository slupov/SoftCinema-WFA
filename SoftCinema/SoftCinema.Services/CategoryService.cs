using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.DTOs;
using SoftCinema.Models;
using SoftCinema.Service.Utilities;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Service
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
        
        public static bool IsCategoryExisting(string categoryName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                {
                    return (context.Categories.Any(c => c.Name == categoryName));
                }
            }
        }
    }
}
