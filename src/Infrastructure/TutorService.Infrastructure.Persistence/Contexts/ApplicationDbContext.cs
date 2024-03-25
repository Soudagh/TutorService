using Microsoft.EntityFrameworkCore;
using Npgsql;
using TutorService.Application.Models;
using TutorService.Application.Models.Entities;
using TutorService.Infrastructure.Persistence.Contexts.Configurations;

namespace TutorService.Infrastructure.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    required public DbSet<User> user { get; set; }
    required public DbSet<Exercise> Exercises { get; set; }
    required public DbSet<Student> Students { get; set; }
    required public DbSet<TaskTheme> TaskThemes { get; set; }
    required public DbSet<ThemeModel> Themes { get; set; }

    [Obsolete("Obsolete")]
    static ApplicationDbContext()
    {
        NpgsqlConnection.GlobalTypeMapper.MapEnum<Roles>();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        // Сюда добавлять различные конфигурации ваших файлов
        modelBuilder.HasPostgresEnum<Roles>("roles");
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new TaskConfiguration());
        modelBuilder.ApplyConfiguration(new TaskThemeConfiguration());
        modelBuilder.ApplyConfiguration(new ThemeConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}
