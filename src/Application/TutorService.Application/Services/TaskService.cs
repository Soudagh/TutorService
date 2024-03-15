using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Services;

public class TaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<bool> CreateTask(TaskCreateRequest request)
    {
        return await _taskRepository.CreateTask(request);
    }

    public async Task<TaskResponse?> GetTask(string id)
    {
        TaskResponse task = await _taskRepository.GetTask(id);
        return new TaskResponse(task.TaskId, task.Name, task.Description, task.Difficulty);
    }

    public async Task<bool> UpdateTask(string id, TaskUpdateRequest request)
    {
        return await _taskRepository.UpdateTask(id, request);
    }

    public async Task<bool> DeleteTask(string id)
    {
        return await _taskRepository.DeleteTask(id);
    }
}