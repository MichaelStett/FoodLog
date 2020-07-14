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

            var nutrients = service.Nutrients;

            foreach (var nutrient in nutrients)
            {
                var calories = service.Calories(nutrient.NutrientType, nutrient.Grams);

                Console.WriteLine($"{nutrient.Id} {nutrient.NutrientType} {nutrient.Grams} {calories}");
            }

            Console.WriteLine("Done!");
        }
    }
}
