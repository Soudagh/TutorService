namespace TutorService.Application.Models.Requests;

public record TaskThemeCreateRequest
(
    string TaskId,
    string ThemeId);