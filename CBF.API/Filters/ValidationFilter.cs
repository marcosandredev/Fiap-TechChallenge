using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CBF.API.Filters;

public class ValidationFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var errors = new List<string>();
            foreach (var key in context.ModelState.Keys)
                errors.AddRange(context.ModelState[key]!.Errors.Select(x => x.ErrorMessage));
            context.Result = new JsonResult(new { errors });
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
        }
    }
}
