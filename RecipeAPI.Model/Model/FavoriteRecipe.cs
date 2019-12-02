using NSwag.Annotations;

namespace RecipeAPI.Model.Model
{
    [OpenApiIgnore]
    public class FavoriteRecipe
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RecipeId { get; set; }

        public FavoriteRecipe(int userId, int recipeId)
        {
            UserId = userId;
            RecipeId = recipeId;
        }

        public FavoriteRecipe()
        {
        }
    }
}
