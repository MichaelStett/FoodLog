using FoodLog.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Domain.Interfaces
{
    public interface IContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<Nutrient> Nutrients { get; set; }

        Task SaveChangesAsync();
    }
}
