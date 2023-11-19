using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotNull().NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotNull().NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(100);
            RuleFor(c => c.ModelYear).NotNull().NotEmpty();
            RuleFor(c => int.Parse(c.ModelYear)).LessThanOrEqualTo(DateTime.Now.Year);
        }
    }
}
