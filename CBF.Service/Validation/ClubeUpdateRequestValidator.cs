using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBF.Domain.DTOs.Request;
using FluentValidation;

namespace CBF.Service.Validation
{
    public class ClubeUpdateRequestValidator : AbstractValidator<ClubeUpdateRequest>
    {
        public ClubeUpdateRequestValidator() 
        {
            RuleFor(c => c.Nome)
            .NotEmpty().WithMessage("Campo nome é obrigatório!")
            .MaximumLength(80).WithMessage("Campo nome deve conter no maximo 80 caracteres!");
        }
    }
}