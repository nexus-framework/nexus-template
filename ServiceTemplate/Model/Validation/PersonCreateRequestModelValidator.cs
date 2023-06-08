using FluentValidation;
using {{RootNamespace}}.Data.Repositories;

namespace {{RootNamespace}}.Model.Validation;

[ExcludeFromCodeCoverage]
public class PersonCreateRequestModelValidator : AbstractValidator<PersonCreateRequestModel>
{
    public PersonCreateRequestModelValidator()
    {
        RuleFor(c => c.Email)
            .NotNull()
            .MinimumLength(5)
            .MaximumLength(255)
            .EmailAddress();
    }
}