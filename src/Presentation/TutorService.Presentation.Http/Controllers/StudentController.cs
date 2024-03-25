using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Dtos;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("api/v1/students")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService taskService)
    {
        _studentService = taskService;
    }

    [HttpPost("createstudent")]
    public async Task<IActionResult> CreateStudent(StudentCreateRequest request)
    {
        try
        {
            bool success = await _studentService.CreateStudentAsync(request);
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

    [HttpGet("getstudent")]
    public async Task<IActionResult> GetStudent([FromQuery] string id)
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

    [HttpPut("updatestudent")]
    public async Task<IActionResult> UpdateStudent(string id, [FromBody] StudentUpdateRequest request)
    {
        try
        {
            bool success = await _studentService.UpdateStudentAsync(id, request);

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

    [HttpDelete("deletestudent")]
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