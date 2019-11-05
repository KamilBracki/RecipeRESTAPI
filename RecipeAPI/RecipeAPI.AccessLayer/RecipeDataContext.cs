using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeAPI.AccessLayer
{

    public class RecipeDataContext : DbContext
    {
        public RecipeDataContext(DbContextOptions<RecipeDataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }

}
