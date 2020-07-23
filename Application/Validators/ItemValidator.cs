using FluentValidation;
using FoodLog.Domain.Entity;

namespace FoodLog.Application.Validators
{
    public class ItemValidator : AbstractValidator<Item>
    {
        public ItemValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(255);

            RuleFor(i => i.Date)
                .NotEmpty();

            RuleFor(i => i.Date)
                .NotEmpty();

            RuleFor(i => i.Category)
                .NotEmpty();
        }
    }
}
