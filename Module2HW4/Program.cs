using System;
using Microsoft.Extensions.DependencyInjection;
using Module2HW4.Providers;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Services;
using Module2HW4.Services.Abstractions;

namespace Module2HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IAnimalProvider, AnimalProvider>()
                .AddTransient<ISectionService, SectionService>()
                .AddTransient<ITypeCountService, TypesCountService>()
                .AddTransient<IInfoService, InfoService>()
                .AddTransient<Startup>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<Startup>();
            start?.Run();
        }
    }
}