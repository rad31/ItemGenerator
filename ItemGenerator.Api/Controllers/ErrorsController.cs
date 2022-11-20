using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ItemGenerator.Api.Controllers;

public sealed class ErrorsController : ApiController
{
    [Route("/error")]
    public IActionResult Error()
    {
        var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

        if (exception is null)
            return Problem();

        return Problem(statusCode: (int)HttpStatusCode.InternalServerError, title: exception.Message);
    }
}