using ItemGenerator.Application.Common.Interfaces.Authentication;

namespace ItemGenerator.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Login(string userName, string password)
    {
        // TODO: Check if user exists

        Guid userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(userId, userName);

        return new AuthenticationResult(
            userId,
            userName,
            token);
    }
    public AuthenticationResult Register(string userName, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            userName,
            Guid.NewGuid().ToString());
    }
}