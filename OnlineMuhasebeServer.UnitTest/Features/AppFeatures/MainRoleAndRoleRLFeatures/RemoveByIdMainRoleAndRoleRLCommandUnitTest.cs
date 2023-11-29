using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.RemoveByIdMainRoleAndRoleRL;
using OnlineMuhasebeServer.Application.Services.AppServices;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleAndRoleRLFeatures;

public sealed class RemoveByIdMainRoleAndRoleRLCommandUnitTest
{
    private readonly Mock<IMainRoleAndRoleRelationshipService> _serviceMock;

    public RemoveByIdMainRoleAndRoleRLCommandUnitTest()
    {
        _serviceMock = new();
    }

    [Fact]
    public async Task MainRoleAndRoleRelationshipShouldNotBeNull()
    {
        _serviceMock.Setup(s=>
        s.GetByIdAsync(It.IsAny<string>()))
            .ReturnsAsync(new Domain.AppEntities.MainRoleAndRoleRelationship());
    }

    [Fact]
    public async Task RemoveByIdMainRoleAndRoleRLCommandResponseShouldNotBeNull()
    {
        RemoveByIdMainRoleAndRoleRLCommand removeByIdMainRoleAndRoleRLCommand = new(
            Id : "fc4d346d-2bf1-498c-b111-a8bd06938d27");

        RemoveByIdMainRoleAndRoleRLCommandHandler handler = new(_serviceMock.Object);

        _serviceMock.Setup(s =>
            s.GetByIdAsync(It.IsAny<string>()))
                .ReturnsAsync(new Domain.AppEntities.MainRoleAndRoleRelationship());

        RemoveByIdMainRoleAndRoleRLCommandResponse response = await handler.Handle(removeByIdMainRoleAndRoleRLCommand, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
