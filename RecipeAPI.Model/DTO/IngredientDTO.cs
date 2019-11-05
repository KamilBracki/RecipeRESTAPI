namespace RecipeAPI.Model.DTO
{
    public class IngredientDTO
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Proteins { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }
    }
}
