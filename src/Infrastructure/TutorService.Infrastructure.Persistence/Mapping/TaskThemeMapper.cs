using TutorService.Application.Models;
using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Models;
using TutorService.Application.Models.Requests;

namespace TutorService.Infrastructure.Persistence.Mapping;

public class TaskThemeMapper
{
    public static TaskTheme ModelToEntity(TaskThemeModel taskThemeModel)
    {
        var taskTheme = new TaskTheme(
            taskThemeId: taskThemeModel.TaskThemeId,
            themeId: taskThemeModel.ThemeId,
            taskId: taskThemeModel.TaskId
        );
        return taskTheme;
    }

    public static TaskThemeModel EntityToModel(TaskTheme taskTheme)
    {
        var taskThemeModel = new TaskThemeModel(
            taskThemeId: taskTheme.TaskThemeId,
            taskId: taskTheme.TaskId,
            themeId: taskTheme.ThemeId
        );
        return taskThemeModel;
    }

    public static TaskThemeModel TaskThemeCreateToModel(TaskThemeCreateRequest request)
    {
        var taskThemeModel = new TaskThemeModel(
            taskThemeId: Guid.NewGuid(),
            taskId: new Guid(request.TaskId),
            themeId: new Guid(request.ThemeId)
        );
        return taskThemeModel;
    }

    public static TaskThemeModel TaskThemeUpdateToModel(TaskThemeUpdateRequest request)
    {
        var taskThemeModel = new TaskThemeModel(
            taskThemeId: Guid.Empty,
            taskId: new Guid(request.TaskId),
            themeId: new Guid(request.ThemeId)
        );
        return taskThemeModel;
    }
}