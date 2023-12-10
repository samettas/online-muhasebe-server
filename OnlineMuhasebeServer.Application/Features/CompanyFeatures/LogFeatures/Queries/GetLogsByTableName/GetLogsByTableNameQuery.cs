using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.LogFeatures.Queries.GetLogsByTableName;

public sealed record GetLogsByTableNameQuery(
    string TableName,
    string CompanyId,
    int pageNumber = 1,
    int pageSize = 10) : IQuery<GetLogsByTableNameQueryResponse>;
