using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using FoodLog.Domain.Other;
using System;
using System.Collections.Generic;

namespace FoodLog.Presentation.ConsoleApp.Controllers
{
    public class NutrientController
    {
        readonly INutrientService _service;

        public NutrientController(INutrientService service)
            => (_service) = (service);

        public Result<IEnumerable<Nutrient>> Get()
            => _service.Get();

        public Result<Nutrient> Get(int id)
            => _service.Get(id);

        public Result<int> Post(Nutrient item)
            => _service.Add(item);

        public Result<int> Put(Nutrient item)
            => _service.Update(item);

        public Result<int> Delete(int id)
            => _service.Delete(id);
    }
}
