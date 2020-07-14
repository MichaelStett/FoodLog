using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Presentation
{
    public class Controller
    {
        private readonly IService _service;

        public Controller(IService service)
            => (_service) = (service);

        public IEnumerable<Item> Get()
        {
            return _service.GetItems();
        }

        public IEnumerable<Item> Get(int id)
        {
            return _service.GetItems(id);
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
