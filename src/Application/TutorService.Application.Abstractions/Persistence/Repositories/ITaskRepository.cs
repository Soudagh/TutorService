using TutorService.Application.Models.Models;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Abstractions.Persistence.Repositories;

public interface ITaskRepository
{
    Task<bool> CreateTask(TaskModel request);

    Task<TaskResponse> GetTask(string id);

    Task<bool> UpdateTask(string id, TaskModel request);

    Task<bool> DeleteTask(string id);
}