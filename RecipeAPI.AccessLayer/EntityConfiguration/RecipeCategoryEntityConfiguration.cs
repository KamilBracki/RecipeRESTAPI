using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeAPI.Model.JoiningModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeAPI.AccessLayer.EntityConfiguration
{
    public class RecipeCategoryEntityConfiguration : IEntityTypeConfiguration<RecipeCategory>
    {
        public void Configure(EntityTypeBuilder<RecipeCategory> builder)
        {
            builder.HasKey(k => new { k.RecipeId, k.CategoryId });
            builder.Property(i => i.Id).ValueGeneratedOnAdd();




            builder
                .HasOne(r => r.Recipe)
                .WithMany(rc => rc.RecipesCategories)
                .HasForeignKey(r => r.RecipeId);

            
        }

    }
}
