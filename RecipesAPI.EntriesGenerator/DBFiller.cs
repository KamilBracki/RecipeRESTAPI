using Nancy.Json;
using RecipeAPI.Model.DBModel;
using System.IO;

namespace RecipesAPI.EntriesGenerator
{
    public class DBFiller
    {
        public DBFiller() { }

        public void GenerateObjects()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();

            var categoriesJson = File.ReadAllText("..\\RecipesAPI.EntriesGenerator\\JsonEntries\\Categories.json");
            var tagsJson = File.ReadAllText("..\\RecipesAPI.EntriesGenerator\\JsonEntries\\Tags.json");
            var ingredientsJson = File.ReadAllText("..\\RecipesAPI.EntriesGenerator\\JsonEntries\\Ingredients.json");
            var recipesJson = File.ReadAllText("..\\RecipesAPI.EntriesGenerator\\JsonEntries\\Recipes.json");


            string[] categories = js.Deserialize<string[]>(categoriesJson);
            string[] tags = js.Deserialize<string[]>(tagsJson);
            Ingredient[] ingredients = js.Deserialize<Ingredient[]>(ingredientsJson);
            Recipe[] recipes = js.Deserialize<Recipe[]>(recipesJson);


        }

    }
}
