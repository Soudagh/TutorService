namespace TutorService.Application.Exceptions;

public class BadRequestException(string message = "Bad Request") : Exception(message);