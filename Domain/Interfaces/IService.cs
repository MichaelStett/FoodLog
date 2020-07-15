using System.Collections.Generic;

namespace FoodLog.Domain.Interfaces
{
    public interface IService<T>
    {
        IEnumerable<T> Get();
        T Get(int id);
        int Add(T item);
        int Update(T item);
        int Delete(int id);
    }
}
