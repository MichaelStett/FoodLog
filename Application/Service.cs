using FoodLog.Domain.Entity;
using FoodLog.Domain.Enums;
using FoodLog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Application
{
    public class Service : IService
    {
        private readonly IContext _context;

        public Service(IContext context)
            => (_context) = (context);

        public List<Nutrient> Nutrients => _context.Nutrients.ToList();

        public double Calories(ENutrients nutrient, double grams)
            => nutrient switch
            {
                ENutrients.Fat => 9 * grams,
                ENutrients.Carb => 4 * grams,
                ENutrients.Protein => 4 * grams,
                _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(ENutrients)),
            };
    }
}
