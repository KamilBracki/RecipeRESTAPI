using RecipeAPI.Model.Model;

namespace RecipeAPI.Model.JoiningModel
{
    public class RecipeCategory
    {
        public int RecipeId { get; set; }
        public DBModel.Recipe Recipe { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public RecipeCategory(DBModel.Recipe recipe, Category category)
        {
            Recipe = recipe;
            Category = category;
        }

        public RecipeCategory()
        {
        }
    }
}
