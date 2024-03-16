using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("api/v1/tasksTheme")]
public class TaskThemeController:ControllerBase
{
    private readonly ITaskThemeService _taskThemeService;

    public TaskThemeController(ITaskThemeService taskThemeService)
    {
        _taskThemeService = taskThemeService;
    }
    
    [HttpPost("createtaskTheme")]
    public async Task<IActionResult> CreateTaskTheme(TaskThemeCreateRequest request)
    {
        try
        {
            bool success = await _taskThemeService.CreateTaskThemeAsync(request);
            if (success)
            {
                return Ok(new { body = true });
            }
            else
            {
                return BadRequest(new { errors = new List<string>() { "Failed to create taskTheme." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }
    
    [HttpGet("gettaskTheme")]
    public async Task<IActionResult> GetTaskTheme([FromQuery] string id)
    {
        try
        {
            TaskThemeResponse task = await _taskThemeService.GetTaskThemeAsync(id);
            if (task != null)
            {
                return Ok(task);
            }
            else
            {
                return NotFound(new { errors = new List<string>() { "TaskTheme not found." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }
    
    [HttpPut("updatetaskTheme")]
    public async Task<IActionResult> UpdateTask(string id, [FromBody] TaskThemeUpdateRequest request)
    {
        try
        {
            bool success = await _taskThemeService.UpdateTaskThemeAsync(id, request);
            if (success)
            {
                return Ok(new { body = true });
            }
            else
            {
                return BadRequest(new { errors = new List<string>() { "Failed to update taskTheme." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }
    
    [HttpDelete("deletetaskTheme")]
    public async Task<IActionResult> DeleteTask(string id)
    {
        try
        {
            bool success = await _taskThemeService.DeleteTaskThemeAsync(id);
            if (success)
            {
                return Ok(new { body = true });
            }
            else
            {
                return BadRequest(new { errors = new List<string>() { "Failed to delete taskTheme." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }
    
}