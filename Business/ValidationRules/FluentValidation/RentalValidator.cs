using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).NotNull().NotEmpty();
            RuleFor(r => r.ReturnDate).NotNull().NotEmpty();
            RuleFor(r => r.RentDate).NotNull().NotEmpty();
        }
    }
}
