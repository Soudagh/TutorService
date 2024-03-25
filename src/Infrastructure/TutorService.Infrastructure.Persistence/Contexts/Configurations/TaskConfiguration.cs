using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorService.Application.Models.Entities;

namespace TutorService.Infrastructure.Persistence.Contexts.Configurations;

public class TaskConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        builder.HasKey(task => task.TaskId).HasName("task_pkey");
        builder.Property(task => task.TaskId)
            .HasColumnName("task_id")
            .HasColumnType("character varying")
            .HasMaxLength(200);
        builder.Property(task => task.Difficulty)
            .HasColumnName("difficulty")
            .HasColumnType("integer");
        builder.Property(task => task.Name)
            .HasColumnName("name")
            .HasColumnType("character varying");
        builder.ToTable("task");
    }
}