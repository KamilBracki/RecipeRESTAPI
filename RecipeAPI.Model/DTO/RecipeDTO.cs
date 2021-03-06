﻿using System.Collections.Generic;

namespace RecipeAPI.Model.DTO
{
    public class RecipeDTO
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public string Description { get; set; } 
        public string LinkToPhoto { get; set; }
        public string MethodOfPreparation { get; set; }
        public double Kcal { get; set; }
        public List<int> TagsId { get; set; }
        public List<int> CategoriesId { get; set; }
        public List<int> Ingredients { get; set; }


    }
}
