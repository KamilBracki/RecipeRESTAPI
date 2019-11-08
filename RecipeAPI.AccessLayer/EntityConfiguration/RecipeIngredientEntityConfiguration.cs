using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeAPI.Model.JoiningModel;

namespace RecipeAPI.AccessLayer.EntityConfiguration
{
    public class RecipeIngredientEntityConfiguration : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {

            builder.HasKey(k => new { k.RecipeId, k.IngredientId });
            builder.Property(i => i.Id).ValueGeneratedOnAdd();

            builder
                .HasOne(r => r.Recipe)
                .WithMany(rc => rc.RecipeIngredients)
                .HasForeignKey(r => r.RecipeId);

            builder
                .HasOne(i => i.Ingredient)
                .WithMany(rc => rc.RecipeIngredients)
                .HasForeignKey(r => r.IngredientId);




        }
    }
}
