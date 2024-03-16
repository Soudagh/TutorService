using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Application.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<bool> CreateStudentAsync(StudentCreateRequest request)
    {
        return await _studentRepository.CreateStudent(request);
    }

    public async Task<StudentResponse> GetStudentAsync(string studentId)
    {
        StudentResponse student = await _studentRepository.GetStudent(studentId);
        return new StudentResponse(student.StudentId, student.ThemeId, student.CompletedTasks, student.SuggestedTasks);
    }

    public async Task<bool> UpdateStudentAsync(string studentId, StudentUpdateRequest request)
    {
        return await _studentRepository.UpdateStudent(studentId, request);
    }

    public async Task<bool> DeleteStudentAsync(string studentId)
    {
        return await _studentRepository.DeleteStudent(studentId);
    }
}