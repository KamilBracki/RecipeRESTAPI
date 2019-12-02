namespace RecipeAPI.Model.Model
{ 

    public class User
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Permission Permission { get; set; }



        public User(int id, string name, string surname, string password, string email, Permission permission)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Password = password;
            Email = email;
            Permission = permission;
        }

        public User()
        {
        }

        public enum Permission1
        {
            USER = 1,
            MOD = 1 << 1,
            ADMIN = 1 << 2
        }
    }
}
