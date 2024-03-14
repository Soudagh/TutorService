using TutorService.Application.Models;

namespace TutorService.Application.Contracts;

public interface ITaskThemeService
{
    TaskThemeModel CreateTaskTheme(int taskId, int themeId);

    TaskThemeModel GetTaskTheme(int taskThemeId, int taskId, int themeId);

    bool UpdateTaskTheme(TaskThemeModel newTaskTheme);

    bool DeleteTaskTheme(int taskThemeId);
}