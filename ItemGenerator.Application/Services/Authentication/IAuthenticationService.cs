using ErrorOr;

namespace ItemGenerator.Application.Services.Authentication;

public interface IAuthenticationService
{
    ErrorOr<AuthenticationResult> Login(string username, string passwowrd);
    ErrorOr<AuthenticationResult> Register(string username, string passwowrd, string email);
}