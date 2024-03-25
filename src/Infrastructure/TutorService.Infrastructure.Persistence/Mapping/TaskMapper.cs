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
            difficulty: taskModel.Difficulty);

        return task;
    }

    public static TaskModel EntityToModel(Exercise task)
    {
        var taskModel = new TaskModel
        {
            TaskId = task.TaskId,
            Name = task.Name,
            Description = task.Description,
            Difficulty = task.Difficulty,
        };

        return taskModel;
    }

    public static TaskModel TaskCreateToModel(TaskCreateRequest request)
    {
        var taskModel = new TaskModel
        {
            TaskId = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description,
            Difficulty = request.Difficulty,
        };

        return taskModel;
    }

    public static TaskModel TaskUpdateToModel(TaskUpdateRequest request)
    {
        var taskModel = new TaskModel
        {
            TaskId = Guid.Empty,
            Name = request.Name,
            Description = request.Description,
            Difficulty = request.Difficulty,
        };

        return taskModel;
    }
}