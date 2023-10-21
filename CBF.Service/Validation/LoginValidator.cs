using CBF.Domain.DTOs;
using FluentValidation;

namespace CBF.Service.Validation;
public class LoginValidator : AbstractValidator<LoginDTO>
{
    public LoginValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .MaximumLength(80)
            .EmailAddress()
            .WithMessage("O campo Email é obrigatório");

        RuleFor(x => x.Senha)
            .NotEmpty()
            .Length(8, 20)
            .WithMessage("O campo Senha é obrigatório");
    }
}
