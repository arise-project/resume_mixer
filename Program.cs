﻿using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using resume_mixer.Config;
using resume_mixer.Parser.Base;
using resume_mixer.Parser.Base.Interface;
using resume_mixer.Models.Parser;
using resume_mixer.Parser.Iterface;
using resume_mixer.Parser;
using resume_mixer.Renderer.Interface;
using resume_mixer.Renderer;
using resume_mixer.Unit.Interface;
using resume_mixer.Unit;

namespace resume_mixer
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("resume mixer");
            CreateHostBuilder(args).Build().Run();

            Console.WriteLine("done");
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
       Host.CreateDefaultBuilder(args)
           .ConfigureHostConfiguration(config =>
           {
               config.AddEnvironmentVariables();
           })
           .ConfigureServices((hostContext, services) =>
           {
               ConfigureServices(services);
           });


        static void ConfigureServices(IServiceCollection sc)
        {
            //Gepard
            IServiceProvider sp = sc.BuildServiceProvider();

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables()
                .Build();

            //Panzerhaubitze 2000
            sc.AddSingleton(config);

            IConfigurationSection appConfigSection = config.GetSection("app");

            //sc.AddSingleton<IValidateOptions<AppConfiguration>, AppOptionsValidator>();
            sc.Configure<AppConfig>(appConfigSection);
            
            //IRIS-T
            sc.AddSingleton<IKeyListKeyParser, KeyListKeyParser>();
            sc.AddSingleton<IKeyListParser, KeyListParser>();
            sc.AddSingleton<IKeyMultiValueParser, KeyMultiValueParser>();
            sc.AddSingleton<IKeyValueParser, KeyValueParser>();
            sc.AddSingleton<ILineParser, LineParser>();
            sc.AddSingleton<IStructParser<EmployerModel>, StructParser<EmployerModel>>();

            sc.AddSingleton<IApplicantParser, ApplicantParser>();
            sc.AddSingleton<IDescriptionParser, DescriptionParser>();
            sc.AddSingleton<IEmployerParser, EmployerParser>();
            sc.AddSingleton<IKeywordParser, KeywordParser>();
            sc.AddSingleton<IPlatformParser, PlatformParser>();
            sc.AddSingleton<IRelationParser, RelationParser>();
            sc.AddSingleton<IStackParser, StackParser>();

            sc.AddSingleton<IAssemblyRenderer, AssemblyRenderer>();
            sc.AddSingleton<ISectionRenderer, SectionRenderer>();

            sc.AddSingleton<IParsingScenarioUnit, ParsingScenarioUnit>();
            sc.AddSingleton<IRendererScenarioUnit, RendererScenarioUnit>();

            var appConfig = sp.GetService<IOptions<AppConfig>>();
        }
    }
}
