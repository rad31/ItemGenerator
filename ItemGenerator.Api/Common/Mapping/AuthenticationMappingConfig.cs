using ItemGenerator.Application.Authentication.Commands.Register;
using ItemGenerator.Application.Authentication.Common;
using ItemGenerator.Application.Authentication.Queries.Login;
using ItemGenerator.Contracts.Authentication;
using Mapster;

namespace ItemGenerator.Api.Common.Mapping;

public sealed class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();
        config.NewConfig<LoginRequest, LoginQuery>();
        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest, src => src.User);
    }
}