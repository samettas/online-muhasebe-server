using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed class CreateUCAFCommandValidator : AbstractValidator<CreateUCAFCommand>
    {
        public CreateUCAFCommandValidator()
        {
            RuleFor(p => p.Code).NotEmpty().WithMessage("Hesap planı kodu boş olamaz!");
            RuleFor(p => p.Code).NotNull().WithMessage("Hesap planı boş olamaz!");
            RuleFor(p => p.Code).MinimumLength(5).WithMessage("Hesap planı kodu en az 5 karakterden olmalıdır!");

            RuleFor(p => p.Name).NotEmpty().WithMessage("Hesap planı adı boş olamaz!");
            RuleFor(p => p.Name).NotNull().WithMessage("Hesap planı adı boş olamaz!");

            RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Hesap planı adı boş olamaz!");
            RuleFor(p => p.CompanyId).NotNull().WithMessage("Hesap planı adı boş olamaz!");

            RuleFor(p => p.Type).NotEmpty().WithMessage("Hesap planı tipi boş olamaz!");
            RuleFor(p => p.Type).NotNull().WithMessage("Hesap planı tipi boş olamaz!");
            RuleFor(p => p.Type).MaximumLength(1).WithMessage("Hesap planı tipi 1 karakter olmalıdır!");
        }
    }
}
