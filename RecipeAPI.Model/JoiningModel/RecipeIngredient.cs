using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeAPI.Model.JoiningModel
{
    public class RecipeIngredient
    {
        [Key]
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public DBModel.Recipe Recipe { get; set; }


        public int IngredientId { get; set; }
        public DBModel.Ingredient Ingredient { get; set; }
        public double Weight { get; set; }

        public RecipeIngredient(DBModel.Recipe recipe, DBModel.Ingredient ingredient, double weight)
        {
            Recipe = recipe;
            Ingredient = ingredient;
            Weight = weight;
        }

        public RecipeIngredient()
        {

        }
    }
}

