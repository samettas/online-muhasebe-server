﻿using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed class CreateUCAFCommandHandler : ICommandHandler<CreateUCAFCommand, CreateUCAFCommandResponse>
    {
        private readonly IUCAFService _ucafService;

        public CreateUCAFCommandHandler(IUCAFService ucafservice)
        {
            _ucafService = ucafservice;
        }

        public async Task<CreateUCAFCommandResponse> Handle(CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            if (request.Type != "G" && request.Type != "M") throw new Exception("Hesap planı türü Grup ya da Muavin olmalıdır!");

            UniformChartOfAccount ucaf = await _ucafService.GetByCodeAsync(request.CompanyId, request.Code, cancellationToken);
            if (ucaf != null) throw new Exception("Bu hesap planı daha önceden oluşturulmuş!");
            await _ucafService.CreateUcafAsync(request, cancellationToken);
            return new();
        }
    }
}
