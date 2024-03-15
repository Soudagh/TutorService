using Microsoft.EntityFrameworkCore;
using TutorService.Application.Models;

namespace TutorService.Infrastructure.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    required public DbSet<UserModel> Users { get; set; }

    required public DbSet<ExerciseModel> Exercises { get; set; }

    required public DbSet<StudentModel> Students { get; set; }

    required public DbSet<TaskThemeModel> TaskThemes { get; set; }

    required public DbSet<ThemeModel> Themes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        // Сюда добавлять различные конфигурации ваших файлов
        base.OnModelCreating(modelBuilder);
    }
}
