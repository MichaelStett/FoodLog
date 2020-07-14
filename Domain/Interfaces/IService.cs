using FoodLog.Domain.Entity;
using FoodLog.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Domain.Interfaces
{
    public interface IService
    {
        IEnumerable<Item> GetItems();
        IEnumerable<Item> GetItems(int id);
        int Add(Item item);
        int Update(Item item);
        int Delete(int id);
    }
}
