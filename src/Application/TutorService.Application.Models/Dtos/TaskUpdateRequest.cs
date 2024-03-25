namespace TutorService.Application.Models.Requests;

public record TaskUpdateRequest(string Name, string Description, int Difficulty);
