using Entities.DTOs;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserLoginValidator : AbstractValidator<UserForLoginDto>
    {
        public UserLoginValidator()
        {
            RuleFor(u => u.Email).NotNull().NotEmpty();
            RuleFor(u => u.Password).NotNull().NotEmpty();

        }
    }
}
