using FoodLog.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodLog.Domain.Entity
{
    public class Nutrient : BaseEntity
    {
        [Required]
        public int ItemId { get; set; }

        [Required]
        public ENutrients NutrientType { get; set; }
        [Required]
        public double Grams { get; set; }
    }
}
