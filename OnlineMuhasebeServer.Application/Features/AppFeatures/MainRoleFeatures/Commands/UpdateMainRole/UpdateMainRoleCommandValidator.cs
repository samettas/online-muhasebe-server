using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;

internal class UpdateMainRoleCommandValidator : AbstractValidator<UpdateMainRoleCommand>
{
    public UpdateMainRoleCommandValidator()
    {
        RuleFor(p=> p.Id).NotEmpty().NotEmpty().WithMessage("Id alanı boş olamaz");
        RuleFor(p=> p.Id).NotEmpty().NotNull().WithMessage("Id alanı boş olamaz");
        RuleFor(p => p.Title).NotEmpty().NotEmpty().WithMessage("Başlık alanı boş olamaz");
        RuleFor(p => p.Title).NotEmpty().NotNull().WithMessage("Başlık alanı boş olamaz");
    }
}
