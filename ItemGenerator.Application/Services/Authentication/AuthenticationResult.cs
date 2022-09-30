namespace ItemGenerator.Application.Services.Authentication;

public record AuthenticationResult(
    Guid Id,
    string UserName,
    string Token);