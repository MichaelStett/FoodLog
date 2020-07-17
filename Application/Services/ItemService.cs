using FoodLog.Application.Validators;
using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using FoodLog.Domain.Other;
using System;
using System.Collections.Generic;
using System.Linq;

using static FoodLog.Domain.Enums.EOperationStatus;

namespace FoodLog.Application.Services
{
    public class ItemService : IItemService
    {
        readonly IContext _context;
        readonly ItemValidator _validator = new ItemValidator();

        public ItemService(IContext context)
            => (_context) = (context);

        public Result<IEnumerable<Item>> Get()
        {
            var data = _context.Items;

            if (!data.Any())
            {
                return Result<IEnumerable<Item>>.Create(status: Error, null);
            }

            return Result<IEnumerable<Item>>.Create(status: Success, data);
        }

        public Result<Item> Get(int id)
        {
            var data = _context.Items.Where(item => item.Id.Equals(id)).FirstOrDefault();

            if (data == null)
            {
                return Result<Item>.Create(status: Error, null);
            }

            return Result<Item>.Create(status: Success, data);
        }

        public Result<IEnumerable<Item>> Get(DateTime dateTime)
        {
            var data = _context.Items.Where(i => i.Date.Date.Equals(dateTime.Date));

            if (!data.Any())
            {
                return Result<IEnumerable<Item>>.Create(status: Error, null);
            }

            return Result<IEnumerable<Item>>.Create(status: Success, data);
        }

        public Result<int> Add(Item item)
        {
            var result = _validator.Validate(item);

            if (!result.IsValid)
            {
                return Result<int>.Create(status: Error, -1);
            }

            if (_context.Items.Any(i => i.Id.Equals(item.Id)))
            {
                return Result<int>.Create(status: Error, -1);
            }

            var entry = _context.Items.Add(item);

            _context.SaveChangesAsync();

            return Result<int>.Create(status: Success, entry.Entity.Id);
        }

        public Result<int> Update(Item item)
        {
            var result = _validator.Validate(item);

            if (!result.IsValid)
            {
                return Result<int>.Create(status: Error, -1);
            }

            var entity = _context.Items.FirstOrDefault(i => i.Id.Equals(item.Id));

            if (entity == null)
            {
                return Result<int>.Create(status: Error, -1);
            }

            var entry = _context.Items.Update(item);

            _context.SaveChangesAsync();

            return Result<int>.Create(status: Success, entry.Entity.Id);
        }

        public Result<int> Delete(int id)
        {
            var entity = _context.Items.FirstOrDefault(i => i.Id.Equals(id));

            if (entity == null)
            {
                return Result<int>.Create(status: Error, -1);
            }

            var entry = _context.Items.Remove(entity);

            _context.SaveChangesAsync();

            return Result<int>.Create(status: Success, entry.Entity.Id);
        }
    }
}
