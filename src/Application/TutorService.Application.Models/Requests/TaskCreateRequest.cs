namespace TutorService.Application.Models.Requests;

public record TaskCreateRequest(
    string Name,
    string Description,
    string Difficulty);