using System.Collections.Generic;
using System;
using Food.Model;

namespace Food.Court.API.Food.Repositories
{
    public interface ICategory
    {
        List<Category> GetCategory();

        Category GetCategory(int Id);

        Category AddCategory(Category category);

        void DeleteCategory(int Id);

        Category Editcategory(Category category);



    }
}
