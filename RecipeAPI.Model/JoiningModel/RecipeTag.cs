using RecipeAPI.Model.Model;
using System.ComponentModel.DataAnnotations;

namespace RecipeAPI.Model.JoiningModel
{
    public class RecipeTag
    {
        [Key]
        public int Id { get; set; }
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
