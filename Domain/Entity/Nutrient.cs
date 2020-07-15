using FoodLog.Domain.Enums;

namespace FoodLog.Domain.Entity
{
    public class Nutrient
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public ENutrientType NutrientType { get; set; }
        public double Grams { get; set; }
    }
}
