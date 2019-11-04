using RecipeAPI.Model;

namespace RecipeAPI.AccessLayer.JoiningModels
{
    class RecipeCategory
    {
        public int RecipeId { get; set; }
        public DBModels.Recipe Recipe { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public RecipeCategory(DBModels.Recipe recipe, Category category)
        {
            Recipe = recipe;
            Category = category;
        }

        public RecipeCategory()
        {
        }
    }
}
