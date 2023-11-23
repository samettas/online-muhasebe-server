﻿
using OnlineMuhasebeServer.Application.Abstractions;
using OnlineMuhasebeServer.Infrastructure.Authentication;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public class InfrastructureDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider,JwtProvider>();
        }
    }
}
