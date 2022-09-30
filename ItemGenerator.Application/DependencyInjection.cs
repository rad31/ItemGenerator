using ItemGenerator.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace ItemGenerator.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}