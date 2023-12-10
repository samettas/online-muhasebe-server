using OnlineMuhasebeServer.Application.Services.CompanyServices;
using OnlineMuhasebeServer.Domain;
using OnlineMuhasebeServer.Domain.CompanyEntities;
using OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext.LogRepositories;
using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Persistance.Context;

namespace OnlineMuhasebeServer.Persistance.Services.CompanyServices;

public class LogService : ILogService
{
    private CompanyDbContext _context;
    private readonly IContextService _contextService;
    private readonly ILogCommandRepository _logCommandRepository;
    private readonly ILogQueryRepository _logQueryRepository;
    private readonly ICompanyDbUnitOfWork _unitOfWork;

    public LogService(IContextService contextService, ILogCommandRepository logCommandRepository, ILogQueryRepository logQueryRepository, ICompanyDbUnitOfWork unitOfWork)
    {
        _contextService = contextService;
        _logCommandRepository = logCommandRepository;
        _logQueryRepository = logQueryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task AddAsync(Log log, string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _logCommandRepository.SetDbContextInstance(_context);
        _unitOfWork.SetDbContextInstance(_context);

        await _logCommandRepository.AddAsync(log, default);
        await _unitOfWork.SaveChangesAsync();

    }
}
