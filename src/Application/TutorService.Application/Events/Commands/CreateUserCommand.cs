using MediatR;
using TutorService.Application.Models.Dtos;

namespace TutorService.Application.Events.Commands;

public class CreateUserCommand : IRequest<bool>
{
    public UserCreateRequest UserCreateRequest { get; set; } = null!;
}