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

            RuleFor(e => e.Ano).NotEmpty().WithMessage("O campo Ano é obrigatório.");
            RuleFor(e => e.Partidas).NotEmpty().WithMessage("O campo Partidas é obrigatório.");
            RuleFor(e => e.Gols).NotEmpty().WithMessage("O campo Gols é obrigatório.");
            RuleFor(e => e.Assistencias).NotEmpty().WithMessage("O campo Assistencias é obrigatório.");
            RuleFor(e => e.Amarelos).NotEmpty().WithMessage("O campo Amarelos é obrigatório.");
            RuleFor(e => e.Vermelhos).NotEmpty().WithMessage("O campo Vermelhos é obrigatório.");
        }
    }
}
