using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Dtos;
using TutorService.Infrastructure.Persistence.Mapping;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]/student")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService taskService)
    {
        _studentService = taskService;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateStudent([FromBody] StudentCreateRequest request)
    {
        try
        {
            var studentModel = StudentMapper.StudentCreateToModel(request);
            bool success = await _studentService.CreateStudentAsync(studentModel);
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string>() { "Failed to create student." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }

    [HttpGet("{studentId}")]
    public async Task<IActionResult> GetStudent(string id)
    {
        try
        {
            StudentResponse student = await _studentService.GetStudentAsync(id);

            if (student != null)
            {
                return Ok(student);
            }

            return NotFound(new { errors = new List<string>() { "Student not found." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }

    [HttpPut("{studentId}")]
    public async Task<IActionResult> UpdateStudent(string id, [FromBody] StudentUpdateRequest request)
    {
        try
        {
            var studentModel = StudentMapper.StudentUpdateToModel(request);
            bool success = await _studentService.UpdateStudentAsync(id, studentModel);

            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string>() { "Failed to update student." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }

    [HttpDelete("{studentId}")]
    public async Task<IActionResult> DeleteStudent(string id)
    {
        try
        {
            bool success = await _studentService.DeleteStudentAsync(id);

            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string>() { "Failed to delete student." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }
}