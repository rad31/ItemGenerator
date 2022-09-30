using ItemGenerator.Application.Common.Interfaces.Authentication;
using ItemGenerator.Application.Common.Interfaces.Persistence;
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

    public AuthenticationResult Register(string userName, string password, string email)
    {
        if (_userRepository.GetUserByUserName(userName) is not null)
            throw new Exception($"User {userName} already exists.");

        var user = new User
        {
            Id = Guid.NewGuid(),
            UserName = userName,
            Password = password,
            Email = email
        };

        _userRepository.Add(user);

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
    public AuthenticationResult Login(string userName, string password)
    {
        var user = _userRepository.GetUserByUserName(userName);

        if (user is null)
            throw new Exception("Unable to login with given username and password.");

        if (user.Password != password)
            throw new Exception("Unable to login with given username and password.");

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}