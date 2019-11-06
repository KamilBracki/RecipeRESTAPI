using Nancy.Json;
using RecipeAPI.AccessLayer;
using RecipeAPI.Model.JoiningModel;
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

            var rcList = new List<RecipeCategory>();
            var riList = new List<RecipeIngredient>();
            var rtList = new List<RecipeTag>();

            var rCat1 = new RecipeCategory(recipes[0], categories[0]);
            var rCat2 = new RecipeCategory(recipes[0], categories[1]);
            var rCat3 = new RecipeCategory(recipes[1], categories[2]);
            var rCat4 = new RecipeCategory(recipes[1], categories[3]);

            rcList.Add(rCat1);
            rcList.Add(rCat2);
            rcList.Add(rCat3);
            rcList.Add(rCat4);

            var rIng1 = new RecipeIngredient(recipes[0], ingredients[1], 10);
            var rIng2 = new RecipeIngredient(recipes[0], ingredients[2], 4);
            var rIng3 = new RecipeIngredient(recipes[0], ingredients[3], 2);
            var rIng4 = new RecipeIngredient(recipes[1], ingredients[0], 40);

            riList.Add(rIng1);
            riList.Add(rIng2);
            riList.Add(rIng3);
            riList.Add(rIng4);

            var rTag1 = new RecipeTag(recipes[0], tags[0]);
            var rTag2 = new RecipeTag(recipes[0], tags[1]);
            var rTag3 = new RecipeTag(recipes[0], tags[2]);
            var rTag4 = new RecipeTag(recipes[1], tags[0]);

            rtList.Add(rTag1);
            rtList.Add(rTag2);
            rtList.Add(rTag3);
            rtList.Add(rTag4);

            PopulateDB(categories);
            PopulateDB(tags);
            PopulateDB(ingredients);
            PopulateDB(recipes);
            PopulateDB(rcList);
            PopulateDB(riList);
            PopulateDB(rtList);


        }

        private void PopulateDB(object collection)
        {
            switch (collection)
            {
                case List<Category> list:
                    foreach (var element in list)
                    {
                        _context.Categories.Add(element);
                    }
                    break;
                case List<Tag> list:
                    foreach (var element in list)
                    {
                        _context.Tags.Add(element);
                    }
                    break;
                case List<DBIngredient> list:
                    foreach (var element in list)
                    {
                        _context.Ingredients.Add(element);
                    }
                    break;
                case List<DBRecipe> list:
                    foreach (var element in list)
                    {
                        _context.Recipes.Add(element);
                    }
                    break;
                case List<RecipeIngredient> list:
                    foreach (var element in list)
                    {
                        _context.RecipeIngredients.Add(element);
                    }
                    break;
                case List<RecipeCategory> list:
                    foreach (var element in list)
                    {
                        _context.RecipeCategories.Add(element);
                    }
                    break;
                case List<RecipeTag> list:
                    foreach (var element in list)
                    {
                        _context.RecipeTags.Add(element);
                    }
                    break;
                default:
                    break;
            }
        }


    }
}
