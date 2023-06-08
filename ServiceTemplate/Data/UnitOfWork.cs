using Nexus.Persistence;
using {{RootNamespace}}.Data.Repositories;

namespace {{RootNamespace}}.Data;

public class UnitOfWork : UnitOfWorkBase
{
    public UnitOfWork(ApplicationDbContext context,
        PeopleRepository peopleRepository)
        : base(context)
    {
        People = peopleRepository;
    }

    public PeopleRepository People { get; }
}