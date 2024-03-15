namespace TutorService.Application.Models.Requests;

public record TaskUpdateRequest(string TaskId, string Name, string Description, int Difficulty);
