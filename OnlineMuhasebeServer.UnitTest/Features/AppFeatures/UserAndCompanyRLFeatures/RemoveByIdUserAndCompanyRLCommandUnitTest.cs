using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.RemoveUserAndCompanyRL;
using OnlineMuhasebeServer.Application.Services.AppServices;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.UserAndCompanyRLFeatures;

public sealed class RemoveByIdUserAndCompanyRLCommandUnitTest
{
    private readonly Mock<IUserAndCompanyRelationshipService> _serviceMock;

    public RemoveByIdUserAndCompanyRLCommandUnitTest()
    {
        _serviceMock = new();
    }

    [Fact]
    public async Task RemoveByIdUserAndCompanyRLCommandResponseShouldNotBeNull()
    {
        RemoveByIdUserAndCompanyRLCommand command = new(
            Id: "006fdcfa-fcfb-46ad-bc5d-845eecdb33de");
        RemoveByIdUserAndCompanyRLCommandHandler handler = new(_serviceMock.Object);
        RemoveByIdUserAndCompanyRLCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
