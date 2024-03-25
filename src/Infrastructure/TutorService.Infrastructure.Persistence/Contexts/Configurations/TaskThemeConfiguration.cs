using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorService.Application.Models.Entities;

namespace TutorService.Infrastructure.Persistence.Contexts.Configurations;

public class TaskThemeConfiguration : IEntityTypeConfiguration<TaskTheme>
{
    public void Configure(EntityTypeBuilder<TaskTheme> builder)
    {
        builder.Property(taskTheme => taskTheme.TaskThemeId)
            .HasColumnName("task_theme_id")
            .HasColumnType("character varying")
            .HasMaxLength(200);
        builder.Property(taskTheme => taskTheme.TaskId)
            .HasColumnName("task_id")
            .HasColumnType("character varying")
            .HasMaxLength(200);
        builder.Property(taskTheme => taskTheme.ThemeId)
            .HasColumnName("theme_id")
            .HasColumnType("character varying")
            .HasMaxLength(200);
    }
}