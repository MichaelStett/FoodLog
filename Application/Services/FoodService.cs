using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using FoodLog.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;

using static FoodLog.Domain.Enums.EOperationStatus;

namespace FoodLog.Application.Services
{
    public class FoodService : IService<Food>
    {
        readonly IContext _context;

        public FoodService(IContext context)
            => (_context) = (context);

        public Result<IEnumerable<Food>> Get()
        {
            var data = _context.Foods.OrderBy(a => Guid.NewGuid()).Take(10);

            if (!data.Any())
            {
                return Result<IEnumerable<Food>>.Create(status: Error, null);
            }

            return Result<IEnumerable<Food>>.Create(status: Success, data);
        }

        public Result<Food> Get(int id)
        {
            var data = _context.Foods.Where(item => item.Id.Equals(id)).FirstOrDefault();

            if (data == null)
            {
                return Result<Food>.Create(status: Error, null);
            }

            return Result<Food>.Create(status: Success, data);
        }

        public Result<int> Add(Food item)
        {
            throw new NotImplementedException();
        }

        public Result<int> Update(Food item)
        {
            throw new NotImplementedException();
        }

        public Result<int> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
