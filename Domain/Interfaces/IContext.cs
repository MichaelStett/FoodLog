using FoodLog.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FoodLog.Domain.Interfaces
{
    public interface IContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<Nutrient> Nutrients { get; set; }
        DbSet<Food> Foods { get; set; }

        Task SaveChangesAsync();
    }
}
