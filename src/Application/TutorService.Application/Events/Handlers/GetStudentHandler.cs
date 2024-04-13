using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Queries;
using TutorService.Application.Models.Dtos;

namespace TutorService.Application.Events.Handlers;

public class GetStudentHandler : IRequestHandler<GetStudentQuery, StudentResponse>
{
    private readonly IStudentRepository _studentRepository;

    public GetStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<StudentResponse> Handle(GetStudentQuery request, CancellationToken cancellationToken)
    {
        StudentResponse student = await _studentRepository.GetStudent(request.StudentId);
        return new StudentResponse(student.StudentId, student.TutorId, student.ThemeId);
    }
}