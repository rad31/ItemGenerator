using ItemGenerator.Api.Common.Errors;
using ItemGenerator.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ItemGenerator.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddMappings();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddSingleton<ProblemDetailsFactory, ItemGeneratorProblemDetailsFactory>();

        return services;
    }
}