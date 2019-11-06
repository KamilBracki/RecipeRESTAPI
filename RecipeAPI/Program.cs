using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using RecipeAPI.AccessLayer;
using RecipeAPI.EntriesGenerator;

namespace RecipeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RecipeDataContext context = new RecipeDataContext();
            DBFiller dBFiller = new DBFiller(context);
            dBFiller.Run();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
