using ItemGenerator.Contracts.Authentication;
using ItemGenerator.Application.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace ItemGenerator.Api.AddControllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var result = _authenticationService.Register(request.UserName, request.Password);
        var response = new AuthenticationResponse(
            result.Id,
            result.UserName,
            result.Token);

        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var result = _authenticationService.Login(request.UserName, request.Password);
        var response = new AuthenticationResponse(
            result.Id,
            result.UserName,
            result.Token);
            
        return Ok(response);
    }
}