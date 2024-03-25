using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorService.Application.Models.Entities;

namespace TutorService.Infrastructure.Persistence.Contexts.Configurations;

public class ThemeConfiguration : IEntityTypeConfiguration<Theme>
{
    public void Configure(EntityTypeBuilder<Theme> builder)
    {
        builder.HasKey(theme => theme.ThemeId).HasName("theme_pkey");
        builder.Property(theme => theme.ThemeId)
            .HasColumnName("theme_id")
            .HasColumnType("character varying");
        builder.Property(theme => theme.Title)
            .HasColumnName("title")
            .HasColumnName("character varying")
            .HasMaxLength(100);
        builder.Property(theme => theme.Difficulty)
            .HasColumnName("difficulty")
            .HasColumnType("integer");
        builder.ToTable("theme");
    }
}