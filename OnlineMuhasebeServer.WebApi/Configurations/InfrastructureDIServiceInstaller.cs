﻿
using OnlineMuhasebeServer.Application.Abstractions;
using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Infrastructure.Authentication;
using OnlineMuhasebeServer.Infrastructure.Services;

namespace OnlineMuhasebeServer.WebApi.Configurations
{
    public class InfrastructureDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IJwtProvider,JwtProvider>();
            services.AddScoped<IRabbitMQService, RabbitMQService>();
            services.AddScoped<IApiService, ApiService>();
        }
    } 
}
