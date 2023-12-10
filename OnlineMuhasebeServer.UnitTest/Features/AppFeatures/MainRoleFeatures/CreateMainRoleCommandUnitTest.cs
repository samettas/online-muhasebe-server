using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.MainFeatures
{
    public sealed class CreateMainRoleCommandUnitTest
    {
        private readonly Mock<IMainRoleService> _mainRoleService;

        public CreateMainRoleCommandUnitTest()
        {
            _mainRoleService = new();
        }

        [Fact]
        public async Task MainRoleShouldBeNull()
        {
            MainRole mainRole = await _mainRoleService.Object.GetByTitleAndCompanyId(
                title: "Admin",
                companyId:"d6a0eac0-c54c-467d-90f2-5f0d5a6b87df", default);
            mainRole.ShouldBeNull();
        }

        [Fact]
        public async Task CreateMainRoleCommandResponseShouldNotBeNull()
        {
            var command = new CreateMainRoleCommand(
                Title: "Admin",
                CompanyId: "8f64a3a6-05fd-4525-95b4-a7a9b0f5872b");

            var handler = new CreateMainRoleCommandHandler(_mainRoleService.Object);

            CreateMainRoleCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
