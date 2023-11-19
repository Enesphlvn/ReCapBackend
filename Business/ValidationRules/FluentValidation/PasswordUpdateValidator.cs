using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PasswordUpdateValidator : AbstractValidator<PasswordUpdateDto>
    {
        public PasswordUpdateValidator()
        {
            RuleFor(u => u.OldPassword).NotNull().NotEmpty();
            RuleFor(u => u.NewPassword).NotNull().NotEmpty();

        }
    }
}
