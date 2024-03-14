using TutorService.Application.Models;

namespace TutorService.Application.Contracts;

public interface IStudentService
{
    StudentModel CreateStudent(int studentUserId, int tutorUserId, int themeId);

    StudentModel GetStudent(int studentId);

    bool UpdateStudent(StudentModel newStudent);

    bool DeleteStudent(int studentId);
}