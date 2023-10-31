using CBF.Domain.DTOs.Request;
using CBF.Domain.Entities.Enums;
using CBF.Infra.Repositories.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Service.Validation
{
    public class TransferenciaValidator : AbstractValidator<TransferenciaRequest>
    {
        public TransferenciaValidator(IClubeRepository clubeRepository, ITemporadaRepository temporadaRepository, IJogadorRepository jogadorRepository)
        {
            RuleFor(x => x.IdJogador)
                .NotEmpty()
                .Must(x => jogadorRepository.ExistAsync(c => c.Id == x).Result)
                .WithMessage("Jogador não cadastrado");

            RuleFor(x => x.IdClubeAnterior)
                .NotEmpty()
               .Must(x => clubeRepository.ExistAsync(c => c.Id == x).Result)
               .WithMessage("Clube não cadastrado");

            RuleFor(x => x.IdClubeNovo)
               .NotEmpty()
               .Must(x => clubeRepository.ExistAsync(c => c.Id == x).Result)
               .WithMessage("Clube não cadastrado");

            RuleFor(x => x.IdTemporada)
                .NotEmpty()
                .Must(x => temporadaRepository.ExistAsync(c => c.Id == x).Result)
               .WithMessage("Temporada não cadastrada");

            RuleFor(j => j.TipoTransferencia)
               .Must(j => Enum.IsDefined(typeof(TipoTransferencia), j))
               .WithMessage("Campo posicao deve ser escolhido de 1 a 6");

            RuleFor(model => model.DtTransferencia)
                .NotEmpty()
                .WithMessage("O campo de data é obrigatório.");

            RuleFor(x => x.DtInicioContrato)
                .NotEmpty()
                .WithMessage("O campo de Data Início Contrato é obrigatório.");

            RuleFor(x => x.DtPrevisaoFimContrato)
                .NotEmpty()
                .WithMessage("O campo de Data Previsão Fim Contrato é obrigatório.");
        }
    }
}
