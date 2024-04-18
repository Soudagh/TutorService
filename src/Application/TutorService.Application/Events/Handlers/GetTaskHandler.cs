using MediatR;
using System.Globalization;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Queries;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Events.Handlers;

public class GetTaskHandler : IRequestHandler<GetTaskQuery, TaskResponse>
{
    private readonly ITaskRepository _taskRepository;

    public GetTaskHandler(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<TaskResponse> Handle(GetTaskQuery request, CancellationToken cancellationToken)
    {
        TaskResponse task = await _taskRepository.GetTask(request.TaskId);
        return new TaskResponse(task.TaskId, task.Name, task.Description, task.Difficulty);
    }
}