using RecipeAPI.Model;

namespace RecipeAPI.AccessLayer.JoiningModels
{
    class RecipesCategories
    {
        public int RecipeId { get; set; }
        public DBModels.Recipe Recipe { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public RecipesCategories(DBModels.Recipe recipe, Category category)
        {
            Recipe = recipe;
            Category = category;
        }

        public RecipesCategories()
        {
        }
    }
}
