using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeAPI.Model
{

    class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public string Complexity { get; set; } /* to improve */
        public string LinkToPhoto { get; set; }
        public string MethodOfPreparation { get; set; }
        public double Kcal { get; set; }
        public Dictionary<int, double> Ingredients { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }


        public Recipe(Builder builder)
        {
            RecipeId = builder.RecipeId;
            Name = builder.Name;
            PreparationTime = builder.PreparationTime;
            Complexity = builder.Complexity;
            LinkToPhoto = builder.LinkToPhoto;
            MethodOfPreparation = builder.MethodOfPreparation;
            Ingredients = builder.Ingredients;
            Tags = builder.Tags;
            Categories = builder.Categories;

        }
        

    }

}
