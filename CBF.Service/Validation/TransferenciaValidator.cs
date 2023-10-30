using CBF.Domain.DTOs.Request;
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
        public TransferenciaValidator()
        {
            RuleFor(x => x.IdJogador)
                .NotEmpty();

            RuleFor(x => x.IdClubeAnterior)
                .NotEmpty();

            RuleFor(x => x.IdClubeNovo)
                .NotEmpty();

            RuleFor(x => x.IdTemporada)
                .NotEmpty();

            RuleFor(x => x.TipoTransferencia)
                .NotEmpty();

            RuleFor(x => x.DtTransferencia)
                .NotEmpty();

            RuleFor(x => x.DtInicioContrato)
                .NotEmpty();

            RuleFor(x => x.DtPrevisaoFimContrato)
                .NotEmpty();
        }   
    }
}
