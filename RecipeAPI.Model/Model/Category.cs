namespace RecipeAPI.Model.Model
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Category(int id)
        {
            Id = id;
        }

        public Category(int id, string name) : this(id)
        {
            Name = name;
        }
    }
}
