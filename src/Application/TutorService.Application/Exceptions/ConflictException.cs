namespace TutorService.Application.Exceptions;

public class ConflictException(string message = "Conflict") : Exception(message);