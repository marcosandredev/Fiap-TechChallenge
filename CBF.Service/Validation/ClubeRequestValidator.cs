using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBF.Domain.DTOs.Request;
using FluentValidation;

namespace CBF.Service.Validation
{
    public class ClubeRequestValidator : AbstractValidator<ClubeRequest>
    {
        public ClubeRequestValidator()
        {
            RuleFor(c => c.Nome)
            .NotEmpty().WithMessage("Campo nome é obrigatório!")
            .MaximumLength(80).WithMessage("Campo nome deve conter no maximo 80 caracteres!");

            RuleFor(c => c.DTFundacao)
            .NotEmpty().WithMessage("Campo DTFundacao é obrigatório!")
            .LessThan(c => DateTime.Now).WithMessage("A data deve estar no passado");

            RuleFor(c => c.Cidade)
            .NotEmpty().WithMessage("Campo Cidade é obrigatório!")
            .MaximumLength(80).WithMessage("Campo Cidade deve conter no maximo 80 caracteres!");

            RuleFor(c => c.Estado)
            .NotEmpty().WithMessage("Campo Estado é obrigatório!")
            .MaximumLength(80).WithMessage("Campo Estado deve conter no maximo 80 caracteres!");                

            RuleFor(c => c.Pais)
            .NotEmpty().WithMessage("Campo Pais é obrigatório!")
            .MaximumLength(80).WithMessage("Campo Pais deve conter no maximo 80 caracteres!");                    
        }
    }
}