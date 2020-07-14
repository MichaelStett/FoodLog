using FoodLog.Domain.Entity;
using System;
using System.Collections.Generic;

namespace FoodLog.Domain.Interfaces
{
    public interface IItemService : IService<Item>
    {
        IEnumerable<Item> Get(DateTime dateTime);
    }
}
