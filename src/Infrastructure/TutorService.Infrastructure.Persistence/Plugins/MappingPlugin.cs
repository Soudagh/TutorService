using Itmo.Dev.Platform.Postgres.Plugins;
using Npgsql;
using TutorService.Application.Models;

namespace TutorService.Infrastructure.Persistence.Plugins;

/// <summary>
///     Plugin for configuring NpgsqlDataSource's mappings
///     ie: enums, composite types
/// </summary>
public class MappingPlugin : IDataSourcePlugin
{
    public void Configure(NpgsqlDataSourceBuilder builder)
    {
        builder.MapEnum<Roles>();
        builder.Build();
    }
}