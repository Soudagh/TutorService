using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Requests;
using TutorService.Application.Models.Responses;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("api/v1/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("createuser")]
    public async Task<IActionResult> CreateUser(UserCreateRequest request)
    {
        try
        {
            bool success = await _userService.CreateUserAsync(request);
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to create user." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpGet("getuser/{userId}")]
    public async Task<IActionResult> GetUserById([FromQuery] string userId)
    {
        try
        {
            UserResponse user = await _userService.GetUserAsync(userId);
            if (user != null)
            {
                return Ok(user);
            }

            return NotFound(new { errors = new List<string> { "User not found." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpPut("updateuser/{userId}")]
    public async Task<IActionResult> UpdateUser(string userId, [FromBody] UserUpdateRequest request)
    {
        try
        {
            bool success = await _userService.UpdateUserAsync(userId, request);
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to update user." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }

    [HttpDelete("deleteuser/{userId}")]
    public async Task<IActionResult> DeleteUser(string userId)
    {
        try
        {
            bool success = await _userService.DeleteUserAsync(userId);
            if (success)
            {
                return Ok(new { body = true });
            }

            return BadRequest(new { errors = new List<string> { "Failed to delete user." } });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { errors = new List<string> { ex.Message } });
        }
    }
}