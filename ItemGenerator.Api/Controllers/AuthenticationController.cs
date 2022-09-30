using ItemGenerator.Contracts.Authentication;
using ItemGenerator.Domain.Common.Errors;
using ItemGenerator.Application.Services.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ItemGenerator.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ApiController
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var result = _authenticationService.Register(
            request.Username,
            request.Password,
            request.Email);

        return result.Match(
            authResult => Ok(MapToResponse(authResult)),
            errors => Problem(errors));
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var result = _authenticationService.Login(
            request.Username,
            request.Password);

        if (result.IsError && result.FirstError == Errors.Authentication.InvalidCredentials)
            return Problem(statusCode: (int)HttpStatusCode.Unauthorized, title: "Invalid credentials");

        return result.Match(
            authResult => Ok(MapToResponse(authResult)),
            errors => Problem(errors));
    }

    public static AuthenticationResponse MapToResponse(AuthenticationResult authenticationResult)
    {
        return new AuthenticationResponse(
            authenticationResult.User.Id,
            authenticationResult.User.Username,
            authenticationResult.User.Email,
            authenticationResult.Token);
    }
}