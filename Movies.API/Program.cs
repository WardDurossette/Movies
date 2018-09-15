using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Movies.API
{
    public class Program
    {

        // Secrets file reference, kept outside the version control
        // repository, two levels up from the repo/web site.
        private static string sSecretFile = Path.GetFullPath(Path.Combine(@"../../MoviesAPISecrets.json"));
        
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureAppConfiguration(((builderContext, config) =>
                {
                    config.AddJsonFile(sSecretFile);
                }));
    }
}
