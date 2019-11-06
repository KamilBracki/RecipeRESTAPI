using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeAPI.Model.JoiningModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeAPI.AccessLayer.EntityConfiguration
{
    public class RecipeTagEntityConfiguration : IEntityTypeConfiguration<RecipeTag>
    {

        public void Configure(EntityTypeBuilder<RecipeTag> builder)
        {
            builder.HasKey(k => new { k.RecipeId, k.TagId });

        }
    }
}
