using TutorService.Application.Models;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Requests;

namespace TutorService.Infrastructure.Persistence.Mapping;

public class StudentMapper
{
    public static Student ModelToEntity(StudentModel studentModel)
    {
        var student = new Student(
            studentId: studentModel.StudentId,
            studentUserId: studentModel.StudentUserId,
            themeId: studentModel.ThemeId,
            tutorId: studentModel.TutorId
        );
        return student;
    }

    public static StudentModel EntityToModel(Student student)
    {
        var studentModel = new StudentModel(
            studentId: student.StudentId,
            studentUserId: student.StudentUserId,
            themeId: student.ThemeId,
            tutorId: student.TutorId
        );
        return studentModel;
    }

    public StudentModel StudentCreateToModel(StudentCreateRequest request)
    {
        var studentModel = new StudentModel(
            studentId: Guid.NewGuid(), 
            studentUserId: new Guid(request.StudentUserId),
            themeId: new Guid(request.ThemeId),
            tutorId: new Guid(request.TutorId)
        );
        return studentModel;
    }

    public StudentModel StudentUpdateToModel(StudentCreateRequest request)
    {
        var studentModel = new StudentModel(
            studentId: Guid.Empty, 
            studentUserId: new Guid(request.StudentUserId),
            themeId: new Guid(request.ThemeId),
            tutorId: new Guid(request.TutorId)
        );
        return studentModel;
    }
}