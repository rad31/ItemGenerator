using System.Net;
using System.Reflection;
using ErrorOr;
using ItemGenerator.Api.Common.Http;
using ItemGenerator.Domain.Common.Errors;
using Microsoft.AspNetCore.Mvc;

namespace ItemGenerator.Api.Controllers;

public abstract class ApiController : ControllerBase
{
    protected IActionResult Problem(List<Error> errors)
    {
        HttpContext.Items[HttpContextItemKeys.Errors] = errors;

        var firstError = errors[0];

        var statusCode = (ErrorTypesExtended)firstError.NumericType switch
        {
            ErrorTypesExtended.Conflict => HttpStatusCode.Conflict,
            ErrorTypesExtended.Validation => HttpStatusCode.BadRequest,
            ErrorTypesExtended.NotFound => HttpStatusCode.NotFound,
            ErrorTypesExtended.Authorization => HttpStatusCode.Unauthorized,
            _ => HttpStatusCode.InternalServerError,
        };

        return Problem(statusCode: (int)statusCode, title: firstError.Description);
    }
}