using AutoTurn.Application.Common.Behaviors;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using AutoTurn.Application.Authentication.Commands;

namespace  AutoTurn.Application;


public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(
            cfg => cfg.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly)
           );
        var assemblies = new[]
        {
            typeof(RegisterValidator).Assembly,
            
        };
        services.AddValidatorsFromAssemblies(assemblies, ServiceLifetime.Scoped);
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        return services;
    }
}
