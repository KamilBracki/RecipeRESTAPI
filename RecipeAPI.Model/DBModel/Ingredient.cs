using RecipeAPI.Model.JoiningModel;
using System.Collections.Generic;

namespace RecipeAPI.Model.DBModel
{
    public class Ingredient
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Proteins { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }

        public IList<RecipeIngredient> RecipeIngredients { get; set; }

        public Ingredient(int id, string name, double proteins, double carbohydrates, double fat)
        {
            Id = id;
            Name = name;
            Proteins = proteins;
            Carbohydrates = carbohydrates;
            Fat = fat;
        }

        public Ingredient() { }
    }
}
