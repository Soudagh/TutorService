using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Models;
using TutorService.Application.Models.Requests;

namespace TutorService.Infrastructure.Persistence.Mapping;

public class TaskMapper
{
    public static Exercise ModelToEntity(TaskModel taskModel)
    {
        var task = new Exercise(
            taskId: taskModel.TaskId,
            name: taskModel.Name,
            description: taskModel.Description,
            difficulty: taskModel.Difficulty
        );
        return task;
    }

    public static TaskModel EntityToModel(Exercise task)
    {
        var taskModel = new TaskModel(
            taskId: task.TaskId,
            name: task.Name,
            description: task.Description,
            difficulty: task.Difficulty
        );
        return taskModel;
    }
    
    public static TaskModel TaskCreateToModel(TaskCreateRequest request)
    {
        var taskModel = new TaskModel(
            taskId: Guid.NewGuid(),
            name: request.Name,
            description: request.Description,
            difficulty: request.Difficulty
            );
        return taskModel;
    }

    public static TaskModel UserUpdateToModel(TaskUpdateRequest request)
    {
        var taskModel = new TaskModel(
            taskId: Guid.Empty,
            name: request.Name,
            description: request.Description,
            difficulty: request.Difficulty);
        return taskModel;
    }
}