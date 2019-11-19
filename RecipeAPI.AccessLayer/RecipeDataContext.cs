using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RecipeAPI.AccessLayer.EntityConfiguration;
using RecipeAPI.Model.DBModel;
using RecipeAPI.Model.JoiningModel;
using RecipeAPI.Model.Model;
using System;

namespace RecipeAPI.AccessLayer
{

    public class RecipeDataContext : DbContext
    {
        public RecipeDataContext(DbContextOptions<RecipeDataContext> options) : base(options)
        {

        }

        public RecipeDataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder
                .UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                .EnableSensitiveDataLogging();


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new TagEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new IngredientEntityConfiguration());
            modelBuilder.ApplyConfiguration(new RecipeEntityConfiguration());


            modelBuilder.ApplyConfiguration(new RecipeCategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new RecipeIngredientEntityConfiguration());
            modelBuilder.ApplyConfiguration(new RecipeTagEntityConfiguration());


        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<RecipeCategory> RecipeCategories { get; set; }
        public virtual DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public virtual DbSet<RecipeTag> RecipeTags { get; set; }



    }

}
