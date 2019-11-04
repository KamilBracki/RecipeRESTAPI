using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeAPI.Model
{
    class Category
    {
        public int CategoryId { get; private set; }
        public string CategoryName { get; set; }

        public Category(int id)
        {
            CategoryId = id;
        }

        public Category(int categoryId, string categoryName) : this(categoryId)
        {
            CategoryName = categoryName;
        }
    }
}
