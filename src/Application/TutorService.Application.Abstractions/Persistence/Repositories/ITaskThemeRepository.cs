using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Abstractions.Persistence.Repositories;

public interface ITaskThemeRepository
{
    Task<bool> CreateTaskTheme(TaskThemeCreateRequest request);

    Task<TaskThemeResponse> GetTaskTheme(string id);

    Task<bool> UpdateTaskTheme(string id, TaskThemeUpdateRequest request);

    Task<bool> DeleteTaskTheme(string id);
}