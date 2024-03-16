namespace TutorService.Application.Models.Responses;

public record TaskThemeResponse(
    string TaskThemeId,
    string TaskId,
    string ThemeId);
