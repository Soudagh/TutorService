using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Models;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;
using TutorService.Infrastructure.Persistence.Contexts;

namespace TutorService.Infrastructure.Persistence.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;

    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateStudent(StudentCreateRequest request)
    {
        try
        {
            var newStudent = new StudentModel(
                studentId: 0,
                studentUserId: request.StudentUserId,
                tutorId: request.TutorId,
                themeId: request.ThemeId,
                completedTasks: request.CompletedTasks,
                suggestedTasks: request.SuggestedTasks);

            _context.Students.Add(newStudent);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<StudentResponse> GetStudent(string id)
    {
        try
        {
            StudentModel? student = await _context.Students.FindAsync(id);
            if (student == null)
                return null!;

            return new StudentResponse(
                student.StudentId.ToString(),
                student.ThemeId.ToString(),
                student.CompletedTasks,
                student.SuggestedTasks);
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<bool> UpdateStudent(string id, StudentUpdateRequest request)
    {
        try
        {
            StudentModel? student = await _context.Students.FindAsync(id);
            if (student == null)
                return false;

            student.StudentId = request.StudentId;
            student.StudentUserId = request.StudentUserId;
            student.TutorId = request.TutorId;
            student.ThemeId = request.ThemeId;
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeleteStudent(string id)
    {
        try
        {
            StudentModel? student = await _context.Students.FindAsync(id);
            if (student == null)
                return false;

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}