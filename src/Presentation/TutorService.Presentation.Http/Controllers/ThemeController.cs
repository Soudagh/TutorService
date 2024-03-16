using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("api/v1/themes")]
public class ThemeController : ControllerBase
{
    private readonly IThemeService _themeService;

    public ThemeController(IThemeService themeService)
    {
        _themeService = themeService;
    }

    [HttpPost("createtheme")]
    public async Task<IActionResult> CreateTheme(ThemeCreateRequest request)
    {
        try
        {
            bool success = await _themeService.CreateThemeAsync(request);
            if (success)
            {
                return Ok(new { body = true });
            }
            else
            {
                return BadRequest(new { errors = new List<string>() { "Failed to create theme." } });
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string>() { ex.Message } });
        }
    }

    [HttpGet("gettheme")]
    public async Task<IActionResult> GetTheme([FromQuery] string id)
        {
            try
            {
                ThemeResponse theme = await _themeService.GetThemeAsync(id);
                if (theme != null)
                {
                    return Ok(theme);
                }
                else
                {
                    return NotFound(new { errors = new List<string>() { "Theme not found." } });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { errors = new List<string>() { ex.Message } });
            }
        }

    [HttpPut("updatetheme")]
    public async Task<IActionResult> UpdateTheme(string id, [FromBody] ThemeUpdateRequest request)
        {
            try
            {
                bool success = await _themeService.UpdateThemeAsync(id, request);
                if (success)
                {
                    return Ok(new { body = true });
                }
                else
                {
                    return BadRequest(new { errors = new List<string>() { "Failed to update theme." } });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { errors = new List<string>() { ex.Message } });
            }
        }

    [HttpDelete("deletetheme")]
    public async Task<IActionResult> DeleteTheme(string id)
        {
            try
            {
                bool success = await _themeService.DeleteThemeAsync(id);
                if (success)
                {
                    return Ok(new { body = true });
                }
                else
                {
                    return BadRequest(new { errors = new List<string>() { "Failed to delete theme." } });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { errors = new List<string>() { ex.Message } });
            }
        }
    }
