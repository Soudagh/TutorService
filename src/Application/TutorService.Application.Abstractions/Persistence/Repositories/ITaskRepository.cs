using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Abstractions.Persistence.Repositories;

public interface ITaskRepository
{
    Task<bool> CreateTask(TaskCreateRequest request);

    Task<TaskResponse> GetTask(string id);

    Task<bool> UpdateTask(string id, TaskUpdateRequest request);

    Task<bool> DeleteTask(string id);
}