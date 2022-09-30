namespace ItemGenerator.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string UserName,
    string Token);