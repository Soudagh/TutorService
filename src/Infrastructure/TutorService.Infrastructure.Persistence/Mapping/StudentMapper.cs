using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Models;

namespace TutorService.Infrastructure.Persistence.Mapping;

public class StudentMapper
{
    public static Student ModelToEntity(StudentModel studentModel)
    {
        var student = new Student
        {
            StudentId = studentModel.StudentId,
            StudentUserId = studentModel.StudentUserId,
            ThemeId = studentModel.ThemeId,
            TutorId = studentModel.TutorId,
        };

        return student;
    }

    public static StudentModel EntityToModel(Student student)
    {
        var studentModel = new StudentModel
        {
            StudentId = student.StudentId,
            StudentUserId = student.StudentUserId,
            ThemeId = student.ThemeId,
            TutorId = student.TutorId,
        };

        return studentModel;
    }

    public StudentModel StudentCreateToModel(StudentCreateRequest request)
    {
        var studentModel = new StudentModel
        {
            StudentId = Guid.NewGuid(),
            StudentUserId = new Guid(request.StudentUserId),
            ThemeId = new Guid(request.ThemeId),
            TutorId = new Guid(request.TutorId),
        };

        return studentModel;
    }

    public StudentModel StudentUpdateToModel(StudentCreateRequest request)
    {
        var studentModel = new StudentModel
        {
            StudentId = Guid.Empty,
            StudentUserId = new Guid(request.StudentUserId),
            ThemeId = new Guid(request.ThemeId),
            TutorId = new Guid(request.TutorId),
        };

        return studentModel;
    }
}