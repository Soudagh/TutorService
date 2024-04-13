using MediatR;
using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Events.Commands;

namespace TutorService.Application.Events.Handlers;

public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, bool>
{
    private readonly IStudentRepository _studentRepository;

    public DeleteStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public Task<bool> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
    {
        return _studentRepository.DeleteStudent(request.StudentId);
    }
}