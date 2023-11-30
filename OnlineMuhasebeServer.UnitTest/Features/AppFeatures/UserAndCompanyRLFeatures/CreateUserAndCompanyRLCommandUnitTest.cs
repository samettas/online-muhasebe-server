using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL;
using OnlineMuhasebeServer.Application.Services.AppServices;
using OnlineMuhasebeServer.Domain.AppEntities;
using Shouldly;

namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.UserAndCompanyRLFeatures;

public sealed class CreateUserAndCompanyRLCommandUnitTest
{
    private readonly Mock<IUserAndCompanyRelationshipService> _serviceMock;
    public CreateUserAndCompanyRLCommandUnitTest()
    {
        _serviceMock = new();
    }

    [Fact]
    public async Task UserAndCompanyRelationshipShouldBeNull()
    {
        UserAndCompanyRelationship userAndCompanyRelationship = await 
            _serviceMock.Object.GetByUserIdAndCompanyId(
            userId: "61d742e7-49ad-4de4-b787-e5234fd83a4c",
            companyId: "006fdcfa-fcfb-46ad-bc5d-845eecdb33de",
            cancellationToken: default);

        userAndCompanyRelationship.ShouldBeNull();
    }

    [Fact]
    public async Task CreateUserAndCompanyRLCommandResponseShouldNotBeNull()
    {
        CreateUserAndCompanyRLCommand command = new(
            AppUserId: "61d742e7-49ad-4de4-b787-e5234fd83a4c",
            CompanyId: "006fdcfa-fcfb-46ad-bc5d-845eecdb33de");

        CreateUserAndCompanyRLCommandHandler handler = new(_serviceMock.Object);

        CreateUserAndCompanyRLCommandResponse response = await handler.Handle(command, default);
        response.ShouldNotBeNull();
        response.Message.ShouldNotBeEmpty();
    }
}
