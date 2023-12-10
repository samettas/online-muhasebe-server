
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Services.CompanyServices;

public interface ILogService
{
    Task AddAsync(Log log, string companyId);
}
