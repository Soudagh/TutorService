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

    [HttpGet("gettask/{taskId}")]
    public async Task<IActionResult> GetTask(string taskId)
    {
        try
        {
            TaskResponse task = await _taskService.GetTaskAsync(taskId);
            if (task != null)
            {
                return Ok(task);
            }
            else
            {
                return NotFound(new { errors = new List<string> { "Task not found." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpPut("updatetask/{taskId}")]
    public async Task<IActionResult> UpdateTask(string taskId, [FromBody] TaskUpdateRequest request)
    {
        try
        {
            bool success = await _taskService.UpdateTaskAsync(taskId, request);
            if (success)
            {
                return Ok(new { body = true });
            }
            else
            {
                return BadRequest(new { errors = new List<string> { "Failed to update task." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpDelete("deletetask/{taskId}")]
    public async Task<IActionResult> DeleteTask(string taskId)
    {
        try
        {
            bool success = await _taskService.DeleteTaskAsync(taskId);
            if (success)
            {
                return Ok(new { body = true });
            }
            else
            {
                return BadRequest(new { errors = new List<string> { "Failed to delete task." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }
}