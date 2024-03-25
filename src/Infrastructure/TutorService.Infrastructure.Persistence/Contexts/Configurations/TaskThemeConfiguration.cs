using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorService.Application.Models.Entities;

namespace TutorService.Infrastructure.Persistence.Contexts.Configurations;

public class TaskThemeConfiguration : IEntityTypeConfiguration<TaskTheme>
{
    public void Configure(EntityTypeBuilder<TaskTheme> builder)
    {
        builder.HasKey(taskTheme => taskTheme.TaskThemeId).HasName("task_theme_pkey");
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
        builder
            .HasOne(x => x.Task)
            .WithMany(x => x.TaskThemes)
            .HasForeignKey(x => x.TaskId)
            .HasConstraintName("task_fkey");
        builder
            .HasOne(x => x.Theme)
            .WithMany(x => x.TaskThemes)
            .HasForeignKey(x => x.ThemeId)
            .HasConstraintName("theme_fkey");
        builder.ToTable("task_theme");
    }
}