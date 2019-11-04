using RecipeAPI.Model;
using System.Collections.Generic;

namespace RecipeAPI.AccessLayer.DBModels
{
    class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public string Complexity { get; set; }
        public string LinkToPhoto { get; set; }
        public string MethodOfPreparation { get; set; }
        public double Kcal { get; set; }
        public Dictionary<int, double> Ingredients { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }

        public Recipe(int recipeId, string name, int preparationTime, string complexity, string linkToPhoto, string methodOfPreparation, double kcal, Dictionary<int, double> ingredients, List<Tag> tags, List<Category> categories)
        {
            RecipeId = recipeId;
            Name = name;
            PreparationTime = preparationTime;
            Complexity = complexity;
            LinkToPhoto = linkToPhoto;
            MethodOfPreparation = methodOfPreparation;
            Kcal = kcal;
            Ingredients = ingredients;
            Tags = tags;
            Categories = categories;
        }
    }
}
