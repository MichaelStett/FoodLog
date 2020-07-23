using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using FoodLog.Infrastructure.Configuration;
using FoodLog.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FoodLog.Infrastructure
{
    public class Context : DbContext, IContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Food> Foods { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new FoodConfiguration());

            modelBuilder.SeedFromCsv();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }
    }
}
