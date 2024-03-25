namespace TutorService.Application.Models.Dtos;

public record UserCreateRequest(
    string FullName,
    string Phone,
    string Mail,
    string Avatar,
    string Login,
    string PasswordHashed,
    string Role);