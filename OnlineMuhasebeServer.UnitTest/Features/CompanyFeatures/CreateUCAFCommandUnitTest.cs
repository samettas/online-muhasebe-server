using Moq;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineMuhasebeServer.Application.Services.CompanyService;
using OnlineMuhasebeServer.Domain.CompanyEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.CompanyFeatures
{
    public sealed class CreateUCAFCommandUnitTest
    {
        private readonly Mock<IUCAFService> _ucafService;

        public CreateUCAFCommandUnitTest()
        {
            _ucafService = new();
        }

        [Fact]
        public async Task UCAFShouldBeNull()
        {
            UniformChartOfAccount ucaf = await _ucafService.Object.GetByCode("0000000", default);
            ucaf.ShouldBeNull();
        }

        [Fact]
        public async Task CreateUCAFCommandResponseShouldNotBeNull()
        {
            var command = new CreateUCAFCommand(
                Code: "00000000",
                Name: "Tl Kasa",
                Type: "M",
                CompanyId: "6d6d69aa-f579-4c8a-8886-0da214900f7f");

            var handler = new CreateUCAFCommandHandler(_ucafService.Object);

            CreateUCAFCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();
        }
    }
}
