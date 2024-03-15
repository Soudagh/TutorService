using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("api/v1/tasks")]
public class TaskController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpPost("createtask")]
    public async Task<IActionResult> CreateTask(TaskCreateRequest request)
    {
        try
        {
            bool success = await _taskService.CreateTaskAsync(request);
            if (success)
            {
                return Ok(new { body = true });
            }
            else
            {
                return BadRequest(new { errors = new List<string>() { "Failed to create task." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }

    [HttpGet("gettask")]
    public async Task<IActionResult> GetTask([FromQuery] string id)
    {
        try
        {
            TaskResponse task = await _taskService.GetTaskAsync(id);
            if (task != null)
            {
                return Ok(task);
            }
            else
            {
                return NotFound(new { errors = new List<string>() { "Task not found." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }

    [HttpPut("updatetask")]
    public async Task<IActionResult> UpdateTask(string id, [FromBody] TaskUpdateRequest request)
    {
        try
        {
            bool success = await _taskService.UpdateTaskAsync(id, request);
            if (success)
            {
                return Ok(new { body = true });
            }
            else
            {
                return BadRequest(new { errors = new List<string>() { "Failed to update task." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }

    [HttpDelete("deletetask")]
    public async Task<IActionResult> DeleteTask(string id)
    {
        try
        {
            bool success = await _taskService.DeleteTaskAsync(id);
            if (success)
            {
                return Ok(new { body = true });
            }
            else
            {
                return BadRequest(new { errors = new List<string>() { "Failed to delete task." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }
}