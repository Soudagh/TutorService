using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Events.Handlers;

public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, bool>
{
    private readonly IStudentRepository _studentRepository;

    public UpdateStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public Task<bool> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
    {
        var studentModel = new StudentModel
        {
            StudentId = Guid.Empty,
            StudentUserId = new Guid(request.StudentUpdateRequest.StudentUserId),
            TutorId = new Guid(request.StudentUpdateRequest.TutorId),
            ThemeId = new Guid(request.StudentUpdateRequest.ThemeId),
        };
        return _studentRepository.UpdateStudent(request.StudentId, studentModel);
    }
}