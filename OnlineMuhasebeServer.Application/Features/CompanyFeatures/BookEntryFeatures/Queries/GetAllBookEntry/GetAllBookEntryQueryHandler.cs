using EntityFrameworkCorePagination.Nuget.Pagination;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.BookEntryFeatures.Queries.GetAllBookEntry;

public sealed class GetAllBookEntryQueryHandler : IQueryHandler<GetAllBookEntryQuery, PaginationResult<GetAllBookEntryQueryResponse>>
{
    private readonly IBookEntryService _bookEntryService;
    private readonly IApiService _apiService;
    public GetAllBookEntryQueryHandler(IBookEntryService bookEntryService, IApiService apiService)
    {
        _bookEntryService = bookEntryService;
        _apiService = apiService;
    }

    public async Task<PaginationResult<GetAllBookEntryQueryResponse>> Handle(GetAllBookEntryQuery request, CancellationToken cancellationToken)
    {
        int year = _apiService.GetYearByToken();

        PaginationResult<BookEntry> result = await _bookEntryService.GetAllAsync(request.CompanyId, request.pageNumber, request.pageSize, year);

        int count = _bookEntryService.GetCount(request.CompanyId);

        PaginationResult<GetAllBookEntryQueryResponse> newResult = new(
            pageNumber: request.pageNumber,
            pageSize: request.pageSize,
            totalCount: count,
            datas: result.Datas.Select(s => new GetAllBookEntryQueryResponse(
                s.Id, s.BookEntryNumber, s.Date, s.Description, s.Type, 0, 0)).ToList());

        return newResult;

    }
}
