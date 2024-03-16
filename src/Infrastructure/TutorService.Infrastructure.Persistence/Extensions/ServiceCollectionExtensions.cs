using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TutorService.Application.Abstractions.Persistence;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Infrastructure.Persistence.Contexts;
using TutorService.Infrastructure.Persistence.Repositories;

namespace TutorService.Infrastructure.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructurePersistence(this IServiceCollection collection, IConfiguration configuration)
    {
        AddContext(collection, configuration);

        // TODO: add repositories
        collection.AddScoped<IPersistenceContext, PersistenceContext>();
        collection.AddScoped<IUserRepository, UserRepository>();
        collection.AddScoped<ITaskRepository, TaskRepository>();
        collection.AddScoped<IThemeRepository, ThemeRepository>();
        collection.AddScoped<ITaskThemeRepository, TaskThemeRepository>();

        return collection;
    }

    private static IServiceCollection AddContext(this IServiceCollection collection, IConfiguration configuration)
    {
        collection.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5433;Database=Tutor_Service;Username=postgres;Password=rfghjv2012"));

        return collection;
    }
}