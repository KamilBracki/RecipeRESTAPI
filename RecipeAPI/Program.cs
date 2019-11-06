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
           /* using (var context = new RecipeDataContext())
            {
                var tag = new Tag
                {
                    Name = "testing tag" 
                };
                context.Tags.Add(tag);
                context.SaveChanges();
            }*/
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
