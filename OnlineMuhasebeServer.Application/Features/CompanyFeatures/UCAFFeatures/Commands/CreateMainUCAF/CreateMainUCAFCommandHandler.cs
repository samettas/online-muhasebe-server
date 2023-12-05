using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.CompanyService;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateMainUCAF;

public sealed class CreateMainUCAFCommandHandler : ICommandHandler<CreateMainUCAFCommand, CreateMainUCAFCommandResponse>
{
    private readonly IUCAFService _ucafService;

    public CreateMainUCAFCommandHandler(IUCAFService service)
    {
        _ucafService = service;
    }

    public async Task<CreateMainUCAFCommandResponse> Handle(CreateMainUCAFCommand request, CancellationToken cancellationToken)
    {
        await _ucafService.CreateMainUcafsToCompanyAsync(request.CompanyId, cancellationToken);
        return new();
    }
}
