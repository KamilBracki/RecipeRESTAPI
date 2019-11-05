using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeAPI.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeAPI.AccessLayer.EntityConfiguration
{
    public class TagEntityConfiguration : IEntityTypeConfiguration<Tag>
    {

        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder
                .Property(i => i.TagId)
                .ValueGeneratedOnAdd();
        }
    }
}
