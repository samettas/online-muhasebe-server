using EntityFrameworkCorePagination.Nuget.Pagination;
using OnlineMuhasebeServer.Application.Messaging;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.BookEntryFeatures.Queries.GetAllBookEntry;

public sealed record GetAllBookEntryQuery(
    string CompanyId,
    int pageNumber = 1,
    int pageSize = 10) : IQuery<PaginationResult<GetAllBookEntryQueryResponse>>;
