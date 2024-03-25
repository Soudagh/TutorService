using TutorService.Application.Models.Dtos;

namespace TutorService.Application.Contracts;

public interface IStudentService
{
    Task<bool> CreateStudentAsync(StudentCreateRequest request);

    Task<StudentResponse> GetStudentAsync(string studentId);

    Task<bool> UpdateStudentAsync(string studentId, StudentUpdateRequest request);

    Task<bool> DeleteStudentAsync(string studentId);
}