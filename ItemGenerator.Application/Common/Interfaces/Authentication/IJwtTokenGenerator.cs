using ItemGenerator.Domain.Entities;

namespace ItemGenerator.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}