#pragma warning disable SA1206

using Microsoft.EntityFrameworkCore;
using TutorService.Application.Models;

namespace TutorService.Infrastructure.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public required DbSet<UserModel> Users { get; set; }

    public required DbSet<TaskModel> Exercises { get; set; }

    public required DbSet<StudentModel> Students { get; set; }

    public required DbSet<TaskThemeModel> TaskThemes { get; set; }

    public required DbSet<ThemeModel> Themes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        // Сюда добавлять различные конфигурации ваших файлов
        base.OnModelCreating(modelBuilder);
    }
}
