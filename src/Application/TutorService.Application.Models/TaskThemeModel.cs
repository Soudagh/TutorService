namespace TutorService.Application.Models;

public class TaskThemeModel
{
    public int TaskThemeId { get; set; }

    public int TaskId { get; set; }

    public int ThemeId { get; set; }

    public TaskThemeModel(int taskThemeId, int taskId, int themeId)
    {
        TaskThemeId = taskThemeId;
        TaskId = taskId;
        ThemeId = themeId;
    }
}