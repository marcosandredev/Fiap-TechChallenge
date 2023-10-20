using CBF.Domain.DTOs;
using FluentValidation;

namespace CBF.Service.Validation;
public class LoginValidator : AbstractValidator<LoginDTO>
{
    public LoginValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage("O campo Email é obrigatório");

        RuleFor(x => x.Senha)
            .NotEmpty()
            .WithMessage("O campo Senha é obrigatório");
    }
}
