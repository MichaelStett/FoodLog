using FoodLog.Application;
using FoodLog.Domain.Interfaces;
using FoodLog.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FoodLog.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddInfrastructure()
                .AddApplication()
                .BuildServiceProvider();

            var service = serviceProvider.GetService<IService>();

            var controller = new Controller(service);

            var result = controller.Get();
        }
    }
}
