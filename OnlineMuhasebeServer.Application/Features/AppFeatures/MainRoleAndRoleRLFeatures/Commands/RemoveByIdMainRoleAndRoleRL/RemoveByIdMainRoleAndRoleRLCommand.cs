using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL;

public sealed record RemoveByIdMainRoleAndRoleRLCommand(
    string Id) : ICommand<RemoveByIdMainRoleAndRoleRLCommandResponse>;
