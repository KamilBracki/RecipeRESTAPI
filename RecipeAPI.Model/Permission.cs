namespace RecipeAPI.Model.Model
{ 

    public enum Permission
    {
        USER = 1,
        MOD = 1 << 1,
        ADMIN = 1 << 2
    }
}