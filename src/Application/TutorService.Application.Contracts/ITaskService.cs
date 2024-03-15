using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Contracts;

public interface ITaskService
{
    Task<bool> CreateTaskAsync(TaskCreateRequest request);

    Task<TaskResponse> GetTaskAsync(string id);

    Task<bool> UpdateTaskAsync(string id, TaskUpdateRequest request);

    Task<bool> DeleteTaskAsync(string id);
}
