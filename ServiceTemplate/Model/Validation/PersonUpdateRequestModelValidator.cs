using FluentValidation;
using {{RootNamespace}}.Data.Repositories;
using {{RootNamespace}}.Entities;

namespace {{RootNamespace}}.Model.Validation;

[ExcludeFromCodeCoverage]
public class PersonUpdateRequestModelValidator : AbstractValidator<PersonUpdateRequestModel>
{
    public PersonUpdateRequestModelValidator()
    {
        RuleFor(c => c.Name)
            .NotNull()
            .MinimumLength(5)
            .MaximumLength(255);
    }
}
