using RecipeAPI.Model.JoiningModel;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RecipeAPI.AccessLayer.EntityConfiguration
{
    public class RecipeIngredientEntityConfiguration : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {
            builder.HasKey(k => new { k.RecipeId, k.IngredientId});
            builder.Property(i => i.Id).ValueGeneratedOnAdd();

            builder
                .HasOne(r => r.Recipe)
                .WithMany(rc => rc.RecipeIngredient)
                .HasForeignKey(r => r.RecipeId);

            builder
                .HasOne(i => i.Ingredient)
                .WithMany(rc => rc.RecipeIngredient)
                .HasForeignKey(r => r.IngredientId);
            
            
        }
    }
}
