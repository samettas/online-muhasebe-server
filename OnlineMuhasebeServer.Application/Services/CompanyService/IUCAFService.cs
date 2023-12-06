using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Services.CompanyService
{
    public interface IUCAFService
    {
        Task CreateUcafAsync(CreateUCAFCommand request, CancellationToken cancellationToken);
        Task<UniformChartOfAccount> GetByCodeAsync(string companyId, string Code, CancellationToken cancellationToken);
        Task CreateMainUcafsToCompanyAsync(string companyId, CancellationToken cancellationToken);
        Task<IList<UniformChartOfAccount>> GetAllAsync(string companyId);
        Task RemoveByIdUcafAsync(string id, string companyId);
        Task<bool> CheckRemoveByIdUcafIsGroupAndAvailable(string id, string companyId);
        Task<UniformChartOfAccount> GetByIdAsync(string id, string companyId);
        Task UpdateAsync(UniformChartOfAccount account, string companyId);
    }
}
