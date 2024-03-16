using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Contracts;

public interface ITaskThemeService
{
    Task<bool> CreateTaskThemeAsync(TaskThemeCreateRequest request);

    Task<TaskThemeResponse> GetTaskThemeAsync(string id);

    Task<bool> UpdateTaskThemeAsync(string id, TaskThemeUpdateRequest request);

    Task<bool> DeleteTaskThemeAsync(string id);
}