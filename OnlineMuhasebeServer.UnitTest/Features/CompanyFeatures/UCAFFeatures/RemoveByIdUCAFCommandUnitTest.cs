using Moq;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.RemoveByIdUCAF;
using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.CompanyFeatures.UCAFFeatures;

public sealed class RemoveByIdUCAFCommandUnitTest
{
    private readonly Mock<IUCAFService> _ucafService;
    private readonly Mock<IApiService> _apiService;
    private readonly Mock<ILogService> _logService;

    public RemoveByIdUCAFCommandUnitTest()
    {
        _ucafService = new();
        _apiService = new();
        _logService = new();
    }

    [Fact]
    public async Task CheckRemoveByIdUcafIsGroupAndAvailableShouldBeTrue()
    {
        _ucafService.Setup(s =>
        s.CheckRemoveByIdUcafIsGroupAndAvailable(
        It.IsAny<string>(),
        It.IsAny<string>())).
        ReturnsAsync(true);
    }

    [Fact]
    public async Task RemoveByIdUCAFCommandResponseShouldNotBeNull()
    {
        var command = new RemoveByIdUCAFCommand(
            Id: "8f397d90-47f3-4982-a1b5-9120e125850c",
            CompanyId: "8f64a3a6-05fd-4525-95b4-a7a9b0f5872b");

        await CheckRemoveByIdUcafIsGroupAndAvailableShouldBeTrue();


        var handler = new RemoveByIdUCAFCommandHandler(_ucafService.Object, _logService.Object, _apiService.Object);

        RemoveByIdUCAFCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
