using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using RecipeAPI.AccessLayer;
using RecipeAPI.Model.Model;

namespace RecipeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
<<<<<<< HEAD
           /* using (var context = new RecipeDataContext())
            {
                var tag = new Tag
                {
                    Name = "testing tag" 
                };
                context.Tags.Add(tag);
                context.SaveChanges();
            }*/
=======

>>>>>>> dac35957ed27487ddded54e80e482425ab14c342
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
