// See https://aka.ms/new-console-template for more information

using InternSystem.Application.Common.Persistences.IRepositories;
using InternSystem.Infrastructure.Persistences.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ConfigureService
{
    public static IServiceCollection ConfigureInfrastructureService(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}