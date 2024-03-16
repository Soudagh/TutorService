namespace TutorService.Application.Models.Responses;

public record UserResponse(
    string UserId,
    string FullName,
    string Phone,
    string Mail,
    string Avatar,
    string Login,
    RoleEnum Role);