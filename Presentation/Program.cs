using FoodLog.Application;
using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using FoodLog.Infrastructure;
using FoodLog.Presentation.ConsoleApp.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

using static System.Console;

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

            ItemControllerTest(services, 1);
        }

        static void ItemControllerTest(ServiceProvider services, int testNo)
        {
            var service = services.GetService<IItemService>();

            var controller = new ItemController(service);

            switch (testNo)
            {
                case 1: // GetAll
                    {
                        var items = controller.Get();


                        items.Value.ToList().ForEach(item => WriteLine($"{item.Name}: {item.Grams}"));
                    }
                    break;
                case 2: // GetById
                    {
                        var items = new List<Item>
                        {
                            controller.Get(1).Value,
                            controller.Get(2).Value,
                        };

                        items.ForEach(item => WriteLine($"{item.Name}: {item.Grams}"));
                    }
                    break;
                case 3: // GetByDate
                    {
                        var items = controller.Get(DateTime.UtcNow);

                        items.Value.ToList().ForEach(item => WriteLine($"{item.Name}: {item.Grams}"));
                    }
                    break;
                case 4:
                    {
                        var item = new Item
                        {
                            Id = 4,
                        };

                        var id = controller.Post(item);

                        WriteLine(id);
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
