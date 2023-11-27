using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using OnlineMuhasebeServer.Application.Services.AppService;
using OnlineMuhasebeServer.Domain.AppEntities.Identity;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.RoleFeatures
{
    public sealed class UpdateRoleCommandUnitTest
    {
        private readonly Mock<IRoleService> _roleServiceMock;

        public UpdateRoleCommandUnitTest()
        {
            _roleServiceMock = new();
        }

        [Fact]
        public async Task AppRoleShouldNotBe()
        {
            _roleServiceMock.Setup(
                x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());
        }

        [Fact]
        public async Task AppRoleCodeShouldBeUnique()
        {
            AppRole checkRoleCode = await _roleServiceMock.Object.GetByCode("UCAF.Create");
            checkRoleCode.ShouldBeNull();
        }

        [Fact]
        public async Task UpdateRoleCommandResponseShouldNotBeNull()
        {
            var command = new UpdateRoleCommand(
                Id: "5de821c0-479b-4268-a15b-990502b38d6b",
                Code: "UCAF.Create2",
                Name: "HESAP PLANı KAYıT EKLEME2");

            _roleServiceMock.Setup(
                x => x.GetById(It.IsAny<string>())).ReturnsAsync(new AppRole());

            var handler = new UpdateRoleCommandHandler(_roleServiceMock.Object);

            UpdateRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
