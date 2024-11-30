using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;


namespace AutoTurn.Models;


public static class DependencyInjection
{
    public static IServiceCollection AddModels(
        this IServiceCollection services,
        IConfigurationManager configuration)
    {
        services.AddDbContext<AutoTurnDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("default"));
            //options.EnableSensitiveDataLogging();
        });
        return services;
    }

}
