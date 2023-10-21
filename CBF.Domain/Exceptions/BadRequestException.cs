namespace CBF.Domain.Exceptions;
public class BadRequestException : Exception
{

    public BadRequestException() : base(ExceptionMessage.Bad_Request)
    {
    }

    public BadRequestException(string message) : base(message)
    {
    }
}
