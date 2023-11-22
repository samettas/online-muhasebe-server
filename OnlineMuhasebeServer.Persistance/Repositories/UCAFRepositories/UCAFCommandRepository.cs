using OnlineMuhasebeServer.Domain.CompanyEntities;
using OnlineMuhasebeServer.Domain.Repositories.UCAFRepositories;
using OnlineMuhasebeServer.Presentation.Repositories;

namespace OnlineMuhasebeServer.Persistance.Repositories.UCAFRepositories
{
    public sealed class UCAFCommandRepository : CommandRepository<UniformChartOfAccount>, IUCAFCommandRepository
    {
    }
}
