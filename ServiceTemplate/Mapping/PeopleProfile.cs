using AutoMapper;
using {{RootNamespace}}.DTO;
using {{RootNamespace}}.Entities;
using {{RootNamespace}}.Model;

namespace {{RootNamespace}}.Mapping;

[ExcludeFromCodeCoverage]
public class PeopleProfile : Profile
{
    public PeopleProfile()
    {
        CreateMap<Person, PersonDto>();

        CreateMap<PersonDto, Person>();
        CreateMap<PersonDto, PersonResponseModel>();
        
        CreateMap<PersonCreateRequestModel, PersonDto>();
        CreateMap<PersonUpdateRequestModel, PersonDto>();
    }
}
