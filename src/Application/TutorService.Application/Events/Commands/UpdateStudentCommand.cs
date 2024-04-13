using MediatR;
using TutorService.Application.Models.Dtos;

namespace TutorService.Application.Events.Commands;

public class UpdateStudentCommand : IRequest<bool>
{
    public string StudentId { get; set; } = null!;

    public StudentUpdateRequest StudentUpdateRequest { get; set; } = null!;
}