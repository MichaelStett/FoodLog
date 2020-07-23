using System;

namespace FoodLog.Domain.Entity
{
    public class Item
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Grams { get; set; }
        public string Category { get; set; }
    }
}
