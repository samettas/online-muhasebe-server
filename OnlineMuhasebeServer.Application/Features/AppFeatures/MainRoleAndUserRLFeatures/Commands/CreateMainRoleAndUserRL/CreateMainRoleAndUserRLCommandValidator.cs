using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL;

public sealed class CreateMainRoleAndUserRLCommandValidator : AbstractValidator<CreateMainRoleAndUserRLCommand>
{
    public CreateMainRoleAndUserRLCommandValidator()
    {
        RuleFor(p=>p.UserId).NotEmpty().WithMessage("Kullanıcı seçiniz!");
        RuleFor(p=>p.UserId).NotNull().WithMessage("Kullanıcı seçiniz!");
        RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket seçiniz!");
        RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket seçiniz!");
        RuleFor(p => p.MainRoleId).NotEmpty().WithMessage("Ana rol seçiniz!");
        RuleFor(p => p.MainRoleId).NotNull().WithMessage("Ana rol seçiniz!");
    }
}
