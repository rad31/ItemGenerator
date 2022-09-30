namespace ItemGenerator.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Login(string userName, string passwowrd);
    AuthenticationResult Register(string userName, string passwowrd, string email);
}