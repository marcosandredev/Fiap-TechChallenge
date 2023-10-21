using CBF.Domain.DTOs.Request;
using CBF.Domain.Entities.Enums;
using CBF.Infra.Repositories.Interfaces;
using FluentValidation;

namespace CBF.Service.Validation;
public class UsuarioRequestValidator : AbstractValidator<UsuarioRequest>
{
    public UsuarioRequestValidator(IUsuarioRepository usuarioRepository)
    {
        RuleFor(x => x.Email)
            .MaximumLength(80)
            .EmailAddress()
            .NotEmpty()
            .Must(x => usuarioRepository.ExistAsync(u => u.Email == x).Result == false);

        RuleFor(x => x.Nome)
            .MaximumLength(100)
            .NotEmpty();

        RuleFor(x => x.Senha)
            .Length(8, 20)
            .NotEmpty();

        RuleFor(x => x.NomeUsuario)
            .Length(6, 30)
            .NotEmpty()
            .Must(x => usuarioRepository.ExistAsync(u => u.NomeUsuario == x).Result == false);

        RuleFor(x => x.Permissao)
            .Must(x => Enum.IsDefined(typeof(Permissao), x)); ;
    }
}
