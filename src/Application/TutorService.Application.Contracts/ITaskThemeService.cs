using TutorService.Application.Models;

namespace TutorService.Application.Contracts;

public interface ITaskThemeService
{
    TaskThemeModel Create(int taskId, int themeId);

    TaskThemeModel Get(int taskThemeId, int taskId, int themeId);

    bool Update(TaskThemeModel newTaskTheme);

    bool Delete(int taskThemeId);
}