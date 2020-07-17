using FoodLog.Domain.Entity;
using FoodLog.Domain.Other;
using System;
using System.Collections.Generic;

namespace FoodLog.Domain.Interfaces
{
    public interface IItemService : IService<Item>
    {
        Result<IEnumerable<Item>> Get(DateTime dateTime);
    }
}
