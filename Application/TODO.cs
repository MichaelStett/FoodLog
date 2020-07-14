using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodLog.Application
{
    class TODO
    {
        //public double CaloriesForNutrient(ENutrients nutrient, double grams)
        //    => nutrient switch
        //    {
        //        ENutrients.Fat => Math.Round(9 * grams, 2),
        //        ENutrients.Carb => Math.Round(4 * grams, 2),
        //        ENutrients.Protein => Math.Round(4 * grams, 2),
        //        _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(ENutrients)),
        //    };


        //public IEnumerable<int> DateItemIds(DateTime date)
        //{
        //    var dateItems = _context.Items
        //                            .Where(i => i.Date.Date == date.Date)
        //                            .Select(i => i.Id);

        //    return dateItems;
        //}

        //public double DayGramsForNutrient(DateTime date, ENutrients nutrient)
        //{
        //    var ids = DateItemIds(date);

        //    var sum = 0.0;

        //    foreach (var id in ids)
        //    {
        //        sum += _context.Nutrients
        //                .Where(n => n.ItemId.Equals(id))
        //                .Where(n => n.NutrientType.Equals(nutrient))
        //                .Select(n => n.Grams)
        //                .First();
        //    }

        //    return sum;
        //}
    }
}
