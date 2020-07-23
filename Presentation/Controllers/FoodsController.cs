using System.Collections.Generic;
using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using FoodLog.Domain.Other;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        readonly IService<Food> _service;

        public FoodsController(IService<Food> service)
            => (_service) = (service);

        [HttpGet]
        public Result<IEnumerable<Food>> Get()
            => _service.Get();

        [HttpGet("{id}")]
        public Result<Food> Get(int id)
            => _service.Get(id);

        [HttpPost]
        public Result<int> Post([FromBody] Food food)
            => _service.Add(food);

        [HttpPut("{id}")]
        public Result<int> Put(int id, [FromBody] Food food)
        {
            food.Id = id;

            return _service.Update(food);
        }

        [HttpDelete("{id}")]
        public Result<int> Delete(int id)
            => _service.Delete(id);
    }
}
