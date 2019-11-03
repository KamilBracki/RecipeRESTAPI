namespace RecipeAPI.Model
{
    class Ingredient
    {
        public int IngredientId { get; private set; }
        public string IngredientName { get; set; }
        public double Proteins { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }



        public Ingredient(Builder builder)
        {
            IngredientId = builder.IngredientId;
            IngredientName = builder.IngredientName;
            Proteins = builder.Proteins;
            Carbohydrates = builder.Proteins;
            Fat = builder.Fat;
        }
        
    }
}
