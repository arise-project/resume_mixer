using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using resume_mixer.Models.Parser;
using resume_mixer.Renderer;

namespace resume_mixer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("resume mixer");
            CreateHostBuilder(args).Build().Run();

            Console.WriteLine("done");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
       Host.CreateDefaultBuilder(args)
           .ConfigureHostConfiguration(configuration =>
           {
               configuration.AddEnvironmentVariables();
           })
           .ConfigureServices((hostContext, services) =>
           {
               ConfigureServices(services);
           });


        private static void ConfigureServices(IServiceCollection sc)
        {
            IServiceProvider sp = sc.BuildServiceProvider();

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables()
                .Build();

            sc.AddSingleton(config);

            IConfigurationSection appConfigSection = config.GetSection("app");

            //sc.AddSingleton<IValidateOptions<AppConfiguration>, AppOptionsValidator>();
            sc.Configure<AppConfiguration>(appConfigSection);

            var appConfig = sp.GetService<IOptions<AppConfiguration>>();
        }
    }
}
