using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.RoleFeatures.Queries.GetlAllRoles
{
    public sealed record GetAllRolesQuery() : IQuery<GetAllRolesQueryResponse>;
}
