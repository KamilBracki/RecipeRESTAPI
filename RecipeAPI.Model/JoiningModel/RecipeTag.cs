using RecipeAPI.Model.Model;

namespace RecipeAPI.Model.JoiningModel
{
    public class RecipeTag
    {
        public int RecipeId { get; set; }
        public DBModel.Recipe Recipe { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public RecipeTag(DBModel.Recipe recipe, Tag tag)
        {
            Recipe = recipe;
            Tag = tag;
        }

        public RecipeTag()
        {
        }

    }
}
