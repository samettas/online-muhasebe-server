using MediatR;

namespace OnlineMuhasebeServer.Application.Features.RoleFeatures.Commands.DeleteRole
{
    public sealed class DeleteRoleRequest : IRequest<DeleteRoleResponse>
    {
        public string Id { get; set; }
    }
}
