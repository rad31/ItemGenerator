using System.Net;
using ErrorOr;
using ItemGenerator.Api.Common.Http;
using ItemGenerator.Domain.Common.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ItemGenerator.Api.Controllers;

[Authorize]
public abstract class ApiController : ControllerBase
{
    protected IActionResult Problem(List<Error> errors)
    {
        if (errors is null || errors.Count == 0)
            return Problem();

        if (errors.All(error => error.NumericType == (int)ErrorTypesExtended.Validation))
            return ValidationProblem(errors);

        HttpContext.Items[HttpContextItemKeys.Errors] = errors;

        return Problem(errors[0]);
    }

    private IActionResult ValidationProblem(List<Error> errors)
    {
        var modelStateDictionary = new ModelStateDictionary();

            foreach (var error in errors)
            {
                modelStateDictionary.AddModelError(
                    error.Code,
                    error.Description);
            }

            return ValidationProblem(modelStateDictionary);
    }

    private IActionResult Problem(Error error)
    {
        var statusCode = (ErrorTypesExtended)error.NumericType switch
        {
            ErrorTypesExtended.Conflict => HttpStatusCode.Conflict,
            ErrorTypesExtended.Validation => HttpStatusCode.BadRequest,
            ErrorTypesExtended.NotFound => HttpStatusCode.NotFound,
            ErrorTypesExtended.Authorization => HttpStatusCode.Unauthorized,
            _ => HttpStatusCode.InternalServerError,
        };

        return Problem(statusCode: (int)statusCode, title: error.Description);
    }
}