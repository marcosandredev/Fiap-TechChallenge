﻿using CBF.Domain.DTOs.Request;
using CBF.Domain.Entities.Enums;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBF.Service.Validation
{
    public class JogadorUpdateRequestValidador : AbstractValidator<JogadorUpdateRequest>
    {
        public JogadorUpdateRequestValidador()
        {

            RuleFor(j => j.Nome)
                .NotEmpty().WithMessage("Campo nome é obrigatório!")
                .MaximumLength(80).WithMessage("Campo nome deve conter no maximo 80 caracteres!");

            RuleFor(j => j.Posicao)
                .Must(j => Enum.IsDefined(typeof(Posicao), j)).WithMessage("Campo posicao deve ser escolhido de 1 a 11");

            RuleFor(j => j.PePreferido)
                 .Must(j => Enum.IsDefined(typeof(PePreferido), j)).WithMessage("Campo PePreferido deve ser escolhido de 1 a 3");

            RuleFor(j => j.Peso)
                 .NotEmpty().WithMessage("Campo Peso é obrigatório!");

        }
    }
}
