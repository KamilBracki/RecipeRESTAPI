using Microsoft.EntityFrameworkCore;
using RecipeAPI.AccessLayer.EntityConfiguration;
using RecipeAPI.Model.JoiningModel;
using RecipeAPI.Model.Model;

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
            optionsBuilder.UseSqlServer("Server=tcp:recipesdb.database.windows.net,1433;Initial Catalog=recipesDB;Persist Security Info=False;User ID=recipesdb;Password=Codecool1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>().ToTable("Tags");
            modelBuilder.ApplyConfiguration(new TagEntityConfiguration());
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<RecipeCategory> RecipeCategories { get; set; }
        public virtual DbSet<RecipeIngredient> RecipeIngredients{ get; set; }
        public virtual DbSet<RecipeTag> RecipeTags { get; set; }



    }

}
