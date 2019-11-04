using RecipeAPI.AccessLayer.DBModels;

namespace RecipeAPI.AccessLayer.JoiningModels
{
    class RecipesIngredients
    {
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int IngredientsId { get; set; }
        public Ingredient Ingredient { get; set; }
        public double Weight { get; set; }

        public RecipesIngredients(Recipe recipe, Ingredient ingredient, double weight)
        {
            Recipe = recipe;
            Ingredient = ingredient;
            Weight = weight;
        }

        public RecipesIngredients()
        {

        }
    }
}
