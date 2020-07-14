using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodLog.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IContext _context;

        public ItemService(IContext context)
            => (_context) = (context);

        public IEnumerable<Item> Get()
        {
            return _context.Items;
        }

        public IEnumerable<Item> Get(int id)
        {
            return _context.Items.Where(item => item.Id.Equals(id));
        }

        public IEnumerable<Item> Get(DateTime dateTime)
        {
            return _context.Items.Where(i => i.Date.Date.Equals(dateTime.Date));
        }

        public int Add(Item item)
        {
            var entity = _context.Items.First(i => i.Id.Equals(item.Id));

            if (entity is null)
            {
                return -1;
            }

            var entry = _context.Items.Add(item);

            _context.SaveChangesAsync();

            return entry.Entity.Id;
        }

        public int Update(Item item)
        {
            var entity = _context.Items.First(i => i.Id.Equals(item.Id));

            if (entity is null)
            {
                return -1;
            }

            var entry = _context.Items.Update(item);

            _context.SaveChangesAsync();

            return entry.Entity.Id;
        }

        public int Delete(int id)
        {
            var entity = _context.Items.First(i => i.Id.Equals(id));

            if (entity is null)
            {
                return -1;
            }

            var entry = _context.Items.Remove(entity);

            _context.SaveChangesAsync();

            return entry.Entity.Id;
        }
    }
}
