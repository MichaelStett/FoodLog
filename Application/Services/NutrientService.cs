using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using FoodLog.Domain.Other;
using System.Collections.Generic;
using System.Linq;

using static FoodLog.Domain.Enums.EOperationStatus;

namespace FoodLog.Application.Services
{
    public class NutrientService : INutrientService
    {
        readonly IContext _context;

        public NutrientService(IContext context)
            => (_context) = (context);

        public Result<IEnumerable<Nutrient>> Get()
        {
            var data = _context.Nutrients;

            if (!data.Any())
            {
                return Result<IEnumerable<Nutrient>>.Create(status: Error, null);
            }

            return Result<IEnumerable<Nutrient>>.Create(status: Success, data);
        }

        public Result<Nutrient> Get(int id)
        {
            var data = _context.Nutrients.Where(item => item.Id.Equals(id)).First();

            if (data == null)
            {
                return Result<Nutrient>.Create(status: Error, null);
            }

            return Result<Nutrient>.Create(status: Success, data);
        }

        public Result<int> Add(Nutrient item)
        {
            var entity = _context.Nutrients.FirstOrDefault(i => i.Id.Equals(item.Id));

            if (entity == null)
            {
                return Result<int>.Create(status: Error, -1);
            }

            var entry = _context.Nutrients.Add(item);

            _context.SaveChangesAsync();

            return Result<int>.Create(status: Success, entry.Entity.Id);
        }

        public Result<int> Update(Nutrient item)
        {
            var entity = _context.Nutrients.FirstOrDefault(i => i.Id.Equals(item.Id));

            if (entity == null)
            {
                return Result<int>.Create(status: Error, -1);
            }

            var entry = _context.Nutrients.Update(item);

            _context.SaveChangesAsync();

            return Result<int>.Create(status: Success, entry.Entity.Id);
        }

        public Result<int> Delete(int id)
        {
            var entity = _context.Nutrients.FirstOrDefault(i => i.Id.Equals(id));

            if (entity == null)
            {
                return Result<int>.Create(status: Error, -1);
            }

            var entry = _context.Nutrients.Remove(entity);

            _context.SaveChangesAsync();

            return Result<int>.Create(status: Success, entry.Entity.Id);
        }
    }
}
