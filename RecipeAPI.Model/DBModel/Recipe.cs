
using RecipeAPI.Model.JoiningModel;
using System.Collections.Generic;

namespace RecipeAPI.Model.DBModel
{
    public class Recipe
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public string Description { get; set; }
        public string LinkToPhoto { get; set; }
        public string MethodOfPreparation { get; set; }
        public double Kcal { get; set; }

        public IList<RecipeTag> RecipeTags { get; set; }
        public IList<RecipeCategory> RecipeCategories { get; set; }
        public IList<RecipeIngredient> RecipeIngredients { get; set; }


        public Recipe(int id, int authorId, string name, int preparationTime, string description, string linkToPhoto, string methodOfPreparation, double kcal)
        {
            Id = id;
            AuthorId = authorId;
            Name = name;
            PreparationTime = preparationTime;
            Description = description;
            LinkToPhoto = linkToPhoto;
            MethodOfPreparation = methodOfPreparation;
            Kcal = kcal;
        }

        public Recipe() { }


    }
}
