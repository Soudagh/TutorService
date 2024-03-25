namespace TutorService.Application.Models.Models;

public class StudentModel
{
    public Guid StudentId { get; set; }

    public Guid StudentUserId { get; set; }

    public Guid TutorId { get; set; }

    public Guid ThemeId { get; set; }
}