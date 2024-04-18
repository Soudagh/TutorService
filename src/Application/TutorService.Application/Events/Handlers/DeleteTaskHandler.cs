using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;

namespace TutorService.Application.Events.Handlers;

public class DeleteTaskHandler : IRequestHandler<DeleteTaskCommand, bool>
{
    private readonly ITaskRepository _taskRepository;

    public DeleteTaskHandler(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public Task<bool> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
        return _taskRepository.DeleteTask(request.TaskId);
    }
}