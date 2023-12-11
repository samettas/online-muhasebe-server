using Moq;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.BookEntryFeatures.Commands.RemoveByIdBookEntry;
using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.CompanyFeatures.BookEntryFeatures;

public sealed class RemoveByIdBookEntryCommandUnitTest
{
    private readonly Mock<IBookEntryService> _service;
    private readonly Mock<ILogService> _logService;
    private readonly Mock<IApiService> _apiService;

    public RemoveByIdBookEntryCommandUnitTest()
    {
        _logService = new();
        _service = new();
        _apiService = new();
    }

    [Fact]
    public async Task RemoveByIdBookEntryCommandResponseShouldNotBeNull()
    {
        RemoveByIdBookEntryCommand command = new(
            Id: "aa7d83f6-80b8-4278-9b3c-a6517034df29",
            CompanyId: "8f64a3a6-05fd-4525-95b4-a7a9b0f5872b");

        RemoveByIdBookEntryCommandHandler handler = new RemoveByIdBookEntryCommandHandler(_service.Object, _logService.Object, _apiService.Object);

        RemoveByIdBookEntryCommandResponse response = await handler.Handle(command, default);

        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();

    }

}
