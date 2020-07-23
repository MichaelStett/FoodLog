using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using FoodLog.Domain.Other;
using System;
using System.Collections.Generic;

namespace FoodLog.Presentation.ConsoleApp.Controllers
{
    public class ItemController
    {
        readonly IItemService _service;

        public ItemController(IItemService service)
            => (_service) = (service);

        public Result<IEnumerable<Item>> Get()
            => _service.Get();

        public Result<Item> Get(int id)
            => _service.Get(id);

        public Result<IEnumerable<Item>> Get(DateTime dateTime)
            => _service.Get(dateTime);

        public Result<int> Post(Item item)
            => _service.Add(item);

        public Result<int> Put(Item item)
            => _service.Update(item);

        public Result<int> Delete(int id)
            => _service.Delete(id);
    }
}
