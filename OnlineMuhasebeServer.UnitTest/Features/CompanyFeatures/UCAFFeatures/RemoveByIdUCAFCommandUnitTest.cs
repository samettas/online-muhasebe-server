using Moq;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.RemoveByIdUCAF;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.CompanyFeatures.UCAFFeatures;

public sealed class RemoveByIdUCAFCommandUnitTest
{
    private readonly Mock<IUCAFService> _ucafService;

    public RemoveByIdUCAFCommandUnitTest()
    {
        _ucafService = new();
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
            CompanyId: "6d6d69aa-f579-4c8a-8886-0da214900f7f");

        await CheckRemoveByIdUcafIsGroupAndAvailableShouldBeTrue();


        var handler = new RemoveByIdUCAFCommandHandler(_ucafService.Object);

        RemoveByIdUCAFCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
