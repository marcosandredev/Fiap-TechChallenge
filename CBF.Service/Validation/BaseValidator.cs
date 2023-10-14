using CBF.Domain.Entities.Common;
using FluentValidation;

namespace CBF.Service.Validation;
public class BaseValidator : AbstractValidator<EntityBase>
{
    public BaseValidator()
    {

    }
}
