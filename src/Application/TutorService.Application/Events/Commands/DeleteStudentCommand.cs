using MediatR;

namespace TutorService.Application.Events.Commands;

public class DeleteStudentCommand : IRequest<bool>
{
    public string StudentId { get; set; } = null!;
}