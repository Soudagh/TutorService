namespace TutorService.Application.Models.Responses;

public record TaskResponse(
    string TaskId,
    string Name,
    string Description,
    string Difficulty);