using RecipeAPI.Model.Model;
using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Model.JoiningModel
{
    public class RecipeCategory
    {
        [Key]
        public int Id { get; set; }
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
