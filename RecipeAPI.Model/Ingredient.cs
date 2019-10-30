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

        public Ingredient(int ingredientId, string ingredientName, double proteins, 
                        double carbohydrates, double fat) : this(ingredientId)
        {
            IngredientName = ingredientName;
            Proteins = proteins;
            Carbohydrates = carbohydrates;
            Fat = fat;
        }
    }
}
