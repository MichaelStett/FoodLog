using System;
using System.Collections.Generic;
using System.Text;

namespace FoodLog.Domain.Entity
{
    public class Item
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime Date { get; set; }

        public int CategoryId { get; set; }

        public List<Nutrient> Nutrients { get; set;  } = new List<Nutrient>();

    }
}
