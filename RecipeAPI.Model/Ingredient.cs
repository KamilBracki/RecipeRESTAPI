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
            Carbohydrates = builder.Carbohydrates;
            Fat = builder.Fat;
        }
        public class Builder
        {
            public int IngredientId;
            public string IngredientName;
            public double Proteins;
            public double Carbohydrates;
            public double Fat;



            public Builder WithIngredientId(int id)
            {
                IngredientId = id;
                return this;
            }
            public Builder WithName(string name)
            {
                IngredientName = name;
                return this;
            }

            public Builder WithProteins(int proteins)
            {
                Proteins = proteins;
                return this;
            }

            public Builder Withcarbohydrates(int carboydrates)
            {
                Carbohydrates = carboydrates;
                return this;
            }

            public Builder WithFat(int fats)
            {
                Fat = fats;
                return this;
            }
            

            public Ingredient Build()
            {
                return new Ingredient(this);
            }
        }
    }
}
