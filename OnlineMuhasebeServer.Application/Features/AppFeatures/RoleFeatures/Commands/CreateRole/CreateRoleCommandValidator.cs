using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed class CreateRoleCommandValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleCommandValidator()
        {
            RuleFor(p=>p.Code).NotEmpty().WithMessage("Rol kodu boş olamaz!");
            RuleFor(p=>p.Code).NotNull().WithMessage("Rol kodu boş olamaz!");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Rol adı boş olamaz!");
            RuleFor(p => p.Name).NotNull().WithMessage("Rol adı boş olamaz!");
        }
    }
}
