namespace TutorService.Application.Models.Dtos;

public record StudentUpdateRequest(
    string StudentId,
    string StudentUserId,
    string TutorId,
    string ThemeId);