using CBF.Domain.DTOs.Request;
using CBF.Infra.Repositories.Interfaces;
using FluentValidation;

namespace CBF.Service.Validation;
public class ClubeJogadorRequestValidator : AbstractValidator<ClubeJogadorRequest>
{
    public ClubeJogadorRequestValidator(IClubeRepository clubeRepository)
    {
        RuleFor(x => x.IdClube)
            .NotEmpty()
            .Must(x => clubeRepository.ExistAsync(c => c.Id == x).Result)
            .WithMessage("Clube não cadastrado");

        RuleFor(x => x.DtInicioContrato).NotEmpty();

        RuleFor(x => x.DtFimContrato).NotEmpty();

        RuleFor(x => x.Salario).NotEmpty();
    }
}
