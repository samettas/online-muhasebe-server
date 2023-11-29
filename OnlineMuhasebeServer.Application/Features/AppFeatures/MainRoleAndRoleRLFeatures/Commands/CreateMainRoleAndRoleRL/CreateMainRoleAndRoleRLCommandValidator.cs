using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAndRoleRLFeatures.Commands.CreateMainRoleAndRoleRL
{
    public sealed class CreateMainRoleAndRoleRLCommandValidator : 
        AbstractValidator<CreateMainRoleAndRoleRLCommand>
    {
        public CreateMainRoleAndRoleRLCommandValidator()
        {
            RuleFor(p=> p.RoleId).NotEmpty().WithMessage("Rol seçiniz!");
            RuleFor(p=> p.RoleId).NotNull().WithMessage("Rol seçiniz!");
            RuleFor(p => p.MainRoleId).NotEmpty().WithMessage("Ana rol seçiniz!");
            RuleFor(p => p.MainRoleId).NotNull().WithMessage("Ana rol seçiniz!");
        }
    }
}
