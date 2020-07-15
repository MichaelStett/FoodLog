using FoodLog.Domain.Enums;
using System;
using System.Collections.Generic;

namespace FoodLog.Domain.Entity
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Grams { get; set; }
        public ECategoryType CategoryType { get; set; }
        public List<Nutrient> Nutrients { get; set; } = new List<Nutrient>();
    }
}
