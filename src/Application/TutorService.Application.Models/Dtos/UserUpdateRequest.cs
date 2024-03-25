namespace TutorService.Application.Models.Dtos;

public record UserUpdateRequest(
    string FullName,
    string Phone,
    string Mail,
    string Avatar,
    string Login,
    string PasswordHashed,
    Roles Role);