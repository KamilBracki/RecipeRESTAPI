using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipeAPI.Model.JoiningModel;

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
                .WithMany(rc => rc.RecipeCategories)
                .HasForeignKey(r => r.RecipeId);


        }

    }
}
