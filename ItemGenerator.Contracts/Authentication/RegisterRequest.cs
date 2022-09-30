namespace ItemGenerator.Contracts.Authentication;

public record RegisterRequest(
    string Username,
    string Password,
    string Email);