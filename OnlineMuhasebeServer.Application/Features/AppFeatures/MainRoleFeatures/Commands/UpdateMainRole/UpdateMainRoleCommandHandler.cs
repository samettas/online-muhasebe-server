using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole
{
    public sealed class UpdateMainRoleCommandHandler : ICommandHandler<UpdateMainRoleCommand,
        UpdateMainRoleCommandResponse>
    {
        private readonly IMainRoleService _mainRoleService;

        public UpdateMainRoleCommandHandler(IMainRoleService mainRoleService)
        {
            _mainRoleService = mainRoleService;
        }

        public async Task<UpdateMainRoleCommandResponse> Handle(UpdateMainRoleCommand request, CancellationToken cancellationToken)
        {
            MainRole mainRole = await _mainRoleService.GetByIdAsync(request.Id);

            if (mainRole == null) throw new Exception("Bu ana rol bulunamadı!");

            if (mainRole.Title == request.Title) throw new Exception("Aynı ana rol adıyla değiştiremezsiniz!(Zaten aynı!)");

            if (mainRole.Title != request.Title)
            {
                MainRole checkMainRoletitle = await _mainRoleService.GetByTitleAndCompanyId(request.Title, mainRole.CompanyId, cancellationToken);
                if(checkMainRoletitle != null) throw new Exception("Bu rol adı daha önce kullanılmış!");
            }

            mainRole.Title = request.Title;
            await _mainRoleService.UpdateAsync(mainRole);
            return new();

            
        }
    }
}
