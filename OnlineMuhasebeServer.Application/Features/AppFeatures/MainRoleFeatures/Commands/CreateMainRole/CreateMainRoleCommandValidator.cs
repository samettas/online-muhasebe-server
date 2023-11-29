using FluentValidation;
using OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;

public sealed class CreateMainRoleCommandValidator : AbstractValidator<CreateMainRoleCommand>
{
    public CreateMainRoleCommandValidator()
    {
        RuleFor(p=> p.Title).NotEmpty().WithMessage("Rol başlığı boş olamaz!");
        RuleFor(p=> p.Title).NotNull().WithMessage("Rol başlığı boş olamaz!");

    }
}
