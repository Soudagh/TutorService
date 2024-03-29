using TutorService.Application.Abstractions.Persistence.Repositories;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Entities;
using TutorService.Application.Models.Models;
using TutorService.Infrastructure.Persistence.Contexts;
using TutorService.Infrastructure.Persistence.Mapping;

namespace TutorService.Infrastructure.Persistence.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationDbContext _context;

    public StudentRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateStudent(StudentModel studentModel)
    {
        try
        {
            var student = StudentMapper.ModelToEntity(studentModel);
            _context.Add(entity: student);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public async Task<StudentResponse> GetStudent(string id)
    {
        try
        {
            Student? student = await _context.Students.FindAsync(new Guid(id));
            if (student == null)
            {
                return null!;
            }

            // User user = UserMapper.ModelToEntity(userModel);
            return new StudentResponse(
                student.StudentId.ToString(),
                student.TutorId.ToString(),
                student.ThemeId.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null!;
        }
    }

    public async Task<bool> UpdateStudent(string id, StudentModel studentModel)
        {
            try
            {
                Student? student = await _context.Students.FindAsync(new Guid(id));
                if (student == null)
                    return false;

                student.StudentId = studentModel.StudentId;
                student.StudentUserId = studentModel.StudentUserId;
                student.TutorId = studentModel.TutorId;
                student.ThemeId = studentModel.ThemeId;
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
                Student? student = await _context.Students.FindAsync(id);
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