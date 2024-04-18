using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;
using TutorService.Application.Models;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Events.Handlers;

public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, bool>
{
    private readonly ITaskRepository _taskRepository;

    public CreateTaskHandler(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public Task<bool> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
    {
        var taskModel = new TaskModel
        {
            Name = request.TaskCreateRequest.Name,
            Description = request.TaskCreateRequest.Description,
            Difficulty = request.TaskCreateRequest.Difficulty,
        };

        return _taskRepository.CreateTask(taskModel);
    }
}