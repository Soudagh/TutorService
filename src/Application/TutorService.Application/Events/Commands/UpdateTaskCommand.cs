using MediatR;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Requests;

namespace TutorService.Application.Events.Commands;

public class UpdateTaskCommand : IRequest<bool>
{
    public string TaskId { get; set; } = null!;

    public TaskUpdateRequest TaskUpdateRequest { get; set; } = null!;
}