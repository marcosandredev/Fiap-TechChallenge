using CBF.Domain.DTOs.Request;
using CBF.Infra.Repositories.Interfaces;
using FluentValidation;

namespace CBF.Service.Validation
{
    public class EstatisticaJogadorRequestValidator : AbstractValidator<EstatisticaJogadorRequest>
    {
        public EstatisticaJogadorRequestValidator(IJogadorRepository jogadorRepository, ITemporadaRepository temporadaRepository)
        {
            RuleFor(e => e.IdJogador).NotEmpty().WithMessage("O campo IdJogador é obrigatório.")
                .Must(x => jogadorRepository.ExistAsync(j => j.Id == x).Result)
                .WithMessage("Jogador não cadastrado.");

            RuleFor(e => e.IdTemporada).NotEmpty().WithMessage("O campo IdTemporada é obrigatório.")
                .Must(x => temporadaRepository.ExistAsync(t => t.Id == x).Result)
                .WithMessage("Temporada não cadastrada.");

            RuleFor(e => e.Partidas).GreaterThanOrEqualTo(0).WithMessage("O campo Partidas deve ser superior ou igual a 0.");
            RuleFor(e => e.Gols).GreaterThanOrEqualTo(0).WithMessage("O campo Gols deve ser superior ou igual a 0.");
            RuleFor(e => e.Assistencias).GreaterThanOrEqualTo(0).WithMessage("O campo Assistencias deve ser superior ou igual a 0.");
            RuleFor(e => e.Amarelos).GreaterThanOrEqualTo(0).WithMessage("O campo Amarelos deve ser superior ou igual a 0.");
            RuleFor(e => e.Vermelhos).GreaterThanOrEqualTo(0).WithMessage("O campo Vermelhos deve ser superior ou igual a 0.");
        }


    }
}
