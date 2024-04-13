using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Events.Handlers;

public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, bool>
{
    private readonly IStudentRepository _studentRepository;

    public CreateStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public Task<bool> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
    {
        var studentModel = new StudentModel
        {
            StudentId = Guid.NewGuid(),
            StudentUserId = new Guid(request.StudentCreateRequest.StudentUserId),
            TutorId = new Guid(request.StudentCreateRequest.TutorId),
            ThemeId = new Guid(request.StudentCreateRequest.ThemeId),
        };

        return _studentRepository.CreateStudent(studentModel);
    }
}