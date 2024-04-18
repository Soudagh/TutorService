using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Models;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Services;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<bool> CreateTaskAsync(TaskModel request)
    {
        return await _taskRepository.CreateTask(request);
    }

    public async Task<TaskResponse> GetTaskAsync(string id)
    {
        TaskResponse task = await _taskRepository.GetTask(id);
        return new TaskResponse(task.TaskId, task.Name, task.Description, task.Difficulty);
    }

    public async Task<bool> UpdateTaskAsync(string id, TaskModel request)
    {
        return await _taskRepository.UpdateTask(id, request);
    }

    public async Task<bool> DeleteTaskAsync(string id)
    {
        return await _taskRepository.DeleteTask(id);
    }
}