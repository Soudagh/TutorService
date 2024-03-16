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

        return collection;
    }

    private static IServiceCollection AddContext(this IServiceCollection collection, IConfiguration configuration)
    {
        collection.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetSection("Infrastructure:Persistence:Postgres:ConnectionString").Value));

        return collection;
    }
}