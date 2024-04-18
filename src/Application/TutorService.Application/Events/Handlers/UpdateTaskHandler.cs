using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Events.Handlers;

public class UpdateTaskHandler : IRequestHandler<UpdateTaskCommand, bool>
{
    private readonly ITaskRepository _taskRepository;

    public UpdateTaskHandler(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public Task<bool> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
    {
        var taskModel = new TaskModel
        {
            Name = request.TaskUpdateRequest.Name,
            Description = request.TaskUpdateRequest.Description,
            Difficulty = request.TaskUpdateRequest.Difficulty,
        };
        return _taskRepository.UpdateTask(request.TaskId, taskModel);
    }
}