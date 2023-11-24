using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public sealed class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
    {
        public UpdateRoleCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("ID bilgisi boş olamaz!");
            RuleFor(p => p.Id).NotNull().WithMessage("ID bilgisi boş olamaz!");
            RuleFor(p => p.Code).NotEmpty().WithMessage("Rol kodu boş olamaz!");
            RuleFor(p => p.Code).NotNull().WithMessage("Rol kodu boş olamaz!");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Rol adı boş olamaz!");
            RuleFor(p => p.Name).NotNull().WithMessage("Rol adı boş olamaz!");
        }
    }
}
