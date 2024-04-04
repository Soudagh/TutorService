using MediatR;
using Microsoft.AspNetCore.Mvc;
using TutorService.Application.Events.Commands;
using TutorService.Application.Events.Queries;
using TutorService.Application.Models.Dtos;
using TutorService.Application.Models.Responses;

namespace TutorService.Presentation.Http.Controllers;

[ApiController]
[Route("[controller]/user")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("")]
    public async Task<IActionResult> CreateUser([FromBody] UserCreateRequest request)
    {
        try
        {
            bool success = await _mediator.Send(new CreateUserCommand { UserCreateRequest = request });
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
            UserResponse user = await _mediator.Send(new GetUserQuery { UserId = userId });
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
            bool success = await _mediator.Send(new UpdateUserCommand
            {
                UserUpdateRequest = request,
                UserId = userId,
            });

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
            bool success = await _mediator.Send(new DeleteUserCommand { UserId = userId });
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