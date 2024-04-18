using TutorService.Application.Models.Models;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Contracts;

public interface ITaskService
{
    Task<bool> CreateTaskAsync(TaskModel request);

    Task<TaskResponse> GetTaskAsync(string id);

    Task<bool> UpdateTaskAsync(string id, TaskModel request);

    Task<bool> DeleteTaskAsync(string id);
}
