using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeAPI.Model.Model;

namespace RecipeAPI.AccessLayer.EntityConfiguration
{
    class FavoriteRecipeEntityConfiguration : IEntityTypeConfiguration<FavoriteRecipe>
    {
        public void Configure(EntityTypeBuilder<FavoriteRecipe> builder)
        {
            builder
                .Property(i => i.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
