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
            Id: "",
            CompanyId: "");

        RemoveByIdBookEntryCommandHandler handler = new RemoveByIdBookEntryCommandHandler(_service.Object, _logService.Object, _apiService.Object);

        RemoveByIdBookEntryCommandResponse response = await handler.Handle(command, default);

        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();

    }

}
