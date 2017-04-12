using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImportServices.Utilities;
using SoftCinema.Data;
using SoftCinema.DTOs;
using SoftCinema.Service;
using SoftCinema.Service.Utilities;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Import.ImportServices
{
    public static class CategoryImportService
    {
        public static void ImportCategories(IEnumerable<CategoryDTО> categories)
        {
            
                foreach (var categoryDto in categories)
                {
                    try
                    {
                        ImportCategory(categoryDto);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }

            
        }

        public static void ImportCategory(CategoryDTО categoryDtо)
        {
            string categoryName = categoryDtо.Name;
            DataValidator.ValidateStringMaxLength(categoryName, Constants.MaxCategoryNameLength);
            DataValidator.ValidateCategoryExisting(categoryName);
            CategoryService.AddCategory(categoryName);
            Console.WriteLine(string.Format(SuccessMessages.CategoryAddedSuccess, categoryName));
        }
    }
}
