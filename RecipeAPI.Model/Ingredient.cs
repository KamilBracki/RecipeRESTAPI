namespace RecipeAPI.Model
{
    class Ingredient
    {
        public int IngredientId { get; private set; }
        public string IngredientName { get; set; }
        public double Proteins { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }

        public Ingredient(int id)
        {
            IngredientId = id;
        }
    }
}
