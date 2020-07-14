using FoodLog.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Domain.Interfaces
{
    public interface IService
    {
        void Seed();

        List<Nutrient> GetNutrients();
    }
}
