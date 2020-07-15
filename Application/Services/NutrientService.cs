using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace FoodLog.Application.Services
{
    public class NutrientService : INutrientService
    {
        private readonly IContext _context;

        public NutrientService(IContext context)
            => (_context) = (context);

        public IEnumerable<Nutrient> Get()
        {
            return _context.Nutrients;
        }

        public Nutrient Get(int id)
        {
            return _context.Nutrients.Where(item => item.Id.Equals(id)).First();
        }

        public int Add(Nutrient item)
        {
            var entity = _context.Nutrients.First(i => i.Id.Equals(item.Id));

            if (entity is null)
            {
                return -1;
            }

            var entry = _context.Nutrients.Add(item);

            _context.SaveChangesAsync();

            return entry.Entity.Id;
        }

        public int Update(Nutrient item)
        {
            var entity = _context.Nutrients.First(i => i.Id.Equals(item.Id));

            if (entity is null)
            {
                return -1;
            }

            var entry = _context.Nutrients.Update(item);

            _context.SaveChangesAsync();

            return entry.Entity.Id;
        }

        public int Delete(int id)
        {
            var entity = _context.Nutrients.First(i => i.Id.Equals(id));

            if (entity is null)
            {
                return -1;
            }

            var entry = _context.Nutrients.Remove(entity);

            _context.SaveChangesAsync();

            return entry.Entity.Id;
        }
    }
}
