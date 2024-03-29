using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Abstractions.Persistence.Repositories;

public interface IStudentRepository
{
    Task<bool> CreateStudent(StudentModel studentModel);

    Task<StudentResponse> GetStudent(string id);

    Task<bool> UpdateStudent(string id, StudentModel studentModel);

    Task<bool> DeleteStudent(string id);
}