using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeAPI.Model
{

    class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public int PreprationTime { get; set; }
        public string Complexity { get; set; } /* to improve */
        public string LinkToPhoto { get; set; }
        public string MethodOfPreparation { get; set; }
        public double Kcal { get; set; }
        public Dictionary<int, double> Ingredients { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }


        public Recipe(int id, string name, int preparationTime, string complexity, string linkToPhoto, string methodOfPreparation, double kcal, Dictionary<int, double> ingredients, List<Tag> tags, List<Category> categories)
        {
            RecipeId = id;
            Name = name;
            PreprationTime = preparationTime;
            Complexity = complexity;
            LinkToPhoto = linkToPhoto;
            MethodOfPreparation = methodOfPreparation;
            Ingredients = ingredients;
            Tags = tags;
            Categories = categories;

        }

    }

}
