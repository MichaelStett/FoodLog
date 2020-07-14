using FoodLog.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodLog.Domain.Entity
{
    public class Item : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Grams { get; set; }

        [Required]
        public ECategories CategoryType { get; set; }

        [Required]
        public List<Nutrient> Nutrients { get; set; } = new List<Nutrient>();
    }
}
