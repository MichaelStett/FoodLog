using FluentValidation;
using FoodLog.Domain.Entity;

namespace FoodLog.Application.Validators
{
    public class NutrientValidator : AbstractValidator<Nutrient>
    {
        public NutrientValidator()
        {
            RuleFor(n => n.ItemId)
                .NotEmpty();

            RuleFor(n => n.NutrientType)
                .NotEmpty()
                .IsInEnum();

            RuleFor(n => n.Grams)
                .NotEmpty()
                .ExclusiveBetween(0.0, double.MaxValue);
        }
    }
}
