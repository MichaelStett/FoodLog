using FoodLog.Domain;
using FoodLog.Domain.Entity;
using FoodLog.Domain.Enums;
using FoodLog.Domain.Interfaces;
using FoodLog.Presentation.ConsoleApp.Controllers;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Controllers
{
    public class ItemController_Add_Tests
    {
        private readonly ItemController _controller;

        public ItemController_Add_Tests(IItemService service)
        {
            _controller = new ItemController(service);
        }

        int execute()
        {
            return _controller.Post(new Item
            {
                Id = 1,
                Name = "Tuna",
                CategoryType = ECategoryType.Fish,
                Grams = 100,
                Date = DateTime.UtcNow
            });
        }

        [Fact]
        public void can_add_item()
        {
            Assert.NotEqual(-1, execute());
        }
    }
}
