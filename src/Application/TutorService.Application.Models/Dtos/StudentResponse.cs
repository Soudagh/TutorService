namespace TutorService.Application.Models.Dtos;

public record StudentResponse(
    string StudentId,
    string TutorId,
    string ThemeId);