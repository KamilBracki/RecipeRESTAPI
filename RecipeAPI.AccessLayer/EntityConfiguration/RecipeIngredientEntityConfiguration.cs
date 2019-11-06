using RecipeAPI.Model.JoiningModel;
using System;
using System.Collections.Generic;
using System.Text;
using
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecipeAPI.AccessLayer.EntityConfiguration
{
    public class RecipeIngredientEntityConfiguration : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {
            builder.HasKey(k => new { k.RecipeId, k.Ingredient });

        }
    }
}
