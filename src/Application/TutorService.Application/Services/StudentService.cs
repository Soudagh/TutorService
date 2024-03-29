using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Models;

namespace TutorService.Application.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<bool> CreateStudentAsync(StudentModel studentModel)
    {
        return await _studentRepository.CreateStudent(studentModel);
    }

    public async Task<StudentResponse> GetStudentAsync(string studentId)
    {
        StudentResponse student = await _studentRepository.GetStudent(studentId);
        return new StudentResponse(student.StudentId, student.TutorId, student.ThemeId);
    }

    public async Task<bool> UpdateStudentAsync(string studentId, StudentModel studentModel)
    {
        return await _studentRepository.UpdateStudent(studentId, studentModel);
    }

    public async Task<bool> DeleteStudentAsync(string studentId)
    {
        return await _studentRepository.DeleteStudent(studentId);
    }
}