using ErrorOr;
using ItemGenerator.Application.Common.Interfaces.Authentication;
using ItemGenerator.Application.Common.Interfaces.Persistence;
using ItemGenerator.Domain.Common.Errors;
using ItemGenerator.Domain.Entities;

namespace ItemGenerator.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public ErrorOr<AuthenticationResult> Register(string username, string password, string email)
    {
        if (_userRepository.GetUserByUsername(username) is not null)
            return Errors.User.DuplicateUsername;

        var user = new User
        {
            Id = Guid.NewGuid(),
            Username = username,
            Password = password,
            Email = email
        };

        _userRepository.Add(user);

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
    public ErrorOr<AuthenticationResult> Login(string username, string password)
    {
        var user = _userRepository.GetUserByUsername(username);

        if (user is null || user.Password != password)
            return Errors.Authentication.InvalidCredentials;

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}