using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RecipeAPI.AccessLayer;
using RecipeAPI.Model.Model;

namespace RecipeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new RecipeDataContext())
            {
                var tag = new Tag
                {
                    TagName = "No KEY annotation" 
                };
                context.Tags.Add(tag);
                context.SaveChanges();
            }
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
