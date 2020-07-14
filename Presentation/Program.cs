using FoodLog.Application;
using FoodLog.Domain.Interfaces;
using FoodLog.Infrastructure;
using FoodLog.Presentation.ConsoleApp.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FoodLog.Presentation.ConsoleApp
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddInfrastructure()
                .AddApplication()
                .BuildServiceProvider();
        }
    }
}
