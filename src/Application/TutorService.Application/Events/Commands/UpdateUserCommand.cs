using MediatR;
using TutorService.Application.Models.Dtos;

namespace TutorService.Application.Events.Commands;

public class UpdateUserCommand : IRequest<bool>
{
    public string UserId { get; set; } = null!;

    public UserUpdateRequest UserUpdateRequest { get; set; } = null!;
}