using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorService.Application.Models.Entities;

namespace TutorService.Infrastructure.Persistence.Contexts.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.UserId).HasName("user_pkey");
        builder.Property(user => user.UserId)
            .HasColumnName("user_id")
            .HasColumnType("character varying")
            .HasMaxLength(200);
        builder.Property(user => user.FullName)
            .HasColumnName("full_name")
            .HasColumnType("character varying")
            .HasMaxLength(50);
        builder.Property(user => user.Phone)
            .HasColumnName("phone")
            .HasColumnType("character varying")
            .HasMaxLength(20);
        builder.Property(user => user.Mail)
            .HasColumnName("mail")
            .HasColumnType("character varying")
            .HasMaxLength(50);
        builder.Property(user => user.Avatar)
            .HasColumnName("avatar")
            .HasColumnType("character varying")
            .HasMaxLength(200);
        builder.Property(user => user.Login)
            .HasColumnName("login")
            .HasColumnType("character varying")
            .HasMaxLength(50);
        builder.Property(user => user.PasswordHashed)
            .HasColumnName("hashed_password")
            .HasColumnType("character varying")
            .HasMaxLength(200);
        builder.Property(user => user.Role)
            .HasColumnName("role")
            .HasColumnType("roles");
        builder.ToTable("user");
    }
}
