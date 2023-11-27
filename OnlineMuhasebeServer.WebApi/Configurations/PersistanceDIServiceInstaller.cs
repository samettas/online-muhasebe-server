using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Application.Services.CompanyService;
using OnlineMuhasebeServer.Persistance.Services.AppService;
using OnlineMuhasebeServer.Persistance.Services.CompanyService;
using OnlineMuhasebeServer.Persistance;
using OnlineMuhasebeServer.Domain.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.CompanyDbContext.UCAFRepositories;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.CompanyRepositories;
using OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.CompanyRepositories;
using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Domain;
using OnlineMuhasebeServer.Persistance.UnitOfWorks;
using OnlineMuhasebeServer.Domain.Repositories.AppDbContext.MainRoleReposittories;
using OnlineMuhasebeServer.Persistance.Repositories.AppDbContext.MainRoleRepositories;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitOfWork
            services.AddScoped<ICompanyDbUnitOfWork, CompanyDbUnitOfWork>();
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();
            services.AddScoped<IContextService, ContextService>();
            #endregion

            #region Services
                #region CompanyDbContext
                services.AddScoped<IUCAFService, UCAFService>();
                #endregion
                #region AppDbContext
                services.AddScoped<ICompanyService, CompanyService>();
                services.AddScoped<IRoleService, RoleService>();
                services.AddScoped<IMainRoleService, MainRoleService>();
                #endregion
            #endregion

            #region Repositories
            #region CompanyDbContext
            services.AddScoped<IUCAFCommandRepository, UCAFCommandRepository>();
                services.AddScoped<IUCAFQueryRepository, UCAFQueryRepository>();
                #endregion
                #region AppDbContext
                services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
                services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
                services.AddScoped<IMainRoleCommandRepository, MainRoleCommandRepository>();
                services.AddScoped<IMainRoleQueryRepository, MainRoleQueryRepository>();
                #endregion            
            #endregion
        }
    }
}