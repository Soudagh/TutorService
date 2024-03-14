using TutorService.Application.Models;

namespace TutorService.Application.Contracts;

public interface IStudentService
{
    StudentModel Create(int studentUserId, int tutorUserId, int themeId);

    StudentModel Get(int studentId);

    bool Update(StudentModel newStudent);

    bool Delete(int studentId);
}