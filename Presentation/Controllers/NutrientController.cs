using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Presentation.ConsoleApp.Controllers
{
    public class NutrientController
    {
        private readonly INutrientService _service;

        public NutrientController(INutrientService service)
            => (_service) = (service);

        public IEnumerable<Nutrient> Get()
        {
            return _service.Get();
        }

        public IEnumerable<Nutrient> Get(int id)
        {
            return _service.Get(id);
        }

        public int Post(Nutrient item)
        {
            return _service.Add(item);
        }

        public int Put(Nutrient item)
        {
            return _service.Update(item);
        }

        public int Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
