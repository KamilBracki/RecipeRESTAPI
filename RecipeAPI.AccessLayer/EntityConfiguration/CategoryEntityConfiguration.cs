using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeAPI.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeAPI.AccessLayer.EntityConfiguration
{
    class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
        }
    }
}
