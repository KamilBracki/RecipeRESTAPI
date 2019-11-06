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

            _context.SaveChanges();


        }
        private void GenerateObjects()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();

            var categoriesJson = File.ReadAllText("..\\RecipesAPI.EntriesGenerator\\JsonEntries\\Categories.json");
            var tagsJson = File.ReadAllText("..\\RecipesAPI.EntriesGenerator\\JsonEntries\\Tags.json");
            var ingredientsJson = File.ReadAllText("..\\RecipesAPI.EntriesGenerator\\JsonEntries\\Ingredients.json");
            var recipesJson = File.ReadAllText("..\\RecipesAPI.EntriesGenerator\\JsonEntries\\Recipes.json");

            // Lists of json objects
            var categories = js.Deserialize<List<Category>>(categoriesJson);
            var tags = js.Deserialize<List<Tag>>(tagsJson);
            var ingredients = js.Deserialize<List<DBIngredient>>(ingredientsJson);
            var recipes = js.Deserialize<List<DBRecipe>>(recipesJson);

            PopulateDB(categories);
            PopulateDB(tags);
            PopulateDB(ingredients);
            PopulateDB(recipes);


        }

        private void PopulateDB(object list)
        {
            switch (list)
            {
                case List<Category> catList:
                    foreach (var category in catList)
                    {
                        _context.Categories.Add(category);
                    }
                    break;
                case List<Tag> tagList:
                    foreach (var tag in tagList)
                    {
                        _context.Tags.Add(tag);
                    }
                    break;
                case List<DBIngredient> ingList:
                    foreach (var ingredient in ingList)
                    {
                        _context.Ingredients.Add(ingredient);
                    }
                    break;
                case List<DBRecipe> recList:
                    foreach (var recipe in recList)
                    {
                        _context.Recipes.Add(recipe);
                    }
                    break;
                default:
                    break;
            }
        }


    }
}
