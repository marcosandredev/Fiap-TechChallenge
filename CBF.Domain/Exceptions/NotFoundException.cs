namespace CBF.Domain.Exceptions;
public class NotFoundException : Exception
{
    public NotFoundException() : base(ExceptionMessage.Id_Not_Found)
    {

    }
}
