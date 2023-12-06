using Moq;
using OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.UpdateUCAF;
using OnlineMuhasebeServer.Application.Services.CompanyService;
using OnlineMuhasebeServer.Domain.CompanyEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.UserAndCompanyRLFeatures;

public sealed class UpdateUCAFCommandUnitTest
{
    private readonly Mock<IUCAFService> _service;

    public UpdateUCAFCommandUnitTest()
    {
        _service = new();
    }

    [Fact]
    public async Task UniformChartOfAccountShouldNotBeNull()
    {
        _service.Setup(s =>
        s.GetByIdAsync(
            It.IsAny<string>(),
            It.IsAny<string>()))
            .ReturnsAsync(new UniformChartOfAccount());
    }

    [Fact]
    public async Task CheckNewUCAFCodeShouldBeNull()
    {
        string companyId = "6d6d69aa-f579-4c8a-8886-0da214900f7f";
        string code = "100.01.001";
        UniformChartOfAccount ucaf = await _service.Object.GetByCodeAsync(companyId, code, default);
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
            CompanyId: "6d6d69aa-f579-4c8a-8886-0da214900f7f");

        await UniformChartOfAccountShouldNotBeNull();

        UpdateUCAFCommandHandler handler = new UpdateUCAFCommandHandler(_service.Object);

        UpdateUCAFCommandResponse response = await handler.Handle(command, default);

        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();


    }
}
