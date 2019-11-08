namespace RecipeAPI.Model.Model
{
    public class IngredientBuilder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Proteins { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }



        public IngredientBuilder(Builder builder)
        {
            Id = builder.Id;
            Name = builder.Name;
            Proteins = builder.Proteins;
            Carbohydrates = builder.Carbohydrates;
            Fat = builder.Fat;
        }
        public class Builder
        {
            public int Id;
            public string Name;
            public double Proteins;
            public double Carbohydrates;
            public double Fat;



            public Builder WithId(int id)
            {
                Id = id;
                return this;
            }
            public Builder WithName(string name)
            {
                Name = name;
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


            public IngredientBuilder Build()
            {
                return new IngredientBuilder(this);
            }
        }
    }
}
