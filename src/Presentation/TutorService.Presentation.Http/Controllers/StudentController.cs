using MediatR;
using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Events.Commands;
using TutorService.Application.Events.Queries;
using TutorService.Application.Models.Dtos;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]/student")]
public class StudentController : ControllerBase
{
    private readonly IMediator _mediator;

    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateStudent([FromBody] StudentCreateRequest request)
    {
        try
        {
            bool success = await _mediator.Send(new CreateStudentCommand { StudentCreateRequest = request });
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to create student." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpGet("{studentId}")]
    public async Task<IActionResult> GetStudentById(string studentId)
    {
        try
        {
            StudentResponse student = await _mediator.Send(new GetStudentQuery { StudentId = studentId });
            if (student != null)
            {
                return Ok(student);
            }

            return NotFound(new { errors = new List<string> { "Student not found." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpPut("{studentId}")]
    public async Task<IActionResult> UpdateStudent(string studentId, [FromBody] StudentUpdateRequest request)
    {
        try
        {
            bool success = await _mediator.Send(new UpdateStudentCommand
            {
                StudentUpdateRequest = request,
                StudentId = studentId,
            });

            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to update student." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpDelete("{studentId}")]
    public async Task<IActionResult> DeleteStudent(string studentId)
    {
        try
        {
            bool success = await _mediator.Send(new DeleteStudentCommand { StudentId = studentId });
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to delete student." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }
}