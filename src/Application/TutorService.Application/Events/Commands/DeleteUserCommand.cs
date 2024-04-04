using MediatR;

namespace TutorService.Application.Events.Commands;

public class DeleteUserCommand : IRequest<bool>
{
    public string UserId { get; set; } = null!;
}