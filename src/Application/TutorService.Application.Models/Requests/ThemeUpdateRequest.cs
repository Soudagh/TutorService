namespace TutorService.Application.Models.Requests;

public record ThemeUpdateRequest(string ThemeId, string Title, int Difficulty);