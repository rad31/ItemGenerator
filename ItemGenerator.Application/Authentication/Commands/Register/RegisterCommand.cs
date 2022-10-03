using ErrorOr;
using ItemGenerator.Application.Authentication.Common;
using MediatR;

namespace ItemGenerator.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string Username,
    string Password,
    string Email)
    : IRequest<ErrorOr<AuthenticationResult>>;