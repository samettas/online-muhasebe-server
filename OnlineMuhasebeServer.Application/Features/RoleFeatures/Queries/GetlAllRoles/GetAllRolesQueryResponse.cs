using OnlineMuhasebeServer.Domain.AppEntities.Identity;

namespace OnlineMuhasebeServer.Application.Features.RoleFeatures.Queries.GetlAllRoles
{
    public sealed record GetAllRolesQueryResponse(
        IList<AppRole> Roles);
}
