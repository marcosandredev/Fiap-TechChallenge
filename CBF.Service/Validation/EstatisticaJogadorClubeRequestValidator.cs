using CBF.Domain.DTOs.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Service.Validation
{
    public class EstatisticaJogadorClubeRequestValidator : AbstractValidator<EstatisticaJogadorClubeRequest>
    {
        public EstatisticaJogadorClubeRequestValidator()
        {
            RuleFor(e => e.IdJogador).NotEmpty().WithMessage("O campo IdJogador é obrigatório.");
            RuleFor(e => e.IdClube).NotEmpty().WithMessage("O campo IdClube é obrigatório.");
            RuleFor(e => e.IdTemporada).NotEmpty().WithMessage("O campo IdTemporada é obrigatório.");
            RuleFor(e => e.Ano).NotEmpty().WithMessage("O campo Ano é obrigatório.");
            RuleFor(e => e.Partidas).NotEmpty().WithMessage("O campo Partidas é obrigatório.");
            RuleFor(e => e.Gols).NotEmpty().WithMessage("O campo Gols é obrigatório.");
            RuleFor(e => e.Assistencias).NotEmpty().WithMessage("O campo Assistencias é obrigatório.");
            RuleFor(e => e.Amarelos).NotEmpty().WithMessage("O campo Amarelos é obrigatório.");
            RuleFor(e => e.Vermelhos).NotEmpty().WithMessage("O campo Vermelhos é obrigatório.");
        }
    }
}
