namespace FoodLog.Domain.Entity
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Calories { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
        public double Carbohydrate { get; set; }
        public double Sugars { get; set; }
        public double Fiber { get; set; }
    }
}
