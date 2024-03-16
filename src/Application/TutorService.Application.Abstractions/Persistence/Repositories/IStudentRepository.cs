using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Abstractions.Persistence.Repositories;

public interface IStudentRepository
{
    Task<bool> CreateStudent(StudentCreateRequest request);

    Task<StudentResponse> GetStudent(string id);

    Task<bool> UpdateStudent(string id, StudentUpdateRequest request);

    Task<bool> DeleteStudent(string id);
}