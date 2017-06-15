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
        private readonly CategoryService categoryService;
        private readonly CategoryValidator categoryValidator;

        public CategoryImportService()
        {
            this.categoryService = new CategoryService();
            this.categoryValidator = new CategoryValidator(categoryService);
        }

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
            categoryValidator.ValidateCategoryDoesNotExist(categoryName);

            categoryService.AddCategory(categoryName);

            Console.WriteLine(string.Format(Constants.ImportSuccessMessages.CategoryAddedSuccess, categoryName));
        }
    }
}
