using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeAPI.Model.Model;

namespace RecipeAPI.AccessLayer.EntityConfiguration
{
    class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
        }
    }
}
