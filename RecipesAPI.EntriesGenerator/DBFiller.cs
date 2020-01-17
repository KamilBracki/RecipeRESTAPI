using Nancy.Json;
using RecipeAPI.AccessLayer;
using RecipeAPI.Model.Model;
using System.Collections.Generic;
using System.IO;
using DBIngredient = RecipeAPI.Model.DBModel.Ingredient;
using DBRecipe = RecipeAPI.Model.DBModel.Recipe;

namespace RecipeAPI.EntriesGenerator
{
    public class DBFiller
    {
        private readonly RecipeDataContext _context;
        public DBFiller(RecipeDataContext context)
        {
            _context = context;
        }

        public void Run()
        {
            GenerateObjects();
        }

        class JsonObject
        {
            public List<Category> Categories { get; set; }
            public List<Tag> Tags { get; set; }
            public List<DBIngredient> Ingredients { get; set; }
            public List<DBRecipe> Recipes { get; set; }



        }
        private void GenerateObjects()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();

            var jsonObject = File.ReadAllText("..\\RecipesApi.EntriesGenerator\\DBEntries.json");
            var objects = js.Deserialize<JsonObject>(jsonObject);

            var categories = objects.Categories;
            var tags = objects.Tags;
            var ingredients = objects.Ingredients;
            var recipes = objects.Recipes;


            PopulateDB(categories);

            PopulateDB(tags);

            PopulateDB(ingredients);
            _context.SaveChanges();
            PopulateDB(recipes);
            _context.SaveChanges();


        }


        private void PopulateDB<T>(List<T> collection)
        {
            switch (collection)
            {
                case List<Category> list:
                    _context.Categories.AddRange(list);
                    break;
                case List<Tag> list:
                    _context.Tags.AddRange(list);
                    break;
                case List<DBIngredient> list:
                    _context.Ingredients.AddRange(list);
                    break;
                case List<DBRecipe> list:
                    _context.Recipes.AddRange(list);
                    break;

                default:
                    break;
            }
        }


    }
}
