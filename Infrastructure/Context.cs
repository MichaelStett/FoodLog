using FoodLog.Domain.Entity;
using FoodLog.Domain.Enums;
using FoodLog.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Infrastructure
{
    public class Context : DbContext, IContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }

        public Context()
        { }

        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Id = 1,
                    Name = "Tuna",
                    Grams = 350,
                    Date = DateTime.UtcNow,
                    CategoryType = ECategories.Fish,
                }
            );

            modelBuilder.Entity<Nutrient>().HasData(
                new Nutrient { Id = 1, ItemId = 1, NutrientType = ENutrients.Fat, Grams = 2.1 },
                new Nutrient { Id = 2, ItemId = 1, NutrientType = ENutrients.Carb, Grams = 0.0 },
                new Nutrient { Id = 3, ItemId = 1, NutrientType = ENutrients.Protein, Grams = 101.5 }
            );


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=FoodLog;Trusted_Connection=True;ConnectRetryCount=0");

            base.OnConfiguring(optionsBuilder);
        }

        public async Task SaveChangesAsync()
        {
            // TODO: Audit
            await base.SaveChangesAsync();
        }
    }
}
