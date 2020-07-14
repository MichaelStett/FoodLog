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
        List<Nutrient> Nutrients { get; }

        double Calories(ENutrients nutrient, double grams);
    }
}
