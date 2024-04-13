using MediatR;
using TutorService.Application.Models.Dtos;

namespace TutorService.Application.Events.Commands;

public class CreateStudentCommand : IRequest<bool>
{
    public StudentCreateRequest StudentCreateRequest { get; set; } = null!;
}