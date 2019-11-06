using RecipeAPI.Model.JoiningModel;
using System.Collections.Generic;

namespace RecipeAPI.Model.DBModel
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public string Complexity { get; set; }
        public string LinkToPhoto { get; set; }
        public string MethodOfPreparation { get; set; }
        public double Kcal { get; set; }
        public IList<RecipeTag> RecipesTags { get; set; }
        public IList<RecipeCategory> RecipesCategories { get; set; }
        public IList<int> RecipeIngredientsId { get; set; }

        public Recipe(int id, string name, int preparationTime, string complexity, string linkToPhoto, string methodOfPreparation, double kcal)
        {
            Id = id;
            Name = name;
            PreparationTime = preparationTime;
            Complexity = complexity;
            LinkToPhoto = linkToPhoto;
            MethodOfPreparation = methodOfPreparation;
            Kcal = kcal;
        }

        public Recipe() { }
    }
}
