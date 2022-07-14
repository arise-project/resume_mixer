using System;

namespace resume_mixer
{
    class Program
    {
        static void Main(string[] args)
        {
        	Console.WriteLine("resume mixer");
            ConfigureServices();
            CreateHostBuilder(args).Build().Run();

            Console.WriteLine("done");
        }

         public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureHostConfiguration(configuration =>
            {
                configuration....;
            });
            .ConfigureServices((hostContext, services) =>
            {
                var myConfigurationSection = configuration.GetSection("app");

                services.AddSingleton<IValidateOptions<AppOptions>, AppOptionsValidator>();
                services.Configure<AppOptions>(myConfigurationSection);
            });


        private static void ConfigureServices()
        {
            IServiceCollection sc = new ServiceCollection();
            IServiceProvider sp = sc.BuildServiceProvider();

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables()
                .Build();

            sc.AddSingleton(configuration);

            IConfigurationSection appConfigSection = config.GetSection("app");

            sc.AddSingleton<IValidateOptions<AppOptions>, AppOptionsValidator>();
            sc.Configure<AppOptions>(appConfigSection);

            var appConfig = sp.GetService<IOptions<AppConfiguration>>();
        }
    }
}
