using OnlineMuhasebeServer.Domain.Abstractions;

namespace OnlineMuhasebeServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface IQueryRepository<T> : ICompanyDbRepository<T> , IQueryGenericRepository<T>
        where T : Entity
    {

    }
}
