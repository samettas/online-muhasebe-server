using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleAndRoleRLFeatures
{
    public sealed class CreateMainRoleAndRoleRLCommandUnitTest
    {
        private readonly Mock<IMainRoleAndRoleRelationshipService> _service;

        public CreateMainRoleAndRoleRLCommandUnitTest()
        {
            _service = new();
        }

        [Fact]
        public async Task MainRoleAndRoleRelationshipShouldBeNull()
        {
            MainRoleAndRoleRelationship entity = (await _service.Object.GetByRoleIdAndMainRoleId(
                roleId: "8a5bcd8f-1665-43a4-bb15-92a8368f09e5",
                mainRoleId: "2ce84f5c-a0ee-493a-ab81-ea1e0da8f198",
                cancellationToken: default))!;
            entity.ShouldBeNull();
        }

        [Fact]
        public async Task CreateMainRoleAndRoleRLCommandResponseShouldNotBeNull()
        {
            var command = new CreateMainRoleAndRoleRLCommand(
                RoleId: "8a5bcd8f-1665-43a4-bb15-92a8368f09e5",
                MainRoleId : "2ce84f5c-a0ee-493a-ab81-ea1e0da8f198");

            var handler = new CreateMainRoleAndRoleRLCommandHandler(_service.Object);

            CreateMainRoleAndRoleRLCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
