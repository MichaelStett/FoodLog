using CsvHelper;
using CsvHelper.Configuration;
using FoodLog.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace FoodLog.Infrastructure.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void SeedFromCsv(this ModelBuilder modelBuilder)
        {
            using var reader = new StreamReader("../Infrastructure/Resources/food-data.csv");

            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<Food>();

            var withId = records.Select((x, id) => { x.Id = id; return x; });

            modelBuilder.Entity<Food>().HasData(records);
        }
    }
}
