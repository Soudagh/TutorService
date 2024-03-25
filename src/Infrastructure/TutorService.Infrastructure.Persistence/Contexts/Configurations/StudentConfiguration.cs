using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorService.Application.Models.Entities;

namespace TutorService.Infrastructure.Persistence.Contexts.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(student => student.StudentId)
            .HasColumnName("student_id")
            .HasColumnType("character varying")
            .HasMaxLength(200);
        builder.Property(student => student.StudentUserId)
            .HasColumnName("student_user_id")
            .HasColumnType("character varying")
            .HasMaxLength(200);
        builder.Property(student => student.TutorId)
            .HasColumnName("tutor_id")
            .HasColumnType("character varying")
            .HasMaxLength(200);
        builder.Property(student => student.ThemeId)
            .HasColumnName("tutor_id")
            .HasColumnType("character varying")
            .HasMaxLength(200);
    }
}