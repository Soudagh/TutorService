using MediatR;
using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Events.Commands;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly IMediator _mediator;

    public TaskController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("task")]
    public async Task<IActionResult> CreateTask(TaskCreateRequest request)
    {
        try
        {
            bool success = await _mediator.Send(new TaskCreateCommand { TaskCreateRequest = request });
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string>() { "Failed to create task." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }

    [HttpGet("task/{taskId}")]
    public async Task<IActionResult> GetTask(string taskId)
    {
        try
        {
            TaskResponse task = await _taskService.GetTaskAsync(taskId);
            if (task != null)
            {
                return Ok(task);
            }

            return NotFound(new { errors = new List<string> { "Task not found." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpPut("task/{taskId}")]
    public async Task<IActionResult> UpdateTask(string taskId, [FromBody] TaskUpdateRequest request)
    {
        try
        {
            bool success = await _taskService.UpdateTaskAsync(taskId, request);
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to update task." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpDelete("task/{taskId}")]
    public async Task<IActionResult> DeleteTask(string taskId)
    {
        try
        {
            bool success = await _taskService.DeleteTaskAsync(taskId);
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to delete task." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }
}