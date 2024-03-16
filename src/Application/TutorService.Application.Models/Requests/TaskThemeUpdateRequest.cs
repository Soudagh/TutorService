namespace TutorService.Application.Models.Requests;

public record TaskThemeUpdateRequest(
    int TaskThemeId,
    int TaskId,
    int ThemeId);
