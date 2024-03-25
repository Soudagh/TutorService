namespace TutorService.Application.Models.Entities;

public class TaskTheme
{
    public Guid TaskThemeId { get; set; }

    public Guid TaskId { get; set; }

    public Guid ThemeId { get; set; }

    public Exercise Task { get; set; } = null!;

    public Theme Theme { get; set; } = null!;
}