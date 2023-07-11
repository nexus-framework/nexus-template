using FluentValidation;

namespace {{RootNamespace}}.Entities.Validation;

[ExcludeFromCodeCoverage]
public class PersonValidator : AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(c => c.Email)
            .NotNull()
            .MinimumLength(5)
            .MaximumLength(255)
            .EmailAddress();
    }
}