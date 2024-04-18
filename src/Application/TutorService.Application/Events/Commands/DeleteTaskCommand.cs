using MediatR;

namespace TutorService.Application.Events.Commands;

public class DeleteTaskCommand : IRequest<bool>
{
    public string TaskId { get; set; } = null!;
}