namespace TutorService.Application.Models.Dtos;

public record StudentCreateRequest(
    string StudentUserId,
    string TutorId,
    string ThemeId);
