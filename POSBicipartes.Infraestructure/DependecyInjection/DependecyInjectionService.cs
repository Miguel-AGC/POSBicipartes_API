using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POSBicipartes.Infrastructure.Persistence.Context;

namespace POSBicipartes.Infrastructure.DependencyInjection;

public static class DependencyInjectionService
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString))
            .UseSnakeCaseNamingConvention();
        });

        return services;
    }
}