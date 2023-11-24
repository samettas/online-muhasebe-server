using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.RoleFeatures.Command
{
    public sealed class DeleteRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleServiceMock;

        public DeleteRoleCommandUnitTest()
        {
            _roleServiceMock = new();
        }

        [Fact]
        public async Task AppRoleShouldNotBeNull()
        {
            _roleServiceMock.Setup(
                x=> x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new AppRole());
        }

        [Fact]
        public async Task DeleteRoleCommandResponseShouldNotBeNull()
        {
            var command = new DeleteRoleCommand(
                Id: "5de821c0-479b-4268-a15b-990502b38d6b");

            _roleServiceMock.Setup(
                x => x.GetById(It.IsAny<string>()))
                .ReturnsAsync(new AppRole());

            var handler = new DeleteRoleCommandHandler(_roleServiceMock.Object);
            DeleteRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
