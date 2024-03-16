namespace TutorService.Application.Models.Requests;

public record UserUpdateRequest(
    string UserId,
    string FullName,
    string Phone,
    string Mail,
    string Avatar,
    string Login,
    string PasswordHashed,
    RoleEnum Role);