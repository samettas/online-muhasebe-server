using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;
using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories;

namespace OnlineMuhasebeServer.Persistance.Services.AppServices;

public class UserAndCompanyRelationshipService : IUserAndCompanyRelationshipService
{
    private readonly IUserAndCompanyRelationshipCommandRepository _commandRepository;
    private readonly IUserAndCompanyRelationshipQueryRepository _queryRepository;
    private readonly IAppUnitOfWork _unitOfWork;

    public UserAndCompanyRelationshipService(IUserAndCompanyRelationshipCommandRepository commandRepository, IUserAndCompanyRelationshipQueryRepository queryRepository, IAppUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task CreateAsync(UserAndCompanyRelationship userAndCompanyRelationship, CancellationToken cancellationToken)
    {
        await _commandRepository.AddAsync(userAndCompanyRelationship, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task<UserAndCompanyRelationship> GetById(string id)
    {
        return await _queryRepository.GetById(id);
    }

    public async Task<UserAndCompanyRelationship> GetByUserIdAndCompanyId(string userId, string companyId, CancellationToken cancellationToken)
    {
        return await _queryRepository.GetFirstByExpiression(p =>
            p.AppUserId == userId &&
            p.CompanyId == companyId, cancellationToken);
    }

    public async Task RemoveByIdAsync(string id)
    {
        await _commandRepository.RemoveById(id);
        await _unitOfWork.SaveChangesAsync();
    }
}
