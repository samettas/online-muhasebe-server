using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleAndUserRLFeatures;

public sealed class CreateMainRoleAndUserRLCommandUnitTest
{
    private readonly Mock<IMainRoleAndUserRelationshipService> _serviceMock;

    public CreateMainRoleAndUserRLCommandUnitTest()
    {
        _serviceMock = new();
    }

    [Fact]
    public async Task MainRoleAndUserRelationshipShouldBeNull()
    {
        MainRoleAndUserRelationship entity = await _serviceMock.Object.GetByUserIdCompanyIdAndMainRoleIdAsync(
            userId: "4ab84632-826e-43bf-ba3d-4a13b622bc08",
            companyId: "346b4a58-909a-428b-9822-421152c816c0",
            mainRoleId: "14f6b1b8-c453-45b2-b41f-f30a90adf0f2",
            cancellationToken: default);

        entity.ShouldBeNull();
    }

    [Fact]
    public async Task CreateMainRoleAndUserRLCommandResponseShouldNotBeNull()
    {
        CreateMainRoleAndUserRLCommand command = new(
            UserId: "4ab84632-826e-43bf-ba3d-4a13b622bc08",
            MainRoleId: "346b4a58-909a-428b-9822-421152c816c0",
            CompanyId: "14f6b1b8-c453-45b2-b41f-f30a90adf0f2");

        CreateMainRoleAndUserRLCommandHandler handler = new(_serviceMock.Object);
        CreateMainRoleAndUserRLCommandResponse response = await handler.Handle(command, default);

        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
