using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Requests;
using TutorService.Infrastructure.Persistence.Mapping;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]/theme")]
public class ThemeController : ControllerBase
{
    private readonly IThemeService _themeService;

    public ThemeController(IThemeService themeService)
    {
        _themeService = themeService;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateTheme([FromBody] ThemeCreateRequest request)
    {
        try
        {
            var themeModel = ThemeMapper.ThemeCreateToModel(request);
            bool success = await _themeService.CreateThemeAsync(themeModel);
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
            ThemeResponse theme = await _themeService.GetThemeAsync(themeId);
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
            var themeModel = ThemeMapper.ThemeUpdateToModel(request);
            bool success = await _themeService.UpdateThemeAsync(themeId, themeModel);
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
            bool success = await _themeService.DeleteThemeAsync(themeId);
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