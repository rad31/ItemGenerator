using ItemGenerator.Domain.Entities;

namespace ItemGenerator.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token);