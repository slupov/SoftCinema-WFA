using System;
using System.Collections.Generic;
using ImportServices.Utilities;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace ImportServices
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
            DataValidator.ValidateCategoryDoesNotExist(categoryName);

            CategoryService.AddCategory(categoryName);

            Console.WriteLine(string.Format(SuccessMessages.CategoryAddedSuccess, categoryName));
        }
    }
}
