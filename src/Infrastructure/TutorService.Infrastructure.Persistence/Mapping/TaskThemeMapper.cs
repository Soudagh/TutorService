using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Models;
using TutorService.Application.Models.Requests;

namespace TutorService.Infrastructure.Persistence.Mapping;

public class TaskThemeMapper
{
    public static TaskTheme ModelToEntity(TaskThemeModel taskThemeModel)
    {
        var taskTheme = new TaskTheme
        {
            TaskThemeId = taskThemeModel.TaskThemeId,
            ThemeId = taskThemeModel.ThemeId,
            TaskId = taskThemeModel.TaskId,
        };
        return taskTheme;
    }

    public static TaskThemeModel EntityToModel(TaskTheme taskTheme)
    {
        var taskThemeModel = new TaskThemeModel
        {
            TaskThemeId = taskTheme.TaskThemeId,
            TaskId = taskTheme.TaskId,
            ThemeId = taskTheme.ThemeId,
        };

        return taskThemeModel;
    }

    public static TaskThemeModel TaskThemeCreateToModel(TaskThemeCreateRequest request)
    {
        var taskThemeModel = new TaskThemeModel
        {
            TaskThemeId = Guid.NewGuid(),
            TaskId = new Guid(request.TaskId),
            ThemeId = new Guid(request.ThemeId),
        };
        return taskThemeModel;
    }

    public static TaskThemeModel TaskThemeUpdateToModel(TaskThemeUpdateRequest request)
    {
        var taskThemeModel = new TaskThemeModel
        {
            TaskThemeId = Guid.Empty,
            TaskId = new Guid(request.TaskId),
            ThemeId = new Guid(request.ThemeId),
        };
        return taskThemeModel;
    }
}