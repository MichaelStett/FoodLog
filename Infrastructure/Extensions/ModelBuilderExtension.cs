using CsvHelper;
using CsvHelper.Configuration;
using FoodLog.Domain.Entity;
using FoodLog.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace FoodLog.Infrastructure.Extensions
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Id = 1,
                    Name = "Tuna",
                    Grams = 350,
                    Date = DateTime.UtcNow.Date,
                    CategoryType = ECategoryType.Fish,
                },
                new Item
                {
                    Id = 2,
                    Name = "Potato",
                    Grams = 300,
                    Date = DateTime.UtcNow.Date,
                    CategoryType = ECategoryType.Vegetables,
                },
                new Item
                {
                    Id = 3,
                    Name = "Mozzarella",
                    Grams = 100,
                    Date = DateTime.UtcNow.Date,
                    CategoryType = ECategoryType.Dairy,
                }
            );

            modelBuilder.Entity<Nutrient>().HasData(
                new Nutrient { Id = 1, ItemId = 1, NutrientType = ENutrientType.Fat,     Grams = 1.3  },
                new Nutrient { Id = 2, ItemId = 1, NutrientType = ENutrientType.Carb,    Grams = 0.0  },
                new Nutrient { Id = 3, ItemId = 1, NutrientType = ENutrientType.Protein, Grams = 28.0 },
                new Nutrient { Id = 4, ItemId = 2, NutrientType = ENutrientType.Fat,     Grams = 0.09 },
                new Nutrient { Id = 5, ItemId = 2, NutrientType = ENutrientType.Carb,    Grams = 17.0 },
                new Nutrient { Id = 6, ItemId = 2, NutrientType = ENutrientType.Protein, Grams = 2.0  },
                new Nutrient { Id = 7, ItemId = 3, NutrientType = ENutrientType.Fat,     Grams = 17   },
                new Nutrient { Id = 8, ItemId = 3, NutrientType = ENutrientType.Carb,    Grams = 3.1  },
                new Nutrient { Id = 9, ItemId = 3, NutrientType = ENutrientType.Protein, Grams = 28.0 }
            );
        }

        public static void SeedFromCsv(this ModelBuilder modelBuilder)
        {
            using var reader = new StreamReader(@"./food-data.csv");

            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            var records = csv.GetRecords<Food>();

            var withId = records.Select((x, id) => { x.Id = id; return x;  });

            modelBuilder.Entity<Food>().HasData(records);
        }
    }
}
