using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoftCinema.Services.Utilities.Validators
{
    public class CategoryValidator
    {
        private CategoryService categoryService;

        public CategoryValidator(CategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public  void ValidateCategoryDoesNotExist(string categoryName)
        {
            if (categoryService.IsCategoryExisting(categoryName))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.CategoryAlreadyExists, categoryName));
            }
        }

        public  void CheckCategoriesExist(List<string> categories)
        {
            foreach (var category in categories)
            {
                CheckCategoryExists(category);
            }
        }

        private  void CheckCategoryExists(string categoryName)
        {
            if (!categoryService.IsCategoryExisting(categoryName))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.CategoryDoesntExist, categoryName));
            }
        }
    }
}
