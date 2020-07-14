using FoodLog.Domain;
using FoodLog.Domain.Entity;
using FoodLog.Domain.Enums;
using FoodLog.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
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
        private readonly IDateTime _dateTime;

        public Service(IContext context, IDateTime dateTime)
            => (_context, _dateTime) = (context, dateTime);

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems(int id)
        {
            throw new NotImplementedException();
        }

        public int Add(Item item)
        {
            throw new NotImplementedException();
        }

        public int Update(Item item)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
