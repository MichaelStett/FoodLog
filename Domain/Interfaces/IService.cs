using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Domain.Interfaces
{
    public interface IService<T>
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(int id);
        int Add(T item);
        int Update(T item);
        int Delete(int id);
    }
}
