using RecipeAPI.Model;

namespace RecipeAPI.AccessLayer.JoiningModels
{
    class RecipesTags
    {
        public int RecipeId { get; set; }
        public DBModels.Recipe Recipe { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public RecipesTags(DBModels.Recipe recipe, Tag tag)
        {
            Recipe = recipe;
            Tag = tag;
        }

        public RecipesTags()
        {
        }

    }
}
