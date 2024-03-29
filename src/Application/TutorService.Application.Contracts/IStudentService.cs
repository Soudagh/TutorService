using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Contracts;

public interface IStudentService
{
    Task<bool> CreateStudentAsync(StudentModel studentModel);

    Task<StudentResponse> GetStudentAsync(string studentId);

    Task<bool> UpdateStudentAsync(string studentId, StudentModel studentModel);

    Task<bool> DeleteStudentAsync(string studentId);
}