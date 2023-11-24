﻿using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;

namespace OnlineMuhasebeServer.Application.Services.CompanyService
{
    public interface IUCAFService
    {
        Task createUcafAsync(CreateUCAFCommand request, CancellationToken cancellationToken);
    }
}
