using Moq;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using OnlineMuhasebeServer.Domain.CompanyEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.CompanyFeatures.UCAFFeatures;

public sealed class CreateUCAFCommandUnitTest
{
    private readonly Mock<IUCAFService> _ucafService;
    private readonly Mock<IApiService> _apiService;
    private readonly Mock<ILogService> _logService;

    public CreateUCAFCommandUnitTest()
    {
        _ucafService = new();
        _apiService = new();
        _logService = new();
    }

    [Fact]
    public async Task UCAFShouldBeNull()
    {
        string companyId = "8f64a3a6-05fd-4525-95b4-a7a9b0f5872b";
        string code = "100.01.001";
        UniformChartOfAccount ucaf = await _ucafService.Object.GetByCodeAsync(companyId, code, default);
        ucaf.ShouldBeNull();
    }

    [Fact]
    public async Task CreateUCAFCommandResponseShouldNotBeNull()
    {
        var command = new CreateUCAFCommand(
            Code: "00000000",
            Name: "Tl Kasa",
            Type: "M",
            CompanyId: "8f64a3a6-05fd-4525-95b4-a7a9b0f5872b");

        var handler = new CreateUCAFCommandHandler(_ucafService.Object,_logService.Object,_apiService.Object);

        CreateUCAFCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
