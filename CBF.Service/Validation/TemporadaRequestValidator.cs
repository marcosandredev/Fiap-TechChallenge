using CBF.Domain.DTOs.Request;
using FluentValidation;

namespace CBF.Service.Validation;
public class TemporadaRequestValidator : AbstractValidator<TemporadaRequest>
{
    public TemporadaRequestValidator()
    {
        RuleFor(x => x.Nome)
            .NotEmpty()
            .MaximumLength(80);

        RuleFor(x => x.Ativo)
            .Must(x => x == false || x == true);

        RuleFor(x => x.Inicio)
            .NotEmpty();

        RuleFor(x => x.Fim)
            .NotEmpty();
    }
}
