using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using CBF.Domain.Exceptions;

namespace CBF.API.Filters;

public class ApplicationExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is NotFoundException)
        {
            var exception = context.Exception as NotFoundException;
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NoContent;
            context.Result = new ObjectResult(exception.Message);
        }

        else if (context.Exception is BadRequestException)
        {
            var exception = context.Exception as BadRequestException;
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            context.Result = new ObjectResult(exception.Message);
        }
        else
            UnknownError(context);
    }

    private static void UnknownError(ExceptionContext context)
    {
        var exception = context.Exception;
        context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Result = new ObjectResult( new
        {
            ExceptionMessage.Unknown_Error,
            exception.Message
        });
    }
}
