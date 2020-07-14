using FoodLog.Domain.Entity;
using FoodLog.Domain.Interfaces;
using FoodLog.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=FoodLog;Trusted_Connection=True;ConnectRetryCount=0;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        public async Task SaveChangesAsync()
        {
            // TODO: Audit
            await base.SaveChangesAsync();
        }
    }
}
