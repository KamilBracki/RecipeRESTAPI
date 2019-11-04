using RecipeAPI.AccessLayer.DBModels;

namespace RecipeAPI.AccessLayer.JoiningModels
{
    class RecipeIngredient
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int IngredientsId { get; set; }
        public Ingredient Ingredient { get; set; }
        public double Weight { get; set; }

        public RecipeIngredient(Recipe recipe, Ingredient ingredient, double weight)
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
