namespace TutorService.Application.Models;

public class TaskThemeModel
{
    private string _taskThemeId;
    private string _taskId;
    private string _themeId;

    public TaskThemeModel(string taskThemeId, string taskId, string themeId)
    {
        _taskThemeId = taskThemeId;
        _taskId = taskId;
        _themeId = themeId;
    }
}