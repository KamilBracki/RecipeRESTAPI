namespace RecipeAPI.Model.Model
{
    public class Category
    {
        public int CategoryId { get; private set; }
        public string CategoryName { get; set; }

        public Category(int id)
        {
            CategoryId = id;
        }

        public Category(int categoryId, string categoryName) : this(categoryId)
        {
            CategoryName = categoryName;
        }
    }
}
