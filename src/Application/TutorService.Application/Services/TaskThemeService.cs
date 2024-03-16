using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Services;

public class TaskThemeService : ITaskThemeService
{
    private readonly ITaskThemeRepository _taskThemeRepository;

    public TaskThemeService(ITaskThemeRepository taskThemeRepository)
    {
        _taskThemeRepository = taskThemeRepository;
    }

    public async Task<bool> CreateTaskThemeAsync(TaskThemeCreateRequest request)
    {
        return await _taskThemeRepository.CreateTaskTheme(request);
    }

    public async Task<TaskThemeResponse> GetTaskThemeAsync(string id)
    {
        TaskThemeResponse taskTheme = await _taskThemeRepository.GetTaskTheme(id);
        return new TaskThemeResponse(taskTheme.TaskThemeId, taskTheme.TaskId, taskTheme.ThemeId);
    }

    public async Task<bool> UpdateTaskThemeAsync(string id, TaskThemeUpdateRequest request)
    {
        return await _taskThemeRepository.UpdateTaskTheme(id, request);
    }

    public async Task<bool> DeleteTaskThemeAsync(string id)
    {
        return await _taskThemeRepository.DeleteTaskTheme(id);
    }
}