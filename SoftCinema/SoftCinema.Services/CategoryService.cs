using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Data;
using SoftCinema.DTOs;
using SoftCinema.Models;

namespace SoftCinema.Service
{
    public class CategoryService
    {
        public static void ImportCategories(IEnumerable<CategoryDТО> categories, SoftCinemaContext context)
        {
            foreach (var categoryDto in categories)
            {
                if (context.Categories.Any(c => c.Name == categoryDto.Name))
                {
                    Console.WriteLine($"Category {categoryDto.Name} has already been imported!");
                    continue;
                }
                if (categoryDto.Name.Length > 50)
                {
                    Console.WriteLine("Category name is too long!");
                    continue;
                }
                Category category = new Category()
                {
                    Name = categoryDto.Name
                };
                context.Categories.Add(category);
            }
            context.SaveChanges();
        }
    }
}
