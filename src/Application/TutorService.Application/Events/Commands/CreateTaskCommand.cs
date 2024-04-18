using MediatR;
using TutorService.Application.Models.Requests;

namespace TutorService.Application.Events.Commands;

public class CreateTaskCommand : IRequest<bool>
{
    public TaskCreateRequest TaskCreateRequest { get; set; } = null!;
}