using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeAPI.Model.Model;

namespace RecipeAPI.AccessLayer.EntityConfiguration
{
    public class TagEntityConfiguration : IEntityTypeConfiguration<Tag>
    {

        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder
                .Property(i => i.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
