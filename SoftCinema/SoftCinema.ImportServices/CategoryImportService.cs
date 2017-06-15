using System;
using System.Collections.Generic;
using SoftCinema.DTOs;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;

namespace ImportServices
{
    public  class CategoryImportService
    {
        public  void ImportCategories(IEnumerable<CategoryDto> categories)
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

        public  void ImportCategory(CategoryDto categoryDto)
        {
            string categoryName = categoryDto.Name;
            InputDataValidator.ValidateStringMaxLength(categoryName, Constants.MaxCategoryNameLength);
            CategoryValidator.ValidateCategoryDoesNotExist(categoryName);

            CategoryService.AddCategory(categoryName);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.CategoryAddedSuccess, categoryName));
        }
    }
}
