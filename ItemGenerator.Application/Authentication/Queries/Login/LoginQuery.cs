using ErrorOr;
using ItemGenerator.Application.Authentication.Common;
using MediatR;

namespace ItemGenerator.Application.Authentication.Queries.Login;

public record LoginQuery(string Username, string Password)
    : IRequest<ErrorOr<AuthenticationResult>>;