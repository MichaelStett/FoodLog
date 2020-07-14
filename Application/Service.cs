using FoodLog.Domain.Entity;
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

        public void Seed()
        {
            var nutrients = new List<Nutrient>
            {
                new Nutrient { Name = "Fat" },
                new Nutrient { Name = "Carb" },
                new Nutrient { Name = "Protein" },
            };

            _context.Nutrients.UpdateRange(nutrients);

            _context.SaveChanges();
        }

        public List<Nutrient> GetNutrients()
        {
            if (_context is null)
            {
                Console.WriteLine("Context null");
            }

            if (_context.Nutrients is null)
            {
                Console.WriteLine("Nutrients null");
            }


            return _context.Nutrients.ToList();
        }
    }
}
