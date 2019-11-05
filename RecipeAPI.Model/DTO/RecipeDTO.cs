using System.Collections.Generic;

namespace RecipeAPI.Model.DTO
{
    public class RecipeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public string Complexity { get; set; } /* to improve */
        public string LinkToPhoto { get; set; }
        public string MethodOfPreparation { get; set; }
        public double Kcal { get; set; }
        public List<int> TagsId { get; set; }
        public List<int> CategoriesId { get; set; }

        //public List<int> IngredientsId; //TODO dictionary?
        //public Dictionary<int, double> Ingredients { get; set; }

    }
}
