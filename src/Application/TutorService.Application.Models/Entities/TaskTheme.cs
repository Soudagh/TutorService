namespace TutorService.Application.Models.Entities;

public class TaskTheme
{
    public Guid TaskThemeId { get; set; }

    public Guid TaskId { get; set; }

    public Guid ThemeId { get; set; }

    public TaskTheme(Guid taskThemeId, Guid taskId, Guid themeId)
    {
        TaskThemeId = taskThemeId;
        TaskId = taskId;
        ThemeId = themeId;
    }
}