using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Contracts;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Responses;
using TutorService.Infrastructure.Persistence.Mapping;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateUser([FromBody] UserCreateRequest request)
    {
        try
        {
            var userModel = UserMapper.UserCreateToModel(request);
            bool success = await _userService.CreateUserAsync(userModel);
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

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetUserById(string userId)
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

    [HttpPut("{userId}")]
    public async Task<IActionResult> UpdateUser(string userId, [FromBody] UserUpdateRequest request)
    {
        try
        {
            var userModel = UserMapper.UserUpdateToModel(request);
            bool success = await _userService.UpdateUserAsync(userId, userModel);
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

    [HttpDelete("{userId}")]
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