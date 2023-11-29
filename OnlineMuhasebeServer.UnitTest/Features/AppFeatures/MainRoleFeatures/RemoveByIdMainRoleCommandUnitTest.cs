using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainRoleFeatures
{
    public sealed class RemoveByIdMainRoleCommandUnitTest
    {
        private readonly Mock<IMainRoleService> _mainRoleService;

        public RemoveByIdMainRoleCommandUnitTest()
        {
            _mainRoleService = new();
        }

        [Fact]
        public async Task RemoveByIdMainRoleCommandResponseShouldNotBeNull()
        {
            var command = new RemoveByIdMainRoleCommand(
                Id: "6d6d69aa-f579-4c8a-8886-0da214900f7f");

            var handler = new RemoveByIdMainRoleCommandHandler(_mainRoleService.Object);

            RemoveByIdMainRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
