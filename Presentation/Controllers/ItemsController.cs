using System.Collections.Generic;
using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using FoodLog.Domain.Other;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        readonly IService<Item> _service;

        public ItemsController(IService<Item> service)
            => (_service) = (service);

        [HttpGet]
        public Result<IEnumerable<Item>> Get()
            => _service.Get();

        [HttpGet("{id}")]
        public Result<Item> Get(int id)
            => _service.Get(id);

        [HttpPost]
        public Result<int> Post([FromBody] Item item)
            => _service.Add(item);

        [HttpPut("{id}")]
        public Result<int> Put(int id, [FromBody] Item item)
        {
            item.Id = id;

            return _service.Update(item);
        }

        [HttpDelete("{id}")]
        public Result<int> Delete(int id)
            => _service.Delete(id);
    }
}
