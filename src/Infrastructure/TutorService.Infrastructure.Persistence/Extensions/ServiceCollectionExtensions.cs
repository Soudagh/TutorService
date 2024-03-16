using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Plugins;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TutorService.Application.Abstractions.Persistence;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Infrastructure.Persistence.Contexts;
using TutorService.Infrastructure.Persistence.Migrations;
using TutorService.Infrastructure.Persistence.Plugins;
using TutorService.Infrastructure.Persistence.Repositories;

namespace TutorService.Infrastructure.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructurePersistence(this IServiceCollection collection, IConfiguration configuration)
    {
        collection.AddSingleton<IDataSourcePlugin, MappingPlugin>();

        collection.AddPlatformMigrations(typeof(IAssemblyMarker).Assembly);
        collection.AddHostedService<MigrationRunnerService>();

        // TODO: add repositories
        collection.AddScoped<IPersistenceContext, PersistenceContext>();
        collection.AddScoped<IUserRepository, UserRepository>();
        collection.AddScoped<ITaskRepository, TaskRepository>();

        collection.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql("Host=ep-raspy-surf-a2g3tsj7.eu-central-1.aws.neon.tech;Database=tutor_service;Port=5432;User=tutor_service_owner;Password=bkV8TOJM5lKf"));

        return collection;
    }
}