﻿using System.Collections.Generic;

namespace RecipeAPI.Model.Model
{

    public class RecipeBuilder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public string Description { get; set; } /* to improve */
        public string LinkToPhoto { get; set; }
        public string MethodOfPreparation { get; set; }
        public double Kcal { get; set; }
        public Dictionary<int, double> Ingredients { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Category> Categories { get; set; }


        public RecipeBuilder(Builder builder)
        {
            Id = builder.Id;
            Name = builder.Name;
            PreparationTime = builder.PreparationTime;
            Description = builder.Description;
            LinkToPhoto = builder.LinkToPhoto;
            MethodOfPreparation = builder.MethodOfPreparation;
            Ingredients = builder.Ingredients;
            Tags = builder.Tags;
            Categories = builder.Categories;

        }
        public class Builder
        {
            public int Id;
            public int AuthorId;
            public string Name;
            public int PreparationTime;
            public string Description;
            public string LinkToPhoto;
            public string MethodOfPreparation;
            public double Kcal;
            public Dictionary<int, double> Ingredients;
            public List<Tag> Tags;
            public List<Category> Categories;


            public Builder WithId(int id)
            {
                Id = id;
                return this;
            }
            public Builder WithAuthorId(int authorId)
            {
                AuthorId = authorId;
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

            public Builder WithDescription(string description)
            {
                Description = description;
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

            public RecipeBuilder Build()
            {
                return new RecipeBuilder(this);
            }
        }

    }

}
