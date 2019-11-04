using RecipeAPI.AccessLayer.JoiningModels;
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
        public IList<RecipesTags> RecipesTags { get; set; }
        public IList<RecipesCategories> RecipesCategories { get; set; }

        public Recipe(int recipeId, string name, int preparationTime, string complexity, string linkToPhoto, string methodOfPreparation, double kcal)
        {
            RecipeId = recipeId;
            Name = name;
            PreparationTime = preparationTime;
            Complexity = complexity;
            LinkToPhoto = linkToPhoto;
            MethodOfPreparation = methodOfPreparation;
            Kcal = kcal;
        }
    }
}
