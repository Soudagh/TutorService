using MediatR;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Events.Queries;

public class GetTaskQuery : IRequest<TaskResponse>
{
    public string TaskId { get; set; } = null!;
}