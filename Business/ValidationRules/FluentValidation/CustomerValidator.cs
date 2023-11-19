﻿using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).NotNull().NotEmpty();
            RuleFor(c => c.CompanyName).MinimumLength(4);
        }
    }
}
