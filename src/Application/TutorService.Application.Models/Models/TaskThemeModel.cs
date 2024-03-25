namespace TutorService.Application.Models.Models;

public class TaskThemeModel
{
    public Guid TaskThemeId { get; set; }

    public Guid TaskId { get; set; }

    public Guid ThemeId { get; set; }
}