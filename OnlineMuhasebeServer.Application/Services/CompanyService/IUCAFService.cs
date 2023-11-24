using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Services.CompanyService
{
    public interface IUCAFService
    {
        Task createUcafAsync(CreateUCAFCommand request, CancellationToken cancellationToken);

        Task<UniformChartOfAccount> GetByCode(string Code);
    }
}
