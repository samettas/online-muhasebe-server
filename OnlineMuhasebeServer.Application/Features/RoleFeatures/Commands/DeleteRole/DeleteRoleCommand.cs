using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.RoleFeatures.Commands.DeleteRole
{
    public sealed record DeleteRoleCommand(
        string Id) : ICommand<DeleteRoleCommandResponse>;
}
