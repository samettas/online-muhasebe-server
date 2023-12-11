using Moq;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.BookEntryFeatures.Commands.CreateBookEntry;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.BookEntryFeatures.Commands.UpdateBookEntry;
using Shouldly;
using OnlineMuhasebeServer.Domain.CompanyEntities;

namespace OnlineMuhasebeServer.UnitTest.Features.CompanyFeatures.BookEntryFeatures;

public sealed class UpdateBookEntryCommandUnitTest
{
    private readonly Mock<IBookEntryService> _service;
    private readonly Mock<ILogService> _logService;
    private readonly Mock<IApiService> _apiService;
    public UpdateBookEntryCommandUnitTest()
    {
        _service = new();
        _logService = new();
        _apiService = new();
    }

    [Fact]
    public async Task UpdateBookEntryCommandResponseShouldNotBeNull()
    {
        string id = "aa7d83f6-80b8-4278-9b3c-a6517034df29";
        string companyId = "8f64a3a6-05fd-4525-95b4-a7a9b0f5872b";
        _service.Setup(s =>
        s.GetByIdAsync(id, companyId)).ReturnsAsync(new BookEntry());

        UpdateBookEntryCommand command = new(
            Id: id,
            CompanyId: companyId,
            Type: "Muavin",
            Description: "Yevmiye Fişi",
            Date: "10.12.2023") ;

        UpdateBookEntryCommandHandler handler = new(_service.Object, _logService.Object, _apiService.Object);
        UpdateBookEntryCommandResponse response = await handler.Handle(command, default);

        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
