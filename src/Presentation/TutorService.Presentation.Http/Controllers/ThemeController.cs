using MediatR;
using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Events.Commands;
using TutorService.Application.Events.Queries;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Requests;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]/theme")]
public class ThemeController : ControllerBase
{
    private readonly IMediator _mediator;

    public ThemeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateTheme([FromBody] ThemeCreateRequest request)
    {
        try
        {
            bool success = await _mediator.Send(new CreateThemeCommand { ThemeCreateRequest = request });
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to create theme." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpGet("{themeId}")]
    public async Task<IActionResult> GetThemeById(string themeId)
    {
        try
        {
            ThemeResponse theme = await _mediator.Send(new GetThemeQuery { ThemeId = themeId });
            if (theme != null)
            {
                return Ok(theme);
            }

            return NotFound(new { errors = new List<string> { "Theme not found." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpPut("{themeId}")]
    public async Task<IActionResult> UpdateTheme(string themeId, [FromBody] ThemeUpdateRequest request)
    {
        try
        {
            bool success = await _mediator.Send(new UpdateThemeCommand
            {
                ThemeUpdateRequest = request,
                ThemeId = themeId,
            });

            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to update theme." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpDelete("{themeId}")]
    public async Task<IActionResult> DeleteTheme(string themeId)
    {
        try
        {
            bool success = await _mediator.Send(new DeleteThemeCommand { ThemeId = themeId });
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to delete theme." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }
}