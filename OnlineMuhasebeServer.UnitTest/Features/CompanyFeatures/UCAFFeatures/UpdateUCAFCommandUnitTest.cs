using Moq;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.UpdateUCAF;
using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Application.Services.CompanyServices;
using OnlineMuhasebeServer.Domain.CompanyEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.CompanyFeatures.UCAFFeatures;

public sealed class UpdateUCAFCommandUnitTest
{
    private readonly Mock<IUCAFService> _ucafService;
    private readonly Mock<IApiService> _apiService;
    private readonly Mock<ILogService> _logService;

    public UpdateUCAFCommandUnitTest()
    {
        _ucafService = new();
        _apiService = new();
        _logService = new();
    }

    [Fact]
    public async Task UniformChartOfAccountShouldNotBeNull()
    {
        _ucafService.Setup(s =>
        s.GetByIdAsync(
            It.IsAny<string>(),
            It.IsAny<string>()))
            .ReturnsAsync(new UniformChartOfAccount());
    }

    [Fact]
    public async Task CheckNewUCAFCodeShouldBeNull()
    {
        string companyId = "8f64a3a6-05fd-4525-95b4-a7a9b0f5872b";
        string code = "100.01.001";
        UniformChartOfAccount ucaf = await _ucafService.Object.GetByCodeAsync(companyId, code, default);
        ucaf.ShouldBeNull();
    }

    [Fact]
    public async Task UpdateUCAFCommandResponseShouldNotBeNull()
    {
        UpdateUCAFCommand command = new(
            Id: "02d20fad-db3b-4ef8-9b79-b72168d7914e",
            Code: "100.01.001",
            Name: "MERKEZ KASA",
            Type: "M",
            CompanyId: "8f64a3a6-05fd-4525-95b4-a7a9b0f5872b");

        await UniformChartOfAccountShouldNotBeNull();

        UpdateUCAFCommandHandler handler = new UpdateUCAFCommandHandler(_ucafService.Object, _logService.Object, _apiService.Object);

        UpdateUCAFCommandResponse response = await handler.Handle(command, default);

        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();


    }
}
