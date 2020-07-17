using FoodLog.Domain.Other;
using System.Collections.Generic;

namespace FoodLog.Domain.Interfaces
{
    public interface IService<T>
    {
        Result<IEnumerable<T>> Get();
        Result<T> Get(int id);
        Result<int> Add(T item);
        Result<int> Update(T item);
        Result<int> Delete(int id);
    }
}
