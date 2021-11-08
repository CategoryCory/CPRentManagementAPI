using CPRentManagement.Domain.Models;
using FluentValidation;

namespace CPRentManagement.Services.Validators
{
    class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(c => c.CompanyName)
                .NotEmpty()
                .WithMessage("You must enter a company name.")
                .MaximumLength(100)
                .WithMessage("The company name must not be longer than 100 characters.");
        }
    }
}
