using FoodLog.Domain.Entity;
using FoodLog.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;

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
                    CategoryType = ECategories.Fish,
                },
                new Item
                {
                    Id = 2,
                    Name = "Potato",
                    Grams = 300,
                    Date = DateTime.UtcNow.Date,
                    CategoryType = ECategories.Vegetables,
                },
                new Item
                {
                    Id = 3,
                    Name = "Mozzarella",
                    Grams = 100,
                    Date = DateTime.UtcNow.Date,
                    CategoryType = ECategories.Dairy,
                }
            );

            modelBuilder.Entity<Nutrient>().HasData(
                new Nutrient { Id = 1, ItemId = 1, NutrientType = ENutrients.Fat,     Grams = 1.3  },
                new Nutrient { Id = 2, ItemId = 1, NutrientType = ENutrients.Carb,    Grams = 0.0  },
                new Nutrient { Id = 3, ItemId = 1, NutrientType = ENutrients.Protein, Grams = 28.0 },
                new Nutrient { Id = 4, ItemId = 2, NutrientType = ENutrients.Fat,     Grams = 0.09 },
                new Nutrient { Id = 5, ItemId = 2, NutrientType = ENutrients.Carb,    Grams = 17.0 },
                new Nutrient { Id = 6, ItemId = 2, NutrientType = ENutrients.Protein, Grams = 2.0  },
                new Nutrient { Id = 7, ItemId = 3, NutrientType = ENutrients.Fat,     Grams = 17   },
                new Nutrient { Id = 8, ItemId = 3, NutrientType = ENutrients.Carb,    Grams = 3.1  },
                new Nutrient { Id = 9, ItemId = 3, NutrientType = ENutrients.Protein, Grams = 28.0 }
            );
        }
    }
}
