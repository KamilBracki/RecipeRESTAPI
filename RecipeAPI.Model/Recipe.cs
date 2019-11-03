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
        public class Builder
        {
            public int RecipeId;
            public string Name;
            public int PreparationTime;
            public string Complexity;
            public string LinkToPhoto;
            public string MethodOfPreparation;
            public double Kcal;
            public Dictionary<int, double> Ingredients;
            public List<Tag> Tags;
            public List<Category> Categories;


            public Builder WithId(int id)
            {
                RecipeId = id;
                return this;
            }
            public Builder WithName(string name)
            {
                Name = name;
                return this;
            }

            public Builder WithPreparationTie(int prepTime)
            {
                PreparationTime = prepTime;
                return this;
            }

            public Builder WithComplexity(string complexity)
            {
                Complexity = complexity;
                return this;
            }

            public Builder WithLinkToPhoto(string linkToPhoto)
            {
                LinkToPhoto = linkToPhoto;
                return this;
            }

            public Builder WithMethodOfPreparation(string methodOfPrep)
            {
                MethodOfPreparation = methodOfPrep;
                return this;
            }
            public Builder WithKcal(double kcal)
            {
                Kcal = kcal;
                return this;
            }
            public Builder WithIngredients(Dictionary<int, double> ingredients)
            {
                Ingredients = ingredients;
                return this;
            }
            public Builder WithTags(List<Tag> tags)
            {
                Tags = tags;
                return this;
            }
            public Builder WithCategorise(List<Category> categories)
            {
                Categories = categories;
                return this;
            }

            public Recipe Build()
            {
                return new Recipe(this);
            }
        }

    }

}
