using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace ItemGenerator.Api.Controllers;

public class ErrorsController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

        if (exception is null)
            return Problem();

        if (exception is ArgumentException)
            return ValidationProblem(title: exception.Message);
        if (exception is DuplicateNameException)
            return ValidationProblem(title: exception.Message, statusCode: (int)HttpStatusCode.Conflict);

        return Problem(title: $"Unhandled exception type: {exception.GetType()}, {exception.Message}");
    }
}