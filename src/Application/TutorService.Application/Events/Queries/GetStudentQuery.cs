using MediatR;
using TutorService.Application.Models.Dtos;

namespace TutorService.Application.Events.Queries;

public class GetStudentQuery : IRequest<StudentResponse>
{
    public string StudentId { get; set; } = null!;
}