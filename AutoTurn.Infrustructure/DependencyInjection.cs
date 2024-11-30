using AutoTurn.Application.Interfaces;
using AutoTurn.Application.Interfaces.Repository;
using AutoTurn.Infrastructure.Authentication;
using AutoTurn.Infrastructure.Services;
using AutoTurn.Infrustructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;

namespace  AutoTurn.Infrustructure;


public static class DependencyInjection
{
    public static IServiceCollection AddInfrustructure(
        this IServiceCollection services,
        IConfigurationManager configuration)
    {


        services.AddScoped<IUserRepository, UserRepository>();
        
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        configuration.GetSection(JwtSettings.SectionName);
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}
