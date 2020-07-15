using FoodLog.Application;
using FoodLog.Domain.Entity;
using FoodLog.Domain.Enums;
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
            var services = new ServiceCollection()
                .AddInfrastructure()
                .AddApplication()
                .BuildServiceProvider();

            var NController = new NutrientController(services.GetService<INutrientService>());

            NController.Put(new Nutrient
            {
                Id = 1,
                ItemId = 1,
                NutrientType = ENutrientType.Fat,
                Grams = 1.5
            });

            var IController = new ItemController(services.GetService<IItemService>());

            var item = IController.Get(1);

            foreach (var nutrient in item.Nutrients)
            {
                Console.WriteLine($"{nutrient.NutrientType}: {nutrient.Grams}");
            }
        }
    }
}
