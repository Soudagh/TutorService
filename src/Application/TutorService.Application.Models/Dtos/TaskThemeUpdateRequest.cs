namespace TutorService.Application.Models.Requests;

public record TaskThemeUpdateRequest(
    string TaskId,
    string ThemeId);
