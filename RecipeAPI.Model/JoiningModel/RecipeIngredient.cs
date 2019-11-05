namespace RecipeAPI.Model.JoiningModel
{
    public class RecipeIngredient
    {
        public int RecipeId { get; set; }
        public DBModel.Recipe Recipe { get; set; }
        public int IngredientsId { get; set; }
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

