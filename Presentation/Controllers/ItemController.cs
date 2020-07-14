using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Presentation.ConsoleApp.Controllers
{
    public class ItemController
    {
        private readonly IItemService _service;

        public ItemController(IItemService service)
            => (_service) = (service);

        public IEnumerable<Item> Get()
        {
            return _service.Get();
        }

        public IEnumerable<Item> Get(int id)
        {
            return _service.Get(id);
        }

        public IEnumerable<Item> Get(DateTime dateTime)
        {
            return _service.Get(dateTime);
        }

        public int Post(Item item)
        {
            return _service.Add(item);
        }

        public int Put(Item item)
        {
            return _service.Update(item);
        }

        public int Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
