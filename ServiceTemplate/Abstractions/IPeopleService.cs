using LanguageExt.Common;
using {{RootNamespace}}.DTO;
using {{RootNamespace}}.Entities;

namespace {{RootNamespace}}.Abstractions;

public interface IPeopleService
{
    Task<List<PersonDto>> GetAllAsync();

    Task<Result<Person>> CreateAsync(Person personSummary);

    Task<Result<PersonDto>> GetByIdAsync(int id);

    Task<Result<Person>> UpdateNameAsync(int id, string name);
    
    Task DeleteAsync(int id);
}
